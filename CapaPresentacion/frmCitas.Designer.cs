namespace CapaPresentacion
{
    partial class frmCitas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbEstadoCita = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodCita = new System.Windows.Forms.TextBox();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkAnular = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cmbPacientes = new System.Windows.Forms.ComboBox();
            this.cmbServicios = new System.Windows.Forms.ComboBox();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.txtCodServicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoPaciente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIdservicio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.lblCodigoPaciente = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtbuscarpaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCitasHoy = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LblHora = new System.Windows.Forms.Label();
            this.dgv_citas_hoy = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idcitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idservicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.label4 = new System.Windows.Forms.Label();
            this.citaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.citaTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.CitaTableAdapter();
            this.dsPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.ServicioTableAdapter();
            this.fKCitaServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citas_hoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCitaServicioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(132, 163);
            this.cmbUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(207, 24);
            this.cmbUsuarios.TabIndex = 189;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(21, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 32);
            this.label14.TabIndex = 188;
            this.label14.Text = "Usuario";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(1038, 778);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(132, 22);
            this.maskedTextBox1.TabIndex = 187;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblMontoTotal.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMontoTotal.Location = new System.Drawing.Point(886, 778);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(27, 32);
            this.lblMontoTotal.TabIndex = 186;
            this.lblMontoTotal.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(534, 778);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 32);
            this.label5.TabIndex = 185;
            this.label5.Text = "Monto total por citas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1916, 76);
            this.panel3.TabIndex = 184;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.label12.Text = "Citas Médicas";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(36, 48);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(520, 95);
            this.label13.TabIndex = 6;
            this.label13.Text = "Crystal Clear";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnAnular.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(287, 708);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(165, 55);
            this.btnAnular.TabIndex = 183;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnBuscar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(114, 708);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(165, 55);
            this.btnBuscar.TabIndex = 182;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cmbEstadoCita
            // 
            this.cmbEstadoCita.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.cmbEstadoCita.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmbEstadoCita.FormattingEnabled = true;
            this.cmbEstadoCita.Items.AddRange(new object[] {
            "Activo",
            "Cancelada"});
            this.cmbEstadoCita.Location = new System.Drawing.Point(687, 716);
            this.cmbEstadoCita.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstadoCita.Name = "cmbEstadoCita";
            this.cmbEstadoCita.Size = new System.Drawing.Size(160, 40);
            this.cmbEstadoCita.TabIndex = 181;
            this.cmbEstadoCita.Text = "Activo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(525, 716);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 32);
            this.label11.TabIndex = 180;
            this.label11.Text = "Estado de cita";
            // 
            // txtCodCita
            // 
            this.txtCodCita.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodCita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodCita.Enabled = false;
            this.txtCodCita.Location = new System.Drawing.Point(115, 65);
            this.txtCodCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodCita.Name = "txtCodCita";
            this.txtCodCita.Size = new System.Drawing.Size(39, 22);
            this.txtCodCita.TabIndex = 179;
            this.txtCodCita.Visible = false;
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.cmbBusqueda.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] {
            "Paciente",
            "Servicio"});
            this.cmbBusqueda.Location = new System.Drawing.Point(137, 263);
            this.cmbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(160, 40);
            this.cmbBusqueda.TabIndex = 177;
            this.cmbBusqueda.Text = "Paciente";
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.BackgroundColor = System.Drawing.Color.White;
            this.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListado.ColumnHeadersHeight = 50;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anular});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataListado.GridColor = System.Drawing.Color.DarkCyan;
            this.dataListado.Location = new System.Drawing.Point(128, 309);
            this.dataListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataListado.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataListado.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(764, 313);
            this.dataListado.TabIndex = 176;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // Anular
            // 
            this.Anular.HeaderText = "Anular";
            this.Anular.MinimumWidth = 6;
            this.Anular.Name = "Anular";
            this.Anular.ReadOnly = true;
            this.Anular.Width = 125;
            // 
            // chkAnular
            // 
            this.chkAnular.AutoSize = true;
            this.chkAnular.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.chkAnular.ForeColor = System.Drawing.Color.DarkCyan;
            this.chkAnular.Location = new System.Drawing.Point(626, 265);
            this.chkAnular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAnular.Name = "chkAnular";
            this.chkAnular.Size = new System.Drawing.Size(103, 36);
            this.chkAnular.TabIndex = 175;
            this.chkAnular.Text = "Anular";
            this.chkAnular.UseVisualStyleBackColor = true;
            this.chkAnular.CheckedChanged += new System.EventHandler(this.chkAnular_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblTotal.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTotal.Location = new System.Drawing.Point(904, 711);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 32);
            this.lblTotal.TabIndex = 174;
            this.lblTotal.Text = "label3";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.Location = new System.Drawing.Point(305, 276);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(176, 22);
            this.txtBuscar.TabIndex = 173;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(1018, 178);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 55);
            this.btnCancelar.TabIndex = 172;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(841, 178);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(165, 55);
            this.btnEditar.TabIndex = 171;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(668, 178);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(165, 55);
            this.btnGuardar.TabIndex = 170;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(494, 178);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(165, 55);
            this.btnNuevo.TabIndex = 169;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cmbPacientes
            // 
            this.cmbPacientes.BackColor = System.Drawing.SystemColors.Control;
            this.cmbPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacientes.FormattingEnabled = true;
            this.cmbPacientes.Location = new System.Drawing.Point(132, 119);
            this.cmbPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPacientes.Name = "cmbPacientes";
            this.cmbPacientes.Size = new System.Drawing.Size(207, 24);
            this.cmbPacientes.TabIndex = 168;
            this.cmbPacientes.SelectedIndexChanged += new System.EventHandler(this.cmbPacientes_SelectedIndexChanged);
            // 
            // cmbServicios
            // 
            this.cmbServicios.BackColor = System.Drawing.SystemColors.Control;
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Location = new System.Drawing.Point(668, 84);
            this.cmbServicios.Margin = new System.Windows.Forms.Padding(4);
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(148, 24);
            this.cmbServicios.TabIndex = 167;
            this.cmbServicios.SelectedIndexChanged += new System.EventHandler(this.cmbServicios_SelectedIndexChanged);
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.BackColor = System.Drawing.Color.White;
            this.txtCodUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodUsuario.Enabled = false;
            this.txtCodUsuario.Location = new System.Drawing.Point(451, 133);
            this.txtCodUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Size = new System.Drawing.Size(39, 15);
            this.txtCodUsuario.TabIndex = 164;
            this.txtCodUsuario.Visible = false;
            // 
            // txtCodServicio
            // 
            this.txtCodServicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodServicio.Enabled = false;
            this.txtCodServicio.Location = new System.Drawing.Point(667, 48);
            this.txtCodServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodServicio.Name = "txtCodServicio";
            this.txtCodServicio.Size = new System.Drawing.Size(39, 22);
            this.txtCodServicio.TabIndex = 162;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(442, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 32);
            this.label6.TabIndex = 161;
            this.label6.Text = "Codigo de servicio";
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodigoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoPaciente.Enabled = false;
            this.txtCodigoPaciente.Location = new System.Drawing.Point(114, 39);
            this.txtCodigoPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoPaciente.Name = "txtCodigoPaciente";
            this.txtCodigoPaciente.Size = new System.Drawing.Size(39, 22);
            this.txtCodigoPaciente.TabIndex = 160;
            this.txtCodigoPaciente.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(412, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 32);
            this.label8.TabIndex = 158;
            this.label8.Text = "Costo de tipo servicio";
            // 
            // lblIdservicio
            // 
            this.lblIdservicio.AutoSize = true;
            this.lblIdservicio.Location = new System.Drawing.Point(1208, 235);
            this.lblIdservicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdservicio.Name = "lblIdservicio";
            this.lblIdservicio.Size = new System.Drawing.Size(0, 17);
            this.lblIdservicio.TabIndex = 157;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(471, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 156;
            this.label2.Text = "Tipo de servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(883, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 155;
            this.label1.Text = "Fecha de consulta";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Location = new System.Drawing.Point(1090, 82);
            this.dtpFechaCita.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaCita.TabIndex = 154;
            // 
            // lblCodigoPaciente
            // 
            this.lblCodigoPaciente.AutoSize = true;
            this.lblCodigoPaciente.Location = new System.Drawing.Point(95, 110);
            this.lblCodigoPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoPaciente.Name = "lblCodigoPaciente";
            this.lblCodigoPaciente.Size = new System.Drawing.Size(0, 17);
            this.lblCodigoPaciente.TabIndex = 153;
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.SystemColors.Control;
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCosto.Enabled = false;
            this.txtCosto.Location = new System.Drawing.Point(668, 120);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCosto.Size = new System.Drawing.Size(148, 22);
            this.txtCosto.TabIndex = 152;
            // 
            // txtbuscarpaciente
            // 
            this.txtbuscarpaciente.BackColor = System.Drawing.Color.White;
            this.txtbuscarpaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscarpaciente.Enabled = false;
            this.txtbuscarpaciente.Location = new System.Drawing.Point(1323, 708);
            this.txtbuscarpaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscarpaciente.Name = "txtbuscarpaciente";
            this.txtbuscarpaciente.Size = new System.Drawing.Size(153, 22);
            this.txtbuscarpaciente.TabIndex = 151;
            this.txtbuscarpaciente.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 150;
            this.label3.Text = "Paciente";
            // 
            // btnCitasHoy
            // 
            this.btnCitasHoy.BackColor = System.Drawing.SystemColors.Control;
            this.btnCitasHoy.FlatAppearance.BorderSize = 0;
            this.btnCitasHoy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCitasHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitasHoy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitasHoy.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCitasHoy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitasHoy.Location = new System.Drawing.Point(1190, 166);
            this.btnCitasHoy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCitasHoy.Name = "btnCitasHoy";
            this.btnCitasHoy.Size = new System.Drawing.Size(165, 78);
            this.btnCitasHoy.TabIndex = 190;
            this.btnCitasHoy.Text = "Mostrar Citas para Hoy";
            this.btnCitasHoy.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(34, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1566, 887);
            this.tabControl1.TabIndex = 191;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblMontoTotal);
            this.tabPage1.Controls.Add(this.maskedTextBox1);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.btnAnular);
            this.tabPage1.Controls.Add(this.btnCitasHoy);
            this.tabPage1.Controls.Add(this.txtCodigoPaciente);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.cmbEstadoCita);
            this.tabPage1.Controls.Add(this.cmbUsuarios);
            this.tabPage1.Controls.Add(this.txtCodCita);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.cmbPacientes);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dataListado);
            this.tabPage1.Controls.Add(this.cmbBusqueda);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtbuscarpaciente);
            this.tabPage1.Controls.Add(this.chkAnular);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.txtCodServicio);
            this.tabPage1.Controls.Add(this.cmbServicios);
            this.tabPage1.Controls.Add(this.txtCosto);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtpFechaCita);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnNuevo);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1558, 858);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Todas las Citas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LblHora);
            this.tabPage2.Controls.Add(this.dgv_citas_hoy);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1558, 858);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Citas para Hoy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.LblHora.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblHora.Location = new System.Drawing.Point(745, 60);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(75, 32);
            this.LblHora.TabIndex = 178;
            this.LblHora.Text = "label4";
            this.LblHora.Click += new System.EventHandler(this.LblHora_Click);
            // 
            // dgv_citas_hoy
            // 
            this.dgv_citas_hoy.AllowUserToAddRows = false;
            this.dgv_citas_hoy.AllowUserToDeleteRows = false;
            this.dgv_citas_hoy.AllowUserToOrderColumns = true;
            this.dgv_citas_hoy.AutoGenerateColumns = false;
            this.dgv_citas_hoy.BackgroundColor = System.Drawing.Color.White;
            this.dgv_citas_hoy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_citas_hoy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_citas_hoy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_citas_hoy.ColumnHeadersHeight = 50;
            this.dgv_citas_hoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_citas_hoy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.idcitaDataGridViewTextBoxColumn,
            this.idpacienteDataGridViewTextBoxColumn,
            this.idusuarioDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.idservicioDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgv_citas_hoy.DataSource = this.citaBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_citas_hoy.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_citas_hoy.GridColor = System.Drawing.Color.DarkCyan;
            this.dgv_citas_hoy.Location = new System.Drawing.Point(140, 94);
            this.dgv_citas_hoy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_citas_hoy.MultiSelect = false;
            this.dgv_citas_hoy.Name = "dgv_citas_hoy";
            this.dgv_citas_hoy.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_citas_hoy.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_citas_hoy.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_citas_hoy.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_citas_hoy.RowTemplate.Height = 24;
            this.dgv_citas_hoy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_citas_hoy.Size = new System.Drawing.Size(1361, 572);
            this.dgv_citas_hoy.TabIndex = 177;
            this.dgv_citas_hoy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_citas_hoy_CellContentClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Anular";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // idcitaDataGridViewTextBoxColumn
            // 
            this.idcitaDataGridViewTextBoxColumn.DataPropertyName = "idcita";
            this.idcitaDataGridViewTextBoxColumn.HeaderText = "idcita";
            this.idcitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcitaDataGridViewTextBoxColumn.Name = "idcitaDataGridViewTextBoxColumn";
            this.idcitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcitaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idpacienteDataGridViewTextBoxColumn
            // 
            this.idpacienteDataGridViewTextBoxColumn.DataPropertyName = "idpaciente";
            this.idpacienteDataGridViewTextBoxColumn.HeaderText = "idpaciente";
            this.idpacienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpacienteDataGridViewTextBoxColumn.Name = "idpacienteDataGridViewTextBoxColumn";
            this.idpacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpacienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "idusuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "idusuario";
            this.idusuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idusuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idservicioDataGridViewTextBoxColumn
            // 
            this.idservicioDataGridViewTextBoxColumn.DataPropertyName = "idservicio";
            this.idservicioDataGridViewTextBoxColumn.HeaderText = "idservicio";
            this.idservicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idservicioDataGridViewTextBoxColumn.Name = "idservicioDataGridViewTextBoxColumn";
            this.idservicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idservicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // citaBindingSource
            // 
            this.citaBindingSource.DataMember = "Cita";
            this.citaBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "DIA: ";
            // 
            // citaBindingSource1
            // 
            this.citaBindingSource1.DataMember = "Cita";
            this.citaBindingSource1.DataSource = this.dsPrincipal;
            // 
            // citaTableAdapter
            // 
            this.citaTableAdapter.ClearBeforeFill = true;
            // 
            // dsPrincipalBindingSource
            // 
            this.dsPrincipalBindingSource.DataSource = this.dsPrincipal;
            this.dsPrincipalBindingSource.Position = 0;
            // 
            // servicioBindingSource
            // 
            this.servicioBindingSource.DataMember = "Servicio";
            this.servicioBindingSource.DataSource = this.dsPrincipalBindingSource;
            // 
            // servicioTableAdapter
            // 
            this.servicioTableAdapter.ClearBeforeFill = true;
            // 
            // fKCitaServicioBindingSource
            // 
            this.fKCitaServicioBindingSource.DataMember = "FK_Cita_Servicio";
            this.fKCitaServicioBindingSource.DataSource = this.servicioBindingSource;
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1916, 1018);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtCodUsuario);
            this.Controls.Add(this.lblIdservicio);
            this.Controls.Add(this.lblCodigoPaciente);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCitas";
            this.Text = "frmCitas";
            this.Load += new System.EventHandler(this.frmCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citas_hoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCitaServicioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbEstadoCita;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtCodCita;
        private System.Windows.Forms.ComboBox cmbBusqueda;
        public System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anular;
        private System.Windows.Forms.CheckBox chkAnular;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cmbPacientes;
        private System.Windows.Forms.ComboBox cmbServicios;
        public System.Windows.Forms.TextBox txtCodUsuario;
        public System.Windows.Forms.TextBox txtCodServicio;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCodigoPaciente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIdservicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Label lblCodigoPaciente;
        public System.Windows.Forms.TextBox txtCosto;
        public System.Windows.Forms.TextBox txtbuscarpaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Button btnCitasHoy;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView dgv_citas_hoy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblHora;
        private dsPrincipal dsPrincipal;
        private System.Windows.Forms.BindingSource citaBindingSource;
        private dsPrincipalTableAdapters.CitaTableAdapter citaTableAdapter;
        private System.Windows.Forms.BindingSource citaBindingSource1;
        private System.Windows.Forms.BindingSource dsPrincipalBindingSource;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private dsPrincipalTableAdapters.ServicioTableAdapter servicioTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource fKCitaServicioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idservicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}