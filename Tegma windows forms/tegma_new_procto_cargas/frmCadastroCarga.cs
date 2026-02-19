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
            ConfigurarGrid();
            CarregarModelos();
            CarregarDestinos();
        }

        // =============================
        // CONFIGURA GRID
        // =============================
        private void ConfigurarGrid()
        {
            dgvItens.Columns.Clear();

            DataGridViewComboBoxColumn colModelo = new DataGridViewComboBoxColumn();
            colModelo.Name = "Modelo";
            colModelo.HeaderText = "Modelo";
            dgvItens.Columns.Add(colModelo);

            DataGridViewTextBoxColumn colPosicao = new DataGridViewTextBoxColumn();
            colPosicao.Name = "Posicao";
            colPosicao.HeaderText = "Posição";
            dgvItens.Columns.Add(colPosicao);

            DataGridViewComboBoxColumn colDestino = new DataGridViewComboBoxColumn();
            colDestino.Name = "Destino";
            colDestino.HeaderText = "Destino";
            dgvItens.Columns.Add(colDestino);
        }

        // =============================
        // BOTÃO ADICIONAR (INTELIGENTE)
        // =============================
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantidadeVeiculos.Text))
            {
                MessageBox.Show("Informe a quantidade de veículos primeiro.");
                return;
            }

            int quantidade;

            if (!int.TryParse(txtQuantidadeVeiculos.Text, out quantidade))
            {
                MessageBox.Show("Quantidade inválida.");
                return;
            }

            if (quantidade <= 0 || quantidade > 12)
            {
                MessageBox.Show("Quantidade deve ser entre 1 e 12.");
                return;
            }

            dgvItens.Rows.Clear();

            for (int i = 0; i < quantidade; i++)
            {
                dgvItens.Rows.Add();
                dgvItens.Rows[i].Cells["Posicao"].Value = i + 1;
            }
        }

        // =============================
        // BOTÃO LIMPAR
        // =============================
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFrota.Clear();
            txtPlaca.Clear();
            txtQuantidadeVeiculos.Clear();
            txtQuantidadeEntregas.Clear();
            txtObservacao.Clear();
            dgvItens.Rows.Clear();
        }

        // =============================
        // CARREGAR MODELOS
        // =============================
        private void CarregarModelos()
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT NomeModelo FROM Modelos", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataGridViewComboBoxColumn col =
                    (DataGridViewComboBoxColumn)dgvItens.Columns["Modelo"];

                col.DataSource = dt;
                col.DisplayMember = "NomeModelo";
                col.ValueMember = "NomeModelo";
            }
        }

        // =============================
        // CARREGAR DESTINOS
        // =============================
        private void CarregarDestinos()
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT NomeDestino FROM Destinos", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataGridViewComboBoxColumn col =
                    (DataGridViewComboBoxColumn)dgvItens.Columns["Destino"];

                col.DataSource = dt;
                col.DisplayMember = "NomeDestino";
                col.ValueMember = "NomeDestino";
            }
        }

        // =============================
        // DETECTA EDIÇÃO NA GRID
        // =============================
        private void dgvItens_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvItens.CurrentCell.ColumnIndex == dgvItens.Columns["Modelo"].Index)
            {
                ComboBox cb = e.Control as ComboBox;
                if (cb != null)
                {
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                    cb.Leave -= Modelo_Leave;
                    cb.Leave += Modelo_Leave;
                }
            }

            if (dgvItens.CurrentCell.ColumnIndex == dgvItens.Columns["Destino"].Index)
            {
                ComboBox cb = e.Control as ComboBox;
                if (cb != null)
                {
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                    cb.Leave -= Destino_Leave;
                    cb.Leave += Destino_Leave;
                }
            }
        }

        // =============================
        // NOVO MODELO
        // =============================
        private void Modelo_Leave(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb == null || string.IsNullOrWhiteSpace(cb.Text))
                return;

            using (SqlConnection conn = Conexao.ObterConexao())
            {
                conn.Open();

                string verifica = "SELECT COUNT(*) FROM Modelos WHERE NomeModelo = @Nome";
                SqlCommand cmdVerifica = new SqlCommand(verifica, conn);
                cmdVerifica.Parameters.AddWithValue("@Nome", cb.Text.Trim());

                int existe = (int)cmdVerifica.ExecuteScalar();

                if (existe == 0)
                {
                    DialogResult r = MessageBox.Show(
                        "Modelo não encontrado. Deseja cadastrar?",
                        "Novo Modelo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        string insert = "INSERT INTO Modelos (NomeModelo) VALUES (@Nome)";
                        SqlCommand cmdInsert = new SqlCommand(insert, conn);
                        cmdInsert.Parameters.AddWithValue("@Nome", cb.Text.Trim());
                        cmdInsert.ExecuteNonQuery();

                        MessageBox.Show("Modelo cadastrado!");
                        CarregarModelos();
                    }
                }
            }
        }

        // =============================
        // NOVO DESTINO
        // =============================
        private void Destino_Leave(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb == null || string.IsNullOrWhiteSpace(cb.Text))
                return;

            using (SqlConnection conn = Conexao.ObterConexao())
            {
                conn.Open();

                string verifica = "SELECT COUNT(*) FROM Destinos WHERE NomeDestino = @Nome";
                SqlCommand cmdVerifica = new SqlCommand(verifica, conn);
                cmdVerifica.Parameters.AddWithValue("@Nome", cb.Text.Trim());

                int existe = (int)cmdVerifica.ExecuteScalar();

                if (existe == 0)
                {
                    DialogResult r = MessageBox.Show(
                        "Destino não encontrado. Deseja cadastrar?",
                        "Novo Destino",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        string insert = "INSERT INTO Destinos (NomeDestino) VALUES (@Nome)";
                        SqlCommand cmdInsert = new SqlCommand(insert, conn);
                        cmdInsert.Parameters.AddWithValue("@Nome", cb.Text.Trim());
                        cmdInsert.ExecuteNonQuery();

                        MessageBox.Show("Destino cadastrado!");
                        CarregarDestinos();
                    }
                }
            }
        }
            private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvItens.Rows.Count == 0)
            {
                MessageBox.Show("Adicione os veículos antes de salvar.");
                return;
            }

            using (SqlConnection conn = Conexao.ObterConexao())
            {
                conn.Open();

                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    string sqlCarga = @"INSERT INTO Cargas 
                               (Frota, Placa, QuantidadeVeiculos, QuantidadeEntregas, DataCarga, Observacao)
                               VALUES
                               (@Frota, @Placa, @QtdVeic, @QtdEnt, @Data, @Obs);
                               SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdCarga = new SqlCommand(sqlCarga, conn, trans);

                    cmdCarga.Parameters.AddWithValue("@Frota", txtFrota.Text);
                    cmdCarga.Parameters.AddWithValue("@Placa", txtPlaca.Text);
                    cmdCarga.Parameters.AddWithValue("@QtdVeic", int.Parse(txtQuantidadeVeiculos.Text));
                    cmdCarga.Parameters.AddWithValue("@QtdEnt", int.Parse(txtQuantidadeEntregas.Text));
                    cmdCarga.Parameters.AddWithValue("@Data", DateTime.Now);
                    cmdCarga.Parameters.AddWithValue("@Obs", txtObservacao.Text);

                    int idCarga = Convert.ToInt32(cmdCarga.ExecuteScalar());

                    foreach (DataGridViewRow row in dgvItens.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string sqlItem = @"INSERT INTO ItensCarga
                                   (CargaId, Modelo, Posicao, Destino)
                                   VALUES
                                   (@CargaId, @Modelo, @Posicao, @Destino)";

                        SqlCommand cmdItem = new SqlCommand(sqlItem, conn, trans);

                        cmdItem.Parameters.AddWithValue("@CargaId", idCarga);
                        cmdItem.Parameters.AddWithValue("@Modelo", row.Cells["Modelo"].Value?.ToString());
                        cmdItem.Parameters.AddWithValue("@Posicao", row.Cells["Posicao"].Value?.ToString());
                        cmdItem.Parameters.AddWithValue("@Destino", row.Cells["Destino"].Value?.ToString());

                        cmdItem.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Carga salva com sucesso!");

                    btnLimpar_Click(null, null);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Erro ao salvar: " + ex.Message);
                }
            }
        }

    }
}

