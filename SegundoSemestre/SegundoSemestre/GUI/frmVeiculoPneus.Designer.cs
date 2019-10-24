namespace SegundoSemestre.GUI
{
    partial class frmVeiculoPneus
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
            this.dgvPneus = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPneu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nupSulcos = new System.Windows.Forms.NumericUpDown();
            this.chkEstepe = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pneudesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pneu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km_rodados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sulco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estepe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizarSulcos = new System.Windows.Forms.Button();
            this.btnTrocarPneu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPneus)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSulcos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPneus
            // 
            this.dgvPneus.AllowUserToAddRows = false;
            this.dgvPneus.AllowUserToDeleteRows = false;
            this.dgvPneus.AllowUserToResizeColumns = false;
            this.dgvPneus.AllowUserToResizeRows = false;
            this.dgvPneus.BackgroundColor = System.Drawing.Color.White;
            this.dgvPneus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPneus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.pneudesc,
            this.pneu,
            this.km_rodados,
            this.sulco,
            this.estepe});
            this.dgvPneus.Location = new System.Drawing.Point(156, 79);
            this.dgvPneus.Name = "dgvPneus";
            this.dgvPneus.ReadOnly = true;
            this.dgvPneus.RowHeadersVisible = false;
            this.dgvPneus.Size = new System.Drawing.Size(796, 231);
            this.dgvPneus.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTrocarPneu);
            this.groupBox1.Controls.Add(this.btnAtualizarSulcos);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 298);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(6, 19);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(126, 21);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Pneu";
            // 
            // cboPneu
            // 
            this.cboPneu.FormattingEnabled = true;
            this.cboPneu.Location = new System.Drawing.Point(211, 53);
            this.cboPneu.Name = "cboPneu";
            this.cboPneu.Size = new System.Drawing.Size(191, 21);
            this.cboPneu.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Profundidade dos sulcos(cm)";
            // 
            // nupSulcos
            // 
            this.nupSulcos.DecimalPlaces = 1;
            this.nupSulcos.Location = new System.Drawing.Point(592, 53);
            this.nupSulcos.Name = "nupSulcos";
            this.nupSulcos.Size = new System.Drawing.Size(120, 20);
            this.nupSulcos.TabIndex = 45;
            // 
            // chkEstepe
            // 
            this.chkEstepe.AutoSize = true;
            this.chkEstepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstepe.Location = new System.Drawing.Point(743, 55);
            this.chkEstepe.Name = "chkEstepe";
            this.chkEstepe.Size = new System.Drawing.Size(65, 17);
            this.chkEstepe.TabIndex = 46;
            this.chkEstepe.Text = "Estepe";
            this.chkEstepe.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 46);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(126, 21);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(211, 31);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.ReadOnly = true;
            this.txtVeiculo.Size = new System.Drawing.Size(191, 20);
            this.txtVeiculo.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Veiculo";
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // pneudesc
            // 
            this.pneudesc.HeaderText = "Pneu";
            this.pneudesc.Name = "pneudesc";
            this.pneudesc.ReadOnly = true;
            this.pneudesc.Width = 200;
            // 
            // pneu
            // 
            this.pneu.HeaderText = "Pneu";
            this.pneu.Name = "pneu";
            this.pneu.ReadOnly = true;
            this.pneu.Visible = false;
            // 
            // km_rodados
            // 
            this.km_rodados.HeaderText = "Km Rodados";
            this.km_rodados.Name = "km_rodados";
            this.km_rodados.ReadOnly = true;
            // 
            // sulco
            // 
            this.sulco.HeaderText = "Profundidade do Sulco (cm)";
            this.sulco.Name = "sulco";
            this.sulco.ReadOnly = true;
            this.sulco.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sulco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // estepe
            // 
            this.estepe.HeaderText = "Estepe";
            this.estepe.Name = "estepe";
            this.estepe.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(6, 127);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(126, 21);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizarSulcos
            // 
            this.btnAtualizarSulcos.Location = new System.Drawing.Point(6, 73);
            this.btnAtualizarSulcos.Name = "btnAtualizarSulcos";
            this.btnAtualizarSulcos.Size = new System.Drawing.Size(126, 21);
            this.btnAtualizarSulcos.TabIndex = 5;
            this.btnAtualizarSulcos.Text = "Atualizar Sulcos";
            this.btnAtualizarSulcos.UseVisualStyleBackColor = true;
            this.btnAtualizarSulcos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTrocarPneu
            // 
            this.btnTrocarPneu.Location = new System.Drawing.Point(6, 100);
            this.btnTrocarPneu.Name = "btnTrocarPneu";
            this.btnTrocarPneu.Size = new System.Drawing.Size(126, 21);
            this.btnTrocarPneu.TabIndex = 6;
            this.btnTrocarPneu.Text = "Trocar Pneu";
            this.btnTrocarPneu.UseVisualStyleBackColor = true;
            this.btnTrocarPneu.Click += new System.EventHandler(this.btnTrocarPneu_Click);
            // 
            // frmVeiculoPneus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 322);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVeiculo);
            this.Controls.Add(this.chkEstepe);
            this.Controls.Add(this.nupSulcos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboPneu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPneus);
            this.MaximizeBox = false;
            this.Name = "frmVeiculoPneus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veiculo Pneus";
            this.Load += new System.EventHandler(this.frmVeiculoPneus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPneus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupSulcos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPneus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPneu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupSulcos;
        private System.Windows.Forms.CheckBox chkEstepe;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pneudesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn pneu;
        private System.Windows.Forms.DataGridViewTextBoxColumn km_rodados;
        private System.Windows.Forms.DataGridViewTextBoxColumn sulco;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estepe;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizarSulcos;
        private System.Windows.Forms.Button btnTrocarPneu;
    }
}