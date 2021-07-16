namespace CapaPresentacion
{
    partial class frmOperacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.datalistadoOperaciones = new System.Windows.Forms.DataGridView();
            this.lblCantidadOperaciones = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblSuceso = new System.Windows.Forms.Label();
            this.cbSuceso = new System.Windows.Forms.ComboBox();
            this.chkNombreUsuario = new System.Windows.Forms.CheckBox();
            this.chkSuceso = new System.Windows.Forms.CheckBox();
            this.chkRangoFechas = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoOperaciones)).BeginInit();
            this.SuspendLayout();
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
            this.panel3.Size = new System.Drawing.Size(1436, 79);
            this.panel3.TabIndex = 154;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(411, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(519, 60);
            this.label12.TabIndex = 7;
            this.label12.Text = "Historial de Operaciones del Sistema";
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
            // datalistadoOperaciones
            // 
            this.datalistadoOperaciones.AllowUserToAddRows = false;
            this.datalistadoOperaciones.AllowUserToDeleteRows = false;
            this.datalistadoOperaciones.AllowUserToOrderColumns = true;
            this.datalistadoOperaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datalistadoOperaciones.BackgroundColor = System.Drawing.Color.White;
            this.datalistadoOperaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistadoOperaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.datalistadoOperaciones.ColumnHeadersHeight = 50;
            this.datalistadoOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datalistadoOperaciones.DefaultCellStyle = dataGridViewCellStyle18;
            this.datalistadoOperaciones.GridColor = System.Drawing.Color.DarkCyan;
            this.datalistadoOperaciones.Location = new System.Drawing.Point(357, 209);
            this.datalistadoOperaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datalistadoOperaciones.MultiSelect = false;
            this.datalistadoOperaciones.Name = "datalistadoOperaciones";
            this.datalistadoOperaciones.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistadoOperaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.datalistadoOperaciones.RowHeadersWidth = 51;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.datalistadoOperaciones.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.datalistadoOperaciones.RowTemplate.Height = 24;
            this.datalistadoOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoOperaciones.Size = new System.Drawing.Size(1067, 645);
            this.datalistadoOperaciones.TabIndex = 153;
            // 
            // lblCantidadOperaciones
            // 
            this.lblCantidadOperaciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCantidadOperaciones.AutoSize = true;
            this.lblCantidadOperaciones.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblCantidadOperaciones.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCantidadOperaciones.Location = new System.Drawing.Point(929, 175);
            this.lblCantidadOperaciones.Name = "lblCantidadOperaciones";
            this.lblCantidadOperaciones.Size = new System.Drawing.Size(75, 32);
            this.lblCantidadOperaciones.TabIndex = 152;
            this.lblCantidadOperaciones.Text = "label4";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblFechaInicio.Location = new System.Drawing.Point(25, 494);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(82, 32);
            this.lblFechaInicio.TabIndex = 167;
            this.lblFechaInicio.Text = "Desde:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(31, 359);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(319, 22);
            this.txtNombre.TabIndex = 175;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblNombreUsuario.Location = new System.Drawing.Point(25, 325);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(218, 32);
            this.lblNombreUsuario.TabIndex = 174;
            this.lblNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(25, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 196;
            this.label2.Text = "Buscar según:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(31, 529);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(319, 22);
            this.dtpFechaInicio.TabIndex = 197;
            this.dtpFechaInicio.Value = new System.DateTime(2021, 7, 16, 0, 0, 0, 0);
            // 
            // lblSuceso
            // 
            this.lblSuceso.AutoSize = true;
            this.lblSuceso.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblSuceso.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblSuceso.Location = new System.Drawing.Point(25, 396);
            this.lblSuceso.Name = "lblSuceso";
            this.lblSuceso.Size = new System.Drawing.Size(90, 32);
            this.lblSuceso.TabIndex = 198;
            this.lblSuceso.Text = "Suceso:";
            // 
            // cbSuceso
            // 
            this.cbSuceso.BackColor = System.Drawing.SystemColors.Control;
            this.cbSuceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuceso.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.cbSuceso.ForeColor = System.Drawing.Color.DarkCyan;
            this.cbSuceso.FormattingEnabled = true;
            this.cbSuceso.Items.AddRange(new object[] {
            "accedido al sistema",
            "cerrado sesión",
            "registrado",
            "editado",
            "anulo"});
            this.cbSuceso.Location = new System.Drawing.Point(31, 432);
            this.cbSuceso.Margin = new System.Windows.Forms.Padding(4);
            this.cbSuceso.Name = "cbSuceso";
            this.cbSuceso.Size = new System.Drawing.Size(319, 40);
            this.cbSuceso.TabIndex = 199;
            // 
            // chkNombreUsuario
            // 
            this.chkNombreUsuario.AutoSize = true;
            this.chkNombreUsuario.Location = new System.Drawing.Point(31, 223);
            this.chkNombreUsuario.Name = "chkNombreUsuario";
            this.chkNombreUsuario.Size = new System.Drawing.Size(151, 21);
            this.chkNombreUsuario.TabIndex = 200;
            this.chkNombreUsuario.Text = "Nombre de usuario";
            this.chkNombreUsuario.UseVisualStyleBackColor = true;
            this.chkNombreUsuario.CheckedChanged += new System.EventHandler(this.chkNombreUsuario_CheckedChanged);
            // 
            // chkSuceso
            // 
            this.chkSuceso.AutoSize = true;
            this.chkSuceso.Location = new System.Drawing.Point(31, 250);
            this.chkSuceso.Name = "chkSuceso";
            this.chkSuceso.Size = new System.Drawing.Size(77, 21);
            this.chkSuceso.TabIndex = 201;
            this.chkSuceso.Text = "Suceso";
            this.chkSuceso.UseVisualStyleBackColor = true;
            this.chkSuceso.CheckedChanged += new System.EventHandler(this.chkSuceso_CheckedChanged);
            // 
            // chkRangoFechas
            // 
            this.chkRangoFechas.AutoSize = true;
            this.chkRangoFechas.Location = new System.Drawing.Point(31, 277);
            this.chkRangoFechas.Name = "chkRangoFechas";
            this.chkRangoFechas.Size = new System.Drawing.Size(138, 21);
            this.chkRangoFechas.TabIndex = 203;
            this.chkRangoFechas.Text = "Rango de fechas";
            this.chkRangoFechas.UseVisualStyleBackColor = true;
            this.chkRangoFechas.CheckedChanged += new System.EventHandler(this.chkRangoFechas_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Teal;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnBuscar.ForeColor = System.Drawing.Color.MintCream;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(31, 633);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(319, 43);
            this.btnBuscar.TabIndex = 204;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(31, 593);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(319, 22);
            this.dtpFechaFin.TabIndex = 206;
            this.dtpFechaFin.Value = new System.DateTime(2021, 7, 16, 0, 0, 0, 0);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblFechaFin.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblFechaFin.Location = new System.Drawing.Point(25, 558);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(76, 32);
            this.lblFechaFin.TabIndex = 205;
            this.lblFechaFin.Text = "Hasta:";
            // 
            // frmOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 865);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.chkRangoFechas);
            this.Controls.Add(this.chkSuceso);
            this.Controls.Add(this.chkNombreUsuario);
            this.Controls.Add(this.cbSuceso);
            this.Controls.Add(this.lblSuceso);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.datalistadoOperaciones);
            this.Controls.Add(this.lblCantidadOperaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOperacion";
            this.Text = "frmOperacion";
            this.Load += new System.EventHandler(this.frmOperacion_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoOperaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView datalistadoOperaciones;
        private System.Windows.Forms.Label lblCantidadOperaciones;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblSuceso;
        private System.Windows.Forms.ComboBox cbSuceso;
        private System.Windows.Forms.CheckBox chkNombreUsuario;
        private System.Windows.Forms.CheckBox chkSuceso;
        private System.Windows.Forms.CheckBox chkRangoFechas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaFin;
    }
}