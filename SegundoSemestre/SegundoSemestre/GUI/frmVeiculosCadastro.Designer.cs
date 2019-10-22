namespace SegundoSemestre.GUI
{
    partial class frmVeiculos_Cadastro
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cboTipoCombustivel = new System.Windows.Forms.ComboBox();
            this.dtpAnoFabricacao = new System.Windows.Forms.DateTimePicker();
            this.dtpAnoModelo = new System.Windows.Forms.DateTimePicker();
            this.nupMediaConsumo = new System.Windows.Forms.NumericUpDown();
            this.nupKm = new System.Windows.Forms.NumericUpDown();
            this.mskPlaca = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMediaConsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupKm)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 231);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(6, 15);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(126, 21);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 42);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(126, 21);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tipo de Combustível";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(198, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Ano de Fabricação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(198, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Ano do Modelo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(198, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Media de Consumo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(198, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Km";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(329, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 45;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(329, 69);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(120, 20);
            this.txtMarca.TabIndex = 47;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(329, 88);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(121, 20);
            this.txtModelo.TabIndex = 48;
            // 
            // cboTipoCombustivel
            // 
            this.cboTipoCombustivel.FormattingEnabled = true;
            this.cboTipoCombustivel.Location = new System.Drawing.Point(329, 107);
            this.cboTipoCombustivel.Name = "cboTipoCombustivel";
            this.cboTipoCombustivel.Size = new System.Drawing.Size(121, 21);
            this.cboTipoCombustivel.TabIndex = 49;
            // 
            // dtpAnoFabricacao
            // 
            this.dtpAnoFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnoFabricacao.Location = new System.Drawing.Point(329, 127);
            this.dtpAnoFabricacao.Name = "dtpAnoFabricacao";
            this.dtpAnoFabricacao.Size = new System.Drawing.Size(200, 20);
            this.dtpAnoFabricacao.TabIndex = 50;
            // 
            // dtpAnoModelo
            // 
            this.dtpAnoModelo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnoModelo.Location = new System.Drawing.Point(329, 146);
            this.dtpAnoModelo.Name = "dtpAnoModelo";
            this.dtpAnoModelo.Size = new System.Drawing.Size(200, 20);
            this.dtpAnoModelo.TabIndex = 51;
            // 
            // nupMediaConsumo
            // 
            this.nupMediaConsumo.DecimalPlaces = 2;
            this.nupMediaConsumo.Location = new System.Drawing.Point(329, 165);
            this.nupMediaConsumo.Name = "nupMediaConsumo";
            this.nupMediaConsumo.Size = new System.Drawing.Size(120, 20);
            this.nupMediaConsumo.TabIndex = 52;
            // 
            // nupKm
            // 
            this.nupKm.Location = new System.Drawing.Point(329, 184);
            this.nupKm.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nupKm.Name = "nupKm";
            this.nupKm.Size = new System.Drawing.Size(120, 20);
            this.nupKm.TabIndex = 53;
            // 
            // mskPlaca
            // 
            this.mskPlaca.Location = new System.Drawing.Point(329, 50);
            this.mskPlaca.Mask = "AAA-0000";
            this.mskPlaca.Name = "mskPlaca";
            this.mskPlaca.Size = new System.Drawing.Size(100, 20);
            this.mskPlaca.TabIndex = 54;
            // 
            // frmVeiculos_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 255);
            this.Controls.Add(this.mskPlaca);
            this.Controls.Add(this.nupKm);
            this.Controls.Add(this.nupMediaConsumo);
            this.Controls.Add(this.dtpAnoModelo);
            this.Controls.Add(this.dtpAnoFabricacao);
            this.Controls.Add(this.cboTipoCombustivel);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmVeiculos_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veiculos Cadastro";
            this.Load += new System.EventHandler(this.frmVeiculos_Cadastro_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupMediaConsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupKm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cboTipoCombustivel;
        private System.Windows.Forms.DateTimePicker dtpAnoFabricacao;
        private System.Windows.Forms.DateTimePicker dtpAnoModelo;
        private System.Windows.Forms.NumericUpDown nupMediaConsumo;
        private System.Windows.Forms.NumericUpDown nupKm;
        private System.Windows.Forms.MaskedTextBox mskPlaca;
    }
}