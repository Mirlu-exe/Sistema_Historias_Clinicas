namespace CapaPresentacion
{
    partial class frmListadoCitasUsuario
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
            this.spListaCitasMedicasTotalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.spListaCitasMedicasUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spListaCitasMedicasUsuariosTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.spListaCitasMedicasUsuariosTableAdapter();
            this.spListaCitasMedicasTotalesTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.spListaCitasMedicasTotalesTableAdapter();
            this.spListaCitasMedicasFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spListaCitasMedicasFechasTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.spListaCitasMedicasFechasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spListaCitasMedicasTotalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaCitasMedicasUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaCitasMedicasFechasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spListaCitasMedicasTotalesBindingSource
            // 
            this.spListaCitasMedicasTotalesBindingSource.DataMember = "spListaCitasMedicasTotales";
            this.spListaCitasMedicasTotalesBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spListaCitasMedicasUsuariosBindingSource
            // 
            this.spListaCitasMedicasUsuariosBindingSource.DataMember = "spListaCitasMedicasUsuarios";
            this.spListaCitasMedicasUsuariosBindingSource.DataSource = this.dsPrincipal;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spListaCitasMedicasTotalesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptCitasMedicasTotales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // spListaCitasMedicasUsuariosTableAdapter
            // 
            this.spListaCitasMedicasUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // spListaCitasMedicasTotalesTableAdapter
            // 
            this.spListaCitasMedicasTotalesTableAdapter.ClearBeforeFill = true;
            // 
            // spListaCitasMedicasFechasBindingSource
            // 
            this.spListaCitasMedicasFechasBindingSource.DataMember = "spListaCitasMedicasFechas";
            this.spListaCitasMedicasFechasBindingSource.DataSource = this.dsPrincipal;
            // 
            // spListaCitasMedicasFechasTableAdapter
            // 
            this.spListaCitasMedicasFechasTableAdapter.ClearBeforeFill = true;
            // 
            // frmListadoCitasUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListadoCitasUsuario";
            this.Text = "frmListadoCitasUsuario";
            this.Load += new System.EventHandler(this.frmListadoCitasUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spListaCitasMedicasTotalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaCitasMedicasUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaCitasMedicasFechasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spListaCitasMedicasUsuariosBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.spListaCitasMedicasUsuariosTableAdapter spListaCitasMedicasUsuariosTableAdapter;
        private System.Windows.Forms.BindingSource spListaCitasMedicasTotalesBindingSource;
        private dsPrincipalTableAdapters.spListaCitasMedicasTotalesTableAdapter spListaCitasMedicasTotalesTableAdapter;
        private System.Windows.Forms.BindingSource spListaCitasMedicasFechasBindingSource;
        private dsPrincipalTableAdapters.spListaCitasMedicasFechasTableAdapter spListaCitasMedicasFechasTableAdapter;
    }
}