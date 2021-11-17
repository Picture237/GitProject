namespace Lena_Hotel
{
    partial class StatFacture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatFacture));
            this.classeFactureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerStatFacture = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.classeFactureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classeFactureBindingSource
            // 
            this.classeFactureBindingSource.DataSource = typeof(Lena.BO.ClasseFacture);
            // 
            // reportViewerStatFacture
            // 
            this.reportViewerStatFacture.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.classeFactureBindingSource;
            this.reportViewerStatFacture.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerStatFacture.LocalReport.ReportEmbeddedResource = "Lena_Hotel.ReportStatFacture.rdlc";
            this.reportViewerStatFacture.Location = new System.Drawing.Point(0, 0);
            this.reportViewerStatFacture.Name = "reportViewerStatFacture";
            this.reportViewerStatFacture.Size = new System.Drawing.Size(971, 415);
            this.reportViewerStatFacture.TabIndex = 0;
            // 
            // StatFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 415);
            this.Controls.Add(this.reportViewerStatFacture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatFacture";
            this.Text = "StatFacture";
            this.Load += new System.EventHandler(this.StatFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classeFactureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerStatFacture;
        private System.Windows.Forms.BindingSource classeFactureBindingSource;
    }
}