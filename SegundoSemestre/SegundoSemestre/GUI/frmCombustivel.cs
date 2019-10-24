using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoSemestre.GUI
{
    public partial class frmCombustivel : Form
    {
        public frmCombustivel()
        {
            InitializeComponent();
        }

        public DTO.Veiculos veiculo = new DTO.Veiculos();

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                frmAbastecer frm = new frmAbastecer();
                frm.veiculo = veiculo;
                frm.ShowDialog();
                CarregarGrid();
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
                frmVisualizarImagem frm = new frmVisualizarImagem();
                byte[] bImagem = DAL.Veiculo_Abastecimentos.RetornaArquivo(Convert.ToInt32(dgvAbastecimentos.CurrentRow.Cells["codigo"].Value));

                if (bImagem != null)
                {
                    MemoryStream mstream = new MemoryStream(bImagem);
                    frm.img = Image.FromStream(mstream);
                }
                else frm.img = null;

                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCombustivel_Load(object sender, EventArgs e)
        {
            try
            {
                txtVeiculo.Text = veiculo.modelo;
                cboCombustivel.DataSource = DAL.Veiculos.RetornaTipoCombustivel();
                cboCombustivel.DisplayMember = "descricao";
                cboCombustivel.ValueMember = "codigo";
                
                cboCombustivel.SelectedValue = veiculo.tpcomb;
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
                dgvAbastecimentos.Rows.Clear();
                DataTable dt = DAL.Veiculo_Abastecimentos.RetornaAbastecimentos(veiculo.codigo);

                foreach (DataRow drow in dt.Rows)
                {
                    int iIndex = dgvAbastecimentos.Rows.Add();
                    dgvAbastecimentos.Rows[iIndex].Cells["codigo"].Value = drow["codigo"];
                    dgvAbastecimentos.Rows[iIndex].Cells["litros"].Value = drow["litros"];
                    dgvAbastecimentos.Rows[iIndex].Cells["valor_litro"].Value = drow["valor_litro"];
                    dgvAbastecimentos.Rows[iIndex].Cells["total"].Value = drow["total"];
                    dgvAbastecimentos.Rows[iIndex].Cells["datahora"].Value = drow["datahora"];
                    
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
