namespace SegundoSemestre.GUI
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.cmsCadastros = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGaragem = new System.Windows.Forms.Button();
            this.cmsGaragem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRelatórios = new System.Windows.Forms.Button();
            this.cmsRelatórios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abastecimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCadastros.SuspendLayout();
            this.cmsRelatórios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastros
            // 
            this.btnCadastros.Location = new System.Drawing.Point(12, 12);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(294, 87);
            this.btnCadastros.TabIndex = 0;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.UseVisualStyleBackColor = true;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // cmsCadastros
            // 
            this.cmsCadastros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.cargosToolStripMenuItem,
            this.equipamentosToolStripMenuItem,
            this.veiculosToolStripMenuItem});
            this.cmsCadastros.Name = "cmsCadastros";
            this.cmsCadastros.Size = new System.Drawing.Size(151, 114);
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cargosToolStripMenuItem.Text = "Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.cargosToolStripMenuItem_Click);
            // 
            // equipamentosToolStripMenuItem
            // 
            this.equipamentosToolStripMenuItem.Name = "equipamentosToolStripMenuItem";
            this.equipamentosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.equipamentosToolStripMenuItem.Text = "Equipamentos";
            this.equipamentosToolStripMenuItem.Click += new System.EventHandler(this.equipamentosToolStripMenuItem_Click);
            // 
            // veiculosToolStripMenuItem
            // 
            this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.veiculosToolStripMenuItem.Text = "Veiculos";
            this.veiculosToolStripMenuItem.Click += new System.EventHandler(this.veiculosToolStripMenuItem_Click);
            // 
            // btnGaragem
            // 
            this.btnGaragem.Location = new System.Drawing.Point(12, 108);
            this.btnGaragem.Name = "btnGaragem";
            this.btnGaragem.Size = new System.Drawing.Size(294, 87);
            this.btnGaragem.TabIndex = 1;
            this.btnGaragem.Text = "Garagem";
            this.btnGaragem.UseVisualStyleBackColor = true;
            this.btnGaragem.Click += new System.EventHandler(this.btnGaragem_Click);
            // 
            // cmsGaragem
            // 
            this.cmsGaragem.Name = "cmsGaragem";
            this.cmsGaragem.Size = new System.Drawing.Size(61, 4);
            // 
            // btnRelatórios
            // 
            this.btnRelatórios.Location = new System.Drawing.Point(12, 204);
            this.btnRelatórios.Name = "btnRelatórios";
            this.btnRelatórios.Size = new System.Drawing.Size(294, 87);
            this.btnRelatórios.TabIndex = 2;
            this.btnRelatórios.Text = "Relatórios";
            this.btnRelatórios.UseVisualStyleBackColor = true;
            this.btnRelatórios.Click += new System.EventHandler(this.btnRelatórios_Click);
            // 
            // cmsRelatórios
            // 
            this.cmsRelatórios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abastecimentosToolStripMenuItem,
            this.viajensToolStripMenuItem});
            this.cmsRelatórios.Name = "cmsRelatórios";
            this.cmsRelatórios.Size = new System.Drawing.Size(160, 48);
            // 
            // abastecimentosToolStripMenuItem
            // 
            this.abastecimentosToolStripMenuItem.Name = "abastecimentosToolStripMenuItem";
            this.abastecimentosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.abastecimentosToolStripMenuItem.Text = "Abastecimentos";
            this.abastecimentosToolStripMenuItem.Click += new System.EventHandler(this.abastecimentosToolStripMenuItem_Click);
            // 
            // viajensToolStripMenuItem
            // 
            this.viajensToolStripMenuItem.Name = "viajensToolStripMenuItem";
            this.viajensToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.viajensToolStripMenuItem.Text = "Viajens";
            this.viajensToolStripMenuItem.Click += new System.EventHandler(this.viajensToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 306);
            this.Controls.Add(this.btnRelatórios);
            this.Controls.Add(this.btnGaragem);
            this.Controls.Add(this.btnCadastros);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.cmsCadastros.ResumeLayout(false);
            this.cmsRelatórios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.ContextMenuStrip cmsCadastros;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem;
        private System.Windows.Forms.Button btnGaragem;
        private System.Windows.Forms.ContextMenuStrip cmsGaragem;
        private System.Windows.Forms.Button btnRelatórios;
        private System.Windows.Forms.ContextMenuStrip cmsRelatórios;
        private System.Windows.Forms.ToolStripMenuItem abastecimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajensToolStripMenuItem;
    }
}