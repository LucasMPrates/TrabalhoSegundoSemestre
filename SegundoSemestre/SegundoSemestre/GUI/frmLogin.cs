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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                txtSenha.UseSystemPasswordChar = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLogin.Text == "ADMIN" && txtSenha.Text == "183250")
                {
                    frmMenu frm = new frmMenu();
                    this.Hide();
                    frm.ShowDialog();

                    txtLogin.Text = "";
                    txtSenha.Text = "";
                    this.Show();
                }
                else
                {

                    DTO.Login login = DAL.Login.RetornaLogin(txtLogin.Text.Trim());
                    if (login.codigo == 0) throw new Exception("Esse login não existe ou está errado!");
                    if (login.senha == txtSenha.Text.Trim())
                    {
                        frmMenu frm = new frmMenu();
                        this.Hide();
                        frm.ShowDialog();

                        txtLogin.Text = "";
                        txtSenha.Text = "";
                        this.Show();
                    }
                    else
                    {
                        throw new Exception("A senha está incorreta!");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
