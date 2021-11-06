namespace CapaPresentacion
{
    partial class frmArchivosMuertos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArchivosMuertos));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.label49 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.dgv_lista_evol = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtRazonConsulta = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtEnfermedadActual = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtHistoriaFamiliar = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtHistoriaPersonal = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.dtpFechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.txtTratamiento_Actual = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtExamenFisico = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtecg = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtRayos_X = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtEcocardiograma = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtPlanEstudio = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtTerapeutico = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.cmbEstadoHistoria = new System.Windows.Forms.ComboBox();
            this.lbl_id_historia = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnadirEvol = new System.Windows.Forms.Button();
            this.lbl_nombre_pac = new System.Windows.Forms.Label();
            this.lbl_ci_pac = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cblTipo_Sangre = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.cbDiagnosticos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista_evol)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.Controls.Add(this.label49);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1914, 31);
            this.panel7.TabIndex = 162;
            // 
            // label49
            // 
            this.label49.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(636, 0);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(519, 31);
            this.label49.TabIndex = 7;
            this.label49.Text = "Archivos Muertos";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(36, 48);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(520, 95);
            this.label41.TabIndex = 6;
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(632, 11);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(519, 60);
            this.label40.TabIndex = 7;
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_lista_evol
            // 
            this.dgv_lista_evol.AllowUserToAddRows = false;
            this.dgv_lista_evol.AllowUserToDeleteRows = false;
            this.dgv_lista_evol.AllowUserToOrderColumns = true;
            this.dgv_lista_evol.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_lista_evol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_lista_evol.ColumnHeadersHeight = 50;
            this.dgv_lista_evol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_lista_evol.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_lista_evol.Location = new System.Drawing.Point(3, 2);
            this.dgv_lista_evol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_lista_evol.MultiSelect = false;
            this.dgv_lista_evol.Name = "dgv_lista_evol";
            this.dgv_lista_evol.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_lista_evol.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_lista_evol.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_lista_evol.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_lista_evol.RowTemplate.Height = 24;
            this.dgv_lista_evol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lista_evol.Size = new System.Drawing.Size(1741, 587);
            this.dgv_lista_evol.TabIndex = 15;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Anular";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // Anular
            // 
            this.Anular.HeaderText = "Anular";
            this.Anular.MinimumWidth = 6;
            this.Anular.Name = "Anular";
            this.Anular.ReadOnly = true;
            this.Anular.Width = 125;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(520, 95);
            this.label8.TabIndex = 6;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(632, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(519, 60);
            this.label7.TabIndex = 7;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(39, 166);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(220, 32);
            this.label23.TabIndex = 47;
            // 
            // txtRazonConsulta
            // 
            this.txtRazonConsulta.BackColor = System.Drawing.SystemColors.Control;
            this.txtRazonConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonConsulta.Location = new System.Drawing.Point(315, 247);
            this.txtRazonConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRazonConsulta.Multiline = true;
            this.txtRazonConsulta.Name = "txtRazonConsulta";
            this.txtRazonConsulta.Size = new System.Drawing.Size(298, 93);
            this.txtRazonConsulta.TabIndex = 58;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(33, 247);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(223, 32);
            this.label24.TabIndex = 57;
            // 
            // txtEnfermedadActual
            // 
            this.txtEnfermedadActual.BackColor = System.Drawing.SystemColors.Control;
            this.txtEnfermedadActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnfermedadActual.Location = new System.Drawing.Point(315, 377);
            this.txtEnfermedadActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnfermedadActual.Multiline = true;
            this.txtEnfermedadActual.Name = "txtEnfermedadActual";
            this.txtEnfermedadActual.Size = new System.Drawing.Size(298, 88);
            this.txtEnfermedadActual.TabIndex = 60;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(33, 386);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(207, 32);
            this.label25.TabIndex = 59;
            // 
            // txtHistoriaFamiliar
            // 
            this.txtHistoriaFamiliar.BackColor = System.Drawing.SystemColors.Control;
            this.txtHistoriaFamiliar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHistoriaFamiliar.Location = new System.Drawing.Point(315, 490);
            this.txtHistoriaFamiliar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHistoriaFamiliar.Multiline = true;
            this.txtHistoriaFamiliar.Name = "txtHistoriaFamiliar";
            this.txtHistoriaFamiliar.Size = new System.Drawing.Size(298, 98);
            this.txtHistoriaFamiliar.TabIndex = 62;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(32, 535);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(174, 32);
            this.label26.TabIndex = 61;
            // 
            // txtHistoriaPersonal
            // 
            this.txtHistoriaPersonal.BackColor = System.Drawing.SystemColors.Control;
            this.txtHistoriaPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHistoriaPersonal.Location = new System.Drawing.Point(315, 626);
            this.txtHistoriaPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHistoriaPersonal.Multiline = true;
            this.txtHistoriaPersonal.Name = "txtHistoriaPersonal";
            this.txtHistoriaPersonal.Size = new System.Drawing.Size(298, 92);
            this.txtHistoriaPersonal.TabIndex = 64;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(33, 642);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(181, 32);
            this.label27.TabIndex = 63;
            // 
            // dtpFechaConsulta
            // 
            this.dtpFechaConsulta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaConsulta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFechaConsulta.Location = new System.Drawing.Point(315, 161);
            this.dtpFechaConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaConsulta.Name = "dtpFechaConsulta";
            this.dtpFechaConsulta.Size = new System.Drawing.Size(297, 22);
            this.dtpFechaConsulta.TabIndex = 65;
            // 
            // txtTratamiento_Actual
            // 
            this.txtTratamiento_Actual.BackColor = System.Drawing.SystemColors.Control;
            this.txtTratamiento_Actual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTratamiento_Actual.Location = new System.Drawing.Point(886, 161);
            this.txtTratamiento_Actual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTratamiento_Actual.Multiline = true;
            this.txtTratamiento_Actual.Name = "txtTratamiento_Actual";
            this.txtTratamiento_Actual.Size = new System.Drawing.Size(254, 64);
            this.txtTratamiento_Actual.TabIndex = 67;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(634, 163);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(203, 32);
            this.label28.TabIndex = 66;
            // 
            // txtExamenFisico
            // 
            this.txtExamenFisico.BackColor = System.Drawing.SystemColors.Control;
            this.txtExamenFisico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExamenFisico.Location = new System.Drawing.Point(886, 253);
            this.txtExamenFisico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExamenFisico.Multiline = true;
            this.txtExamenFisico.Name = "txtExamenFisico";
            this.txtExamenFisico.Size = new System.Drawing.Size(254, 71);
            this.txtExamenFisico.TabIndex = 69;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(635, 258);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(155, 32);
            this.label29.TabIndex = 68;
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.BackColor = System.Drawing.SystemColors.Control;
            this.txtLaboratorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLaboratorio.Location = new System.Drawing.Point(886, 351);
            this.txtLaboratorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLaboratorio.Multiline = true;
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(254, 65);
            this.txtLaboratorio.TabIndex = 71;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(635, 351);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(130, 32);
            this.label30.TabIndex = 70;
            // 
            // txtecg
            // 
            this.txtecg.BackColor = System.Drawing.SystemColors.Control;
            this.txtecg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtecg.Location = new System.Drawing.Point(886, 433);
            this.txtecg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtecg.Multiline = true;
            this.txtecg.Name = "txtecg";
            this.txtecg.Size = new System.Drawing.Size(254, 73);
            this.txtecg.TabIndex = 73;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(635, 442);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(57, 32);
            this.label31.TabIndex = 72;
            // 
            // txtRayos_X
            // 
            this.txtRayos_X.BackColor = System.Drawing.SystemColors.Control;
            this.txtRayos_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRayos_X.Location = new System.Drawing.Point(886, 543);
            this.txtRayos_X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRayos_X.Multiline = true;
            this.txtRayos_X.Name = "txtRayos_X";
            this.txtRayos_X.Size = new System.Drawing.Size(254, 76);
            this.txtRayos_X.TabIndex = 75;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(634, 566);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(94, 32);
            this.label32.TabIndex = 74;
            // 
            // txtEcocardiograma
            // 
            this.txtEcocardiograma.BackColor = System.Drawing.SystemColors.Control;
            this.txtEcocardiograma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEcocardiograma.Location = new System.Drawing.Point(886, 650);
            this.txtEcocardiograma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEcocardiograma.Multiline = true;
            this.txtEcocardiograma.Name = "txtEcocardiograma";
            this.txtEcocardiograma.Size = new System.Drawing.Size(254, 76);
            this.txtEcocardiograma.TabIndex = 77;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(635, 673);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(178, 32);
            this.label33.TabIndex = 76;
            // 
            // txtPlanEstudio
            // 
            this.txtPlanEstudio.BackColor = System.Drawing.SystemColors.Control;
            this.txtPlanEstudio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlanEstudio.Location = new System.Drawing.Point(315, 767);
            this.txtPlanEstudio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlanEstudio.Multiline = true;
            this.txtPlanEstudio.Name = "txtPlanEstudio";
            this.txtPlanEstudio.Size = new System.Drawing.Size(298, 82);
            this.txtPlanEstudio.TabIndex = 79;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(32, 769);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(169, 32);
            this.label34.TabIndex = 78;
            // 
            // txtTerapeutico
            // 
            this.txtTerapeutico.BackColor = System.Drawing.SystemColors.Control;
            this.txtTerapeutico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTerapeutico.Location = new System.Drawing.Point(886, 762);
            this.txtTerapeutico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTerapeutico.Multiline = true;
            this.txtTerapeutico.Name = "txtTerapeutico";
            this.txtTerapeutico.Size = new System.Drawing.Size(254, 80);
            this.txtTerapeutico.TabIndex = 81;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(635, 773);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(179, 32);
            this.label35.TabIndex = 80;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(1205, 773);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(81, 32);
            this.label36.TabIndex = 82;
            // 
            // cmbEstadoHistoria
            // 
            this.cmbEstadoHistoria.BackColor = System.Drawing.SystemColors.Control;
            this.cmbEstadoHistoria.FormattingEnabled = true;
            this.cmbEstadoHistoria.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoHistoria.Location = new System.Drawing.Point(1205, 809);
            this.cmbEstadoHistoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstadoHistoria.Name = "cmbEstadoHistoria";
            this.cmbEstadoHistoria.Size = new System.Drawing.Size(160, 25);
            this.cmbEstadoHistoria.TabIndex = 83;
            // 
            // lbl_id_historia
            // 
            this.lbl_id_historia.AutoSize = true;
            this.lbl_id_historia.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_id_historia.Location = new System.Drawing.Point(1199, 129);
            this.lbl_id_historia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_historia.Name = "lbl_id_historia";
            this.lbl_id_historia.Size = new System.Drawing.Size(128, 32);
            this.lbl_id_historia.TabIndex = 88;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(1205, 498);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(188, 79);
            this.btnGuardar.TabIndex = 142;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnNuevo.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(1205, 412);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(188, 79);
            this.btnNuevo.TabIndex = 143;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnEditar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(1205, 585);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(188, 87);
            this.btnEditar.TabIndex = 144;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(1205, 679);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(188, 90);
            this.btnCancelar.TabIndex = 145;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1736, 79);
            this.panel2.TabIndex = 153;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(520, 95);
            this.label6.TabIndex = 6;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(632, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(519, 60);
            this.label5.TabIndex = 7;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(21, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 32);
            this.label2.TabIndex = 168;
            // 
            // btnAnadirEvol
            // 
            this.btnAnadirEvol.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAnadirEvol.FlatAppearance.BorderSize = 0;
            this.btnAnadirEvol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAnadirEvol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirEvol.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnAnadirEvol.ForeColor = System.Drawing.Color.MintCream;
            this.btnAnadirEvol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnadirEvol.Location = new System.Drawing.Point(1205, 304);
            this.btnAnadirEvol.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnadirEvol.Name = "btnAnadirEvol";
            this.btnAnadirEvol.Size = new System.Drawing.Size(188, 79);
            this.btnAnadirEvol.TabIndex = 169;
            this.btnAnadirEvol.Text = "+ Añadir Evolucion";
            this.btnAnadirEvol.UseVisualStyleBackColor = false;
            // 
            // lbl_nombre_pac
            // 
            this.lbl_nombre_pac.AutoSize = true;
            this.lbl_nombre_pac.Location = new System.Drawing.Point(1199, 182);
            this.lbl_nombre_pac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre_pac.Name = "lbl_nombre_pac";
            this.lbl_nombre_pac.Size = new System.Drawing.Size(173, 32);
            this.lbl_nombre_pac.TabIndex = 170;
            // 
            // lbl_ci_pac
            // 
            this.lbl_ci_pac.AutoSize = true;
            this.lbl_ci_pac.Location = new System.Drawing.Point(1199, 227);
            this.lbl_ci_pac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ci_pac.Name = "lbl_ci_pac";
            this.lbl_ci_pac.Size = new System.Drawing.Size(110, 32);
            this.lbl_ci_pac.TabIndex = 171;
            this.lbl_ci_pac.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 876);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 32);
            this.label13.TabIndex = 172;
            // 
            // cblTipo_Sangre
            // 
            this.cblTipo_Sangre.BackColor = System.Drawing.SystemColors.Control;
            this.cblTipo_Sangre.FormattingEnabled = true;
            this.cblTipo_Sangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cblTipo_Sangre.Location = new System.Drawing.Point(1205, 887);
            this.cblTipo_Sangre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cblTipo_Sangre.Name = "cblTipo_Sangre";
            this.cblTipo_Sangre.Size = new System.Drawing.Size(67, 25);
            this.cblTipo_Sangre.TabIndex = 266;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(1199, 853);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(90, 32);
            this.label48.TabIndex = 267;
            // 
            // cbDiagnosticos
            // 
            this.cbDiagnosticos.BackColor = System.Drawing.SystemColors.Control;
            this.cbDiagnosticos.FormattingEnabled = true;
            this.cbDiagnosticos.Location = new System.Drawing.Point(315, 876);
            this.cbDiagnosticos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDiagnosticos.Name = "cbDiagnosticos";
            this.cbDiagnosticos.Size = new System.Drawing.Size(825, 25);
            this.cbDiagnosticos.TabIndex = 268;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(520, 95);
            this.label4.TabIndex = 6;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(632, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(519, 60);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1914, 74);
            this.panel1.TabIndex = 200;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(781, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(575, 71);
            this.button1.TabIndex = 197;
            this.button1.Text = "Papelera de Reciclaje";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(171, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(575, 71);
            this.button2.TabIndex = 198;
            this.button2.Text = "Pacientes Fallecidos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(5, 36);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1914, 775);
            this.panelContenedor.TabIndex = 199;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // frmArchivosMuertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1924, 816);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel7);
            this.MinimizeBox = false;
            this.Name = "frmArchivosMuertos";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "frmArchivosMuertos";
            this.Load += new System.EventHandler(this.frmArchivosMuertos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista_evol)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.DataGridView dgv_lista_evol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtRazonConsulta;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtEnfermedadActual;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtHistoriaFamiliar;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtHistoriaPersonal;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker dtpFechaConsulta;
        private System.Windows.Forms.TextBox txtTratamiento_Actual;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtExamenFisico;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtecg;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtRayos_X;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtEcocardiograma;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtPlanEstudio;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtTerapeutico;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox cmbEstadoHistoria;
        private System.Windows.Forms.Label lbl_id_historia;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnadirEvol;
        private System.Windows.Forms.Label lbl_nombre_pac;
        private System.Windows.Forms.Label lbl_ci_pac;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cblTipo_Sangre;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.ComboBox cbDiagnosticos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelContenedor;
    }
}