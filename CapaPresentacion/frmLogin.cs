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


using Utilidades;

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

        SqlDataReader dr;

        DataTable dbdataset;


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

            //tomar los datos del login y asignarlo a variables
            string username_ingresado;
            string password_ingresado;
            string salt_original;
            string password_original;

            username_ingresado = this.txtUsuario.Text;
            password_ingresado = this.txtPassword.Text;

            //buscar según el nombre de usuario, traer esos datos, incluyendo la salt.
            salt_original = traer_salt_username(username_ingresado);
            password_original = traer_password_username(username_ingresado);


            //encriptar la contraseña que se metió en el login.
            string encriptedPass = SHA256Implementation.EncriptText(password_ingresado, salt_original);

            //comparar esa encriptacion con la que está guardada en la BD.
            if (SlowEqualsImplementation.SlowEquals(encriptedPass, password_original)) //en caso de ser iguales se accede al sistema.
            {


                string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                string Query = "select * from Usuario where login = '" + username_ingresado + "' and password = '" + encriptedPass + "' ;";
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
                        
                        

                        menu.lblcodigoUsuario.Text = this.idusuario;
                        menu.lblLogin.Text = this.login;
                        menu.lblAcceso.Text = this.acceso;
                        menu.lblnombreusuario.Text = this.nombre;


                        frmPrincipal.Asignar_Session_Info(Convert.ToInt32(this.idusuario),this.login, this.acceso, this.nombre);


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
            else  //en caso de ser diferentes, mostrar error, usuario no valido.
            {

                MessageBox.Show("Error, usuario no valido");

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
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion, usuario) values (@d1,@d2,@d3)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario ha accedido al sistema.");
            SqlCmd2.Parameters.AddWithValue("@d3", login);




            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }

        public string traer_salt_username(string username_ingresado)
        {
            string sal_del_username = "";
            string rpta;

            SqlConnection SqlCon = new SqlConnection();

            //Código
            SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon.Open();
            //Establecer el Comando
            SqlCommand SqlCmd = new SqlCommand("select salt from Usuario where login ='" + username_ingresado + "' ");
            SqlCmd.Connection = SqlCon;

            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = SqlCmd;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                sda.Update(dbdataset);

                //con esta linea se trae la sal
                sal_del_username = dbdataset.Rows[0][0].ToString();



            }
            catch (Exception ex)
            {

                Console.WriteLine("No se encontro la Salt del username seleccionado.");
            }


            return sal_del_username;

        }


        public string traer_password_username(string username_ingresado)
        {
            string password_del_username = "";
            string rpta;

            SqlConnection SqlCon = new SqlConnection();

            //Código
            SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon.Open();
            //Establecer el Comando
            SqlCommand SqlCmd = new SqlCommand("select password from Usuario where login ='" + username_ingresado + "' ");
            SqlCmd.Connection = SqlCon;

            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = SqlCmd;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                sda.Update(dbdataset);

                //con esta linea se trae la password
                password_del_username = dbdataset.Rows[0][0].ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro la contrasela del username seleccionado");

                Console.WriteLine("No se encontro la contraseña del username seleccionado.");
            }


            return password_del_username;

        }





    }
}
