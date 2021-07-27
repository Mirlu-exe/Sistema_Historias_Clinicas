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
    public partial class frmRecuperarContrasena : Form
    {

        

        private static frmRecuperarContrasena _instancia;
        private int id_de_coincidencia;
        //aqui se le da el valor del id del usuario actual.
        public static DEditarContrasena editarContrasena = new DEditarContrasena();

        public static frmRecuperarContrasena GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new frmRecuperarContrasena();
            }
            return _instancia;
        }




        public frmRecuperarContrasena()
        {
            InitializeComponent();
        }



        private void frmRecuperarContrasena_Load(object sender, EventArgs e)
        {
            this.gbPreguntasSeguridad.Enabled = false;
        }

        private void btnLimpiarPreguntas_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //esto ayuda a que solo se pueda abrir 1 sola ventana de login.
            frmLogin frm = frmLogin.GetInstancia();
            frm.Show();

            Limpiar();

            this.Hide();
        }

        private void btnConfirmarPreguntas_Click(object sender, EventArgs e)
        {



            //recoger la respuesta #1, #2 y la #3
            string Resp1 = (this.txtResp1.Text).ToUpper();
            string Resp2 = (this.txtResp2.Text).ToUpper();
            string Resp3 = (this.txtResp3.Text).ToUpper();

            MessageBox.Show("Sus respuestas fueron: 1=" + Resp1 + "  2=" + Resp2 + "  3=" + Resp3 + ".");

            //realizar una busqueda en la tabla de Respuestas de preguntas.
            //seleccionar el ID del Usuario que aparezca en el resultado.

            id_de_coincidencia = TraerIdQueCoincidaRespuestas(Resp1, Resp2, Resp3);


           


        }

        private void Limpiar()
        {

            txtResp1.Clear();
            txtResp2.Clear();
            txtResp3.Clear();

        }


        private int TraerIdQueCoincidaRespuestas(string Resp1, string Resp2, string Resp3)
        {
            DataTable DtResultado = new DataTable("Respuestas_Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SELECT idusuario FROM dbo.Respuestas_Usuario WHERE " +
                    "Respuesta_1 = '" + Resp1 + "' AND " +
                    "Respuesta_2 = '" + Resp2 + "' AND " +
                    "Respuesta_3 = '" + Resp3 + "' ;";
                SqlCmd.CommandType = CommandType.Text;


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

                if (DtResultado.Rows.Count == 1)
                {

                    id_de_coincidencia = Convert.ToInt32(DtResultado.Rows[0][0]);

                    MessageBox.Show("El id del usuario que coincide es: " + id_de_coincidencia + ".");



                    editarContrasena.Idusuario = id_de_coincidencia;

                    //abrir un form con 3 txtbox con 3 lbls con las preguntas de seguridad

                    frmEditarContrasena frm = new frmEditarContrasena();
                    frm.Show();

                    Limpiar();

                    //mostrar la cedula y mostrar una ventana para ingresar la nueva contraseña.
                    this.Hide();


                }
                else if (DtResultado.Rows.Count == 0) {

                    MessageBox.Show("Error no existe ninguna coincidencia");
                }
                else
                {
                    MessageBox.Show("Error no existe ninguna coincidencia1");
                }


                

            }
            catch (Exception ex)
            {
                DtResultado = null;
                MessageBox.Show(ex.ToString());
            }
            return id_de_coincidencia;
        }

        private void cbPregunta3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtResp3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificarExistenciaUsername_Click(object sender, EventArgs e)
        {

            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);

            SqlDataAdapter cmdDataBase = new SqlDataAdapter("select * from Usuario where login like '" + txt_verificar_username.Text + "' ", conDataBase);

            DataTable tablita_usuarios = new DataTable();

            cmdDataBase.Fill(tablita_usuarios);

            if (tablita_usuarios.Rows.Count > 0)
            {
                MessageBox.Show("Se encontro una coincidencia :) ");

                this.gbPreguntasSeguridad.Enabled = true;

                int id_del_usuario = Convert.ToInt32(tablita_usuarios.Rows[0][0]);

                MessageBox.Show("El id del usuario es: " + id_del_usuario + "");

                CargarPreguntas(id_del_usuario);

                //CompararRespuestas();



            }else
            {
                MessageBox.Show("Ese usuario no existe! >:( ");
                this.gbPreguntasSeguridad.Enabled = false;
            }

            //si NO existe:

            //mensaje: no existe el usuario. 
            //desactivar el siguiente groupbox

            //si SI existe:
            //activar el siguiente groupbox y cargar los datos.


        }

        private void CargarPreguntas( int id_usuario)
        {

            //

            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);

            SqlDataAdapter cmdDataBase = new SqlDataAdapter("select * from Respuestas_Usuario where idusuario = " + id_usuario + "", conDataBase);

            DataTable tablita_preguntas = new DataTable();

            cmdDataBase.Fill(tablita_preguntas);

            if (tablita_preguntas.Rows.Count > 0)
            {
                MessageBox.Show("Tiene preguntas de seguridad :)");

                
                /////////////sacando pregunta 1
                ///
                int id_de_la_pregunta1 = Convert.ToInt32(tablita_preguntas.Rows[0][2]);


                string Con = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                SqlConnection conDataBasewea = new SqlConnection(Con);

                SqlDataAdapter cmdDataBasewea = new SqlDataAdapter("select * from Preguntas_Usuario where id_pregunta =  " + id_de_la_pregunta1+ "", conDataBasewea);

                DataTable tablita_wea = new DataTable();

                cmdDataBasewea.Fill(tablita_wea);

                this.cbPregunta1.Text = Convert.ToString(tablita_wea.Rows[0][1]);


                //////sacando pregunta 2
                ///
                int id_de_la_pregunta2 = Convert.ToInt32(tablita_preguntas.Rows[1][2]);


                string Con2 = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                SqlConnection conDataBasewea2 = new SqlConnection(Con2);

                SqlDataAdapter cmdDataBasewea2 = new SqlDataAdapter("select * from Preguntas_Usuario where id_pregunta =  " + id_de_la_pregunta2 + "", conDataBasewea2);

                DataTable tablita_wea2 = new DataTable();

                cmdDataBasewea2.Fill(tablita_wea2);

                this.cbPregunta2.Text = Convert.ToString(tablita_wea2.Rows[0][1]);



                //////sacando pregunta 3
                ///
                int id_de_la_pregunta3 = Convert.ToInt32(tablita_preguntas.Rows[2][2]);


                string Con3 = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                SqlConnection conDataBasewea3 = new SqlConnection(Con3);

                SqlDataAdapter cmdDataBasewea3 = new SqlDataAdapter("select * from Preguntas_Usuario where id_pregunta =  " + id_de_la_pregunta3 + "", conDataBasewea3);

                DataTable tablita_wea3 = new DataTable();

                cmdDataBasewea3.Fill(tablita_wea3);

                this.cbPregunta3.Text = Convert.ToString(tablita_wea3.Rows[0][1]);






            }
            else
            {
                MessageBox.Show("No se han configurado las preguntas de seguridad");
                this.gbPreguntasSeguridad.Enabled = false;
            }




        }


        private void CompararRespuestas()
        {

            //me traigo las respuestas de las preguntas y las comparo con los textbox

        }





    }
}
