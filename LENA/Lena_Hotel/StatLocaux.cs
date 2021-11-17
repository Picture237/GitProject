using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Lena.BO;
using Lena.BLL;
using Microsoft.Reporting.WinForms;

namespace Lena_Hotel
{
    public partial class StatLocaux : Form
    {
        List<Chambre> _cams;
        //List<Chambre> list;
        public StatLocaux()
        {
            InitializeComponent();
            
        }

        public StatLocaux(List<Chambre> dataSources)
        {
            InitializeComponent();
            _cams = dataSources;
        }

        private void StatLocaux_Load(object sender, EventArgs e)
        {
            ChambreBindingSource.DataSource = _cams;
            ReportParameter[] para = new ReportParameter[] { };
            this.reportViewerStatLoaux.LocalReport.SetParameters(para);
            this.reportViewerStatLoaux.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewerStatLoaux.ZoomMode = ZoomMode.Percent;
            reportViewerStatLoaux.ZoomPercent = 100;
            this.reportViewerStatLoaux.RefreshReport();
        }
    }
}
