namespace CapaPresentacion
{
    partial class frmListadoHistorialOp
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
            this.spmostrar_operacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.spmostraroperacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spmostrar_operacionTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.spmostrar_operacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_operacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostraroperacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HistorialOpTotal";
            reportDataSource1.Value = this.spmostrar_operacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptHistorialOp.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(850, 486);
            this.reportViewer1.TabIndex = 0;
            // 
            // spmostrar_operacionBindingSource
            // 
            this.spmostrar_operacionBindingSource.DataMember = "spmostrar_operacion";
            this.spmostrar_operacionBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spmostraroperacionBindingSource
            // 
            this.spmostraroperacionBindingSource.DataMember = "spmostrar_operacion";
            this.spmostraroperacionBindingSource.DataSource = this.dsPrincipal;
            // 
            // spmostrar_operacionTableAdapter
            // 
            this.spmostrar_operacionTableAdapter.ClearBeforeFill = true;
            // 
            // frmListadoHistorialOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 486);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListadoHistorialOp";
            this.Text = "frmListadoHistorialOp";
            this.Load += new System.EventHandler(this.frmListadoHistorialOp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_operacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostraroperacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsPrincipal dsPrincipal;
        private System.Windows.Forms.BindingSource spmostraroperacionBindingSource;
        private dsPrincipalTableAdapters.spmostrar_operacionTableAdapter spmostrar_operacionTableAdapter;
        private System.Windows.Forms.BindingSource spmostrar_operacionBindingSource;
    }
}