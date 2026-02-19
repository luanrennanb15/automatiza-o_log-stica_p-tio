namespace tegma_new_procto_cargas
{
    partial class frmCadastroCarga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFrota = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblQtdVeiculos = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtQuantidadeVeiculos = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtQuantidadeEntregas = new System.Windows.Forms.TextBox();
            this.lblQuantidadeEntregas = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtFrota = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.colModelo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDestino = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPosicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::tegma_new_procto_cargas.Properties.Resources.tegma_foto;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblFrota
            // 
            this.lblFrota.AutoSize = true;
            this.lblFrota.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFrota.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblFrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrota.Location = new System.Drawing.Point(61, 9);
            this.lblFrota.Name = "lblFrota";
            this.lblFrota.Size = new System.Drawing.Size(46, 17);
            this.lblFrota.TabIndex = 1;
            this.lblFrota.Text = "Frota";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblData.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(598, 73);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 17);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblObservacao.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(37, 73);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(95, 17);
            this.lblObservacao.TabIndex = 6;
            this.lblObservacao.Text = "Observação";
            // 
            // lblQtdVeiculos
            // 
            this.lblQtdVeiculos.AutoSize = true;
            this.lblQtdVeiculos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblQtdVeiculos.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblQtdVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdVeiculos.Location = new System.Drawing.Point(386, 9);
            this.lblQtdVeiculos.Name = "lblQtdVeiculos";
            this.lblQtdVeiculos.Size = new System.Drawing.Size(158, 17);
            this.lblQtdVeiculos.TabIndex = 7;
            this.lblQtdVeiculos.Text = "Quantidade Veiculos";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPlaca.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(245, 9);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(48, 17);
            this.lblPlaca.TabIndex = 8;
            this.lblPlaca.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(217, 29);
            this.txtPlaca.MaxLength = 7;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 23);
            this.txtPlaca.TabIndex = 10;
            // 
            // txtQuantidadeVeiculos
            // 
            this.txtQuantidadeVeiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidadeVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeVeiculos.Location = new System.Drawing.Point(442, 29);
            this.txtQuantidadeVeiculos.MaxLength = 2;
            this.txtQuantidadeVeiculos.Name = "txtQuantidadeVeiculos";
            this.txtQuantidadeVeiculos.Size = new System.Drawing.Size(47, 23);
            this.txtQuantidadeVeiculos.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(520, 491);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 57;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtQuantidadeEntregas
            // 
            this.txtQuantidadeEntregas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeEntregas.Location = new System.Drawing.Point(658, 29);
            this.txtQuantidadeEntregas.MaxLength = 2;
            this.txtQuantidadeEntregas.Name = "txtQuantidadeEntregas";
            this.txtQuantidadeEntregas.Size = new System.Drawing.Size(45, 23);
            this.txtQuantidadeEntregas.TabIndex = 58;
            // 
            // lblQuantidadeEntregas
            // 
            this.lblQuantidadeEntregas.AutoSize = true;
            this.lblQuantidadeEntregas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblQuantidadeEntregas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeEntregas.Location = new System.Drawing.Point(613, 9);
            this.lblQuantidadeEntregas.Name = "lblQuantidadeEntregas";
            this.lblQuantidadeEntregas.Size = new System.Drawing.Size(153, 16);
            this.lblQuantidadeEntregas.TabIndex = 59;
            this.lblQuantidadeEntregas.Text = "Quantidade Entregas";
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Location = new System.Drawing.Point(483, 93);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(273, 23);
            this.dtpData.TabIndex = 60;
            // 
            // txtFrota
            // 
            this.txtFrota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrota.Location = new System.Drawing.Point(32, 29);
            this.txtFrota.MaxLength = 5;
            this.txtFrota.Name = "txtFrota";
            this.txtFrota.Size = new System.Drawing.Size(100, 23);
            this.txtFrota.TabIndex = 9;
            // 
            // txtObservacao
            // 
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(32, 93);
            this.txtObservacao.MaxLength = 100;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(429, 23);
            this.txtObservacao.TabIndex = 61;
            // 
            // dgvItens
            // 
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colModelo,
            this.colDestino,
            this.colPosicao});
            this.dgvItens.Location = new System.Drawing.Point(32, 145);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.Size = new System.Drawing.Size(724, 340);
            this.dgvItens.TabIndex = 62;
            this.dgvItens.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvItens_EditingControlShowing);
            // 
            // colModelo
            // 
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.Name = "colModelo";
            // 
            // colDestino
            // 
            this.colDestino.HeaderText = "Destino";
            this.colDestino.Name = "colDestino";
            // 
            // colPosicao
            // 
            this.colPosicao.HeaderText = "Posição";
            this.colPosicao.Name = "colPosicao";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(208, 491);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 63;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(353, 491);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(108, 23);
            this.btnAdicionar.TabIndex = 64;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // frmCadastroCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 522);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblQuantidadeEntregas);
            this.Controls.Add(this.txtQuantidadeEntregas);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtQuantidadeVeiculos);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtFrota);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblQtdVeiculos);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblFrota);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroCarga";
            this.Text = "frmCadastroCarga";
            this.Load += new System.EventHandler(this.frmCadastroCarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFrota;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblQtdVeiculos;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtQuantidadeVeiculos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtQuantidadeEntregas;
        private System.Windows.Forms.Label lblQuantidadeEntregas;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtFrota;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewComboBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosicao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAdicionar;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}