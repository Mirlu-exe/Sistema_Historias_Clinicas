namespace CapaPresentacion
{
    partial class frmControlEstadistico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.myChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblDataNotFound = new System.Windows.Forms.Label();
            this.rbGraficoTorta = new System.Windows.Forms.RadioButton();
            this.rbGraficoBarrasApiladas = new System.Windows.Forms.RadioButton();
            this.rbGraficoBarras = new System.Windows.Forms.RadioButton();
            this.rbGraficoColumnasApiladas = new System.Windows.Forms.RadioButton();
            this.rbGraficoColumnas = new System.Windows.Forms.RadioButton();
            this.groupClaseGrafico = new System.Windows.Forms.GroupBox();
            this.dpHasta = new System.Windows.Forms.DateTimePicker();
            this.dpDesde = new System.Windows.Forms.DateTimePicker();
            this.cbRangoFecha = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbFiltroTipo = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoGrafico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrearGrafico = new System.Windows.Forms.Button();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.groupClaseGrafico.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // myChart
            // 
            chartArea1.Name = "ChartArea1";
            this.myChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.myChart.Legends.Add(legend1);
            this.myChart.Location = new System.Drawing.Point(6, 0);
            this.myChart.Margin = new System.Windows.Forms.Padding(4);
            this.myChart.Name = "myChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Serie1";
            series1.XValueMember = "sexo, edad";
            series1.YValueMembers = "10, 44";
            series1.YValuesPerPoint = 6;
            this.myChart.Series.Add(series1);
            this.myChart.Size = new System.Drawing.Size(1272, 734);
            this.myChart.TabIndex = 0;
            this.myChart.Text = "chart1";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.lblDataNotFound);
            this.panelContenedor.Controls.Add(this.myChart);
            this.panelContenedor.Location = new System.Drawing.Point(376, 152);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1289, 738);
            this.panelContenedor.TabIndex = 252;
            // 
            // lblDataNotFound
            // 
            this.lblDataNotFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNotFound.Location = new System.Drawing.Point(19, 16);
            this.lblDataNotFound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNotFound.Name = "lblDataNotFound";
            this.lblDataNotFound.Size = new System.Drawing.Size(1246, 704);
            this.lblDataNotFound.TabIndex = 1;
            this.lblDataNotFound.Text = "Datos no encontrados\r\nIntente con otros filtros de busqueda";
            this.lblDataNotFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDataNotFound.Visible = false;
            // 
            // rbGraficoTorta
            // 
            this.rbGraficoTorta.AutoSize = true;
            this.rbGraficoTorta.Location = new System.Drawing.Point(8, 83);
            this.rbGraficoTorta.Margin = new System.Windows.Forms.Padding(4);
            this.rbGraficoTorta.Name = "rbGraficoTorta";
            this.rbGraficoTorta.Size = new System.Drawing.Size(63, 21);
            this.rbGraficoTorta.TabIndex = 4;
            this.rbGraficoTorta.TabStop = true;
            this.rbGraficoTorta.Text = "Torta";
            this.rbGraficoTorta.UseVisualStyleBackColor = true;
            this.rbGraficoTorta.CheckedChanged += new System.EventHandler(this.rbGraficoTorta_CheckedChanged);
            // 
            // rbGraficoBarrasApiladas
            // 
            this.rbGraficoBarrasApiladas.AutoSize = true;
            this.rbGraficoBarrasApiladas.Location = new System.Drawing.Point(165, 54);
            this.rbGraficoBarrasApiladas.Margin = new System.Windows.Forms.Padding(4);
            this.rbGraficoBarrasApiladas.Name = "rbGraficoBarrasApiladas";
            this.rbGraficoBarrasApiladas.Size = new System.Drawing.Size(129, 21);
            this.rbGraficoBarrasApiladas.TabIndex = 3;
            this.rbGraficoBarrasApiladas.TabStop = true;
            this.rbGraficoBarrasApiladas.Text = "Barras Apiladas";
            this.rbGraficoBarrasApiladas.UseVisualStyleBackColor = true;
            this.rbGraficoBarrasApiladas.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbGraficoBarras
            // 
            this.rbGraficoBarras.AutoSize = true;
            this.rbGraficoBarras.Location = new System.Drawing.Point(165, 23);
            this.rbGraficoBarras.Margin = new System.Windows.Forms.Padding(4);
            this.rbGraficoBarras.Name = "rbGraficoBarras";
            this.rbGraficoBarras.Size = new System.Drawing.Size(71, 21);
            this.rbGraficoBarras.TabIndex = 2;
            this.rbGraficoBarras.TabStop = true;
            this.rbGraficoBarras.Text = "Barras";
            this.rbGraficoBarras.UseVisualStyleBackColor = true;
            this.rbGraficoBarras.CheckedChanged += new System.EventHandler(this.rbBarrasApiladas_CheckedChanged);
            // 
            // rbGraficoColumnasApiladas
            // 
            this.rbGraficoColumnasApiladas.AutoSize = true;
            this.rbGraficoColumnasApiladas.Location = new System.Drawing.Point(8, 54);
            this.rbGraficoColumnasApiladas.Margin = new System.Windows.Forms.Padding(4);
            this.rbGraficoColumnasApiladas.Name = "rbGraficoColumnasApiladas";
            this.rbGraficoColumnasApiladas.Size = new System.Drawing.Size(149, 21);
            this.rbGraficoColumnasApiladas.TabIndex = 1;
            this.rbGraficoColumnasApiladas.TabStop = true;
            this.rbGraficoColumnasApiladas.Text = "Columnas Apiladas";
            this.rbGraficoColumnasApiladas.UseVisualStyleBackColor = true;
            this.rbGraficoColumnasApiladas.CheckedChanged += new System.EventHandler(this.rbGraficoColumnasApiladas_CheckedChanged);
            // 
            // rbGraficoColumnas
            // 
            this.rbGraficoColumnas.AutoSize = true;
            this.rbGraficoColumnas.Location = new System.Drawing.Point(8, 25);
            this.rbGraficoColumnas.Margin = new System.Windows.Forms.Padding(4);
            this.rbGraficoColumnas.Name = "rbGraficoColumnas";
            this.rbGraficoColumnas.Size = new System.Drawing.Size(91, 21);
            this.rbGraficoColumnas.TabIndex = 0;
            this.rbGraficoColumnas.TabStop = true;
            this.rbGraficoColumnas.Text = "Columnas";
            this.rbGraficoColumnas.UseVisualStyleBackColor = true;
            this.rbGraficoColumnas.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupClaseGrafico
            // 
            this.groupClaseGrafico.Controls.Add(this.rbGraficoTorta);
            this.groupClaseGrafico.Controls.Add(this.rbGraficoBarrasApiladas);
            this.groupClaseGrafico.Controls.Add(this.rbGraficoBarras);
            this.groupClaseGrafico.Controls.Add(this.rbGraficoColumnasApiladas);
            this.groupClaseGrafico.Controls.Add(this.rbGraficoColumnas);
            this.groupClaseGrafico.Location = new System.Drawing.Point(36, 653);
            this.groupClaseGrafico.Margin = new System.Windows.Forms.Padding(4);
            this.groupClaseGrafico.Name = "groupClaseGrafico";
            this.groupClaseGrafico.Padding = new System.Windows.Forms.Padding(4);
            this.groupClaseGrafico.Size = new System.Drawing.Size(323, 112);
            this.groupClaseGrafico.TabIndex = 251;
            this.groupClaseGrafico.TabStop = false;
            this.groupClaseGrafico.Text = "Estilo de Grafico";
            // 
            // dpHasta
            // 
            this.dpHasta.Location = new System.Drawing.Point(36, 602);
            this.dpHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dpHasta.Name = "dpHasta";
            this.dpHasta.Size = new System.Drawing.Size(322, 22);
            this.dpHasta.TabIndex = 250;
            this.dpHasta.Visible = false;
            // 
            // dpDesde
            // 
            this.dpDesde.Location = new System.Drawing.Point(35, 572);
            this.dpDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dpDesde.Name = "dpDesde";
            this.dpDesde.Size = new System.Drawing.Size(322, 22);
            this.dpDesde.TabIndex = 249;
            this.dpDesde.Visible = false;
            // 
            // cbRangoFecha
            // 
            this.cbRangoFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRangoFecha.FormattingEnabled = true;
            this.cbRangoFecha.Items.AddRange(new object[] {
            "Hoy",
            "Últimos 7 días",
            "Últimos 15 días",
            "Este mes",
            "Este año",
            "Rango específico"});
            this.cbRangoFecha.Location = new System.Drawing.Point(36, 542);
            this.cbRangoFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRangoFecha.Name = "cbRangoFecha";
            this.cbRangoFecha.Size = new System.Drawing.Size(322, 24);
            this.cbRangoFecha.TabIndex = 248;
            this.cbRangoFecha.SelectedIndexChanged += new System.EventHandler(this.cbRangoFecha_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(30, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 32);
            this.label5.TabIndex = 247;
            this.label5.Text = "Rango de Fecha de los registros:";
            // 
            // lbFiltroTipo
            // 
            this.lbFiltroTipo.FormattingEnabled = true;
            this.lbFiltroTipo.ItemHeight = 16;
            this.lbFiltroTipo.Location = new System.Drawing.Point(35, 270);
            this.lbFiltroTipo.Margin = new System.Windows.Forms.Padding(4);
            this.lbFiltroTipo.Name = "lbFiltroTipo";
            this.lbFiltroTipo.Size = new System.Drawing.Size(322, 132);
            this.lbFiltroTipo.TabIndex = 246;
            this.lbFiltroTipo.SelectedIndexChanged += new System.EventHandler(this.lbFiltroTipo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(30, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 32);
            this.label4.TabIndex = 245;
            this.label4.Text = "Elementos de los datos:";
            // 
            // cbTipoGrafico
            // 
            this.cbTipoGrafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoGrafico.FormattingEnabled = true;
            this.cbTipoGrafico.Items.AddRange(new object[] {
            "Diagnósticos",
            "Tipos de Enfermedades"});
            this.cbTipoGrafico.Location = new System.Drawing.Point(35, 198);
            this.cbTipoGrafico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoGrafico.Name = "cbTipoGrafico";
            this.cbTipoGrafico.Size = new System.Drawing.Size(323, 24);
            this.cbTipoGrafico.TabIndex = 243;
            this.cbTipoGrafico.SelectedIndexChanged += new System.EventHandler(this.onChangeCbTipo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(29, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 244;
            this.label1.Text = "Datos a analizar:";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1695, 70);
            this.panel3.TabIndex = 242;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(484, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(519, 60);
            this.label12.TabIndex = 7;
            this.label12.Text = "Control Estadístico";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.ForeColor = System.Drawing.Color.DimGray;
            this.lblFechaHora.Location = new System.Drawing.Point(978, 899);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(146, 32);
            this.lblFechaHora.TabIndex = 240;
            this.lblFechaHora.Text = "lblFechaHora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(703, 899);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 32);
            this.label3.TabIndex = 239;
            this.label3.Text = "Fecha y Hora del Gráfico:";
            // 
            // btnCrearGrafico
            // 
            this.btnCrearGrafico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCrearGrafico.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnCrearGrafico.ForeColor = System.Drawing.Color.White;
            this.btnCrearGrafico.Location = new System.Drawing.Point(36, 783);
            this.btnCrearGrafico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearGrafico.Name = "btnCrearGrafico";
            this.btnCrearGrafico.Size = new System.Drawing.Size(319, 45);
            this.btnCrearGrafico.TabIndex = 237;
            this.btnCrearGrafico.Text = "Generar Gráfico";
            this.btnCrearGrafico.UseVisualStyleBackColor = false;
            this.btnCrearGrafico.Click += new System.EventHandler(this.btnCrearGrafico_Click);
            // 
            // cbCampo
            // 
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Items.AddRange(new object[] {
            "Sexo",
            "Rango de Edad"});
            this.cbCampo.Location = new System.Drawing.Point(35, 457);
            this.cbCampo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(322, 24);
            this.cbCampo.TabIndex = 236;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(29, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 32);
            this.label6.TabIndex = 238;
            this.label6.Text = "Agrupar según:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(35, 111);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(121, 43);
            this.btnNuevo.TabIndex = 235;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(35, 844);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(320, 46);
            this.btnExportar.TabIndex = 253;
            this.btnExportar.Text = "Exportar ";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            this.saveFileDialog1.DefaultExt = "jpg";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // frmControlEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1695, 940);
            this.Controls.Add(this.groupClaseGrafico);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.dpHasta);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.dpDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.btnCrearGrafico);
            this.Controls.Add(this.cbRangoFecha);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cbTipoGrafico);
            this.Controls.Add(this.lbFiltroTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmControlEstadistico";
            this.Text = "frmControlEstadistico";
            this.Load += new System.EventHandler(this.frmControlEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.groupClaseGrafico.ResumeLayout(false);
            this.groupClaseGrafico.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart myChart;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblDataNotFound;
        private System.Windows.Forms.RadioButton rbGraficoTorta;
        private System.Windows.Forms.RadioButton rbGraficoBarrasApiladas;
        private System.Windows.Forms.RadioButton rbGraficoBarras;
        private System.Windows.Forms.RadioButton rbGraficoColumnasApiladas;
        private System.Windows.Forms.RadioButton rbGraficoColumnas;
        private System.Windows.Forms.GroupBox groupClaseGrafico;
        private System.Windows.Forms.DateTimePicker dpHasta;
        private System.Windows.Forms.DateTimePicker dpDesde;
        private System.Windows.Forms.ComboBox cbRangoFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbFiltroTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoGrafico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrearGrafico;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }





}

