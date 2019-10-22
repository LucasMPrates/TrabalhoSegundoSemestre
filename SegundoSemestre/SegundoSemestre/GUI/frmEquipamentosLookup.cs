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
    public partial class frmEquipamentosLookup : Form
    {
        public frmEquipamentosLookup()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                frmEquipamentosCadastro frm = new frmEquipamentosCadastro();
                DTO.Equipamentos equipamento = new DTO.Equipamentos();
                frm.equipamento = equipamento;
                frm.ShowDialog();

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
                DTO.Equipamentos equipamento = DAL.Equipamentos.RetornaEquipamento(Convert.ToInt32(dgvEquipamentos.CurrentRow.Cells["codigo"].Value));
                frmEquipamentosCadastro frm = new frmEquipamentosCadastro();
                frm.equipamento = equipamento;
                frm.ShowDialog();
                
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
                if (MessageBox.Show("Tem certeza que deseja excluir o equipamento " +
                    dgvEquipamentos.CurrentRow.Cells["descricao"].Value.ToString() +
                    " ?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAL.Equipamentos.Delete(Convert.ToInt32(dgvEquipamentos.CurrentRow.Cells["codigo"].Value));
                    MessageBox.Show("Sucesso!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                Filtrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Filtrar()
        {
            try
            {

                dgvEquipamentos.Rows.Clear();
                string descricao = "";
                bool pneu = false, peca = false;

                pneu = radPneu.Checked;
                peca = radPeca.Checked;
                descricao = txtDescricao.Text;

               

                DataTable dt = DAL.Equipamentos.RetornaEquipamentos(descricao, pneu, peca);

                foreach (DataRow drow in dt.Rows)
                {
                    int iIndex = dgvEquipamentos.Rows.Add();
                    dgvEquipamentos.Rows[iIndex].Cells["descricao"].Value = drow["descricao"];
                    dgvEquipamentos.Rows[iIndex].Cells["codigo"].Value = drow["codigo"];
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
