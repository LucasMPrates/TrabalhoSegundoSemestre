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
    public partial class frmVeiculoManutencoes : Form
    {
        public frmVeiculoManutencoes()
        {
            InitializeComponent();
        }

        public DTO.Veiculos veiculo = new DTO.Veiculos();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                int iIndex = dgvVeiculos.Rows.Add();
                DTO.Veiculo_Manutencoes manutencao = new DTO.Veiculo_Manutencoes();

                manutencao.veiculo = veiculo.codigo;
                manutencao.descricao = txtDescricao.Text;
                manutencao.data = DateTime.Today;
                manutencao.proxima_manutencao = Convert.ToInt32(nupProximaManutencao.Value);

                dgvVeiculos.Rows[iIndex].Cells["codigo"].Value             = manutencao.codigo;
                dgvVeiculos.Rows[iIndex].Cells["descricao"].Value          = manutencao.descricao;
                dgvVeiculos.Rows[iIndex].Cells["data"].Value               = manutencao.data;
                dgvVeiculos.Rows[iIndex].Cells["proxima_manutencao"].Value = manutencao.proxima_manutencao;
                dgvVeiculos.Rows[iIndex].Cells["km_rodados"].Value         = manutencao.km_rodados;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViagem_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow drow in dgvVeiculos.Rows)
                {
                    DTO.Veiculo_Manutencoes manutencao = new DTO.Veiculo_Manutencoes();

                    
                    manutencao.codigo =Convert.ToInt32(drow.Cells["codigo"].Value);
                    manutencao.descricao = Convert.ToString(drow.Cells["descricao"].Value);
                    manutencao.proxima_manutencao = Convert.ToInt32(drow.Cells["proxima_manutencao"].Value);
                    manutencao.km_rodados = Convert.ToInt32(drow.Cells["km_rodados"].Value);
                    manutencao.veiculo = veiculo.codigo;
                    manutencao.data = Convert.ToDateTime(drow.Cells["data"].Value);

                    if(manutencao.codigo == 0)
                    {
                        DAL.Veiculo_Manutencoes.Insert(manutencao);
                        drow.Cells["codigo"].Value = manutencao.codigo;
                        
                    }
                    MessageBox.Show("Sucesso!","", MessageBoxButtons.OK, MessageBoxIcon.Information );



                }
                       

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
                if(Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["codigo"].Value) == 0)
                {
                    dgvVeiculos.Rows.Remove(dgvVeiculos.CurrentRow);
                }

                else
                {
                    if (MessageBox.Show("Deseja apagar a manutenção "  
                        + dgvVeiculos.CurrentRow.Cells["descricao"].Value.ToString() + " ?","",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question )
                        == DialogResult.Yes)
                    {
                        DAL.Veiculo_Manutencoes.Delete(Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["codigo"].Value));
                        dgvVeiculos.Rows.Remove(dgvVeiculos.CurrentRow);
                        MessageBox.Show("Sucesso!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (MessageBox.Show("Tem certeza que deseja renovar essa manutenção?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DTO.Veiculo_Manutencoes manutencao = new DTO.Veiculo_Manutencoes();
                    manutencao.codigo = Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["codigo"].Value);
                    manutencao.km_rodados = 0;
                    manutencao.data = DateTime.Today;

                    dgvVeiculos.CurrentRow.Cells["data"].Value = DateTime.Today;
                    dgvVeiculos.CurrentRow.Cells["km_rodados"].Value = 0;

                    DAL.Veiculo_Manutencoes.Update(manutencao);

                    MessageBox.Show("Sucesso!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVeiculoManutencoes_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
                txtVeiculo.Text = veiculo.modelo;
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
                DataTable dt = DAL.Veiculo_Manutencoes.RetornaManutencoes(veiculo.codigo);

                foreach (DataRow drow in dt.Rows)
                {
                    int iIndex = dgvVeiculos.Rows.Add();

                    dgvVeiculos.Rows[iIndex].Cells["codigo"].Value = drow["codigo"];
                    dgvVeiculos.Rows[iIndex].Cells["descricao"].Value = drow["descricao"];
                    dgvVeiculos.Rows[iIndex].Cells["km_rodados"].Value = drow["km_rodados"];
                    dgvVeiculos.Rows[iIndex].Cells["data"].Value = drow["data"];
                    dgvVeiculos.Rows[iIndex].Cells["proxima_manutencao"].Value = drow["proxima_manutencao"];
                    


                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
