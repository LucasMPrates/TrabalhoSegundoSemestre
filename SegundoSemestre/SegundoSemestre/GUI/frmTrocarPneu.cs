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
    public partial class frmTrocarPneu : Form
    {
        public frmTrocarPneu()
        {
            InitializeComponent();
        }

       public DTO.Veiculos veiculo = new DTO.Veiculos();
        public int iCodigo = 0;

        private void frmTrocarPneu_Load(object sender, EventArgs e)
        {
            try
            {
                cboPneu.DataSource = DAL.Veiculo_Pneus.RetornaPneusTrocar(veiculo.codigo);
                cboPneu.DisplayMember = "display";
                cboPneu.ValueMember = "codigo";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show
                    ("Tem certeza que deseja trocar esse pneu? todos os dados em relação a ele serão apagados!"
                    , "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAL.Veiculo_Pneus.TrocarPneu(Convert.ToInt32(cboPneu.SelectedValue),iCodigo);
                    MessageBox.Show("Sucesso!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
