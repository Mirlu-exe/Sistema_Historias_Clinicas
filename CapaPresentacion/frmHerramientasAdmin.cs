using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CapaPresentacion
{
    public partial class frmHerramientasAdmin : Form
    {
        public frmHerramientasAdmin()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("SERVER=MIRLU\\SQLEXPRESS; DATABASE=dbclinica; Integrated Security=true");


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;


            }

            string nombre_copia = (System.DateTime.Today.Day.ToString() + "-"
                + System.DateTime.Today.Month.ToString() + "-"
                + System.DateTime.Today.Year.ToString() + "-"
                + System.DateTime.Now.Hour.ToString() + "-"
                + System.DateTime.Now.Minute.ToString() + "-"
                + System.DateTime.Now.Second.ToString() + "-"
                + "CrystalClear_Respaldo_BD");

            //WIP


        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string database = conexion.Database.ToString();

            if(textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter backup file location");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK '" + textBox1.Text + "";

                //WIP
            }
        }
    }
}
