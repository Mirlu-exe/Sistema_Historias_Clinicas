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

using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();


        }

        public static DUsuario User_Actual = new DUsuario();





        public static DUsuario Asignar_Session_Info(int id_usuario, string login_user, string acceso, string nombre_completo)
        {
            User_Actual.Idusuario = Convert.ToInt32(id_usuario);
            User_Actual.Log = login_user;
            User_Actual.Acceso = acceso;
            User_Actual.Nombre = nombre_completo;


            return User_Actual;
        }

        public static DUsuario Session_Actual = frmPrincipal.User_Actual;


        private void GestionUsuario()
        {
            //Controlar los accesos según Nivel del Usuario

            if (this.lblAcceso.Text == "Medico")
            {
                this.btnPacientes.Enabled = true;
                this.btnCitas.Enabled = true;
                this.btnHistorias.Enabled = true;
                this.btnServicios.Enabled = true;
                this.btnDiagnosticos.Enabled = true;
                this.btnRecetas.Enabled = true;
                this.btnOperaciones.Enabled = true;
                this.btnHerramientasAdmin.Enabled = false;
                this.btnControlEstadistico.Enabled = true;
                this.btnHerramientasAdmin.Hide();

            }

            if (this.lblAcceso.Text == "Asistente")
            {
                this.btnPacientes.Enabled = true;
                this.btnCitas.Enabled = true;
                this.btnHistorias.Enabled = false;
                this.btnServicios.Enabled = false;
                this.btnDiagnosticos.Enabled = false;
                this.btnRecetas.Enabled = false;
                this.btnPlanEstudios.Enabled = false;
                this.btnOperaciones.Enabled = false;
                this.btnHerramientasAdmin.Enabled = false;
                this.btnControlEstadistico.Enabled = false;
                this.btnHerramientasAdmin.Hide();
            }


            if (this.lblAcceso.Text == "Administrador")
            {

                this.btnPacientes.Enabled = true;
                this.btnCitas.Enabled = true;
                this.btnHistorias.Enabled = true;
                this.btnServicios.Enabled = true;
                this.btnDiagnosticos.Enabled = true;
                this.btnRecetas.Enabled = true;
                this.btnOperaciones.Enabled = true;
                this.btnHerramientasAdmin.Enabled = true;
                this.btnControlEstadistico.Enabled = true;
                this.btnHerramientasAdmin.Show();

            }
        }







        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            label3_Click(null, e);


            


            MessageBox.Show("Bienvenido " + Session_Actual.Log + " :) " );



            GestionUsuario();

            this.WindowState = FormWindowState.Maximized;


        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {

            //registro de la operacion Cerrar sesion
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion, usuario) values (@d1,@d2, @d3)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario " + User_Actual.Log + " ha cerrado sesión. ");
            SqlCmd2.Parameters.AddWithValue("@d3", User_Actual.Log);





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";



            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {


            if (MenuVertical.Width == 273)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 273;
            }
                
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmPaciente());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioResumen());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmUsuarios());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmCitas());
        }

        private void btnDiagnosticos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmDiagnostico());
        }

        private void btnHistorias_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmHistoria());
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmRecetas());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmServicios());
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmOperacion());
        }

        private void button7_Click(object sender, EventArgs e)
        {


            //registro de la operacion Cerrar sesion
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion, usuario) values (@d1,@d2,@d3)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario " + User_Actual.Log + " ha cerrado sesión. ");
            SqlCmd2.Parameters.AddWithValue("@d3", User_Actual.Log);





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";



            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPlanEstudios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmPlanEstudio());
        }

        private void lblAcceso_Click(object sender, EventArgs e)
        {

        }

        private void btnConfigPersonal_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.btnConfigPersonal, "Configuración Personal");
        }

        private void btnHerramientasAdmin_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.btnHerramientasAdmin, "Herramientas de Administrador");
        }

        private void btnControlEstadistico_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmControlEstadistico());
        }

        private void btnHerramientasAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmHerramientasAdmin());
        }


        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.btnHerramientasAdmin, "Ayuda");
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmGestionReportes());
        }

        private void btnConfigPersonal_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmConfigPersonal());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //abrir form inicio
            AbrirFormEnPanel(new InicioResumen());
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmInformesMedicosReferenciaMedicas());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmMedicosConfianza());
        }
    }
}
