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
using CapaNegocio;
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class frmRespaldoBaseDatos : Form
    {
        public frmRespaldoBaseDatos()
        {
            InitializeComponent();

        }



        public static DUsuario Session_Actual = frmPrincipal.User_Actual;



        SqlConnection conexion = new SqlConnection("SERVER=ADRIAN-PC\\SQLEXPRESS; DATABASE=dbclinica; Integrated Security=true");


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
                MessageBox.Show("respaldo de Base de datos generada exitosamente"); // mensaje de guardado

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

            frmConfirmarContraseña frm = new frmConfirmarContraseña(this.textBox2.Text); //aca le estoy enviando la cadena de el bak a restaurar

            frm.ShowDialog();


        }




    }
}
