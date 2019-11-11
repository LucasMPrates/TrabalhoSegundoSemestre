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
    public partial class frmVeiculo_Anexos : Form
    {
        public frmVeiculo_Anexos()
        {
            InitializeComponent();
        }

        public DTO.Veiculos veiculo = new DTO.Veiculos();

        private void btnProcurar_Click(object sender, EventArgs e)
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                int iIndex = dgvAnexos.Rows.Add();
                dgvAnexos.Rows[iIndex].Cells["codigo"].Value = 0;
                dgvAnexos.Rows[iIndex].Cells["descricao"].Value = txtDescricao.Text;
                dgvAnexos.Rows[iIndex].Cells["imagem"].Value = txtAnexo.Text;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {


                foreach (DataGridViewRow dgrow in dgvAnexos.Rows)
                {
                    if (dgrow.Cells["codigo"].Value.ToString() == "0")
                    {
                        DTO.Veiculo_Anexos anexo = new DTO.Veiculo_Anexos();
                        anexo.imagem = File.ReadAllBytes(dgrow.Cells["imagem"].Value.ToString());
                        anexo.descricao = dgrow.Cells["descricao"].Value.ToString();
                        anexo.veiculo = veiculo.codigo;

                        DAL.Veiculos.InsertAnexos(anexo);
                        dgrow.Cells["codigo"].Value = anexo.codigo;
                    }


                }
                MessageBox.Show("Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAnexos.CurrentRow.Cells["codigo"].Value.ToString() == "0") throw new Exception("Salve antes de visualizar!");

                frmVisualizarImagem frm = new frmVisualizarImagem();
                byte[] bImagem = DAL.Veiculos.RetornaArquivo(Convert.ToInt32(dgvAnexos.CurrentRow.Cells["codigo"].Value));

                if (bImagem != null)
                {
                    MemoryStream mstream = new MemoryStream(bImagem);
                    frm.img = Image.FromStream(mstream);
                }
                else frm.img = null;

                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAnexos.CurrentRow.IsNewRow) dgvAnexos.Rows.Remove(dgvAnexos.CurrentRow);
                if (MessageBox.Show("Tem certeza que deseja excluir o anexo " + dgvAnexos.CurrentRow.Cells["descricao"].Value.ToString() + " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAL.Veiculos.DeleteAnexo(Convert.ToInt32(dgvAnexos.CurrentRow.Cells["codigo"].Value));
                    dgvAnexos.Rows.Remove(dgvAnexos.CurrentRow);
                }
                MessageBox.Show("Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVeiculo_Anexos_Load(object sender, EventArgs e)
        {
            try
            {
                txtNome.Text = veiculo.modelo;

                CarregarGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarGrid()
        {
            try
            {
                DataTable dt = DAL.Veiculos.RetornaAnexos(veiculo.codigo);

                foreach (DataRow dataRow in dt.Rows)
                {
                    int iIndex = dgvAnexos.Rows.Add();
                    dgvAnexos.Rows[iIndex].Cells["codigo"].Value = Convert.ToInt32(dataRow["codigo"]);
                    dgvAnexos.Rows[iIndex].Cells["descricao"].Value = Convert.ToString(dataRow["descricao"]);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
