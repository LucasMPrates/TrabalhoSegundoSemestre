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
    public partial class frmGaragem : Form
    {
        public frmGaragem()
        {
            InitializeComponent();
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

                if (mskPlaca.Text.Replace('-', ' ').Trim().Length != 0) placa = mskPlaca.Text;


                DataTable dt = DAL.Veiculos.RetornaVeiculos(placa);

                foreach (DataRow drow in dt.Rows)
                {
                    int iIndex = dgvVeiculos.Rows.Add();
                    dgvVeiculos.Rows[iIndex].Cells["codigo"].Value = drow["codigo"];
                    dgvVeiculos.Rows[iIndex].Cells["modelo"].Value = drow["modelo"];
                    dgvVeiculos.Rows[iIndex].Cells["placa"].Value = drow["placa"];
                    dgvVeiculos.Rows[iIndex].Cells["km"].Value = drow["km"];
                    dgvVeiculos.Rows[iIndex].Cells["statusv"].Value = drow["status"];


                    if (drow["status"].ToString() == "1")
                    {
                        dgvVeiculos.Rows[iIndex].Cells["status"].Value = "Na garagem";
                        dgvVeiculos.Rows[iIndex].Cells["status"].Style.ForeColor = Color.Blue;

                        
                    }
                    else if(drow["status"].ToString() == "2")

                    {
                        dgvVeiculos.Rows[iIndex].Cells["status"].Value = "Em viajem";
                        dgvVeiculos.Rows[iIndex].Cells["status"].Style.ForeColor = Color.Red;
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnViagem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Veiculos veiculo = DAL.Veiculos.RetornaVeiculo(Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["codigo"].Value));
                if(veiculo.status == "1")
                {
                    frmRealizarViajem frm = new frmRealizarViajem();
                    frm.veiculo = veiculo;
                    frm.ShowDialog();

                }
                else
                {
                    DTO.Viajens viagem = DAL.Viajens.RetornaViagemAberto(Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["codigo"].Value));
                    frmRetornoViagem frm = new frmRetornoViagem();
                    frm.viagem = viagem;
                    frm.ShowDialog();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPneus_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Veiculos veiculo = DAL.Veiculos.RetornaVeiculo(Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["codigo"].Value));
                frmVeiculoPneus frm = new frmVeiculoPneus();
                frm.veiculo = veiculo;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
