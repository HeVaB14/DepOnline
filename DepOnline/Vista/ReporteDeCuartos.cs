using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepOnline.Vista
{
    public partial class ReporteDeCuartos : Form
    {
        public ReporteDeCuartos()
        {
            InitializeComponent();
        }

        private void ReporteDeCuartos_Load(object sender, EventArgs e)
        {

        }
        public void PrepararReporte(CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument)
        {
            crystalReportViewer1.ReportSource = reportDocument;
        }
    }
}
