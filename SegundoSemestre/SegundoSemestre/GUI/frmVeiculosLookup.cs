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
    public partial class frmVeiculosLookup : Form
    {
        public frmVeiculosLookup()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                frmVeiculos_Cadastro frm = new frmVeiculos_Cadastro();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                frmVeiculos_Cadastro frm = new frmVeiculos_Cadastro();
                DTO.Veiculos veiculo = DAL.Veiculos.RetornaVeiculo(Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["codigo"].Value));
                frm.veiculo = veiculo;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que deseja excluir o veiculo " +
                    dgvVeiculos.CurrentRow.Cells["modelo"].Value.ToString() + " ?","",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAL.Veiculos.Delete(Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["codigo"].Value));
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
                CarregarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarGrid()
        {
            try
            {
                dgvVeiculos.Rows.Clear();
                string placa = "";

                if(mskPlaca.Text.Replace('-',' ').Trim().Length !=0 ) placa = mskPlaca.Text;


                DataTable dt = DAL.Veiculos.RetornaVeiculos(placa);
                
                foreach (DataRow drow in dt.Rows)
                {
                    int iIndex = dgvVeiculos.Rows.Add();
                    dgvVeiculos.Rows[iIndex].Cells["codigo"].Value = drow["codigo"];
                    dgvVeiculos.Rows[iIndex].Cells["modelo"].Value = drow["modelo"];
                    dgvVeiculos.Rows[iIndex].Cells["placa"].Value = drow["placa"];
                    dgvVeiculos.Rows[iIndex].Cells["km"].Value = drow["km"];

                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mskPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAnexos_Click(object sender, EventArgs e)
        {
            try
            {
                frmVeiculo_Anexos frm = new frmVeiculo_Anexos();
                frm.veiculo = DAL.Veiculos.RetornaVeiculo(Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["codigo"].Value));
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
