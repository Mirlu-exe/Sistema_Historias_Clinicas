namespace CapaPresentacion
{
    partial class frmRecuperarContrasenaEmail
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
            this.label4 = new System.Windows.Forms.Label();
            this.gbVerificarUsername = new System.Windows.Forms.GroupBox();
            this.btnVerificarExistenciaUsername = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiarPreguntas = new System.Windows.Forms.Button();
            this.gbVerificarUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(297, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "Recuperar Contraseña";
            // 
            // gbVerificarUsername
            // 
            this.gbVerificarUsername.Controls.Add(this.btnVerificarExistenciaUsername);
            this.gbVerificarUsername.Controls.Add(this.label12);
            this.gbVerificarUsername.Controls.Add(this.txtCorreo);
            this.gbVerificarUsername.Location = new System.Drawing.Point(13, 85);
            this.gbVerificarUsername.Name = "gbVerificarUsername";
            this.gbVerificarUsername.Size = new System.Drawing.Size(830, 100);
            this.gbVerificarUsername.TabIndex = 50;
            this.gbVerificarUsername.TabStop = false;
            // 
            // btnVerificarExistenciaUsername
            // 
            this.btnVerificarExistenciaUsername.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerificarExistenciaUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificarExistenciaUsername.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarExistenciaUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerificarExistenciaUsername.Location = new System.Drawing.Point(568, 50);
            this.btnVerificarExistenciaUsername.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerificarExistenciaUsername.Name = "btnVerificarExistenciaUsername";
            this.btnVerificarExistenciaUsername.Size = new System.Drawing.Size(139, 30);
            this.btnVerificarExistenciaUsername.TabIndex = 47;
            this.btnVerificarExistenciaUsername.Text = "Continuar";
            this.btnVerificarExistenciaUsername.UseVisualStyleBackColor = false;
            this.btnVerificarExistenciaUsername.Click += new System.EventHandler(this.btnVerificarExistenciaUsername_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(119, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(403, 32);
            this.label12.TabIndex = 45;
            this.label12.Text = "Ingrese u correo electronico registrado";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(124, 54);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(436, 22);
            this.txtCorreo.TabIndex = 46;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Control;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolver.Location = new System.Drawing.Point(291, 206);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(129, 28);
            this.btnVolver.TabIndex = 52;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarPreguntas
            // 
            this.btnLimpiarPreguntas.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarPreguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarPreguntas.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarPreguntas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiarPreguntas.Location = new System.Drawing.Point(441, 206);
            this.btnLimpiarPreguntas.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarPreguntas.Name = "btnLimpiarPreguntas";
            this.btnLimpiarPreguntas.Size = new System.Drawing.Size(129, 28);
            this.btnLimpiarPreguntas.TabIndex = 51;
            this.btnLimpiarPreguntas.Text = "Limpiar";
            this.btnLimpiarPreguntas.UseVisualStyleBackColor = false;
            // 
            // frmRecuperarContrasenaEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 280);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiarPreguntas);
            this.Controls.Add(this.gbVerificarUsername);
            this.Controls.Add(this.label4);
            this.Name = "frmRecuperarContrasenaEmail";
            this.Text = "frmRecuperarContrasenaEmail";
            this.gbVerificarUsername.ResumeLayout(false);
            this.gbVerificarUsername.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbVerificarUsername;
        private System.Windows.Forms.Button btnVerificarExistenciaUsername;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiarPreguntas;
    }
}