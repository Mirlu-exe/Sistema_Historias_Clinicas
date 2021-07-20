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


namespace CapaPresentacion
{
    public partial class frmConfigPreguntasSeguridad : Form
    {


        private int id_usuario ;


        private static frmConfigPreguntasSeguridad _instancia;

        public static frmConfigPreguntasSeguridad GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new frmConfigPreguntasSeguridad();
            }
            return _instancia;
        }


        public frmConfigPreguntasSeguridad()
        {
            InitializeComponent();

        }



        public static DUsuario Session_Actual = frmPrincipal.User_Actual;



        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnLimpiarPreguntas_Click(object sender, EventArgs e)
        {

            this.txtLibro.Clear();
            this.txtAbuela.Clear();
            this.txtMascota.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //esto ayuda a que solo se pueda abrir 1 sola ventana de usuarios
            frmUsuarios frm = frmUsuarios.GetInstancia();
            frm.Show();

            txtLibro.Clear();
            txtAbuela.Clear();
            txtMascota.Clear();

            this.Hide();
        }

        private void frmConfigPreguntasSeguridad_Load(object sender, EventArgs e)
        {
            //aca se guarda el id sacado de el formulario de usuarios.
            id_usuario = frmUsuarios.usuarioRespuestas.Idusuario;
        }

        private void btnIngresarRespuestas_Click(object sender, EventArgs e)
        {


            string Resp1 = this.txtLibro.Text.Trim().ToUpper();
            string Resp2 = this.txtAbuela.Text.Trim().ToUpper();
            string Resp3 = this.txtMascota.Text.Trim().ToUpper();

            string rpta = "";

            rpta = NUsuario.EditarRespSeguridad(id_usuario, Resp1, Resp2, Resp3);

            if (rpta.Equals("OK"))
            {

                this.MensajeOk("Se añadieron las respuestas correctamente");
                
               

                //this.OperacionInsertarRespuestasSeguridad();

                this.txtLibro.Clear();
                this.txtAbuela.Clear();
                this.txtMascota.Clear();

                this.Hide();


            }
            else
            {
                this.MensajeError(rpta);
            }

        }


        //private void OperacionInsertarRespuestasSeguridad()
        //{



        //    // Operacion Insertar Respuestas Seguridad
        //    string rpta2 = "";


        //    SqlConnection SqlCon2 = new SqlConnection();




        //    SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
        //    SqlCon2.Open();

        //    SqlCommand SqlCmd2 = new SqlCommand();
        //    SqlCmd2.Connection = SqlCon2;
        //    SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





        //    SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
        //    SqlCmd2.Parameters.AddWithValue("@d2", "Se Insertaron Respuestas de Seguridad");





        //    //Ejecutamos nuestro comando

        //    rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Edito el Registro de Respuestas de seguridad";




        //}






    }
}
