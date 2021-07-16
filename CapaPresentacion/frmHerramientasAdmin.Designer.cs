namespace CapaPresentacion
{
    partial class frmHerramientasAdmin
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnMostrarRestaurar = new System.Windows.Forms.Button();
            this.btnGenerarCopia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(426, 44);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(121, 27);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnGenerar_Click);
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
            this.panel3.Size = new System.Drawing.Size(1358, 76);
            this.panel3.TabIndex = 185;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(415, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(519, 60);
            this.label12.TabIndex = 7;
            this.label12.Text = "Herramientas de Administrador";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 22);
            this.textBox1.TabIndex = 186;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(426, 77);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(121, 27);
            this.btnBackup.TabIndex = 188;
            this.btnBackup.Text = "Generar Copia";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Location = new System.Drawing.Point(704, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 136);
            this.groupBox1.TabIndex = 191;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(86, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 177);
            this.groupBox2.TabIndex = 192;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 27);
            this.button3.TabIndex = 193;
            this.button3.Text = "Restaurar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 27);
            this.button2.TabIndex = 192;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 22);
            this.textBox2.TabIndex = 191;
            // 
            // btnMostrarRestaurar
            // 
            this.btnMostrarRestaurar.BackColor = System.Drawing.SystemColors.Control;
            this.btnMostrarRestaurar.FlatAppearance.BorderSize = 0;
            this.btnMostrarRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMostrarRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarRestaurar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnMostrarRestaurar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnMostrarRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarRestaurar.Location = new System.Drawing.Point(233, 115);
            this.btnMostrarRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarRestaurar.Name = "btnMostrarRestaurar";
            this.btnMostrarRestaurar.Size = new System.Drawing.Size(165, 55);
            this.btnMostrarRestaurar.TabIndex = 193;
            this.btnMostrarRestaurar.Text = "Restaurar BD";
            this.btnMostrarRestaurar.UseVisualStyleBackColor = false;
            // 
            // btnGenerarCopia
            // 
            this.btnGenerarCopia.BackColor = System.Drawing.SystemColors.Control;
            this.btnGenerarCopia.FlatAppearance.BorderSize = 0;
            this.btnGenerarCopia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGenerarCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCopia.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnGenerarCopia.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGenerarCopia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarCopia.Location = new System.Drawing.Point(818, 115);
            this.btnGenerarCopia.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarCopia.Name = "btnGenerarCopia";
            this.btnGenerarCopia.Size = new System.Drawing.Size(306, 55);
            this.btnGenerarCopia.TabIndex = 194;
            this.btnGenerarCopia.Text = "Generar Copia de BD";
            this.btnGenerarCopia.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(511, 532);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 157);
            this.button1.TabIndex = 195;
            this.button1.Text = "Cambiar la direccion de la BD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHerramientasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 747);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerarCopia);
            this.Controls.Add(this.btnMostrarRestaurar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHerramientasAdmin";
            this.Text = "frmHerramientasAdmin";
            this.Load += new System.EventHandler(this.frmHerramientasAdmin_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnMostrarRestaurar;
        private System.Windows.Forms.Button btnGenerarCopia;
        private System.Windows.Forms.Button button1;
    }
}