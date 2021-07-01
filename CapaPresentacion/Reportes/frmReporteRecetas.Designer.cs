namespace CapaPresentacion
{
    partial class frmReporteRecetas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsReceta = new CapaPresentacion.dsReceta();
            this.spreporte_recetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spreporte_recetaTableAdapter = new CapaPresentacion.dsRecetaTableAdapters.spreporte_recetaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporte_recetaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet3";
            reportDataSource2.Value = this.spreporte_recetaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptRecetas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(799, 516);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dsReceta
            // 
            this.dsReceta.DataSetName = "dsReceta";
            this.dsReceta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spreporte_recetaBindingSource
            // 
            this.spreporte_recetaBindingSource.DataMember = "spreporte_receta";
            this.spreporte_recetaBindingSource.DataSource = this.dsReceta;
            // 
            // spreporte_recetaTableAdapter
            // 
            this.spreporte_recetaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 516);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReporteRecetas";
            this.Text = "Reporte de recetas";
            this.Load += new System.EventHandler(this.frmReporteRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReceta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporte_recetaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spreporte_recetaBindingSource;
        private dsReceta dsReceta;
        private dsRecetaTableAdapters.spreporte_recetaTableAdapter spreporte_recetaTableAdapter;
    }
}