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
    public partial class frmVisualizarImagem : Form
    {
        public Image img;
        public frmVisualizarImagem()
        {
            InitializeComponent();
        }

        private void frmVisualizarImagem_Load(object sender, EventArgs e)
        {
            picFoto.BackgroundImage = img;
        }
    }
}
