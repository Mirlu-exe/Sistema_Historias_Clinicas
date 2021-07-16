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
    public partial class frmEditarContrasena : Form
    {






        private static frmRecuperarContrasena _instancia;

        public static frmRecuperarContrasena GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new frmRecuperarContrasena();
            }
            return _instancia;
        }

        //el id del usuario que cambiara su contraseña
        private int id_del_usuario;


        public frmEditarContrasena()
        {
            InitializeComponent();
        }


        public static DUsuario Session_Actual = frmPrincipal.User_Actual;

        private void frmEditarContrasena_Load(object sender, EventArgs e)
        {

            id_del_usuario = frmRecuperarContrasena.editarContrasena.Idusuario;



            MessageBox.Show("El id del usuario que coincide es: " + id_del_usuario + ".");

            DataTable tablita = new DataTable();

            //tablita = NUsuario.BuscarNombre(id_del_usuario.ToString());

            //this.txtNombre.Text = (tablita.Select("idusuario = " + id_del_usuario + "")).ToString();



        }

        private void btnGenerarContrasena_Click(object sender, EventArgs e)
        {


            //validacion de que las dos contraseñas sean iguales



            if (this.txtPassword.Text == "" || this.txtPassword.Text == "")
            {

                MessageBox.Show("Campos vacios. Ingrese la nueva contraseña");

            }
            else if (this.txtPassword.Text == this.txtConfirmPassword.Text)
            {
                string rpta = "";

                rpta = NEditarContrasena.Editar(Convert.ToInt32(this.id_del_usuario),
                               this.txtConfirmPassword.Text.Trim().ToUpper());

                if (rpta.Equals("OK"))
                {

                    this.MensajeOk("Se cambió la contraseña correctamente");

                    //esto ayuda a que solo se pueda abrir 1 sola ventana de login.
                    frmLogin frm = frmLogin.GetInstancia();
                    frm.Show();
                    
                    this.OperacionCambiarContrasena();
                    this.txtPassword.Clear();
                    this.txtConfirmPassword.Clear();

                    this.Hide();


                }
                else
                {
                    this.MensajeError(rpta);
                }

            }else 
            {
                MessageBox.Show("Las contraseñas no coinciden. Vuelva a intentarlo");
            }



         


        }


        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Consultorio", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Consultorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void OperacionCambiarContrasena()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "Se cambió la contraseña");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Edito el Registro";




        }





    }
}
