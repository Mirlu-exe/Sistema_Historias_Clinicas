
namespace CapaPresentacion
{
    partial class frmVisualizadorCrystal
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
            this.cryVisualizador = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryVisualizador
            // 
            this.cryVisualizador.ActiveViewIndex = -1;
            this.cryVisualizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryVisualizador.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryVisualizador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryVisualizador.Location = new System.Drawing.Point(0, 0);
            this.cryVisualizador.Name = "cryVisualizador";
            this.cryVisualizador.Size = new System.Drawing.Size(800, 450);
            this.cryVisualizador.TabIndex = 0;
            // 
            // frmVisualizadorCrystal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cryVisualizador);
            this.Name = "frmVisualizadorCrystal";
            this.ShowIcon = false;
            this.Text = "Visualizador de Informes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVisualizadorCrystal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer cryVisualizador;
    }
}