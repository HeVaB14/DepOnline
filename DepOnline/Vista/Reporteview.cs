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
    public partial class Reporteview : Form
    {
        public Reporteview()
        {
            InitializeComponent();
        }

        private void btnDisponible_Click(object sender, EventArgs e)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            reportDocument.Load(@"C:\Users\gama\Desktop\Integradora\DepOnline\DepOnline\Modelo\ReporteCuarto.rpt");
            ReporteDeCuartos rpt = new ReporteDeCuartos();
            rpt.PrepararReporte(reportDocument);
            rpt.Show();
        }

        private void Reporteview_Load(object sender, EventArgs e)
        {

        }
    }
}
