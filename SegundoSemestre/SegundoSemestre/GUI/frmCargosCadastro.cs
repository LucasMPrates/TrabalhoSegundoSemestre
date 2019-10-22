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
    public partial class frmCargosCadastro : Form
    {
        public frmCargosCadastro()
        {
            InitializeComponent();
        }

        DTO.Cargos cargo = new DTO.Cargos();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                

                cargo.codigo = Convert.ToInt32(txtCodigo.Text);
                cargo.descricao = txtDescricao.Text;
                cargo.salario = Convert.ToDouble(nupSalario.Value);

                if(cargo.codigo == 0)
                {
                    DAL.Cargos.Insert(cargo);
                    txtCodigo.Text = cargo.codigo.ToString();
                }
                else
                {
                    DAL.Cargos.Update(cargo);
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
                if (cargo.codigo == 0) throw new Exception("Salve antes de apagar!");

                if (MessageBox.Show("Tem certeza que deseja apagar o cargo " + cargo.descricao + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DAL.Cargos.Delete(cargo.codigo);
                    cargo = new DTO.Cargos();

                    txtCodigo.Text = cargo.codigo.ToString();
                    txtDescricao.Text = cargo.descricao;
                    nupSalario.Value = Convert.ToDecimal(cargo.salario);
                    MessageBox.Show("Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                
                cargo = DAL.Cargos.RetornaCargo(Convert.ToInt32(txtCodigo.Text));

                if(cargo.codigo != 0)
                {
                    txtCodigo.ReadOnly = true;
                    txtCodigo.Text = cargo.codigo.ToString();
                    txtDescricao.Text = cargo.descricao;
                    nupSalario.Value = Convert.ToDecimal(cargo.salario);
                }

                else
                {
                    txtCodigo.Text = "0";
                    txtDescricao.Text = "";
                    nupSalario.Value = 0;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                cargo = new DTO.Cargos();
                txtCodigo.ReadOnly = false;
                txtCodigo.Text = cargo.codigo.ToString();
                txtDescricao.Text = cargo.descricao;
                nupSalario.Value = Convert.ToDecimal(cargo.salario);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
