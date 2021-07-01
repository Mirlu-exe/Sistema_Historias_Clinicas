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
    public partial class frmLogin : Form
    {

        private static frmLogin _instancia;

        public static frmLogin GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new frmLogin();
            }
            return _instancia;
        }


        string idusuario, login, clave, acceso, nombre;





        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkRevelarClave_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkRevelarClave.Checked)
            {

                this.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {

                this.txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString();
        }

        private void lblRecuperarPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            //codigo para recuperar contraseña

            //abrir un form con 3 txtbox con 3 lbls con las preguntas de seguridad

            frmRecuperarContrasena frm = frmRecuperarContrasena.GetInstancia();
            frm.Show();


            //si coinciden, debe abrir otro form para guardar la contraseña nueva
            //debe devolver al login
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select * from Usuario where login = '" + this.txtUsuario.Text + "' and password = '" + this.txtPassword.Text + "' ;";
            SqlConnection conDataBase = new SqlConnection(CN);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;


            int count = 0;

            try
            {

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {

                    idusuario = myReader["idusuario"].ToString();
                    nombre = myReader["nombre"].ToString();
                    login = myReader["login"].ToString();
                    clave = myReader["password"].ToString();
                    acceso = myReader["acceso"].ToString();
                    count++;


                }

                if (count == 1)
                {


                    MessageBox.Show("Acceso concedido", "Consultorio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.OperacionAccesoSistema();

                    frmPrincipal menu = new frmPrincipal();
                    //frmCitas citas = new frmCitas();
                    menu.lblcodigoUsuario.Text = this.idusuario;
                    menu.lblLogin.Text = this.login;
                    menu.lblAcceso.Text = this.acceso;
                    menu.lblnombreusuario.Text = this.nombre;
                    //menu.lblcodigoUsuario.Text = this.idusuario;
                    //citas.txtCodUsuario.Text = this.idusuario;
                    menu.Show();
                    this.Hide();

                }
                else if (count == 0)
                {
                    MessageBox.Show("Datos Invalidos", "Consultorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR, quizas exista un registro con datos iguales, contacte al administrador");
                }




                conDataBase.Close();






            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");

            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void OperacionAccesoSistema()
        {


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario " + this.txtUsuario.Text + " ha accedido al sistema. ");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }
    }
}
