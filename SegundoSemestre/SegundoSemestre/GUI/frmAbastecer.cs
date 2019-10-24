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
    public partial class frmAbastecer : Form
    {
        public frmAbastecer()
        {
            InitializeComponent();
        }
        DTO.Veiculo_Abastecimentos abastecimento = new DTO.Veiculo_Abastecimentos();
       public DTO.Veiculos veiculo = new DTO.Veiculos();

        private void frmAbastecer_Load(object sender, EventArgs e)
        {
            try
            {
                dtpDataHora.Format = DateTimePickerFormat.Custom;
                dtpDataHora.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.RestoreDirectory = true;
                openFile.Title = "Localizar Arquivo";
                openFile.CheckFileExists = true;
                openFile.CheckPathExists = true;
                openFile.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
               
                openFile.Multiselect = false;

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    txtAnexo.Text = openFile.FileName;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbastecer_Click(object sender, EventArgs e)
        {
            try
            {
                abastecimento.veiculo = veiculo.codigo ;
                abastecimento.anexo = File.ReadAllBytes(txtAnexo.Text);
                abastecimento.litros = Convert.ToDouble(nupLitros.Value);
             
                abastecimento.valor_litro = Convert.ToDouble(nupValorLitro.Value);
               
                abastecimento.total = Convert.ToDouble(nupLitros.Value) * Convert.ToDouble(nupValorLitro.Value);
              
                abastecimento.datahora = dtpDataHora.Value;


                DAL.Veiculo_Abastecimentos.Insert(abastecimento);

                MessageBox.Show("Sucesso!","", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nupValorLitro_Leave(object sender, EventArgs e)
        {
            try
            {
                nupTotal.Value = Convert.ToDecimal(nupLitros.Value) * Convert.ToDecimal(nupValorLitro.Value);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
