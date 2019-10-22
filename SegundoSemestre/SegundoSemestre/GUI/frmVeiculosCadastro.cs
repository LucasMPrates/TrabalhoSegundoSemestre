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
    public partial class frmVeiculos_Cadastro : Form
    {
        public frmVeiculos_Cadastro()
        {
            InitializeComponent();
        }

        public DTO.Veiculos veiculo = new DTO.Veiculos();

        private void frmVeiculos_Cadastro_Load(object sender, EventArgs e)
        {
            try
            {
                dtpAnoFabricacao.Format = DateTimePickerFormat.Custom;
                dtpAnoFabricacao.CustomFormat = "yyyy";
                dtpAnoFabricacao.ShowUpDown = true;
               

                dtpAnoModelo.Format = DateTimePickerFormat.Custom;
                dtpAnoModelo.CustomFormat = "yyyy";
                dtpAnoModelo.ShowUpDown = true;

                cboTipoCombustivel.DataSource = DAL.Veiculos.RetornaTipoCombustivel();
                cboTipoCombustivel.ValueMember = "codigo";
                cboTipoCombustivel.DisplayMember = "descricao";
                cboTipoCombustivel.SelectedIndex = 1;

                CarregarDados();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                veiculo = new DTO.Veiculos();
                CarregarDados();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void CarregarDados()
        {
            try
            {
                if (veiculo.codigo != 0) nupKm.Enabled = false;
                else                     nupKm.Enabled = true;

                txtCodigo.Text = veiculo.codigo.ToString();
                txtMarca.Text = veiculo.marca;
                txtModelo.Text = veiculo.modelo;
                mskPlaca.Text = veiculo.placa;

                dtpAnoFabricacao.Value =  new DateTime(veiculo.ano_fabricacao,1,1);
                dtpAnoModelo.Value = new DateTime(veiculo.ano_modelo,1,1);

                nupMediaConsumo.Value = Convert.ToDecimal(veiculo.media_consumo);
                nupKm.Value = Convert.ToDecimal(veiculo.km);

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
                CarregarObjeto();

                if(veiculo.codigo == 0)
                {
                    DAL.Veiculos.Insert(veiculo);
                    txtCodigo.Text = veiculo.codigo.ToString();
                }
                else
                {
                    DAL.Veiculos.Update(veiculo);
                }
                MessageBox.Show("Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarObjeto()
        {
            try
            {
                veiculo.codigo = Convert.ToInt32(txtCodigo.Text);
                veiculo.placa = mskPlaca.Text;
                veiculo.marca = txtMarca.Text;
                veiculo.modelo = txtModelo.Text;
                veiculo.ano_fabricacao = dtpAnoFabricacao.Value.Year;
                veiculo.ano_modelo = dtpAnoModelo.Value.Year;
                veiculo.km = Convert.ToInt32(nupKm.Value);
                veiculo.media_consumo = Convert.ToDouble(nupMediaConsumo.Value);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
