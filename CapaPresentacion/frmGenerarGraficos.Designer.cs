namespace CapaPresentacion
{
    partial class frmGenerarGraficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnLimpiarGrafico = new System.Windows.Forms.Button();
            this.btnCrearGrafico = new System.Windows.Forms.Button();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartLinea = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartCircular = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardarGrafico = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLinea)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCircular)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarras)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiarGrafico
            // 
            this.btnLimpiarGrafico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLimpiarGrafico.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarGrafico.Location = new System.Drawing.Point(847, 460);
            this.btnLimpiarGrafico.Name = "btnLimpiarGrafico";
            this.btnLimpiarGrafico.Size = new System.Drawing.Size(229, 46);
            this.btnLimpiarGrafico.TabIndex = 164;
            this.btnLimpiarGrafico.Text = "Limpiar Grafico";
            this.btnLimpiarGrafico.UseVisualStyleBackColor = false;
            this.btnLimpiarGrafico.Click += new System.EventHandler(this.btnLimpiarGrafico_Click);
            // 
            // btnCrearGrafico
            // 
            this.btnCrearGrafico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCrearGrafico.ForeColor = System.Drawing.Color.White;
            this.btnCrearGrafico.Location = new System.Drawing.Point(847, 408);
            this.btnCrearGrafico.Name = "btnCrearGrafico";
            this.btnCrearGrafico.Size = new System.Drawing.Size(229, 46);
            this.btnCrearGrafico.TabIndex = 163;
            this.btnCrearGrafico.Text = "Generar Gráfico";
            this.btnCrearGrafico.UseVisualStyleBackColor = false;
            this.btnCrearGrafico.Click += new System.EventHandler(this.btnCrearGrafico_Click);
            // 
            // cbCampo
            // 
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Items.AddRange(new object[] {
            "Edad",
            "Sexo",
            "Estado Civil"});
            this.cbCampo.Location = new System.Drawing.Point(847, 364);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(229, 24);
            this.cbCampo.TabIndex = 162;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartLinea);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(710, 544);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Linea";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartLinea
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLinea.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLinea.Legends.Add(legend1);
            this.chartLinea.Location = new System.Drawing.Point(3, 3);
            this.chartLinea.Name = "chartLinea";
            this.chartLinea.Size = new System.Drawing.Size(704, 516);
            this.chartLinea.TabIndex = 2;
            this.chartLinea.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartCircular);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartCircular
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCircular.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCircular.Legends.Add(legend2);
            this.chartCircular.Location = new System.Drawing.Point(6, 6);
            this.chartCircular.Name = "chartCircular";
            this.chartCircular.Size = new System.Drawing.Size(698, 510);
            this.chartCircular.TabIndex = 3;
            this.chartCircular.Text = "chart1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartBarras);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Barras";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartBarras
            // 
            chartArea3.Name = "ChartArea1";
            this.chartBarras.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartBarras.Legends.Add(legend3);
            this.chartBarras.Location = new System.Drawing.Point(6, 6);
            this.chartBarras.Name = "chartBarras";
            this.chartBarras.Size = new System.Drawing.Size(698, 521);
            this.chartBarras.TabIndex = 1;
            this.chartBarras.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(841, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 32);
            this.label6.TabIndex = 167;
            this.label6.Text = "Campo:";
            // 
            // btnGuardarGrafico
            // 
            this.btnGuardarGrafico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardarGrafico.ForeColor = System.Drawing.Color.White;
            this.btnGuardarGrafico.Location = new System.Drawing.Point(847, 512);
            this.btnGuardarGrafico.Name = "btnGuardarGrafico";
            this.btnGuardarGrafico.Size = new System.Drawing.Size(229, 46);
            this.btnGuardarGrafico.TabIndex = 166;
            this.btnGuardarGrafico.Text = "Guardar Gráfico";
            this.btnGuardarGrafico.UseVisualStyleBackColor = false;
            this.btnGuardarGrafico.Click += new System.EventHandler(this.btnImprimirGrafico_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(81, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 573);
            this.tabControl1.TabIndex = 165;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.DimGray;
            this.radioButton1.Location = new System.Drawing.Point(23, 67);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(191, 36);
            this.radioButton1.TabIndex = 169;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Historia Medica";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.DimGray;
            this.radioButton2.Location = new System.Drawing.Point(20, 109);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(120, 36);
            this.radioButton2.TabIndex = 170;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Paciente";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Location = new System.Drawing.Point(847, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 191);
            this.groupBox1.TabIndex = 171;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar según:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.LblHora.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.LblHora.Location = new System.Drawing.Point(841, 75);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(87, 32);
            this.LblHora.TabIndex = 172;
            this.LblHora.Text = "lblHora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(79, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 173;
            this.label1.Text = "Tipo de Gráfico:";
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnVerTodo.ForeColor = System.Drawing.Color.White;
            this.btnVerTodo.Location = new System.Drawing.Point(847, 564);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(229, 46);
            this.btnVerTodo.TabIndex = 174;
            this.btnVerTodo.Text = "Ver todos los Gráficos Registrados";
            this.btnVerTodo.UseVisualStyleBackColor = false;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // frmGenerarGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 698);
            this.Controls.Add(this.btnVerTodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiarGrafico);
            this.Controls.Add(this.btnCrearGrafico);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuardarGrafico);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmGenerarGraficos";
            this.Text = "Generar Gráficos";
            this.Load += new System.EventHandler(this.graficoPaciente_Load);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLinea)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCircular)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBarras)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarGrafico;
        private System.Windows.Forms.Button btnCrearGrafico;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardarGrafico;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLinea;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCircular;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBarras;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerTodo;
    }
}