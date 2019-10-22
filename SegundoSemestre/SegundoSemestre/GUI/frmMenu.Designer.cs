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
            this.cmsCadastros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastros
            // 
            this.btnCadastros.Location = new System.Drawing.Point(12, 12);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(133, 23);
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
            this.cmsCadastros.Size = new System.Drawing.Size(181, 136);
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargosToolStripMenuItem.Text = "Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.cargosToolStripMenuItem_Click);
            // 
            // equipamentosToolStripMenuItem
            // 
            this.equipamentosToolStripMenuItem.Name = "equipamentosToolStripMenuItem";
            this.equipamentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.equipamentosToolStripMenuItem.Text = "Equipamentos";
            this.equipamentosToolStripMenuItem.Click += new System.EventHandler(this.equipamentosToolStripMenuItem_Click);
            // 
            // veiculosToolStripMenuItem
            // 
            this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veiculosToolStripMenuItem.Text = "Veiculos";
            this.veiculosToolStripMenuItem.Click += new System.EventHandler(this.veiculosToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 211);
            this.Controls.Add(this.btnCadastros);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.cmsCadastros.ResumeLayout(false);
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
    }
}