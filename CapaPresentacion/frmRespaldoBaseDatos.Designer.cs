namespace CapaPresentacion
{
    partial class frmRespaldoBaseDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRespaldoBaseDatos));
            this.btnBrowseGenerar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerarCopia = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarRestaurar = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBrowseRestaurar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowseGenerar
            // 
            this.btnBrowseGenerar.Location = new System.Drawing.Point(584, 106);
            this.btnBrowseGenerar.Name = "btnBrowseGenerar";
            this.btnBrowseGenerar.Size = new System.Drawing.Size(121, 27);
            this.btnBrowseGenerar.TabIndex = 0;
            this.btnBrowseGenerar.Text = "Examinar";
            this.btnBrowseGenerar.UseVisualStyleBackColor = true;
            this.btnBrowseGenerar.Click += new System.EventHandler(this.btnBrowseGenerar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1759, 76);
            this.panel3.TabIndex = 193;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.CadetBlue;
            this.label12.Location = new System.Drawing.Point(507, 80);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(519, 60);
            this.label12.TabIndex = 7;
            this.label12.Text = "Respaldo Base de Datos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 22);
            this.textBox1.TabIndex = 186;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBackup.Location = new System.Drawing.Point(271, 148);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(434, 43);
            this.btnBackup.TabIndex = 188;
            this.btnBackup.Text = "Generar Copia";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnGenerarCopia);
            this.groupBox1.Controls.Add(this.btnBrowseGenerar);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Location = new System.Drawing.Point(217, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1105, 268);
            this.groupBox1.TabIndex = 194;
            this.groupBox1.TabStop = false;
            // 
            // btnGenerarCopia
            // 
            this.btnGenerarCopia.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarCopia.FlatAppearance.BorderSize = 0;
            this.btnGenerarCopia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGenerarCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCopia.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnGenerarCopia.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGenerarCopia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarCopia.Location = new System.Drawing.Point(465, 0);
            this.btnGenerarCopia.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarCopia.Name = "btnGenerarCopia";
            this.btnGenerarCopia.Size = new System.Drawing.Size(306, 55);
            this.btnGenerarCopia.TabIndex = 194;
            this.btnGenerarCopia.Text = "Generar Copia de BD";
            this.btnGenerarCopia.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btnMostrarRestaurar);
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Controls.Add(this.btnBrowseRestaurar);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(217, 534);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1105, 256);
            this.groupBox2.TabIndex = 195;
            this.groupBox2.TabStop = false;
            // 
            // btnMostrarRestaurar
            // 
            this.btnMostrarRestaurar.BackColor = System.Drawing.Color.LightGray;
            this.btnMostrarRestaurar.FlatAppearance.BorderSize = 0;
            this.btnMostrarRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMostrarRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarRestaurar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnMostrarRestaurar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnMostrarRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarRestaurar.Location = new System.Drawing.Point(540, 22);
            this.btnMostrarRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarRestaurar.Name = "btnMostrarRestaurar";
            this.btnMostrarRestaurar.Size = new System.Drawing.Size(165, 55);
            this.btnMostrarRestaurar.TabIndex = 193;
            this.btnMostrarRestaurar.Text = "Restaurar BD";
            this.btnMostrarRestaurar.UseVisualStyleBackColor = false;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRestore.Location = new System.Drawing.Point(271, 186);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(433, 35);
            this.btnRestore.TabIndex = 193;
            this.btnRestore.Text = "Restaurar";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBrowseRestaurar
            // 
            this.btnBrowseRestaurar.Location = new System.Drawing.Point(583, 135);
            this.btnBrowseRestaurar.Name = "btnBrowseRestaurar";
            this.btnBrowseRestaurar.Size = new System.Drawing.Size(121, 27);
            this.btnBrowseRestaurar.TabIndex = 192;
            this.btnBrowseRestaurar.Text = "Examinar";
            this.btnBrowseRestaurar.UseVisualStyleBackColor = true;
            this.btnBrowseRestaurar.Click += new System.EventHandler(this.btnBrowseRestaurar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(271, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 22);
            this.textBox2.TabIndex = 191;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(778, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 199);
            this.pictureBox1.TabIndex = 195;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(778, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 199);
            this.pictureBox2.TabIndex = 196;
            this.pictureBox2.TabStop = false;
            // 
            // frmRespaldoBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1759, 853);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRespaldoBaseDatos";
            this.Text = "frmRespaldoBaseDatos";
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseGenerar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGenerarCopia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMostrarRestaurar;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBrowseRestaurar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
    }
}