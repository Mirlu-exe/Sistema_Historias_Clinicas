namespace CapaPresentacion.Reportes
{
    partial class frmReporteDiagnosticos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.dsPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticoTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.DiagnosticoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsDiagnosticos";
            reportDataSource1.Value = this.diagnosticoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptDiagnosticos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPrincipalBindingSource
            // 
            this.dsPrincipalBindingSource.DataSource = this.dsPrincipal;
            this.dsPrincipalBindingSource.Position = 0;
            // 
            // diagnosticoBindingSource
            // 
            this.diagnosticoBindingSource.DataMember = "Diagnostico";
            this.diagnosticoBindingSource.DataSource = this.dsPrincipal;
            // 
            // diagnosticoTableAdapter
            // 
            this.diagnosticoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteDiagnosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteDiagnosticos";
            this.Text = "frmReporteDiagnosticos";
            this.Load += new System.EventHandler(this.frmReporteDiagnosticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsPrincipal dsPrincipal;
        private System.Windows.Forms.BindingSource dsPrincipalBindingSource;
        private System.Windows.Forms.BindingSource diagnosticoBindingSource;
        private dsPrincipalTableAdapters.DiagnosticoTableAdapter diagnosticoTableAdapter;
    }
}