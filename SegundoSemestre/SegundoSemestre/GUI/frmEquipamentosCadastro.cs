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
    public partial class frmEquipamentosCadastro : Form
    {
        public frmEquipamentosCadastro()
        {
            InitializeComponent();
        }

        public DTO.Equipamentos equipamento = new DTO.Equipamentos();

        private void radPneu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmEquipamentosCadastro_Load(object sender, EventArgs e)
        {
            try
            {
                CarregaDados();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void CarregaDados()
        {
            try
            {
                txtCodigo.Text = equipamento.codigo.ToString();
                txtDescricao.Text = equipamento.descricao;
                radPeca.Checked = equipamento.peca;
                radPneu.Checked = equipamento.pneu;
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
                CarregaObjeto();

                if(equipamento.codigo == 0)
                {
                    DAL.Equipamentos.Insert(equipamento);
                    txtCodigo.Text = equipamento.codigo.ToString();
                }

                else
                {
                    DAL.Equipamentos.Update(equipamento);
                }
                MessageBox.Show("Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CarregaObjeto()
        {
            try
            {
                equipamento.codigo = Convert.ToInt32(txtCodigo.Text);
                equipamento.descricao = txtDescricao.Text;
                equipamento.peca = radPeca.Checked;
                equipamento.pneu = radPneu.Checked;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                equipamento = new DTO.Equipamentos();
                CarregaDados();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
