using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lena.BO;
using Lena.BLL;
using Microsoft.Reporting.WinForms;

namespace Lena_Hotel
{
    public partial class StatFacture : Form
    {
        List<ClasseFacture> Cams;
        string nom = "";
        public StatFacture()
        {
            InitializeComponent();
        }
        public StatFacture(List<ClasseFacture> dataSources,string Nom)
        {
            InitializeComponent();
            Cams = dataSources;
            nom = Nom;
            
        }

        private void StatFacture_Load(object sender, EventArgs e)
        {
            classeFactureBindingSource.DataSource = Cams;
            ReportParameter[] para = new ReportParameter[]
            {
                new ReportParameter("ReportNom",nom)
            };
            this.reportViewerStatFacture.LocalReport.SetParameters(para);
            this.reportViewerStatFacture.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewerStatFacture.ZoomMode = ZoomMode.Percent;
            reportViewerStatFacture.ZoomPercent = 100;
            this.reportViewerStatFacture.RefreshReport();
        }
    }
}
