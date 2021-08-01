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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsRecetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReceta = new CapaPresentacion.dsReceta();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_Plan_Terapeutico_Lista = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMuestras = new System.Windows.Forms.ComboBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
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
            this.txtNota = new System.Windows.Forms.TextBox();
            this.cbExamenes = new System.Windows.Forms.ComboBox();
            this.btnCancelar_informe = new System.Windows.Forms.Button();
            this.btnGuardar_informe = new System.Windows.Forms.Button();
            this.btnNuevo_informe = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombre_Paciente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero_Documento = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox_Indicaciones = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox_Recipe = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsRecetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReceta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.groupBox_Plan_Terapeutico_Lista.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_Indicaciones.SuspendLayout();
            this.groupBox_Recipe.SuspendLayout();
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
            // groupBox_Plan_Terapeutico_Lista
            // 
            this.groupBox_Plan_Terapeutico_Lista.BackColor = System.Drawing.Color.LightGray;
            this.groupBox_Plan_Terapeutico_Lista.Controls.Add(this.listBox1);
            this.groupBox_Plan_Terapeutico_Lista.Controls.Add(this.label8);
            this.groupBox_Plan_Terapeutico_Lista.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox_Plan_Terapeutico_Lista.Location = new System.Drawing.Point(534, 27);
            this.groupBox_Plan_Terapeutico_Lista.Name = "groupBox_Plan_Terapeutico_Lista";
            this.groupBox_Plan_Terapeutico_Lista.Size = new System.Drawing.Size(787, 652);
            this.groupBox_Plan_Terapeutico_Lista.TabIndex = 241;
            this.groupBox_Plan_Terapeutico_Lista.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(6, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(775, 576);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(17, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 32);
            this.label7.TabIndex = 242;
            this.label7.Text = "Estudios";
            // 
            // cbMuestras
            // 
            this.cbMuestras.BackColor = System.Drawing.SystemColors.Control;
            this.cbMuestras.FormattingEnabled = true;
            this.cbMuestras.Items.AddRange(new object[] {
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
            this.cbMuestras.Location = new System.Drawing.Point(23, 201);
            this.cbMuestras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMuestras.Name = "cbMuestras";
            this.cbMuestras.Size = new System.Drawing.Size(365, 30);
            this.cbMuestras.TabIndex = 241;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnQuitar.Location = new System.Drawing.Point(439, 117);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(89, 86);
            this.btnQuitar.TabIndex = 240;
            this.btnQuitar.Text = "-";
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAñadir.Location = new System.Drawing.Point(439, 25);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(89, 86);
            this.btnAñadir.TabIndex = 239;
            this.btnAñadir.Text = "+";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
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
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.dataListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataListado.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataListado.ColumnHeadersHeight = 50;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anular});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListado.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataListado.GridColor = System.Drawing.Color.DarkCyan;
            this.dataListado.Location = new System.Drawing.Point(17, 196);
            this.dataListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataListado.RowHeadersWidth = 80;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dataListado.RowsDefaultCellStyle = dataGridViewCellStyle15;
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
            this.label1.Location = new System.Drawing.Point(20, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 32);
            this.label1.TabIndex = 238;
            this.label1.Text = "Examenes de laboratorio";
            // 
            // txtNota
            // 
            this.txtNota.BackColor = System.Drawing.SystemColors.Control;
            this.txtNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNota.Location = new System.Drawing.Point(23, 65);
            this.txtNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(365, 182);
            this.txtNota.TabIndex = 235;
            // 
            // cbExamenes
            // 
            this.cbExamenes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbExamenes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbExamenes.BackColor = System.Drawing.SystemColors.Control;
            this.cbExamenes.FormattingEnabled = true;
            this.cbExamenes.Items.AddRange(new object[] {
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
            this.cbExamenes.Location = new System.Drawing.Point(20, 109);
            this.cbExamenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbExamenes.Name = "cbExamenes";
            this.cbExamenes.Size = new System.Drawing.Size(368, 30);
            this.cbExamenes.TabIndex = 232;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
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
            // txtSexo
            // 
            this.txtSexo.BackColor = System.Drawing.SystemColors.Control;
            this.txtSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSexo.Location = new System.Drawing.Point(950, 43);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(258, 28);
            this.txtSexo.TabIndex = 232;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(77, 34);
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
            this.label10.Location = new System.Drawing.Point(882, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 32);
            this.label10.TabIndex = 229;
            this.label10.Text = "Sexo";
            // 
            // txtNombre_Paciente
            // 
            this.txtNombre_Paciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre_Paciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre_Paciente.Location = new System.Drawing.Point(449, 44);
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
            this.label6.Location = new System.Drawing.Point(345, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 32);
            this.label6.TabIndex = 227;
            this.label6.Text = "Nombre";
            // 
            // txtNumero_Documento
            // 
            this.txtNumero_Documento.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumero_Documento.Location = new System.Drawing.Point(169, 43);
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
            this.groupBox3.Controls.Add(this.groupBox_Indicaciones);
            this.groupBox3.Controls.Add(this.groupBox_Recipe);
            this.groupBox3.Controls.Add(this.groupBox_Plan_Terapeutico_Lista);
            this.groupBox3.Controls.Add(this.btnQuitar);
            this.groupBox3.Controls.Add(this.btnAñadir);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Location = new System.Drawing.Point(45, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1341, 698);
            this.groupBox3.TabIndex = 233;
            this.groupBox3.TabStop = false;
            // 
            // groupBox_Indicaciones
            // 
            this.groupBox_Indicaciones.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox_Indicaciones.Controls.Add(this.label9);
            this.groupBox_Indicaciones.Controls.Add(this.txtNota);
            this.groupBox_Indicaciones.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox_Indicaciones.Location = new System.Drawing.Point(24, 404);
            this.groupBox_Indicaciones.Name = "groupBox_Indicaciones";
            this.groupBox_Indicaciones.Size = new System.Drawing.Size(409, 269);
            this.groupBox_Indicaciones.TabIndex = 243;
            this.groupBox_Indicaciones.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(162, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 32);
            this.label9.TabIndex = 243;
            this.label9.Text = "Nota:";
            // 
            // groupBox_Recipe
            // 
            this.groupBox_Recipe.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox_Recipe.Controls.Add(this.label7);
            this.groupBox_Recipe.Controls.Add(this.cbMuestras);
            this.groupBox_Recipe.Controls.Add(this.label5);
            this.groupBox_Recipe.Controls.Add(this.cbExamenes);
            this.groupBox_Recipe.Controls.Add(this.label1);
            this.groupBox_Recipe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox_Recipe.Location = new System.Drawing.Point(24, 25);
            this.groupBox_Recipe.Name = "groupBox_Recipe";
            this.groupBox_Recipe.Size = new System.Drawing.Size(409, 373);
            this.groupBox_Recipe.TabIndex = 242;
            this.groupBox_Recipe.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(98, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 32);
            this.label5.TabIndex = 227;
            this.label5.Text = "Examenes Paraclínicos";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
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
            this.groupBox_Plan_Terapeutico_Lista.ResumeLayout(false);
            this.groupBox_Plan_Terapeutico_Lista.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox_Indicaciones.ResumeLayout(false);
            this.groupBox_Indicaciones.PerformLayout();
            this.groupBox_Recipe.ResumeLayout(false);
            this.groupBox_Recipe.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox_Indicaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.GroupBox groupBox_Recipe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMuestras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbExamenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Plan_Terapeutico_Lista;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAñadir;
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
    }
}