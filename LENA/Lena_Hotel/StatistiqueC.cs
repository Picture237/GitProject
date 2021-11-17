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
using Microsoft.Reporting.WinForms;

namespace Lena_Hotel
{
    public partial class StatistiqueC : Form
    {
       List<Reservation> _reserv;

        string _date="";

        public StatistiqueC()
        {
            InitializeComponent();
        }

        public StatistiqueC(List<Reservation> dataSources,string date)
        {
            InitializeComponent();
           _reserv = dataSources;
           _date = date;
        }
        private void Statistique_Load(object sender, EventArgs e)
        {
            ReservationBindingSource.DataSource = _reserv;
            ReportParameter[] para = new ReportParameter[]
            {
                new ReportParameter("ReportDate",_date)
            };
            this.reportViewerStat.LocalReport.SetParameters(para);
            this.reportViewerStat.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewerStat.ZoomMode = ZoomMode.Percent;
            reportViewerStat.ZoomPercent = 100;
            this.reportViewerStat.RefreshReport();
        }
    }
}
