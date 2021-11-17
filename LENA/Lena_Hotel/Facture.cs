using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lena.BO;
using Microsoft.Reporting.WinForms;

namespace Lena_Hotel
{
    public partial class Facture : Form
    {
        
        List<ClasseFacture> _list;
        string _email = "";
        double _telephone = 0d;
        DateTime datedujour = DateTime.Now;
        private BindingSource ClasseFactureBindingSource;
        private IContainer components;
        private ReportViewer reportViewer1;

        public Facture()
        {
            InitializeComponent();

        }


        public Facture(List<ClasseFacture> dataSource, string email,double telephone)
        {
            InitializeComponent();
            _list = dataSource;
            _email = email;
            _telephone = telephone;
            
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ClasseFactureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ClasseFactureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClasseFactureBindingSource
            // 
            this.ClasseFactureBindingSource.DataSource = typeof(Lena.BO.ClasseFacture);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFacture";
            reportDataSource1.Value = this.ClasseFactureBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Lena_Hotel.ReportFacture.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(845, 437);
            this.reportViewer1.TabIndex = 0;
            // 
            // Facture
            // 
            this.ClientSize = new System.Drawing.Size(845, 437);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Facture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Facture_FormClosed);
            this.Load += new System.EventHandler(this.Facture_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ClasseFactureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void Facture_Load_1(object sender, EventArgs e)
        {
            ClasseFactureBindingSource.DataSource = _list;
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("RNom",_email),
                new Microsoft.Reporting.WinForms.ReportParameter("RDate",_telephone.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("RDay",datedujour.ToString())
            };

            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 125;
            this.reportViewer1.RefreshReport();
        }

        public void Chargement()
        {
            
        }
        

        private void Facture_Load(object sender, EventArgs e)
        {
            ClasseFactureBindingSource.DataSource = _list;
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new ReportParameter("RNom",_email),
                new ReportParameter("RDate",_telephone.ToString())
            };

            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }

        private void Facture_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
