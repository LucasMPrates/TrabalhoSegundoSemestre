namespace SegundoSemestre.GUI
{
    partial class frmAbastecer
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
            this.btnAbastecer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nupLitros = new System.Windows.Forms.NumericUpDown();
            this.nupValorLitro = new System.Windows.Forms.NumericUpDown();
            this.nupTotal = new System.Windows.Forms.NumericUpDown();
            this.dtpDataHora = new System.Windows.Forms.DateTimePicker();
            this.txtAnexo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupLitros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupValorLitro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAbastecer);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 219);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnAbastecer
            // 
            this.btnAbastecer.Location = new System.Drawing.Point(6, 19);
            this.btnAbastecer.Name = "btnAbastecer";
            this.btnAbastecer.Size = new System.Drawing.Size(126, 21);
            this.btnAbastecer.TabIndex = 1;
            this.btnAbastecer.Text = "Abastecer";
            this.btnAbastecer.UseVisualStyleBackColor = true;
            this.btnAbastecer.Click += new System.EventHandler(this.btnAbastecer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Litros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor/Litro(R$)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data/Hora";
            // 
            // nupLitros
            // 
            this.nupLitros.DecimalPlaces = 2;
            this.nupLitros.Location = new System.Drawing.Point(251, 20);
            this.nupLitros.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nupLitros.Name = "nupLitros";
            this.nupLitros.Size = new System.Drawing.Size(120, 20);
            this.nupLitros.TabIndex = 15;
            // 
            // nupValorLitro
            // 
            this.nupValorLitro.DecimalPlaces = 2;
            this.nupValorLitro.Location = new System.Drawing.Point(251, 39);
            this.nupValorLitro.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nupValorLitro.Name = "nupValorLitro";
            this.nupValorLitro.Size = new System.Drawing.Size(120, 20);
            this.nupValorLitro.TabIndex = 16;
            this.nupValorLitro.Leave += new System.EventHandler(this.nupValorLitro_Leave);
            // 
            // nupTotal
            // 
            this.nupTotal.DecimalPlaces = 2;
            this.nupTotal.Location = new System.Drawing.Point(251, 58);
            this.nupTotal.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nupTotal.Name = "nupTotal";
            this.nupTotal.ReadOnly = true;
            this.nupTotal.Size = new System.Drawing.Size(120, 20);
            this.nupTotal.TabIndex = 17;
            // 
            // dtpDataHora
            // 
            this.dtpDataHora.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataHora.Location = new System.Drawing.Point(251, 77);
            this.dtpDataHora.Name = "dtpDataHora";
            this.dtpDataHora.Size = new System.Drawing.Size(193, 20);
            this.dtpDataHora.TabIndex = 18;
            // 
            // txtAnexo
            // 
            this.txtAnexo.Location = new System.Drawing.Point(251, 96);
            this.txtAnexo.Name = "txtAnexo";
            this.txtAnexo.Size = new System.Drawing.Size(193, 20);
            this.txtAnexo.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Anexo";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(450, 95);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 21);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmAbastecer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 232);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAnexo);
            this.Controls.Add(this.dtpDataHora);
            this.Controls.Add(this.nupTotal);
            this.Controls.Add(this.nupValorLitro);
            this.Controls.Add(this.nupLitros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmAbastecer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abastecer";
            this.Load += new System.EventHandler(this.frmAbastecer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupLitros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupValorLitro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAbastecer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupLitros;
        private System.Windows.Forms.NumericUpDown nupValorLitro;
        private System.Windows.Forms.NumericUpDown nupTotal;
        private System.Windows.Forms.DateTimePicker dtpDataHora;
        private System.Windows.Forms.TextBox txtAnexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisar;
    }
}