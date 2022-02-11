namespace CapaPresentacion
{
    partial class frmPlanTerapeutico
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndicaciones = new System.Windows.Forms.TextBox();
            this.cbMedicamento = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo_plan_terapeutico = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_idplanterapeutico_evol = new System.Windows.Forms.Label();
            this.lbl_idplanterapeutico_historia = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAsignarPlanTerapeutico = new System.Windows.Forms.Button();
            this.btnImprimirRecipe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCedulaPac_Terapeutico = new System.Windows.Forms.TextBox();
            this.lupa = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_fecha_emision = new System.Windows.Forms.Label();
            this.txtNombre_Paciente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox_Indicaciones = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox_Recipe = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPresentacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDosis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_Plan_Terapeutico_Lista = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_Indicaciones.SuspendLayout();
            this.groupBox_Recipe.SuspendLayout();
            this.groupBox_Plan_Terapeutico_Lista.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(20, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 238;
            this.label1.Text = "Presentación";
            // 
            // txtIndicaciones
            // 
            this.txtIndicaciones.BackColor = System.Drawing.SystemColors.Control;
            this.txtIndicaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIndicaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIndicaciones.Location = new System.Drawing.Point(23, 65);
            this.txtIndicaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIndicaciones.MaxLength = 400;
            this.txtIndicaciones.Multiline = true;
            this.txtIndicaciones.Name = "txtIndicaciones";
            this.txtIndicaciones.Size = new System.Drawing.Size(365, 182);
            this.txtIndicaciones.TabIndex = 235;
            // 
            // cbMedicamento
            // 
            this.cbMedicamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMedicamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbMedicamento.BackColor = System.Drawing.SystemColors.Control;
            this.cbMedicamento.FormattingEnabled = true;
            this.cbMedicamento.Location = new System.Drawing.Point(20, 86);
            this.cbMedicamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMedicamento.Name = "cbMedicamento";
            this.cbMedicamento.Size = new System.Drawing.Size(368, 30);
            this.cbMedicamento.TabIndex = 232;
            this.cbMedicamento.TextChanged += new System.EventHandler(this.cbMedicamento_TextChanged);
            this.cbMedicamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMedicamento_KeyPress);
            this.cbMedicamento.Leave += new System.EventHandler(this.cbMedicamento_Leave);
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
            this.btnCancelar.Location = new System.Drawing.Point(1371, 435);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(188, 90);
            this.btnCancelar.TabIndex = 246;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo_plan_terapeutico
            // 
            this.btnNuevo_plan_terapeutico.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo_plan_terapeutico.FlatAppearance.BorderSize = 0;
            this.btnNuevo_plan_terapeutico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNuevo_plan_terapeutico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo_plan_terapeutico.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnNuevo_plan_terapeutico.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnNuevo_plan_terapeutico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo_plan_terapeutico.Location = new System.Drawing.Point(1372, 121);
            this.btnNuevo_plan_terapeutico.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo_plan_terapeutico.Name = "btnNuevo_plan_terapeutico";
            this.btnNuevo_plan_terapeutico.Size = new System.Drawing.Size(188, 79);
            this.btnNuevo_plan_terapeutico.TabIndex = 244;
            this.btnNuevo_plan_terapeutico.Text = "Nuevo";
            this.btnNuevo_plan_terapeutico.UseVisualStyleBackColor = false;
            this.btnNuevo_plan_terapeutico.Click += new System.EventHandler(this.btnNuevo_informe_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-5, 59);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1595, 892);
            this.tabControl1.TabIndex = 249;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.lbl_idplanterapeutico_evol);
            this.tabPage1.Controls.Add(this.lbl_idplanterapeutico_historia);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.btnAsignarPlanTerapeutico);
            this.tabPage1.Controls.Add(this.btnImprimirRecipe);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnNuevo_plan_terapeutico);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1587, 857);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plan Terapeutico";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lbl_idplanterapeutico_evol
            // 
            this.lbl_idplanterapeutico_evol.AutoSize = true;
            this.lbl_idplanterapeutico_evol.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idplanterapeutico_evol.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_idplanterapeutico_evol.Location = new System.Drawing.Point(1383, 78);
            this.lbl_idplanterapeutico_evol.Name = "lbl_idplanterapeutico_evol";
            this.lbl_idplanterapeutico_evol.Size = new System.Drawing.Size(22, 28);
            this.lbl_idplanterapeutico_evol.TabIndex = 282;
            this.lbl_idplanterapeutico_evol.Text = "0";
            this.lbl_idplanterapeutico_evol.Visible = false;
            // 
            // lbl_idplanterapeutico_historia
            // 
            this.lbl_idplanterapeutico_historia.AutoSize = true;
            this.lbl_idplanterapeutico_historia.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idplanterapeutico_historia.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_idplanterapeutico_historia.Location = new System.Drawing.Point(1383, 39);
            this.lbl_idplanterapeutico_historia.Name = "lbl_idplanterapeutico_historia";
            this.lbl_idplanterapeutico_historia.Size = new System.Drawing.Size(22, 28);
            this.lbl_idplanterapeutico_historia.TabIndex = 281;
            this.lbl_idplanterapeutico_historia.Text = "0";
            this.lbl_idplanterapeutico_historia.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightGray;
            this.label16.Location = new System.Drawing.Point(1371, 12);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 28);
            this.label16.TabIndex = 280;
            this.label16.Text = "ID del plan:";
            this.label16.Visible = false;
            // 
            // btnAsignarPlanTerapeutico
            // 
            this.btnAsignarPlanTerapeutico.BackColor = System.Drawing.SystemColors.Control;
            this.btnAsignarPlanTerapeutico.FlatAppearance.BorderSize = 0;
            this.btnAsignarPlanTerapeutico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAsignarPlanTerapeutico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarPlanTerapeutico.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnAsignarPlanTerapeutico.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAsignarPlanTerapeutico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarPlanTerapeutico.Location = new System.Drawing.Point(1371, 207);
            this.btnAsignarPlanTerapeutico.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignarPlanTerapeutico.Name = "btnAsignarPlanTerapeutico";
            this.btnAsignarPlanTerapeutico.Size = new System.Drawing.Size(188, 122);
            this.btnAsignarPlanTerapeutico.TabIndex = 249;
            this.btnAsignarPlanTerapeutico.Text = "☑ Guardar y asignar este Plan Terapeutico";
            this.btnAsignarPlanTerapeutico.UseVisualStyleBackColor = false;
            this.btnAsignarPlanTerapeutico.Click += new System.EventHandler(this.btnSeleccionarPlanTerapeutico_Click);
            // 
            // btnImprimirRecipe
            // 
            this.btnImprimirRecipe.BackColor = System.Drawing.SystemColors.Control;
            this.btnImprimirRecipe.FlatAppearance.BorderSize = 0;
            this.btnImprimirRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnImprimirRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirRecipe.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnImprimirRecipe.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnImprimirRecipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirRecipe.Location = new System.Drawing.Point(1371, 533);
            this.btnImprimirRecipe.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimirRecipe.Name = "btnImprimirRecipe";
            this.btnImprimirRecipe.Size = new System.Drawing.Size(188, 90);
            this.btnImprimirRecipe.TabIndex = 247;
            this.btnImprimirRecipe.Text = "Imprimir ";
            this.btnImprimirRecipe.UseVisualStyleBackColor = false;
            this.btnImprimirRecipe.Click += new System.EventHandler(this.btnImprimirRecipe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtCedulaPac_Terapeutico);
            this.groupBox1.Controls.Add(this.lupa);
            this.groupBox1.Controls.Add(this.txtSexo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbl_fecha_emision);
            this.groupBox1.Controls.Add(this.txtNombre_Paciente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(23, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1341, 84);
            this.groupBox1.TabIndex = 232;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Paciente";
            // 
            // txtCedulaPac_Terapeutico
            // 
            this.txtCedulaPac_Terapeutico.BackColor = System.Drawing.SystemColors.Control;
            this.txtCedulaPac_Terapeutico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedulaPac_Terapeutico.Enabled = false;
            this.txtCedulaPac_Terapeutico.Location = new System.Drawing.Point(135, 39);
            this.txtCedulaPac_Terapeutico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCedulaPac_Terapeutico.Name = "txtCedulaPac_Terapeutico";
            this.txtCedulaPac_Terapeutico.ReadOnly = true;
            this.txtCedulaPac_Terapeutico.Size = new System.Drawing.Size(145, 28);
            this.txtCedulaPac_Terapeutico.TabIndex = 289;
            // 
            // lupa
            // 
            this.lupa.AutoSize = true;
            this.lupa.BackColor = System.Drawing.Color.CadetBlue;
            this.lupa.Enabled = false;
            this.lupa.ForeColor = System.Drawing.Color.MintCream;
            this.lupa.Location = new System.Drawing.Point(285, 41);
            this.lupa.Name = "lupa";
            this.lupa.Size = new System.Drawing.Size(31, 24);
            this.lupa.TabIndex = 282;
            this.lupa.Text = "🔎";
            this.lupa.Click += new System.EventHandler(this.lupa_Click);
            // 
            // txtSexo
            // 
            this.txtSexo.BackColor = System.Drawing.SystemColors.Control;
            this.txtSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSexo.Enabled = false;
            this.txtSexo.Location = new System.Drawing.Point(893, 37);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(103, 28);
            this.txtSexo.TabIndex = 232;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(44, 34);
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
            this.label10.Location = new System.Drawing.Point(827, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 32);
            this.label10.TabIndex = 229;
            this.label10.Text = "Sexo";
            // 
            // lbl_fecha_emision
            // 
            this.lbl_fecha_emision.AutoSize = true;
            this.lbl_fecha_emision.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha_emision.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lbl_fecha_emision.ForeColor = System.Drawing.Color.Teal;
            this.lbl_fecha_emision.Location = new System.Drawing.Point(1025, 34);
            this.lbl_fecha_emision.Name = "lbl_fecha_emision";
            this.lbl_fecha_emision.Size = new System.Drawing.Size(190, 32);
            this.lbl_fecha_emision.TabIndex = 233;
            this.lbl_fecha_emision.Text = "lbl_fecha_emision";
            // 
            // txtNombre_Paciente
            // 
            this.txtNombre_Paciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre_Paciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre_Paciente.Enabled = false;
            this.txtNombre_Paciente.Location = new System.Drawing.Point(439, 39);
            this.txtNombre_Paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre_Paciente.Name = "txtNombre_Paciente";
            this.txtNombre_Paciente.ReadOnly = true;
            this.txtNombre_Paciente.Size = new System.Drawing.Size(367, 28);
            this.txtNombre_Paciente.TabIndex = 228;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(335, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 32);
            this.label6.TabIndex = 227;
            this.label6.Text = "Nombre";
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
            this.groupBox3.Location = new System.Drawing.Point(23, 121);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1341, 698);
            this.groupBox3.TabIndex = 233;
            this.groupBox3.TabStop = false;
            // 
            // groupBox_Indicaciones
            // 
            this.groupBox_Indicaciones.BackColor = System.Drawing.Color.White;
            this.groupBox_Indicaciones.Controls.Add(this.label9);
            this.groupBox_Indicaciones.Controls.Add(this.txtIndicaciones);
            this.groupBox_Indicaciones.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox_Indicaciones.Location = new System.Drawing.Point(24, 404);
            this.groupBox_Indicaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Indicaciones.Name = "groupBox_Indicaciones";
            this.groupBox_Indicaciones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Indicaciones.Size = new System.Drawing.Size(409, 270);
            this.groupBox_Indicaciones.TabIndex = 243;
            this.groupBox_Indicaciones.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(139, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 32);
            this.label9.TabIndex = 243;
            this.label9.Text = "Indicaciones";
            // 
            // groupBox_Recipe
            // 
            this.groupBox_Recipe.BackColor = System.Drawing.Color.White;
            this.groupBox_Recipe.Controls.Add(this.label7);
            this.groupBox_Recipe.Controls.Add(this.cbPresentacion);
            this.groupBox_Recipe.Controls.Add(this.label3);
            this.groupBox_Recipe.Controls.Add(this.cbDosis);
            this.groupBox_Recipe.Controls.Add(this.label5);
            this.groupBox_Recipe.Controls.Add(this.cbMedicamento);
            this.groupBox_Recipe.Controls.Add(this.label1);
            this.groupBox_Recipe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox_Recipe.Location = new System.Drawing.Point(24, 25);
            this.groupBox_Recipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Recipe.Name = "groupBox_Recipe";
            this.groupBox_Recipe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Recipe.Size = new System.Drawing.Size(409, 373);
            this.groupBox_Recipe.TabIndex = 242;
            this.groupBox_Recipe.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(17, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 32);
            this.label7.TabIndex = 242;
            this.label7.Text = "Medicamento";
            // 
            // cbPresentacion
            // 
            this.cbPresentacion.BackColor = System.Drawing.Color.White;
            this.cbPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPresentacion.FormattingEnabled = true;
            this.cbPresentacion.Location = new System.Drawing.Point(23, 178);
            this.cbPresentacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPresentacion.Name = "cbPresentacion";
            this.cbPresentacion.Size = new System.Drawing.Size(365, 30);
            this.cbPresentacion.TabIndex = 241;
            this.cbPresentacion.SelectedIndexChanged += new System.EventHandler(this.cbPresentacion_SelectedIndexChanged);
            this.cbPresentacion.Leave += new System.EventHandler(this.cbPresentacion_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(20, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 32);
            this.label3.TabIndex = 240;
            this.label3.Text = "Dosis";
            // 
            // cbDosis
            // 
            this.cbDosis.BackColor = System.Drawing.Color.White;
            this.cbDosis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDosis.FormattingEnabled = true;
            this.cbDosis.Location = new System.Drawing.Point(27, 274);
            this.cbDosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDosis.Name = "cbDosis";
            this.cbDosis.Size = new System.Drawing.Size(361, 30);
            this.cbDosis.TabIndex = 239;
            this.cbDosis.Leave += new System.EventHandler(this.cbDosis_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(163, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 32);
            this.label5.TabIndex = 227;
            this.label5.Text = "Recipe";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox_Plan_Terapeutico_Lista
            // 
            this.groupBox_Plan_Terapeutico_Lista.BackColor = System.Drawing.Color.White;
            this.groupBox_Plan_Terapeutico_Lista.Controls.Add(this.listBox1);
            this.groupBox_Plan_Terapeutico_Lista.Controls.Add(this.label8);
            this.groupBox_Plan_Terapeutico_Lista.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox_Plan_Terapeutico_Lista.Location = new System.Drawing.Point(533, 27);
            this.groupBox_Plan_Terapeutico_Lista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Plan_Terapeutico_Lista.Name = "groupBox_Plan_Terapeutico_Lista";
            this.groupBox_Plan_Terapeutico_Lista.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Plan_Terapeutico_Lista.Size = new System.Drawing.Size(787, 652);
            this.groupBox_Plan_Terapeutico_Lista.TabIndex = 241;
            this.groupBox_Plan_Terapeutico_Lista.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(5, 70);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(775, 554);
            this.listBox1.TabIndex = 228;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(301, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 32);
            this.label8.TabIndex = 227;
            this.label8.Text = "Plan Terapeutico";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Teal;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.MintCream;
            this.btnQuitar.Location = new System.Drawing.Point(439, 132);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(89, 86);
            this.btnQuitar.TabIndex = 240;
            this.btnQuitar.Text = "-";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Teal;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.MintCream;
            this.btnAñadir.Location = new System.Drawing.Point(439, 39);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(89, 86);
            this.btnAñadir.TabIndex = 239;
            this.btnAñadir.Text = "+";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(413, -4);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(639, 60);
            this.label12.TabIndex = 7;
            this.label12.Text = "💊    Plan Terapeutico";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1691, 52);
            this.panel3.TabIndex = 248;
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
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(1371, 337);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(188, 90);
            this.btnLimpiar.TabIndex = 283;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmPlanTerapeutico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1691, 887);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "frmPlanTerapeutico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlanTerapeutico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPlanTerapeutico_FormClosing);
            this.Load += new System.EventHandler(this.frmPlanTerapeutico_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox_Indicaciones.ResumeLayout(false);
            this.groupBox_Indicaciones.PerformLayout();
            this.groupBox_Recipe.ResumeLayout(false);
            this.groupBox_Recipe.PerformLayout();
            this.groupBox_Plan_Terapeutico_Lista.ResumeLayout(false);
            this.groupBox_Plan_Terapeutico_Lista.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndicaciones;
        private System.Windows.Forms.ComboBox cbMedicamento;
        private System.Windows.Forms.Button btnNuevo_plan_terapeutico;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombre_Paciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.GroupBox groupBox_Plan_Terapeutico_Lista;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox_Indicaciones;
        private System.Windows.Forms.GroupBox groupBox_Recipe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPresentacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDosis;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label lbl_fecha_emision;
        private System.Windows.Forms.Button btnImprimirRecipe;
        private System.Windows.Forms.Label lupa;
        private System.Windows.Forms.TextBox txtCedulaPac_Terapeutico;
        private System.Windows.Forms.Button btnAsignarPlanTerapeutico;
        private System.Windows.Forms.Label lbl_idplanterapeutico_historia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_idplanterapeutico_evol;
        private System.Windows.Forms.Button btnLimpiar;
    }
}