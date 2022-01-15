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



            if (CompararRespuestas(Convert.ToInt32(lbl_id_user.Text), Convert.ToInt32(label1.Text), this.txtResp1.Text) == true &&
                CompararRespuestas(Convert.ToInt32(lbl_id_user.Text), Convert.ToInt32(label2.Text), this.txtResp2.Text) == true &&
                CompararRespuestas(Convert.ToInt32(lbl_id_user.Text), Convert.ToInt32(label3.Text), this.txtResp3.Text) == true)
            {

                MessageBox.Show("Felicitaciones! todas las respuestas coinciden :D");

                frmEditarContrasena frm2 = new frmEditarContrasena(lbl_id_user.Text, "fuera del principal");
                frm2.Show();



            }
            else
            {
                MessageBox.Show("una o mas respuestas no coinciden :(");
            }

        }

        private void Limpiar()
        {

            txtResp1.Clear();
            txtResp2.Clear();
            txtResp3.Clear();

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

            string Cn = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
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

                this.lbl_id_user.Text = Convert.ToString(id_del_usuario);

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

            string Cn = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
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
                this.label1.Text = Convert.ToString(id_de_la_pregunta1);


                string Con = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                SqlConnection conDataBasewea = new SqlConnection(Con);

                SqlDataAdapter cmdDataBasewea = new SqlDataAdapter("select * from Preguntas_Usuario where id_pregunta =  " + id_de_la_pregunta1+ "", conDataBasewea);

                DataTable tablita_wea = new DataTable();

                cmdDataBasewea.Fill(tablita_wea);

                this.cbPregunta1.Text = Convert.ToString(tablita_wea.Rows[0][1]);

                



                //////sacando pregunta 2
                ///
                int id_de_la_pregunta2 = Convert.ToInt32(tablita_preguntas.Rows[1][2]);
                this.label2.Text = Convert.ToString(id_de_la_pregunta2);

                string Con2 = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                SqlConnection conDataBasewea2 = new SqlConnection(Con2);

                SqlDataAdapter cmdDataBasewea2 = new SqlDataAdapter("select * from Preguntas_Usuario where id_pregunta =  " + id_de_la_pregunta2 + "", conDataBasewea2);

                DataTable tablita_wea2 = new DataTable();

                cmdDataBasewea2.Fill(tablita_wea2);

                this.cbPregunta2.Text = Convert.ToString(tablita_wea2.Rows[0][1]);



                //////sacando pregunta 3
                ///
                int id_de_la_pregunta3 = Convert.ToInt32(tablita_preguntas.Rows[2][2]);
                this.label3.Text = Convert.ToString(id_de_la_pregunta3);

                string Con3 = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
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


        private bool CompararRespuestas(int id_user, int id_de_pregunta, string txtResp)
        {

            bool coinciden;

            //me traigo las respuestas de las preguntas y las comparo con los textbox

            string Cn = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);

            SqlDataAdapter cmdDataBase = new SqlDataAdapter("select * from Respuestas_Usuario where idusuario = '" + id_user + "' and idpregunta = '" + id_de_pregunta +  "' ", conDataBase);

            DataTable tablita_preguntas = new DataTable();

            cmdDataBase.Fill(tablita_preguntas);

            string respOriginal = Convert.ToString(tablita_preguntas.Rows[0][3]);


            if (respOriginal == txtResp)
            {
                //MessageBox.Show("Las respuestas coinciden! :D");
                coinciden = true;
            }
            else
            {
                //MessageBox.Show("Las respuestas no coinciden :(");
                coinciden = false;
            }

            return coinciden;

        }

        private void gbPreguntasSeguridad_Enter(object sender, EventArgs e)
        {

        }
    }
}
