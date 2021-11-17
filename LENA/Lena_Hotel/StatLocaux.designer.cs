namespace Lena_Hotel
{
    partial class StatLocaux
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatLocaux));
            this.ChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerStatLoaux = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ChambreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChambreBindingSource
            // 
            this.ChambreBindingSource.DataSource = typeof(Lena.BO.Chambre);
            // 
            // reportViewerStatLoaux
            // 
            this.reportViewerStatLoaux.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetLocaux";
            reportDataSource1.Value = this.ChambreBindingSource;
            this.reportViewerStatLoaux.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerStatLoaux.LocalReport.ReportEmbeddedResource = "Lena_Hotel.ReportStatLocaux.rdlc";
            this.reportViewerStatLoaux.Location = new System.Drawing.Point(0, 0);
            this.reportViewerStatLoaux.Name = "reportViewerStatLoaux";
            this.reportViewerStatLoaux.Size = new System.Drawing.Size(1106, 640);
            this.reportViewerStatLoaux.TabIndex = 0;
            // 
            // StatLocaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 640);
            this.Controls.Add(this.reportViewerStatLoaux);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatLocaux";
            this.Text = "StatLocaux";
            this.Load += new System.EventHandler(this.StatLocaux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChambreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerStatLoaux;
        private System.Windows.Forms.BindingSource ChambreBindingSource;
    }
}