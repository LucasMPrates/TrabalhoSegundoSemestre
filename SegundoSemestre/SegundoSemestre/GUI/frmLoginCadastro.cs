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
    public partial class frmLoginCadastro : Form
    {
        public frmLoginCadastro()
        {
            InitializeComponent();
        }

        public DTO.Login login = new DTO.Login();


        private void frmLoginCadastro_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarDados();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarDados()
        {
            try
            {
                txtCodigo.Text = login.codigo.ToString();
                txtPessoa.Text = login.pessoa.ToString();
                txtSenha.Text = login.senha;
                txtConfirma.Text = login.senha;
                txtUsuario.Text = login.usuario;
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
                login.codigo = Convert.ToInt32(txtCodigo.Text);
                login.usuario = txtUsuario.Text;
                login.senha = txtSenha.Text;
                login.pessoa = Convert.ToInt32(txtPessoa.Text);

                if (txtSenha.Text != txtConfirma.Text) throw new Exception("As senhas não são iguais!");
                if (txtPessoa.Text == "0") throw new Exception("Selecione uma pessoa válida!");
                if(login.codigo == 0)
                {
                    DAL.Login.Insert(login);
                    txtCodigo.Text = login.codigo.ToString();
                }
                else
                {
                    DAL.Login.Update(login);
                }
                MessageBox.Show("Sucesso!","", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelecionaPessoa frm = new frmSelecionaPessoa();
                frm.ShowDialog();
                txtPessoa.Text = frm.iCodigo;
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
                login = new DTO.Login();
                CarregarDados();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
