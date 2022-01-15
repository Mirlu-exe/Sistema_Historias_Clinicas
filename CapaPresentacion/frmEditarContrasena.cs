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

        private string Valorcito;

        public frmEditarContrasena(string num_id, string valorcito)
        {
            InitializeComponent();

            this.lbl_id_usuario.Text = num_id;

            this.Valorcito = valorcito;

        }


        private void frmEditarContrasena_Load(object sender, EventArgs e)
        {

            id_del_usuario = Convert.ToInt32(lbl_id_usuario.Text);

            MessageBox.Show("El id del usuario que coincide es: " +id_del_usuario+ ".");

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
            else if (this.txtPassword.TextLength < 8)
            {
                MessageBox.Show("Contraseña muy corta, por motivos de seguridad debe tener minimo 8 caracteres");
                this.txtPassword.Clear();
                this.txtConfirmPassword.Clear();
                this.txtPassword.Focus();
            }
            else if (this.txtPassword.Text.Any(Char.IsPunctuation) == false)
            {
                MessageBox.Show("Contraseña poco segura, por motivos de seguridad debe tener almenos un caracter especial");

                this.txtPassword.Clear();
                this.txtConfirmPassword.Clear();
                this.txtPassword.Focus();

            }

            else 
            {

                if (this.txtPassword.Text == this.txtConfirmPassword.Text)
                {

                    string rpta = "";

                    string pswd_plain;
                    string pswd_encrypt;
                    string pswd_salt;

                    pswd_plain = this.txtPassword.Text.Trim();

                    HashWithSaltResult hashWithSaltResult = SHA256Implementation.CreateEncriptHashWithSalt(pswd_plain, DateTime.Now.ToString());
                    pswd_encrypt = hashWithSaltResult.Digest;
                    pswd_salt = hashWithSaltResult.Salt;

                    rpta = NEditarContrasena.Editar(id_del_usuario, pswd_encrypt,  pswd_salt);



                    if (rpta.Equals("OK"))
                    {

                        this.MensajeOk("Se cambió la contraseña correctamente");

                        


                        if (Valorcito == "dentro del principal")
                        {
                            //MessageBox.Show("test dentro del frmPrincipal");
                        }
                        else if(Valorcito == "fuera del principal")
                        {
                            //MessageBox.Show("test fuera del frmPrincipal");

                            frmLogin frm = frmLogin.GetInstancia();
                            frm.Show();
                        }


                        this.OperacionCambiarContrasena();
                        this.txtPassword.Clear();
                        this.txtConfirmPassword.Clear();

                        this.Close();


                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }


                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden. Vuelva a intentarlo");
                }

                    
                


              

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




            SqlCon2.ConnectionString = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
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
