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
    public partial class frmRespaldoBaseDatos : Form
    {
        public frmRespaldoBaseDatos()
        {
            InitializeComponent();
        }



        public static DUsuario Session_Actual = frmPrincipal.User_Actual;



        SqlConnection conexion = new SqlConnection("SERVER=MIRLU\\SQLEXPRESS; DATABASE=dbclinica; Integrated Security=true");


        private void btnBrowseGenerar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;


            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string database = conexion.Database.ToString();

            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter backup file location");
            }
            else
            {

                string nombre_copia = (System.DateTime.Today.Day.ToString() + "-"
                + System.DateTime.Today.Month.ToString() + "-"
                + System.DateTime.Today.Year.ToString() + "-"
                + System.DateTime.Now.Hour.ToString() + "-"
                + System.DateTime.Now.Minute.ToString() + "-"
                + System.DateTime.Now.Second.ToString() + "-"
                + "CrystalClear_Respaldo_BD");

                string direccion_standard = "C:\\Users\\Usuario\\Desktop\\Sistema_Historias_Clinicas\\Prueba de respaldo y restore";

                string cmd = "BACKUP DATABASE[dbclinica] TO DISK = N'" + this.textBox1.Text + "\\[" + nombre_copia + "].bak' WITH INIT, NAME = N'dbclinica-Full Database Backup', NOREWIND, NOUNLOAD,  STATS = 10, FORMAT";

                conexion.Open(); // open

                SqlCommand command1 = new SqlCommand(cmd, conexion); // llamado

                command1.ExecuteNonQuery();
                MessageBox.Show("Data base  done successfuly"); // mensaje de guardado

                conexion.Close(); // close 

                btnBackup.Enabled = false;



            }
        }



        private void btnBrowseRestaurar_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();


            dlg.Filter = "SLQ SERVER database back files (*.bak) | *.bak";
            dlg.Title = "Data base Restore ";

            if (dlg.ShowDialog() == DialogResult.OK) // verificacion de restauracion que este cargada 
            {

                textBox2.Text = dlg.FileName;
                btnRestore.Enabled = true;

            }

        }
        private void btnRestore_Click(object sender, EventArgs e)
        {

            string database = conexion.Database.ToString();
            conexion.Open();

            try
            {

                string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE ");
                SqlCommand cmd1 = new SqlCommand(str1, conexion);

                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK= '" + textBox2.Text + "' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(str2, conexion);

                cmd2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, conexion);

                cmd3.ExecuteNonQuery();

                MessageBox.Show("Database restore done succeessfuly ");
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conexion.Close();

            }


        }



       
    }
}
