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
    public partial class frmPessoasLookup : Form
    {
        public frmPessoasLookup()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                frmPessoas frm = new frmPessoas();
                DTO.Pessoas pessoa = new DTO.Pessoas();
                frm.pessoa = pessoa;
                frm.ShowDialog();
                CarregarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                

               

               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPessoasLookup_Load(object sender, EventArgs e)
        {
            try
            {
                
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
                dgvPessoas.Rows.Clear();

                string nome = "", cpf = "";

                if (mskCPF.Text.Replace(',', ' ').Replace('-', ' ').Trim().Length == 11) cpf = mskCPF.Text;
                nome = txtNome.Text;
                

                DataTable dt = DAL.Pessoas.RetornaPessoas(cpf, nome);


                foreach (DataRow drow in dt.Rows)
                {
                    int iIndex = dgvPessoas.Rows.Add();
                    dgvPessoas.Rows[iIndex].Cells["codigo"].Value = drow["codigo"];
                    dgvPessoas.Rows[iIndex].Cells["nome"].Value = drow["nome"];
                    dgvPessoas.Rows[iIndex].Cells["cpf"].Value = drow["cpf"];
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(dgvPessoas.CurrentRow.Cells["codigo"].Value);

                DTO.Pessoas pessoa = DAL.Pessoas.RetornaPessoa(codigo);

                frmPessoas frm = new frmPessoas();
                frm.pessoa = pessoa;
                frm.ShowDialog();
                CarregarGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que deseja excluir a pessoa " + dgvPessoas.CurrentRow.Cells["nome"].Value.ToString() + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DAL.Pessoas.Delete(Convert.ToInt32(dgvPessoas.CurrentRow.Cells["codigo"].Value));
                    MessageBox.Show("Sucesso!");
                    CarregarGrid();
                }
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
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

        private void btnAnexos_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(dgvPessoas.CurrentRow.Cells["codigo"].Value);
                frmPessoasAnexo frm = new frmPessoasAnexo();
                frm.pessoa = DAL.Pessoas.RetornaPessoa(codigo);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
