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



        private int id_usuario;


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
            OperacionInsertarRespuestasSeguridad();

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

        //evento Close 1
        private void Pregunta1Cbx_DropDownClosed(object sender, EventArgs e)
        {

            if (this.Pregunta1Cbx.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una pregunta de la lista");
            }
            else
            {
                //MessageBox.Show(Convert.ToString(this.cmbPacientes.Text));

                string Pregunt1 = this.Pregunta1Cbx.Text;


                string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                string Query = "select * from Preguntas_Usuario where nombre = '" + Pregunt1 + "' ;";
                SqlConnection conDataBase = new SqlConnection(CN);
                SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
                SqlDataReader myReader;

                try
                {

                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();

                    while (myReader.Read())
                    {

                        string id_pregunta = myReader["id_pregunta"].ToString();
                        string Pregunta = myReader["Pregunta"].ToString();

                        //MessageBox.Show(idpaciente);

                        this.lbl_Id1.Text = id_pregunta;



                    }



                }
                catch (Exception ex)
                {


                }


            }
        }
        
        //evento Close 2
        private void Pregunta2Cbx_DropDownClosed(object sender, EventArgs e)
        {

            if (this.Pregunta2Cbx.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una pregunta de la lista");
            }
            else
            {
                //MessageBox.Show(Convert.ToString(this.cmbPacientes.Text));

                string Pregunt2 = this.Pregunta2Cbx.Text;


                string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                string Query = "select * from Preguntas_Usuario where nombre = '" + Pregunt2 + "' ;";
                SqlConnection conDataBase = new SqlConnection(CN);
                SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
                SqlDataReader myReader;

                try
                {

                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();

                    while (myReader.Read())
                    {

                        string id_pregunta2 = myReader["id_pregunta"].ToString();
                        string Pregunta2 = myReader["Pregunta"].ToString();

                        //MessageBox.Show(idpaciente);

                        this.lbl_Id2.Text = id_pregunta2;



                    }



                }
                catch (Exception ex)
                {


                }


            }
        }

        //evento Close 3
        private void Pregunta3Cbx_DropDownClosed(object sender, EventArgs e)
        {

            if (this.Pregunta3Cbx.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una pregunta de la lista");
            }
            else
            {
                //MessageBox.Show(Convert.ToString(this.cmbPacientes.Text));

                string Pregunt3 = this.Pregunta3Cbx.Text;


                string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                string Query = "select * from Preguntas_Usuario where nombre = '" + Pregunt3 + "' ;";
                SqlConnection conDataBase = new SqlConnection(CN);
                SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
                SqlDataReader myReader;

                try
                {

                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();

                    while (myReader.Read())
                    {

                        string id_pregunta3 = myReader["id_pregunta"].ToString();
                        string Pregunta3 = myReader["Pregunta"].ToString();

                        //MessageBox.Show(idpaciente);

                        this.lbl_Id3.Text = id_pregunta3;



                    }



                }
                catch (Exception ex)
                {


                }


            }
        }


        // Operacion Insertar (Falta por terminar)
        private void OperacionInsertarRespuestasSeguridad()
        {



            //string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            //SqlConnection conDataBase = new SqlConnection(Cn);

            //SqlDataAdapter cmdDataBase = new SqlDataAdapter("sp_insertar_pregunta_respuesta", conDataBase);

            //DataTable dbdataset = new DataTable();

            //cmdDataBase.Fill(dbdataset);

            //Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();


            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Respuestas_Usuario (idusuario, idpregunta, pregunta, estado) values (@d1,@d2,@d3,@d4)";


            SqlCmd2.Parameters.AddWithValue("@d1", this.);
            SqlCmd2.Parameters.AddWithValue("@d2", "Se anuló un usuario");
            SqlCmd2.Parameters.AddWithValue("@d3", "Se anuló un usuario");
            SqlCmd2.Parameters.AddWithValue("@d4", "Se anuló un usuario");





            Pregunta1Cbx.DataSource = dbdataset;
            Pregunta1Cbx.ValueMember = "id_pregunta";
            Pregunta1Cbx.DisplayMember = "Pregunta";



        }
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
