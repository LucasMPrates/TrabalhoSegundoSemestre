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
    public partial class frmTrocaPecas : Form
    {
        public frmTrocaPecas()
        {
            InitializeComponent();
        }

        public DTO.Veiculos veiculo = new DTO.Veiculos();

        private void frmTrocaPecas_Load(object sender, EventArgs e)
        {
            try
            {
                cboPecas.DataSource = DAL.Equipamentos.RetornaPecas();
                cboPecas.ValueMember = "codigo";
                cboPecas.DisplayMember = "descricao";


                

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

                DataTable dt =  DAL.Veiculo_Pecas.RetornaTrocasPeca(veiculo.codigo);
                foreach (DataRow drow in dt.Rows)
                {
                    int iIndex = dgvVeiculos.Rows.Add();

                    dgvVeiculos.Rows[iIndex].Cells["codigo"].Value = drow["codigo"];
                    dgvVeiculos.Rows[iIndex].Cells["peca"].Value = drow["peca"];
                    dgvVeiculos.Rows[iIndex].Cells["descricao"].Value = drow["descricao"];
                    dgvVeiculos.Rows[iIndex].Cells["km_rodados"].Value = drow["km_rodados"];
                    dgvVeiculos.Rows[iIndex].Cells["data"].Value = drow["data"];
                    


                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void btnTrocar_Click(object sender, EventArgs e)
        {
            try
            {
                int iIndex = dgvVeiculos.Rows.Add();
                DTO.Veiculo_Pecas peca = new DTO.Veiculo_Pecas();

                peca.data = DateTime.Today;
                peca.veiculo = veiculo.codigo;
                peca.peca = Convert.ToInt32(cboPecas.SelectedValue);

                dgvVeiculos.Rows[iIndex].Cells["codigo"].Value = peca.codigo;
                dgvVeiculos.Rows[iIndex].Cells["descricao"].Value = cboPecas.Text;
                dgvVeiculos.Rows[iIndex].Cells["data"].Value = peca.data;
                dgvVeiculos.Rows[iIndex].Cells["km_rodados"].Value = peca.km_rodados;
                dgvVeiculos.Rows[iIndex].Cells["peca"].Value = peca.peca;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dgrow in dgvVeiculos.Rows)
                {
                    DTO.Veiculo_Pecas peca = new DTO.Veiculo_Pecas();

                    peca.codigo = Convert.ToInt32(dgrow.Cells["codigo"].Value);
                    peca.veiculo = veiculo.codigo;
                    peca.peca = Convert.ToInt32(dgrow.Cells["peca"].Value);
                    peca.data = Convert.ToDateTime(dgrow.Cells["data"].Value);
                    peca.km_rodados = Convert.ToInt32(dgrow.Cells["km_rodados"].Value);

                    if(peca.codigo == 0)
                    {
                        DAL.Veiculo_Pecas.Insert(peca);
                        dgrow.Cells["codigo"].Value = peca.codigo;
                    }

                }
                MessageBox.Show("Sucesso!","", MessageBoxButtons.OK, MessageBoxIcon.Information);




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
                if (Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["codigo"].Value) == 0)
                {
                    dgvVeiculos.Rows.Remove(dgvVeiculos.CurrentRow);
                }

                else
                {
                    if (MessageBox.Show("Deseja apagar a troca da peca "
                        + dgvVeiculos.CurrentRow.Cells["descricao"].Value.ToString() + " ?", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        DAL.Veiculo_Pecas.Delete(Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["codigo"].Value));
                        dgvVeiculos.Rows.Remove(dgvVeiculos.CurrentRow);
                        MessageBox.Show("Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que deseja renovar essa troca de peça?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DTO.Veiculo_Pecas peca = new DTO.Veiculo_Pecas();
                    peca.codigo = Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["codigo"].Value);
                    peca.km_rodados = 0;
                    peca.data = DateTime.Today;

                    dgvVeiculos.CurrentRow.Cells["data"].Value = DateTime.Today;
                    dgvVeiculos.CurrentRow.Cells["km_rodados"].Value = 0;

                    DAL.Veiculo_Pecas.Update(peca);

                    MessageBox.Show("Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
