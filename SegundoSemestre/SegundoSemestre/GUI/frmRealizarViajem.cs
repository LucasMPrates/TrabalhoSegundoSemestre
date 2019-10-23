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
    public partial class frmRealizarViajem : Form
    {
        public frmRealizarViajem()
        {
            InitializeComponent();
        }


        public DTO.Veiculos veiculo = new DTO.Veiculos();

        private void frmRealizarViajem_Load(object sender, EventArgs e)
        {
            try
            {
                cboMotorista.DataSource = DAL.Pessoas.RetornaMotoristas();
                cboMotorista.ValueMember = "codigo";
                cboMotorista.DisplayMember = "nome";

                txtVeiculo.Text = veiculo.modelo;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = DAL.Viajens.VerificaMotoristaViagem(Convert.ToInt32(cboMotorista.SelectedValue));
                
                if (dt.Rows.Count > 0) throw new Exception("Esse motorista está em viagem!");


                DTO.Viajens viagem = new DTO.Viajens();
                viagem.destino = txtDestino.Text;
                viagem.motorista = Convert.ToInt32(cboMotorista.SelectedValue);
                viagem.obs1 = txtObs.Text;
                viagem.status = "A";
                viagem.km_rodados = 0;
                viagem.veiculo = veiculo.codigo;

                DAL.Viajens.Insert(viagem);
                
                veiculo.status = "2";

                DAL.Veiculos.UpdateStatus(veiculo);

                MessageBox.Show("Sucesso!","", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
