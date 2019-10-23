using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoSemestre.GUI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            try
            {
                cmsCadastros.Show(btnCadastros, new System.Drawing.Point(0, 0));

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPessoasLookup frm = new frmPessoasLookup();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLoginLookup frm = new frmLoginLookup();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCargosCadastro frm = new frmCargosCadastro();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void equipamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEquipamentosLookup frm = new frmEquipamentosLookup();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmVeiculosLookup frm = new frmVeiculosLookup();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGaragem_Click(object sender, EventArgs e)
        {
            try
            {
                //cmsGaragem.Show(btnGaragem, new System.Drawing.Point(0, 0));
                frmGaragem frm = new frmGaragem();
                frm.ShowDialog();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
