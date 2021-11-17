namespace Lena_Hotel
{
    partial class StatistiqueC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatistiqueC));
            this.ReservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerStat = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservationBindingSource
            // 
            this.ReservationBindingSource.DataSource = typeof(Lena.BO.Reservation);
            // 
            // reportViewerStat
            // 
            this.reportViewerStat.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataReserv";
            reportDataSource1.Value = this.ReservationBindingSource;
            this.reportViewerStat.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerStat.LocalReport.ReportEmbeddedResource = "Lena_Hotel.ReportStatistique.rdlc";
            this.reportViewerStat.Location = new System.Drawing.Point(0, 0);
            this.reportViewerStat.Name = "reportViewerStat";
            this.reportViewerStat.Size = new System.Drawing.Size(1142, 634);
            this.reportViewerStat.TabIndex = 0;
            // 
            // StatistiqueC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 634);
            this.Controls.Add(this.reportViewerStat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatistiqueC";
            this.Text = "Statistique";
            this.Load += new System.EventHandler(this.Statistique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerStat;
        private System.Windows.Forms.BindingSource ReservationBindingSource;
    }
}