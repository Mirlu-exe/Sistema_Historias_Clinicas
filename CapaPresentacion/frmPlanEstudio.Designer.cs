namespace CapaPresentacion
{
    partial class frmPlanEstudio
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
            this.dsRecetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReceta = new CapaPresentacion.dsReceta();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_Plan_Estudio_Listas = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbLab = new System.Windows.Forms.ComboBox();
            this.btnQuitarLab = new System.Windows.Forms.Button();
            this.btnAñadirLab = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.cblBusqueda = new System.Windows.Forms.ComboBox();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkAnular = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar_informe = new System.Windows.Forms.Button();
            this.btnGuardar_informe = new System.Windows.Forms.Button();
            this.btnNuevo_informe = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_fecha_emision = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombre_Paciente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero_Documento = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_Recipe = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstudios = new System.Windows.Forms.ComboBox();
            this.btnQuitarEstudios = new System.Windows.Forms.Button();
            this.btnAñadirEstudios = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_id_evol = new System.Windows.Forms.Label();
            this.lbl_id_historia = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.groupBox_Plan_Estudio_Listas.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox_Recipe.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsRecetaBindingSource
            // 
            this.dsRecetaBindingSource.DataSource = this.dsReceta;
            this.dsRecetaBindingSource.Position = 0;
            // 
            // dsReceta
            // 
            this.dsReceta.DataSetName = "dsReceta";
            this.dsReceta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // groupBox_Plan_Estudio_Listas
            // 
            this.groupBox_Plan_Estudio_Listas.BackColor = System.Drawing.Color.White;
            this.groupBox_Plan_Estudio_Listas.Controls.Add(this.listBox2);
            this.groupBox_Plan_Estudio_Listas.Controls.Add(this.listBox1);
            this.groupBox_Plan_Estudio_Listas.Controls.Add(this.label8);
            this.groupBox_Plan_Estudio_Listas.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox_Plan_Estudio_Listas.Location = new System.Drawing.Point(548, 27);
            this.groupBox_Plan_Estudio_Listas.Name = "groupBox_Plan_Estudio_Listas";
            this.groupBox_Plan_Estudio_Listas.Size = new System.Drawing.Size(787, 652);
            this.groupBox_Plan_Estudio_Listas.TabIndex = 241;
            this.groupBox_Plan_Estudio_Listas.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 22;
            this.listBox2.Location = new System.Drawing.Point(6, 362);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(775, 268);
            this.listBox2.TabIndex = 229;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(6, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(775, 268);
            this.listBox1.TabIndex = 228;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(301, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 32);
            this.label8.TabIndex = 227;
            this.label8.Text = "Plan de Estudio";
            // 
            // cbLab
            // 
            this.cbLab.BackColor = System.Drawing.SystemColors.Control;
            this.cbLab.FormattingEnabled = true;
            this.cbLab.Items.AddRange(new object[] {
            "Hematologia completa",
            "Glicemia",
            "Urea",
            "Creatinina",
            "Acido urico",
            "Colesterol total y fraccionado",
            "Trigliceridos ",
            "Transaminasas piruvica",
            "Transaminasas oxalacetica",
            "Proteinas totales y fraccionadas",
            "Tiempo de protrombina",
            "TIempo parcial de tromboplastina"});
            this.cbLab.Location = new System.Drawing.Point(17, 63);
            this.cbLab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLab.Name = "cbLab";
            this.cbLab.Size = new System.Drawing.Size(365, 30);
            this.cbLab.TabIndex = 241;
            // 
            // btnQuitarLab
            // 
            this.btnQuitarLab.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnQuitarLab.Location = new System.Drawing.Point(453, 189);
            this.btnQuitarLab.Name = "btnQuitarLab";
            this.btnQuitarLab.Size = new System.Drawing.Size(89, 86);
            this.btnQuitarLab.TabIndex = 240;
            this.btnQuitarLab.Text = "-";
            this.btnQuitarLab.UseVisualStyleBackColor = false;
            this.btnQuitarLab.Click += new System.EventHandler(this.btnQuitarLab_Click);
            // 
            // btnAñadirLab
            // 
            this.btnAñadirLab.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAñadirLab.Location = new System.Drawing.Point(453, 97);
            this.btnAñadirLab.Name = "btnAñadirLab";
            this.btnAñadirLab.Size = new System.Drawing.Size(89, 86);
            this.btnAñadirLab.TabIndex = 239;
            this.btnAñadirLab.Text = "+";
            this.btnAñadirLab.UseVisualStyleBackColor = false;
            this.btnAñadirLab.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnAnular);
            this.tabPage2.Controls.Add(this.cblBusqueda);
            this.tabPage2.Controls.Add(this.dataListado);
            this.tabPage2.Controls.Add(this.lblTotal);
            this.tabPage2.Controls.Add(this.chkAnular);
            this.tabPage2.Controls.Add(this.txtBuscar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1593, 857);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista Total";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(279, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 43);
            this.button1.TabIndex = 239;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = false;
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
            this.btnAnular.Location = new System.Drawing.Point(1351, 245);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(121, 43);
            this.btnAnular.TabIndex = 237;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            // 
            // cblBusqueda
            // 
            this.cblBusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.cblBusqueda.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.cblBusqueda.ForeColor = System.Drawing.Color.DarkCyan;
            this.cblBusqueda.FormattingEnabled = true;
            this.cblBusqueda.Items.AddRange(new object[] {
            "Nombre",
            "Especialidad"});
            this.cblBusqueda.Location = new System.Drawing.Point(1001, 150);
            this.cblBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.cblBusqueda.Name = "cblBusqueda";
            this.cblBusqueda.Size = new System.Drawing.Size(160, 40);
            this.cblBusqueda.TabIndex = 236;
            this.cblBusqueda.Text = "Nombre";
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListado.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataListado.ColumnHeadersHeight = 50;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anular});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListado.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataListado.GridColor = System.Drawing.Color.DarkCyan;
            this.dataListado.Location = new System.Drawing.Point(17, 196);
            this.dataListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataListado.RowHeadersWidth = 80;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataListado.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(1327, 610);
            this.dataListado.TabIndex = 235;
            // 
            // Anular
            // 
            this.Anular.HeaderText = "Anular";
            this.Anular.MinimumWidth = 6;
            this.Anular.Name = "Anular";
            this.Anular.ReadOnly = true;
            this.Anular.Width = 125;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblTotal.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTotal.Location = new System.Drawing.Point(15, 808);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 32);
            this.lblTotal.TabIndex = 234;
            this.lblTotal.Text = "label3";
            // 
            // chkAnular
            // 
            this.chkAnular.AutoSize = true;
            this.chkAnular.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.chkAnular.ForeColor = System.Drawing.Color.DarkCyan;
            this.chkAnular.Location = new System.Drawing.Point(21, 156);
            this.chkAnular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAnular.Name = "chkAnular";
            this.chkAnular.Size = new System.Drawing.Size(103, 36);
            this.chkAnular.TabIndex = 233;
            this.chkAnular.Text = "Anular";
            this.chkAnular.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.Location = new System.Drawing.Point(1168, 162);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(176, 28);
            this.txtBuscar.TabIndex = 232;
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
            this.btnCancelar.Location = new System.Drawing.Point(150, 69);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 43);
            this.btnCancelar.TabIndex = 231;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.btnEditar.Location = new System.Drawing.Point(21, 69);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 43);
            this.btnEditar.TabIndex = 230;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
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
            this.btnBuscar.Location = new System.Drawing.Point(1351, 194);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 43);
            this.btnBuscar.TabIndex = 229;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(409, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(639, 60);
            this.label12.TabIndex = 7;
            this.label12.Text = "Plan de Estudio";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1690, 70);
            this.panel3.TabIndex = 250;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 32);
            this.label1.TabIndex = 238;
            this.label1.Text = "Examenes de laboratorio";
            // 
            // btnCancelar_informe
            // 
            this.btnCancelar_informe.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar_informe.FlatAppearance.BorderSize = 0;
            this.btnCancelar_informe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancelar_informe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar_informe.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnCancelar_informe.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCancelar_informe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar_informe.Location = new System.Drawing.Point(1393, 301);
            this.btnCancelar_informe.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar_informe.Name = "btnCancelar_informe";
            this.btnCancelar_informe.Size = new System.Drawing.Size(188, 90);
            this.btnCancelar_informe.TabIndex = 246;
            this.btnCancelar_informe.Text = "Cancelar";
            this.btnCancelar_informe.UseVisualStyleBackColor = false;
            // 
            // btnGuardar_informe
            // 
            this.btnGuardar_informe.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar_informe.FlatAppearance.BorderSize = 0;
            this.btnGuardar_informe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardar_informe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar_informe.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnGuardar_informe.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGuardar_informe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar_informe.Location = new System.Drawing.Point(1393, 214);
            this.btnGuardar_informe.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar_informe.Name = "btnGuardar_informe";
            this.btnGuardar_informe.Size = new System.Drawing.Size(188, 79);
            this.btnGuardar_informe.TabIndex = 243;
            this.btnGuardar_informe.Text = "Guardar";
            this.btnGuardar_informe.UseVisualStyleBackColor = false;
            this.btnGuardar_informe.Click += new System.EventHandler(this.btnGuardar_informe_Click);
            // 
            // btnNuevo_informe
            // 
            this.btnNuevo_informe.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo_informe.FlatAppearance.BorderSize = 0;
            this.btnNuevo_informe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNuevo_informe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo_informe.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnNuevo_informe.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnNuevo_informe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo_informe.Location = new System.Drawing.Point(1393, 127);
            this.btnNuevo_informe.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo_informe.Name = "btnNuevo_informe";
            this.btnNuevo_informe.Size = new System.Drawing.Size(188, 79);
            this.btnNuevo_informe.TabIndex = 244;
            this.btnNuevo_informe.Text = "Nuevo";
            this.btnNuevo_informe.UseVisualStyleBackColor = false;
            this.btnNuevo_informe.Click += new System.EventHandler(this.btnNuevo_informe_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1601, 892);
            this.tabControl1.TabIndex = 251;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage1.Controls.Add(this.lbl_fecha_emision);
            this.tabPage1.Controls.Add(this.btnCancelar_informe);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnGuardar_informe);
            this.tabPage1.Controls.Add(this.btnNuevo_informe);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1593, 857);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plan de Estudio";
            // 
            // lbl_fecha_emision
            // 
            this.lbl_fecha_emision.AutoSize = true;
            this.lbl_fecha_emision.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lbl_fecha_emision.ForeColor = System.Drawing.Color.MintCream;
            this.lbl_fecha_emision.Location = new System.Drawing.Point(1391, 395);
            this.lbl_fecha_emision.Name = "lbl_fecha_emision";
            this.lbl_fecha_emision.Size = new System.Drawing.Size(190, 32);
            this.lbl_fecha_emision.TabIndex = 247;
            this.lbl_fecha_emision.Text = "lbl_fecha_emision";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lbl_id_evol);
            this.groupBox1.Controls.Add(this.lbl_id_historia);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSexo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtNombre_Paciente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNumero_Documento);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(45, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1341, 84);
            this.groupBox1.TabIndex = 232;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(291, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 24);
            this.label3.TabIndex = 282;
            this.label3.Text = "🔎";
            // 
            // txtSexo
            // 
            this.txtSexo.BackColor = System.Drawing.SystemColors.Control;
            this.txtSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSexo.Location = new System.Drawing.Point(903, 38);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(171, 28);
            this.txtSexo.TabIndex = 232;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(49, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 32);
            this.label4.TabIndex = 226;
            this.label4.Text = "Cedula";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(835, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 32);
            this.label10.TabIndex = 229;
            this.label10.Text = "Sexo";
            // 
            // txtNombre_Paciente
            // 
            this.txtNombre_Paciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre_Paciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre_Paciente.Location = new System.Drawing.Point(451, 37);
            this.txtNombre_Paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre_Paciente.Name = "txtNombre_Paciente";
            this.txtNombre_Paciente.ReadOnly = true;
            this.txtNombre_Paciente.Size = new System.Drawing.Size(366, 28);
            this.txtNombre_Paciente.TabIndex = 228;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(347, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 32);
            this.label6.TabIndex = 227;
            this.label6.Text = "Nombre";
            // 
            // txtNumero_Documento
            // 
            this.txtNumero_Documento.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumero_Documento.Location = new System.Drawing.Point(141, 38);
            this.txtNumero_Documento.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero_Documento.Mask = "##.###.###";
            this.txtNumero_Documento.Name = "txtNumero_Documento";
            this.txtNumero_Documento.Size = new System.Drawing.Size(143, 28);
            this.txtNumero_Documento.TabIndex = 231;
            this.txtNumero_Documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_Documento_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnQuitarEstudios);
            this.groupBox3.Controls.Add(this.btnAñadirEstudios);
            this.groupBox3.Controls.Add(this.groupBox_Plan_Estudio_Listas);
            this.groupBox3.Controls.Add(this.btnQuitarLab);
            this.groupBox3.Controls.Add(this.btnAñadirLab);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Location = new System.Drawing.Point(31, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1355, 698);
            this.groupBox3.TabIndex = 233;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.groupBox_Recipe);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox4.Location = new System.Drawing.Point(14, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 652);
            this.groupBox4.TabIndex = 242;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(104, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 32);
            this.label5.TabIndex = 227;
            this.label5.Text = "Examenes Paraclinicos";
            // 
            // groupBox_Recipe
            // 
            this.groupBox_Recipe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox_Recipe.Controls.Add(this.cbLab);
            this.groupBox_Recipe.Controls.Add(this.label1);
            this.groupBox_Recipe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox_Recipe.Location = new System.Drawing.Point(8, 70);
            this.groupBox_Recipe.Name = "groupBox_Recipe";
            this.groupBox_Recipe.Size = new System.Drawing.Size(419, 178);
            this.groupBox_Recipe.TabIndex = 242;
            this.groupBox_Recipe.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbEstudios);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(8, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 178);
            this.groupBox2.TabIndex = 243;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 242;
            this.label2.Text = "Estudios";
            // 
            // cbEstudios
            // 
            this.cbEstudios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEstudios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEstudios.BackColor = System.Drawing.SystemColors.Control;
            this.cbEstudios.FormattingEnabled = true;
            this.cbEstudios.Items.AddRange(new object[] {
            "Electroencefalograma",
            "Ecosonograma Abdominal",
            "Ecosonograma Prostatico",
            "Rayos X de torax",
            "Ecocardiograma",
            "Holter del ritmo",
            "Monitoreo ambulatorio de presion artereal (MAPA)",
            "Prueba de esfuerzo",
            "Ecocardiograma Estres con Dobutamina",
            "Angiografia de arterias coronarias",
            "Calcio Score Coronario",
            "Angiotomografia de coronarias"});
            this.cbEstudios.Location = new System.Drawing.Point(17, 58);
            this.cbEstudios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstudios.Name = "cbEstudios";
            this.cbEstudios.Size = new System.Drawing.Size(368, 30);
            this.cbEstudios.TabIndex = 232;
            // 
            // btnQuitarEstudios
            // 
            this.btnQuitarEstudios.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnQuitarEstudios.Location = new System.Drawing.Point(453, 481);
            this.btnQuitarEstudios.Name = "btnQuitarEstudios";
            this.btnQuitarEstudios.Size = new System.Drawing.Size(89, 86);
            this.btnQuitarEstudios.TabIndex = 245;
            this.btnQuitarEstudios.Text = "-";
            this.btnQuitarEstudios.UseVisualStyleBackColor = false;
            // 
            // btnAñadirEstudios
            // 
            this.btnAñadirEstudios.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAñadirEstudios.Location = new System.Drawing.Point(453, 389);
            this.btnAñadirEstudios.Name = "btnAñadirEstudios";
            this.btnAñadirEstudios.Size = new System.Drawing.Size(89, 86);
            this.btnAñadirEstudios.TabIndex = 244;
            this.btnAñadirEstudios.Text = "+";
            this.btnAñadirEstudios.UseVisualStyleBackColor = false;
            this.btnAñadirEstudios.Click += new System.EventHandler(this.btnAñadirEstudios_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // lbl_id_evol
            // 
            this.lbl_id_evol.AutoSize = true;
            this.lbl_id_evol.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lbl_id_evol.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_id_evol.Location = new System.Drawing.Point(1247, 46);
            this.lbl_id_evol.Name = "lbl_id_evol";
            this.lbl_id_evol.Size = new System.Drawing.Size(70, 19);
            this.lbl_id_evol.TabIndex = 290;
            this.lbl_id_evol.Text = "lbl_id_evol";
            // 
            // lbl_id_historia
            // 
            this.lbl_id_historia.AutoSize = true;
            this.lbl_id_historia.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lbl_id_historia.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_id_historia.Location = new System.Drawing.Point(1247, 24);
            this.lbl_id_historia.Name = "lbl_id_historia";
            this.lbl_id_historia.Size = new System.Drawing.Size(88, 19);
            this.lbl_id_historia.TabIndex = 289;
            this.lbl_id_historia.Text = "lbl_id_historia";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.label14.ForeColor = System.Drawing.Color.CadetBlue;
            this.label14.Location = new System.Drawing.Point(1158, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 19);
            this.label14.TabIndex = 288;
            this.label14.Text = "ID Evolucion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.label11.ForeColor = System.Drawing.Color.CadetBlue;
            this.label11.Location = new System.Drawing.Point(1158, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 19);
            this.label11.TabIndex = 287;
            this.label11.Text = "ID Historia:";
            // 
            // frmPlanEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1690, 1102);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlanEstudio";
            this.Text = "frmPlanEstudio";
            this.Load += new System.EventHandler(this.frmPlanEstudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsRecetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.groupBox_Plan_Estudio_Listas.ResumeLayout(false);
            this.groupBox_Plan_Estudio_Listas.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox_Recipe.ResumeLayout(false);
            this.groupBox_Recipe.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dsRecetaBindingSource;
        private dsReceta dsReceta;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancelar_informe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombre_Paciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtNumero_Documento;
        private System.Windows.Forms.Button btnGuardar_informe;
        private System.Windows.Forms.Button btnNuevo_informe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox_Recipe;
        private System.Windows.Forms.ComboBox cbLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Plan_Estudio_Listas;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnQuitarLab;
        private System.Windows.Forms.Button btnAñadirLab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.ComboBox cblBusqueda;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anular;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkAnular;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnQuitarEstudios;
        private System.Windows.Forms.Button btnAñadirEstudios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstudios;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lbl_fecha_emision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_id_evol;
        private System.Windows.Forms.Label lbl_id_historia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
    }
}