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
    public partial class frmPessoas : Form
    {
        public frmPessoas()
        {
            InitializeComponent();
        }

       public DTO.Pessoas pessoa = new DTO.Pessoas();

        private void frmPessoas_Load(object sender, EventArgs e)
        {
            try
            {

                cboSexo.DataSource = DAL.Pessoas.RetornaSexo();
                cboSexo.ValueMember = "codigo";
                cboSexo.DisplayMember = "descricao";

                cboCargo.DataSource = DAL.Cargos.RetornaCargos();
                cboCargo.ValueMember = "codigo";
                cboCargo.DisplayMember = "descricao";

                CarregaDados();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CarregaDados()
        {
            try
            {

                txtCodigo.Text = pessoa.codigo.ToString();
                txtCidade.Text = pessoa.cidade;
                mskCpf.Text = pessoa.cpf;
                txtEndereco.Text = pessoa.endereco;
                txtEstado.Text = pessoa.estado;
                txtNome.Text = pessoa.nome;
                txtVila.Text = pessoa.vila;
                nupNumero.Value = pessoa.numero;
                dtpNascimento.Value = pessoa.nascimento;
                mskTelefone.Text = pessoa.telefone;
                cboSexo.SelectedValue = pessoa.sexo;
                chkMotorista.Checked = pessoa.motorista;
                cboCargo.SelectedValue = pessoa.cargo;
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
                pessoa.nome = txtNome.Text;
                pessoa.nascimento = dtpNascimento.Value;
                pessoa.estado = txtEstado.Text;
                pessoa.cidade = txtCidade.Text;
                pessoa.cpf = mskCpf.Text;
                pessoa.numero = Convert.ToInt32(nupNumero.Value);
                pessoa.vila = txtVila.Text;
                pessoa.endereco = txtEndereco.Text;
                pessoa.telefone = mskTelefone.Text;
                pessoa.sexo = cboSexo.SelectedValue.ToString();
                pessoa.motorista = chkMotorista.Checked;
                pessoa.cargo = Convert.ToInt32(cboCargo.SelectedValue);

                if (pessoa.codigo== 0)
                {
                    SegundoSemestre.DAL.Pessoas.Insert(pessoa);

                    txtCodigo.Text = pessoa.codigo.ToString();
                }

                else
                {
                    DAL.Pessoas.Update(pessoa);
                }

                MessageBox.Show("Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                pessoa = new DTO.Pessoas();
                CarregaDados();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
