using System;
using System.Windows.Forms;

namespace tegma_new_procto_cargas
{
    public partial class frmPrincipal : Form
    {
        private Form formAtivo = null;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirForm(Form novoForm)
        {
            if (formAtivo != null)
                formAtivo.Close();

            formAtivo = novoForm;

            novoForm.TopLevel = false;
            novoForm.FormBorderStyle = FormBorderStyle.None;
            novoForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(novoForm);

            novoForm.Show();
        }

        private void btnCadastroCarga_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmCadastroCarga());
        }

        private void btnPesquisarCarga_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmPesquisa());
        }

        private void btnEditarCarga_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmEditarCarga());
        }

        private void btnExcluirCarga_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmExcluirCarga());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
