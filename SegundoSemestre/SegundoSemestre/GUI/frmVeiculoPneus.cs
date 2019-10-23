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
    public partial class frmVeiculoPneus : Form
    {
        public frmVeiculoPneus()
        {
            InitializeComponent();
        }


        public DTO.Veiculos veiculo = new DTO.Veiculos();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Veiculo_Pneus pneu = new DTO.Veiculo_Pneus();

                pneu.estepe = chkEstepe.Checked;
                pneu.sulco = Convert.ToDouble(nupSulcos.Value);
                pneu.pneu = Convert.ToInt32(cboPneu.SelectedValue);

              DTO.Equipamentos equipamento =   DAL.Equipamentos.RetornaEquipamento(pneu.pneu);

                int iIndex = dgvPneus.Rows.Add();

                dgvPneus.Rows[iIndex].Cells["codigo"].Value = pneu.codigo;
                dgvPneus.Rows[iIndex].Cells["pneu"].Value = pneu.pneu;
                dgvPneus.Rows[iIndex].Cells["pneudesc"].Value = equipamento.descricao;
                dgvPneus.Rows[iIndex].Cells["km_rodados"].Value = pneu.km_rodados;
                dgvPneus.Rows[iIndex].Cells["sulco"].Value = pneu.sulco;
                dgvPneus.Rows[iIndex].Cells["estepe"].Value = pneu.estepe;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVeiculoPneus_Load(object sender, EventArgs e)
        {
            try
            {
                cboPneu.DataSource = DAL.Equipamentos.RetornaPneus();
                cboPneu.ValueMember = "codigo";
                cboPneu.DisplayMember = "descricao";

                txtVeiculo.Text = veiculo.modelo;

                CarregarGrid();

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

                dgvPneus.Rows.Clear();
                DataTable dt = DAL.Veiculo_Pneus.RetornaPneus(veiculo.codigo);

                foreach (DataRow drow in dt.Rows)
                {
                    int iIndex = dgvPneus.Rows.Add();

                    dgvPneus.Rows[iIndex].Cells["codigo"].Value = drow["codigo"];
                    dgvPneus.Rows[iIndex].Cells["pneu"].Value = drow["pneu"];
                    DTO.Equipamentos equipamento =   DAL.Equipamentos.RetornaEquipamento(Convert.ToInt32(drow["pneu"]));
                    dgvPneus.Rows[iIndex].Cells["pneudesc"].Value = equipamento.descricao;
                    dgvPneus.Rows[iIndex].Cells["km_rodados"].Value = drow["km_rodados"];
                    dgvPneus.Rows[iIndex].Cells["sulco"].Value = drow["sulco"];
                    dgvPneus.Rows[iIndex].Cells["estepe"].Value = drow["estepe"];
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow dgrow in dgvPneus.Rows)
                {
                    DTO.Veiculo_Pneus pneu = new DTO.Veiculo_Pneus();

                    pneu.codigo = Convert.ToInt32(dgrow.Cells["codigo"].Value);
                    pneu.pneu = Convert.ToInt32(dgrow.Cells["pneu"].Value);
                    pneu.veiculo = veiculo.codigo;
                    pneu.km_rodados = Convert.ToInt32(dgrow.Cells["km_rodados"].Value);
                    pneu.estepe = Convert.ToBoolean(dgrow.Cells["estepe"].Value);
                    pneu.sulco = Convert.ToDouble(dgrow.Cells["sulco"].Value);

                    if (pneu.codigo == 0)
                    {
                        DAL.Veiculo_Pneus.Insert(pneu);
                        dgrow.Cells["codigo"].Value = pneu.codigo;
                    }
                    
                }

                MessageBox.Show("Sucesso!","", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (Convert.ToInt32(dgvPneus.CurrentRow.Cells["codigo"].Value) == 0) throw new Exception("Salve antes de excluir!");

                if (MessageBox.Show("Tem certeza que deseja apagar o pneu "
                    + dgvPneus.CurrentRow.Cells["pneudesc"].Value.ToString() + " ?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    DAL.Veiculo_Pneus.Delete(Convert.ToInt32(dgvPneus.CurrentRow.Cells["codigo"].Value));
                    MessageBox.Show("Sucesso!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dgvPneus.CurrentRow.Cells["codigo"].Value) == 0) throw new Exception("Salve antes de atualizar o sulco!");

                dgvPneus.CurrentRow.Cells["sulco"].Value = nupSulcos.Value;

                DAL.Veiculo_Pneus.UpdateSulcos(Convert.ToInt32(dgvPneus.CurrentRow.Cells["codigo"].Value), Convert.ToDouble(dgvPneus.CurrentRow.Cells["sulco"].Value));
                MessageBox.Show("Sucesso!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
