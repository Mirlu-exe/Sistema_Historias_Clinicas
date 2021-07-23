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

            this.txtResp1.Clear();
            this.txtResp2.Clear();
            this.txtResp3.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //esto ayuda a que solo se pueda abrir 1 sola ventana de usuarios
            frmUsuarios frm = frmUsuarios.GetInstancia();
            frm.Show();

            txtResp1.Clear();
            txtResp2.Clear();
            txtResp3.Clear();

            this.Hide();
        }

        private void frmConfigPreguntasSeguridad_Load(object sender, EventArgs e)
        {

            //aca se guarda el id sacado de el formulario de usuarios.
            id_usuario = frmUsuarios.usuarioRespuestas.Idusuario;



            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);

            SqlDataAdapter cmdDataBase = new SqlDataAdapter("select * from Preguntas_Usuario", conDataBase);

            DataTable dbdataset = new DataTable();

            cmdDataBase.Fill(dbdataset);


            Pregunta1Cbx.DataSource = dbdataset;
            Pregunta1Cbx.ValueMember = "id_pregunta";
            Pregunta1Cbx.DisplayMember = "Pregunta";

            Pregunta2Cbx.DataSource = dbdataset;
            Pregunta2Cbx.ValueMember = "id_pregunta";
            Pregunta2Cbx.DisplayMember = "Pregunta";

            Pregunta3Cbx.DataSource = dbdataset;
            Pregunta3Cbx.ValueMember = "id_pregunta";
            Pregunta3Cbx.DisplayMember = "Pregunta";


        }

        private void btnIngresarRespuestas_Click(object sender, EventArgs e)
        {

            int Preg1 = Convert.ToInt32(this.Pregunta1Cbx.Text);
            int Preg2 = Convert.ToInt32(this.Pregunta2Cbx.Text);
            int Preg3 = Convert.ToInt32(this.Pregunta3Cbx.Text);

            string Resp1 = this.txtResp1.Text.Trim().ToUpper();
            string Resp2 = this.txtResp2.Text.Trim().ToUpper();
            string Resp3 = this.txtResp3.Text.Trim().ToUpper();


            int id_user = 0;

            if (this.txtResp1.Text == "" || this.txtResp2.Text == "" || this.txtResp3.Text == "")
            {

                MessageBox.Show("No deje campos vacios ");

            }
            else
            {
                InsertarRespuestasSeguridad(id_user, Preg1, Resp1);
                InsertarRespuestasSeguridad(id_user, Preg2, Resp2);
                InsertarRespuestasSeguridad(id_user, Preg3, Resp3);

            }

            //string rpta = "";

            //rpta = NUsuario.EditarRespSeguridad(id_usuario, Resp1, Resp2, Resp3);

            //if (rpta.Equals("OK"))
            //{

            //    this.MensajeOk("Se añadieron las respuestas correctamente");



            //    //this.OperacionInsertarRespuestasSeguridad();

            //    this.txtLibro.Clear();
            //    this.txtAbuela.Clear();
            //    this.txtMascota.Clear();

            //    this.Hide();


            //}
            //else
            //{
            //    this.MensajeError(rpta);
            //}

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
        private void InsertarRespuestasSeguridad( int Id_Usuario, int Preg, string Resp )
        {


            string rpta2 = "";

            DataTable dbdataset = new DataTable();

            SqlConnection SqlCon2 = new SqlConnection();


            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Respuestas_Usuario (idusuario, idpregunta, respuesta, estado) values (@d1,@d2,@d3,@d4)";


            SqlCmd2.Parameters.AddWithValue("@d1", Id_Usuario);

            SqlCmd2.Parameters.AddWithValue("@d2", Preg);
            SqlCmd2.Parameters.AddWithValue("@d3", Resp);

            SqlCmd2.Parameters.AddWithValue("@d4", "Activo");







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
