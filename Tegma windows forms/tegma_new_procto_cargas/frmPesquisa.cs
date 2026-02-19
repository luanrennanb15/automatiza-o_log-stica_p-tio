using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tegma_new_procto_cargas
{
    public partial class frmPesquisa : Form
    {
        public frmPesquisa()
        {
            InitializeComponent();
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            CriarColunas();
            CarregarDestinos();
        }

        private void CriarColunas()
        {
            dgvCargas.Columns.Clear();
            dgvCargas.Columns.Add("Id", "Id");
            dgvCargas.Columns.Add("Frota", "Frota");
            dgvCargas.Columns.Add("Placa", "Placa");
            dgvCargas.Columns.Add("QuantidadeVeiculos", "Quantidade");
            dgvCargas.Columns.Add("QuantidadeEntregas", "Entregas");
            dgvCargas.Columns.Add("DataCarga", "Data");

            dgvItens.Columns.Clear();
            dgvItens.Columns.Add("Modelo", "Modelo");
            dgvItens.Columns.Add("Posicao", "Posição");
            dgvItens.Columns.Add("Destino", "Destino");
        }

        private void CarregarDestinos()
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT Nome FROM Destinos", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbDestino1.DataSource = dt.Copy();
                cmbDestino1.DisplayMember = "Nome";
                cmbDestino1.SelectedIndex = -1;

                cmbDestino2.DataSource = dt.Copy();
                cmbDestino2.DisplayMember = "Nome";
                cmbDestino2.SelectedIndex = -1;

                cmbDestino3.DataSource = dt.Copy();
                cmbDestino3.DisplayMember = "Nome";
                cmbDestino3.SelectedIndex = -1;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCargas.Rows.Clear();

            using (SqlConnection conn = Conexao.ObterConexao())
            {
                conn.Open();

                string sql = @"SELECT DISTINCT C.Id, C.Frota, C.Placa,
                               C.QuantidadeVeiculos, C.QuantidadeEntregas, C.DataCarga
                               FROM Cargas C
                               LEFT JOIN ItensCarga I ON C.Id = I.CargaId
                               WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(txtFrota.Text))
                    sql += " AND C.Frota = @Frota";

                if (!string.IsNullOrWhiteSpace(txtQuantidade.Text))
                    sql += " AND C.QuantidadeVeiculos = @Qtd";

                if (!string.IsNullOrWhiteSpace(txtViagens.Text))
                    sql += " AND C.QuantidadeEntregas = @Entregas";

                if (cmbDestino1.SelectedIndex != -1)
                    sql += " AND C.Id IN (SELECT CargaId FROM ItensCarga WHERE Destino = @D1)";

                if (cmbDestino2.SelectedIndex != -1)
                    sql += " AND C.Id IN (SELECT CargaId FROM ItensCarga WHERE Destino = @D2)";

                if (cmbDestino3.SelectedIndex != -1)
                    sql += " AND C.Id IN (SELECT CargaId FROM ItensCarga WHERE Destino = @D3)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                if (!string.IsNullOrWhiteSpace(txtFrota.Text))
                    cmd.Parameters.AddWithValue("@Frota", txtFrota.Text);

                if (!string.IsNullOrWhiteSpace(txtQuantidade.Text))
                    cmd.Parameters.AddWithValue("@Qtd", txtQuantidade.Text);

                if (!string.IsNullOrWhiteSpace(txtViagens.Text))
                    cmd.Parameters.AddWithValue("@Entregas", txtViagens.Text);

                if (cmbDestino1.SelectedIndex != -1)
                    cmd.Parameters.AddWithValue("@D1", cmbDestino1.Text);

                if (cmbDestino2.SelectedIndex != -1)
                    cmd.Parameters.AddWithValue("@D2", cmbDestino2.Text);

                if (cmbDestino3.SelectedIndex != -1)
                    cmd.Parameters.AddWithValue("@D3", cmbDestino3.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgvCargas.Rows.Add(
                        dr["Id"],
                        dr["Frota"],
                        dr["Placa"],
                        dr["QuantidadeVeiculos"],
                        dr["QuantidadeEntregas"],
                        Convert.ToDateTime(dr["DataCarga"]).ToShortDateString()
                    );
                }
            }
        }

        private void dgvCargas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            dgvItens.Rows.Clear();

            int idCarga = Convert.ToInt32(dgvCargas.Rows[e.RowIndex].Cells["Id"].Value);

            using (SqlConnection conn = Conexao.ObterConexao())
            {
                conn.Open();

                string sql = "SELECT Modelo, Posicao, Destino FROM ItensCarga WHERE CargaId = @Id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", idCarga);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgvItens.Rows.Add(
                        dr["Modelo"],
                        dr["Posicao"],
                        dr["Destino"]
                    );
                }
            }
        }
    }
}
