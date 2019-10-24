namespace SegundoSemestre.GUI
{
    partial class frmGaragem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnViagem = new System.Windows.Forms.Button();
            this.mskPlaca = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPneus = new System.Windows.Forms.Button();
            this.btnCombustivel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCombustivel);
            this.groupBox1.Controls.Add(this.btnPneus);
            this.groupBox1.Controls.Add(this.btnViagem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 274);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // btnViagem
            // 
            this.btnViagem.Location = new System.Drawing.Point(6, 19);
            this.btnViagem.Name = "btnViagem";
            this.btnViagem.Size = new System.Drawing.Size(126, 21);
            this.btnViagem.TabIndex = 2;
            this.btnViagem.Text = "Viajem";
            this.btnViagem.UseVisualStyleBackColor = true;
            this.btnViagem.Click += new System.EventHandler(this.btnViagem_Click);
            // 
            // mskPlaca
            // 
            this.mskPlaca.Location = new System.Drawing.Point(201, 33);
            this.mskPlaca.Mask = "AAA-0000";
            this.mskPlaca.Name = "mskPlaca";
            this.mskPlaca.Size = new System.Drawing.Size(100, 20);
            this.mskPlaca.TabIndex = 42;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(647, 30);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 41;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Placa";
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.AllowUserToAddRows = false;
            this.dgvVeiculos.AllowUserToDeleteRows = false;
            this.dgvVeiculos.AllowUserToResizeColumns = false;
            this.dgvVeiculos.AllowUserToResizeRows = false;
            this.dgvVeiculos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.modelo,
            this.placa,
            this.km,
            this.status,
            this.statusv});
            this.dgvVeiculos.Location = new System.Drawing.Point(156, 60);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.ReadOnly = true;
            this.dgvVeiculos.RowHeadersVisible = false;
            this.dgvVeiculos.Size = new System.Drawing.Size(566, 226);
            this.dgvVeiculos.TabIndex = 39;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 200;
            // 
            // placa
            // 
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            // 
            // km
            // 
            this.km.HeaderText = "KM";
            this.km.Name = "km";
            this.km.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // statusv
            // 
            this.statusv.HeaderText = "Status";
            this.statusv.Name = "statusv";
            this.statusv.ReadOnly = true;
            this.statusv.Visible = false;
            // 
            // btnPneus
            // 
            this.btnPneus.Location = new System.Drawing.Point(6, 46);
            this.btnPneus.Name = "btnPneus";
            this.btnPneus.Size = new System.Drawing.Size(126, 21);
            this.btnPneus.TabIndex = 3;
            this.btnPneus.Text = "Pneus";
            this.btnPneus.UseVisualStyleBackColor = true;
            this.btnPneus.Click += new System.EventHandler(this.btnPneus_Click);
            // 
            // btnCombustivel
            // 
            this.btnCombustivel.Location = new System.Drawing.Point(6, 73);
            this.btnCombustivel.Name = "btnCombustivel";
            this.btnCombustivel.Size = new System.Drawing.Size(126, 21);
            this.btnCombustivel.TabIndex = 4;
            this.btnCombustivel.Text = "Combustível";
            this.btnCombustivel.UseVisualStyleBackColor = true;
            this.btnCombustivel.Click += new System.EventHandler(this.btnCombustivel_Click);
            // 
            // frmGaragem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 304);
            this.Controls.Add(this.mskPlaca);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVeiculos);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmGaragem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garagem";
            this.Load += new System.EventHandler(this.frmGaragem_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViagem;
        private System.Windows.Forms.MaskedTextBox mskPlaca;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVeiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn km;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusv;
        private System.Windows.Forms.Button btnPneus;
        private System.Windows.Forms.Button btnCombustivel;
    }
}