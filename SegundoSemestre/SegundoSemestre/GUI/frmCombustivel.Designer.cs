namespace SegundoSemestre.GUI
{
    partial class frmCombustivel
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
            this.dgvAbastecimentos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.litros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_litro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datahora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVisualizarAnexo = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCombustivel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbastecimentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAbastecimentos
            // 
            this.dgvAbastecimentos.AllowUserToAddRows = false;
            this.dgvAbastecimentos.AllowUserToDeleteRows = false;
            this.dgvAbastecimentos.AllowUserToResizeColumns = false;
            this.dgvAbastecimentos.AllowUserToResizeRows = false;
            this.dgvAbastecimentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAbastecimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbastecimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.litros,
            this.valor_litro,
            this.total,
            this.datahora});
            this.dgvAbastecimentos.Location = new System.Drawing.Point(156, 54);
            this.dgvAbastecimentos.Name = "dgvAbastecimentos";
            this.dgvAbastecimentos.ReadOnly = true;
            this.dgvAbastecimentos.RowHeadersVisible = false;
            this.dgvAbastecimentos.Size = new System.Drawing.Size(577, 224);
            this.dgvAbastecimentos.TabIndex = 40;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // litros
            // 
            this.litros.HeaderText = "Litros";
            this.litros.Name = "litros";
            this.litros.ReadOnly = true;
            // 
            // valor_litro
            // 
            this.valor_litro.HeaderText = "Valor/Litro R$";
            this.valor_litro.Name = "valor_litro";
            this.valor_litro.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total R$";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // datahora
            // 
            this.datahora.HeaderText = "Data/Hora";
            this.datahora.Name = "datahora";
            this.datahora.ReadOnly = true;
            this.datahora.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVisualizarAnexo);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 265);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // btnVisualizarAnexo
            // 
            this.btnVisualizarAnexo.Location = new System.Drawing.Point(6, 42);
            this.btnVisualizarAnexo.Name = "btnVisualizarAnexo";
            this.btnVisualizarAnexo.Size = new System.Drawing.Size(126, 21);
            this.btnVisualizarAnexo.TabIndex = 1;
            this.btnVisualizarAnexo.Text = "Visualizar Anexo";
            this.btnVisualizarAnexo.UseVisualStyleBackColor = true;
            this.btnVisualizarAnexo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(6, 15);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(126, 21);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(211, 27);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.ReadOnly = true;
            this.txtVeiculo.Size = new System.Drawing.Size(235, 20);
            this.txtVeiculo.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Veiculo";
            // 
            // cboCombustivel
            // 
            this.cboCombustivel.Enabled = false;
            this.cboCombustivel.FormattingEnabled = true;
            this.cboCombustivel.Location = new System.Drawing.Point(452, 26);
            this.cboCombustivel.Name = "cboCombustivel";
            this.cboCombustivel.Size = new System.Drawing.Size(121, 21);
            this.cboCombustivel.TabIndex = 44;
            // 
            // frmCombustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 289);
            this.Controls.Add(this.cboCombustivel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVeiculo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAbastecimentos);
            this.MaximizeBox = false;
            this.Name = "frmCombustivel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combustivel";
            this.Load += new System.EventHandler(this.frmCombustivel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbastecimentos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbastecimentos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnVisualizarAnexo;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCombustivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn litros;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_litro;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn datahora;
    }
}