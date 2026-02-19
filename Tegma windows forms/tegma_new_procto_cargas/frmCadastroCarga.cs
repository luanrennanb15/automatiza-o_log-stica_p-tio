using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tegma_new_procto_cargas
{
    public partial class frmCadastroCarga : Form
    {
        public frmCadastroCarga()
        {
            InitializeComponent();
        }

        private void frmCadastroCarga_Load(object sender, EventArgs e)
        {
            dgvItens.AllowUserToAddRows = false;
            CarregarModelos();
            CarregarDestinos();
        }

        private void CarregarModelos()
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT NomeModelo FROM Modelos", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                var col = (DataGridViewComboBoxColumn)dgvItens.Columns["colModelo"];
                col.DataSource = dt;
                col.DisplayMember = "NomeModelo";
                col.ValueMember = "NomeModelo";
            }
        }

        private void CarregarDestinos()
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT NomeDestino FROM Destinos", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                var col = (DataGridViewComboBoxColumn)dgvItens.Columns["colDestino"];
                col.DataSource = dt;
                col.DisplayMember = "NomeDestino";
                col.ValueMember = "NomeDestino";
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantidadeVeiculos.Text))
            {
                MessageBox.Show("Informe a quantidade de veículos primeiro.");
                return;
            }

            int quantidade = int.Parse(txtQuantidadeVeiculos.Text);

            if (quantidade > 12)
            {
                MessageBox.Show("Máximo permitido é 12 veículos.");
                return;
            }

            if (dgvItens.Rows.Count >= quantidade)
            {
                MessageBox.Show("Quantidade máxima de veículos atingida.");
                return;
            }

            dgvItens.Rows.Add();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFrota.Clear();
            txtPlaca.Clear();
            txtQuantidadeVeiculos.Clear();
            txtQuantidadeEntregas.Clear();
            txtObservacao.Clear();
            dgvItens.Rows.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvItens.Rows.Count != int.Parse(txtQuantidadeVeiculos.Text))
            {
                MessageBox.Show("Quantidade de veículos não confere com os itens adicionados.");
                return;
            }

            if (!ValidarPosicoes())
                return;

            SalvarCarga();
        }

        private bool ValidarPosicoes()
        {
            for (int i = 0; i < dgvItens.Rows.Count; i++)
            {
                for (int j = i + 1; j < dgvItens.Rows.Count; j++)
                {
                    if (dgvItens.Rows[i].Cells["colPosicao"].Value != null &&
                        dgvItens.Rows[j].Cells["colPosicao"].Value != null)
                    {
                        if (dgvItens.Rows[i].Cells["colPosicao"].Value.ToString() ==
                            dgvItens.Rows[j].Cells["colPosicao"].Value.ToString())
                        {
                            MessageBox.Show("Existe posição duplicada!");
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void SalvarCarga()
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    string sqlCarga = @"INSERT INTO Cargas 
                    (Frota, Placa, QuantidadeVeiculos, QuantidadeEntregas, DataCarga, Observacao) 
                    VALUES (@Frota, @Placa, @QtdVeiculos, @QtdEntregas, @Data, @Obs);
                    SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdCarga = new SqlCommand(sqlCarga, conn, trans);

                    cmdCarga.Parameters.AddWithValue("@Frota", txtFrota.Text);
                    cmdCarga.Parameters.AddWithValue("@Placa", txtPlaca.Text);
                    cmdCarga.Parameters.AddWithValue("@QtdVeiculos", int.Parse(txtQuantidadeVeiculos.Text));
                    cmdCarga.Parameters.AddWithValue("@QtdEntregas", int.Parse(txtQuantidadeEntregas.Text));
                    cmdCarga.Parameters.AddWithValue("@Data", dtpData.Value);
                    cmdCarga.Parameters.AddWithValue("@Obs", txtObservacao.Text);

                    int cargaId = Convert.ToInt32(cmdCarga.ExecuteScalar());

                    foreach (DataGridViewRow row in dgvItens.Rows)
                    {
                        string sqlItem = @"INSERT INTO ItensCarga 
                        (CargaId, Modelo, Posicao, Destino) 
                        VALUES (@CargaId, @Modelo, @Posicao, @Destino)";

                        SqlCommand cmdItem = new SqlCommand(sqlItem, conn, trans);

                        cmdItem.Parameters.AddWithValue("@CargaId", cargaId);
                        cmdItem.Parameters.AddWithValue("@Modelo", row.Cells["colModelo"].Value);
                        cmdItem.Parameters.AddWithValue("@Posicao", row.Cells["colPosicao"].Value);
                        cmdItem.Parameters.AddWithValue("@Destino", row.Cells["colDestino"].Value);

                        cmdItem.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Carga salva com sucesso!");
                    btnLimpar_Click(null, null);
                }
                catch
                {
                    trans.Rollback();
                    MessageBox.Show("Erro ao salvar carga.");
                }
            }
        }
    }
}
