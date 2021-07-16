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
using CapaDatos;


namespace CapaPresentacion
{
    public partial class frmHerramientasAdmin : Form
    {
        public frmHerramientasAdmin()
        {
            InitializeComponent();
        }



        public static DUsuario Session_Actual = frmPrincipal.User_Actual;



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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmHerramientasAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
