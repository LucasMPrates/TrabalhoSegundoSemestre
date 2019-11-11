using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmRPT : Form
    {

        public string sRPT = "";
        public DataSet DS = new DataSet();
        public bool bDS = true;
        ReportDocument cryRpt = new ReportDocument();
        public string caminho = "";
        public frmRPT()
        {
            InitializeComponent();
        }

        private void frmRPT_Load(object sender, EventArgs e)
        {
            try
            {

                
                
               
                cryRpt.Load(caminho);
               
                cryRpt.SetDataSource(DS);
                cryRpt.Refresh();
                
               crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRPT_FormClosed(object sender, FormClosedEventArgs e)
        {
            cryRpt.Dispose();
        }
    }
}
