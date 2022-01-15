using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using CapaPresentacion;
using System.Data.SqlClient;
using Utilidades;

namespace CapaPresentacion
{
    public partial class frmConfirmarContraseña : Form
    {


        public static DUsuario Session_Actual = frmPrincipal.User_Actual;


        SqlConnection conexion = new SqlConnection("SERVER=ADRIAN-PC\\SQLEXPRESS; DATABASE=dbclinica; Integrated Security=true");

        string idusuario, login, clave, acceso, nombre;

        SqlDataReader dr;

        DataTable dbdataset;

        string cadena_restore;


        public frmConfirmarContraseña(string cadena)
        {
            InitializeComponent();

            cadena_restore = cadena;

        }

        public static bool ContraseñaCoincide ;

        public static bool Butter_Tester()
        {

            return ContraseñaCoincide;
        }


        private void frmConfirmarContraseña_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public string traer_salt_username(string username_ingresado)
        {
            string sal_del_username = "";
            string rpta;

            SqlConnection SqlCon = new SqlConnection();

            //Código
            SqlCon.ConnectionString = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
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
                MessageBox.Show(ex.ToString());
                Console.WriteLine("No se encontro la Salt del username seleccionado. Llame al admin");
            }


            return sal_del_username;

        }

        public string traer_password_username(string username_ingresado)
        {
            string password_del_username = "";
            string rpta;

            SqlConnection SqlCon = new SqlConnection();

            //Código
            SqlCon.ConnectionString = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
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
                MessageBox.Show(ex.ToString());

            }


            return password_del_username;

        }


        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            //tomar los datos del login y asignarlo a variables
            string username_ingresado;
            string password_ingresado;
            string salt_original;
            string password_original;

            username_ingresado = Session_Actual.Nombre;
            password_ingresado = this.txtPassword.Text;

            //buscar según el nombre de usuario, traer esos datos, incluyendo la salt.
            salt_original = traer_salt_username(username_ingresado);
            password_original = traer_password_username(username_ingresado);


            //encriptar la contraseña que se metió en el login.
            string encriptedPass = SHA256Implementation.EncriptText(password_ingresado, salt_original);

            //comparar esa encriptacion con la que está guardada en la BD.
            if (SlowEqualsImplementation.SlowEquals(encriptedPass, password_original)) //en caso de ser iguales se accede al sistema.
            {


                string CN = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
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


                        MessageBox.Show("Contraseña correcta", "Consultorio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //colocar variable TRUE

                        ContraseñaCoincide = true;

                        string database = conexion.Database.ToString();
                        conexion.Open();

                        try
                        {

                            string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE ");
                            SqlCommand cmd1 = new SqlCommand(str1, conexion);

                            cmd1.ExecuteNonQuery();

                            string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK= '" + cadena_restore + "' WITH REPLACE;";
                            SqlCommand cmd2 = new SqlCommand(str2, conexion);

                            cmd2.ExecuteNonQuery();

                            string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                            SqlCommand cmd3 = new SqlCommand(str3, conexion);

                            cmd3.ExecuteNonQuery();

                            MessageBox.Show("Restauración de la base de datos completada exitosamente");
                            conexion.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            conexion.Close();

                        }


                        this.Hide();

                    }
                    else if (count == 0)
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Consultorio", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //accion para realizar en caso de que la contraseña este incorrecta.
                        //colocar variable FALSE


                        ContraseñaCoincide = false;

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
                    MessageBox.Show(ex.ToString());

                }



            }
            else  //en caso de ser diferentes, mostrar error, usuario no valido.
            {

                MessageBox.Show("Contraseña incorrecta.", "Consultorio", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ContraseñaCoincide = false;


            }





        }
    }
}
