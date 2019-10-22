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
    public partial class frmLoginLookup : Form
    {
        public frmLoginLookup()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                frmLoginCadastro frm = new frmLoginCadastro();
                frm.ShowDialog();
                CarregarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                frmLoginCadastro frm = new frmLoginCadastro();
                DTO.Login login = DAL.Login.RetornaLogin(Convert.ToInt32(dgvLogins.CurrentRow.Cells["codigo"].Value));
                frm.login = login;
                frm.ShowDialog();
                CarregarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLoginLookup_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    CarregarGrid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarGrid()
        {
            try
            {
                dgvLogins.Rows.Clear();
                DataTable dt = DAL.Login.RetornaLogins();


                foreach (DataRow drow in dt.Rows)
                {
                    int iIndex = dgvLogins.Rows.Add();
                    dgvLogins.Rows[iIndex].Cells["codigo"].Value = drow["codigo"];
                    dgvLogins.Rows[iIndex].Cells["usuario"].Value = drow["usuario"];
                    dgvLogins.Rows[iIndex].Cells["pessoa"].Value = drow["nome"];
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que deseja excluir o login " + dgvLogins.CurrentRow.Cells["usuario"].Value.ToString() + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DAL.Login.Delete(Convert.ToInt32(dgvLogins.CurrentRow.Cells["usuario"].Value));
                    MessageBox.Show("Sucesso!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
