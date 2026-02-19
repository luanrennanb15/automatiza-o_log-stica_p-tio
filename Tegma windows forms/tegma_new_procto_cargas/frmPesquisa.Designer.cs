namespace tegma_new_procto_cargas
{
    partial class frmPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPesquisaFrota = new System.Windows.Forms.Label();
            this.lblPesquisaQtdVeiculos = new System.Windows.Forms.Label();
            this.lblPesquisaDestino = new System.Windows.Forms.Label();
            this.txtFrota = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cmbDestino1 = new System.Windows.Forms.ComboBox();
            this.txtViagens = new System.Windows.Forms.TextBox();
            this.lblViagens = new System.Windows.Forms.Label();
            this.cmbDestino3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDestino2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCargas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroViagens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPesquisaFrota
            // 
            this.lblPesquisaFrota.AutoSize = true;
            this.lblPesquisaFrota.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPesquisaFrota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPesquisaFrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisaFrota.Location = new System.Drawing.Point(67, 11);
            this.lblPesquisaFrota.Name = "lblPesquisaFrota";
            this.lblPesquisaFrota.Size = new System.Drawing.Size(43, 19);
            this.lblPesquisaFrota.TabIndex = 1;
            this.lblPesquisaFrota.Text = "Frota";
            // 
            // lblPesquisaQtdVeiculos
            // 
            this.lblPesquisaQtdVeiculos.AutoSize = true;
            this.lblPesquisaQtdVeiculos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPesquisaQtdVeiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPesquisaQtdVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisaQtdVeiculos.Location = new System.Drawing.Point(194, 9);
            this.lblPesquisaQtdVeiculos.Name = "lblPesquisaQtdVeiculos";
            this.lblPesquisaQtdVeiculos.Size = new System.Drawing.Size(141, 19);
            this.lblPesquisaQtdVeiculos.TabIndex = 3;
            this.lblPesquisaQtdVeiculos.Text = "Quantidade Veiculos";
            // 
            // lblPesquisaDestino
            // 
            this.lblPesquisaDestino.AutoSize = true;
            this.lblPesquisaDestino.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPesquisaDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPesquisaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisaDestino.Location = new System.Drawing.Point(59, 68);
            this.lblPesquisaDestino.Name = "lblPesquisaDestino";
            this.lblPesquisaDestino.Size = new System.Drawing.Size(58, 19);
            this.lblPesquisaDestino.TabIndex = 5;
            this.lblPesquisaDestino.Text = "Destino";
            // 
            // txtFrota
            // 
            this.txtFrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrota.Location = new System.Drawing.Point(24, 33);
            this.txtFrota.Name = "txtFrota";
            this.txtFrota.Size = new System.Drawing.Size(121, 23);
            this.txtFrota.TabIndex = 6;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(232, 33);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(58, 23);
            this.txtQuantidade.TabIndex = 8;
            // 
            // cmbDestino1
            // 
            this.cmbDestino1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino1.FormattingEnabled = true;
            this.cmbDestino1.Location = new System.Drawing.Point(24, 90);
            this.cmbDestino1.Name = "cmbDestino1";
            this.cmbDestino1.Size = new System.Drawing.Size(121, 24);
            this.cmbDestino1.TabIndex = 10;
            // 
            // txtViagens
            // 
            this.txtViagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViagens.Location = new System.Drawing.Point(422, 33);
            this.txtViagens.Name = "txtViagens";
            this.txtViagens.Size = new System.Drawing.Size(58, 23);
            this.txtViagens.TabIndex = 11;
            // 
            // lblViagens
            // 
            this.lblViagens.AutoSize = true;
            this.lblViagens.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblViagens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblViagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViagens.Location = new System.Drawing.Point(378, 9);
            this.lblViagens.Name = "lblViagens";
            this.lblViagens.Size = new System.Drawing.Size(157, 19);
            this.lblViagens.TabIndex = 12;
            this.lblViagens.Text = "Quantidade de viagens";
            // 
            // cmbDestino3
            // 
            this.cmbDestino3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino3.FormattingEnabled = true;
            this.cmbDestino3.Location = new System.Drawing.Point(388, 90);
            this.cmbDestino3.Name = "cmbDestino3";
            this.cmbDestino3.Size = new System.Drawing.Size(121, 24);
            this.cmbDestino3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Destino";
            // 
            // cmbDestino2
            // 
            this.cmbDestino2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino2.FormattingEnabled = true;
            this.cmbDestino2.Location = new System.Drawing.Point(198, 90);
            this.cmbDestino2.Name = "cmbDestino2";
            this.cmbDestino2.Size = new System.Drawing.Size(121, 24);
            this.cmbDestino2.TabIndex = 16;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Destino";
            
            // 
            // dgvCargas
            // 
            this.dgvCargas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Frota,
            this.Placa,
            this.QuantidadeTotal,
            this.NumeroViagens,
            this.DataCarga});
            this.dgvCargas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCargas.Location = new System.Drawing.Point(0, 124);
            this.dgvCargas.Name = "dgvCargas";
            this.dgvCargas.Size = new System.Drawing.Size(788, 164);
            this.dgvCargas.TabIndex = 17;
            this.dgvCargas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargas_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MaxInputLength = 100;
            this.Id.Name = "Id";
            // 
            // Frota
            // 
            this.Frota.HeaderText = "Frota";
            this.Frota.MaxInputLength = 5;
            this.Frota.Name = "Frota";
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.MaxInputLength = 7;
            this.Placa.Name = "Placa";
            // 
            // QuantidadeTotal
            // 
            this.QuantidadeTotal.HeaderText = "Quantidade";
            this.QuantidadeTotal.MaxInputLength = 2;
            this.QuantidadeTotal.Name = "QuantidadeTotal";
            // 
            // NumeroViagens
            // 
            this.NumeroViagens.HeaderText = "Viagens";
            this.NumeroViagens.MaxInputLength = 2;
            this.NumeroViagens.Name = "NumeroViagens";
            // 
            // DataCarga
            // 
            this.DataCarga.HeaderText = "Data";
            this.DataCarga.MaxInputLength = 20;
            this.DataCarga.Name = "DataCarga";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(682, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 33);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lblPesquisaFrota);
            this.panel1.Controls.Add(this.lblPesquisaQtdVeiculos);
            this.panel1.Controls.Add(this.cmbDestino2);
            this.panel1.Controls.Add(this.lblPesquisaDestino);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFrota);
            this.panel1.Controls.Add(this.cmbDestino3);
            this.panel1.Controls.Add(this.cmbDestino1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtViagens);
            this.panel1.Controls.Add(this.lblViagens);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 124);
            this.panel1.TabIndex = 19;
            // 
            // dgvItens
            // 
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Posicao,
            this.Destino});
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.Location = new System.Drawing.Point(0, 288);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.Size = new System.Drawing.Size(788, 234);
            this.dgvItens.TabIndex = 20;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MaxInputLength = 50;
            this.Modelo.Name = "Modelo";
            // 
            // Posicao
            // 
            this.Posicao.HeaderText = "Posicao";
            this.Posicao.MaxInputLength = 2;
            this.Posicao.Name = "Posicao";
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.MaxInputLength = 50;
            this.Destino.Name = "Destino";
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(788, 522);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.dgvCargas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPesquisaFrota;
        private System.Windows.Forms.Label lblPesquisaQtdVeiculos;
        private System.Windows.Forms.Label lblPesquisaDestino;
        private System.Windows.Forms.TextBox txtFrota;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cmbDestino1;
        private System.Windows.Forms.TextBox txtViagens;
        private System.Windows.Forms.Label lblViagens;
        private System.Windows.Forms.ComboBox cmbDestino3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDestino2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCargas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroViagens;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
    }
}