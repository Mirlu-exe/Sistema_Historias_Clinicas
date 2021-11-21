namespace CapaPresentacion
{
    partial class frmDeathDetailsInput
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCausaMuerte = new System.Windows.Forms.TextBox();
            this.dtp_FechaMuerte = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Paciente_fallecido = new System.Windows.Forms.DataGridView();
            this.Anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGuardarDeathDetails = new System.Windows.Forms.Button();
            this.btnCancelarDeathDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Paciente_fallecido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCausaMuerte
            // 
            this.txtCausaMuerte.BackColor = System.Drawing.SystemColors.Control;
            this.txtCausaMuerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCausaMuerte.Location = new System.Drawing.Point(393, 332);
            this.txtCausaMuerte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCausaMuerte.Name = "txtCausaMuerte";
            this.txtCausaMuerte.Size = new System.Drawing.Size(549, 27);
            this.txtCausaMuerte.TabIndex = 220;
            // 
            // dtp_FechaMuerte
            // 
            this.dtp_FechaMuerte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaMuerte.Location = new System.Drawing.Point(77, 332);
            this.dtp_FechaMuerte.Name = "dtp_FechaMuerte";
            this.dtp_FechaMuerte.Size = new System.Drawing.Size(250, 22);
            this.dtp_FechaMuerte.TabIndex = 223;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(387, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 222;
            this.label4.Text = "Causa de Muerte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(71, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 32);
            this.label3.TabIndex = 221;
            this.label3.Text = "Fecha de Muerte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(71, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 225;
            this.label2.Text = "Paciente:";
            // 
            // dgv_Paciente_fallecido
            // 
            this.dgv_Paciente_fallecido.AllowUserToAddRows = false;
            this.dgv_Paciente_fallecido.AllowUserToDeleteRows = false;
            this.dgv_Paciente_fallecido.AllowUserToOrderColumns = true;
            this.dgv_Paciente_fallecido.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Paciente_fallecido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Paciente_fallecido.ColumnHeadersHeight = 50;
            this.dgv_Paciente_fallecido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Paciente_fallecido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anular});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Paciente_fallecido.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Paciente_fallecido.GridColor = System.Drawing.Color.DarkCyan;
            this.dgv_Paciente_fallecido.Location = new System.Drawing.Point(77, 97);
            this.dgv_Paciente_fallecido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Paciente_fallecido.MultiSelect = false;
            this.dgv_Paciente_fallecido.Name = "dgv_Paciente_fallecido";
            this.dgv_Paciente_fallecido.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Paciente_fallecido.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Paciente_fallecido.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Paciente_fallecido.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Paciente_fallecido.RowTemplate.Height = 24;
            this.dgv_Paciente_fallecido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Paciente_fallecido.Size = new System.Drawing.Size(865, 138);
            this.dgv_Paciente_fallecido.TabIndex = 224;
            // 
            // Anular
            // 
            this.Anular.HeaderText = "Anular";
            this.Anular.MinimumWidth = 6;
            this.Anular.Name = "Anular";
            this.Anular.ReadOnly = true;
            this.Anular.Width = 125;
            // 
            // btnGuardarDeathDetails
            // 
            this.btnGuardarDeathDetails.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardarDeathDetails.FlatAppearance.BorderSize = 0;
            this.btnGuardarDeathDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardarDeathDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDeathDetails.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnGuardarDeathDetails.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGuardarDeathDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarDeathDetails.Location = new System.Drawing.Point(558, 416);
            this.btnGuardarDeathDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarDeathDetails.Name = "btnGuardarDeathDetails";
            this.btnGuardarDeathDetails.Size = new System.Drawing.Size(188, 79);
            this.btnGuardarDeathDetails.TabIndex = 226;
            this.btnGuardarDeathDetails.Text = "Guardar";
            this.btnGuardarDeathDetails.UseVisualStyleBackColor = false;
            // 
            // btnCancelarDeathDetails
            // 
            this.btnCancelarDeathDetails.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelarDeathDetails.FlatAppearance.BorderSize = 0;
            this.btnCancelarDeathDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancelarDeathDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarDeathDetails.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnCancelarDeathDetails.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCancelarDeathDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarDeathDetails.Location = new System.Drawing.Point(754, 416);
            this.btnCancelarDeathDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarDeathDetails.Name = "btnCancelarDeathDetails";
            this.btnCancelarDeathDetails.Size = new System.Drawing.Size(188, 79);
            this.btnCancelarDeathDetails.TabIndex = 227;
            this.btnCancelarDeathDetails.Text = "Cancelar";
            this.btnCancelarDeathDetails.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 228;
            this.label1.Text = "Ficha de Fallecimiento";
            // 
            // frmDeathDetailsInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1028, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarDeathDetails);
            this.Controls.Add(this.btnGuardarDeathDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Paciente_fallecido);
            this.Controls.Add(this.txtCausaMuerte);
            this.Controls.Add(this.dtp_FechaMuerte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "frmDeathDetailsInput";
            this.Text = "frmDeathDetailsInput";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Paciente_fallecido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCausaMuerte;
        private System.Windows.Forms.DateTimePicker dtp_FechaMuerte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Paciente_fallecido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anular;
        private System.Windows.Forms.Button btnGuardarDeathDetails;
        private System.Windows.Forms.Button btnCancelarDeathDetails;
        private System.Windows.Forms.Label label1;
    }
}