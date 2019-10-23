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
    public partial class frmRetornoViagem : Form
    {
        public frmRetornoViagem()
        {
            InitializeComponent();
        }


       public DTO.Viajens viagem = new DTO.Viajens();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                viagem.km_rodados = Convert.ToInt32(nupKms.Value);
                viagem.obs2 = txtObs.Text;

                DAL.Viajens.Update(viagem);
                veiculo.status = "1";
                veiculo.km = veiculo.km + viagem.km_rodados;
                DAL.Veiculos.UpdateStatus(veiculo);
                DAL.Veiculos.UpdateKM(veiculo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        DTO.Veiculos veiculo = new DTO.Veiculos();

        private void frmRetornoViagem_Load(object sender, EventArgs e)
        {
            try
            {
                DTO.Pessoas pessoa = DAL.Pessoas.RetornaPessoa(viagem.motorista);
                txtMotorista.Text = pessoa.nome;
                veiculo  = DAL.Veiculos.RetornaVeiculo(viagem.veiculo);
                txtVeiculo.Text = veiculo.modelo;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
