using System;
using System.ComponentModel;

namespace tegma_new_procto_cargas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnExcluirCarga = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditarCarga = new System.Windows.Forms.Button();
            this.btnPesquisarCarga = new System.Windows.Forms.Button();
            this.btnCadastroCarga = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrincipal.Controls.Add(this.btnExcluirCarga);
            this.panelPrincipal.Controls.Add(this.btnSair);
            this.panelPrincipal.Controls.Add(this.btnEditarCarga);
            this.panelPrincipal.Controls.Add(this.btnPesquisarCarga);
            this.panelPrincipal.Controls.Add(this.btnCadastroCarga);
            this.panelPrincipal.Controls.Add(this.panel1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.ForeColor = System.Drawing.Color.Chocolate;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(243, 522);
            this.panelPrincipal.TabIndex = 7;
            // 
            // btnExcluirCarga
            // 
            this.btnExcluirCarga.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnExcluirCarga.BackColor = System.Drawing.Color.Black;
            this.btnExcluirCarga.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnExcluirCarga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnExcluirCarga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnExcluirCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCarga.Font = new System.Drawing.Font("Cambria Math", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCarga.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnExcluirCarga.Location = new System.Drawing.Point(5, 360);
            this.btnExcluirCarga.Name = "btnExcluirCarga";
            this.btnExcluirCarga.Size = new System.Drawing.Size(231, 73);
            this.btnExcluirCarga.TabIndex = 12;
            this.btnExcluirCarga.Text = "Excluir Cargas";
            this.btnExcluirCarga.UseVisualStyleBackColor = false;
            this.btnExcluirCarga.Click += new System.EventHandler(this.btnExcluirCarga_Click);
            // 
            // btnSair
            // 
            this.btnSair.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSair.BackColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Cambria Math", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnSair.Location = new System.Drawing.Point(5, 439);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(231, 73);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEditarCarga
            // 
            this.btnEditarCarga.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnEditarCarga.BackColor = System.Drawing.Color.Black;
            this.btnEditarCarga.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnEditarCarga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnEditarCarga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnEditarCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCarga.Font = new System.Drawing.Font("Cambria Math", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCarga.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnEditarCarga.Location = new System.Drawing.Point(5, 281);
            this.btnEditarCarga.Name = "btnEditarCarga";
            this.btnEditarCarga.Size = new System.Drawing.Size(231, 73);
            this.btnEditarCarga.TabIndex = 10;
            this.btnEditarCarga.Text = "Editar Cargas";
            this.btnEditarCarga.UseVisualStyleBackColor = false;
            this.btnEditarCarga.Click += new System.EventHandler(this.btnEditarCarga_Click);
            // 
            // btnPesquisarCarga
            // 
            this.btnPesquisarCarga.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnPesquisarCarga.BackColor = System.Drawing.Color.Black;
            this.btnPesquisarCarga.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnPesquisarCarga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnPesquisarCarga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnPesquisarCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCarga.Font = new System.Drawing.Font("Cambria Math", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCarga.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnPesquisarCarga.Location = new System.Drawing.Point(5, 202);
            this.btnPesquisarCarga.Name = "btnPesquisarCarga";
            this.btnPesquisarCarga.Size = new System.Drawing.Size(231, 73);
            this.btnPesquisarCarga.TabIndex = 9;
            this.btnPesquisarCarga.Text = "Pesquisar Cargas";
            this.btnPesquisarCarga.UseVisualStyleBackColor = false;
            this.btnPesquisarCarga.Click += new System.EventHandler(this.btnPesquisarCarga_Click);
            // 
            // btnCadastroCarga
            // 
            this.btnCadastroCarga.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCadastroCarga.BackColor = System.Drawing.Color.Black;
            this.btnCadastroCarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastroCarga.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnCadastroCarga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCadastroCarga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCadastroCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCarga.Font = new System.Drawing.Font("Cambria Math", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCarga.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnCadastroCarga.Location = new System.Drawing.Point(5, 123);
            this.btnCadastroCarga.Name = "btnCadastroCarga";
            this.btnCadastroCarga.Size = new System.Drawing.Size(231, 73);
            this.btnCadastroCarga.TabIndex = 8;
            this.btnCadastroCarga.Text = "Cadastro de Carga";
            this.btnCadastroCarga.UseVisualStyleBackColor = false;
            this.btnCadastroCarga.Click += new System.EventHandler(this.btnCadastroCarga_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 117);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(243, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(788, 522);
            this.panelContainer.TabIndex = 8;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 522);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Carga Tegma";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCadastroCarga;
        private System.Windows.Forms.Button btnExcluirCarga;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEditarCarga;
        private System.Windows.Forms.Button btnPesquisarCarga;
        private System.Windows.Forms.Panel panelContainer;
    }
}

