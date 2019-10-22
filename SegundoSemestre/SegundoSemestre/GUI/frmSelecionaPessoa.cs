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
    public partial class frmSelecionaPessoa : Form
    {
        public frmSelecionaPessoa()
        {
            InitializeComponent();
        }

        public string iCodigo = "";

        private void frmSelecionaPessoa_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DAL.Pessoas.RetornaPessoas();


                foreach (DataRow drow in dt.Rows)
                {
                    int iIndex = dgvPessoas.Rows.Add();
                    dgvPessoas.Rows[iIndex].Cells["codigo"].Value = drow["codigo"];
                    dgvPessoas.Rows[iIndex].Cells["nome"].Value = drow["nome"];
                    dgvPessoas.Rows[iIndex].Cells["cpf"].Value = drow["cpf"];
                }
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
                iCodigo = Convert.ToString(dgvPessoas.CurrentRow.Cells["codigo"].Value);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
