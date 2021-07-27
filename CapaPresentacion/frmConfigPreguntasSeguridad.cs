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

            

            if (VerificarSiYaPoseeRespuestas(Session_Actual.Idusuario) == true)
            {
                MessageBox.Show("Usted ya posee Preguntas/Respuestas configuradas, si continua, estas serán sobreescritas");
            }
            else if (VerificarSiYaPoseeRespuestas(Session_Actual.Idusuario) == false)
            {
                MessageBox.Show("Ingrese sus Preguntas/Respuestas de seguridad");
            }

            

            



            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);








            SqlDataAdapter cmdDataBase1 = new SqlDataAdapter("select * from Preguntas_Usuario", conDataBase);

            DataTable dbdataset_1 = new DataTable();

            cmdDataBase1.Fill(dbdataset_1);

            Pregunta1Cbx.DataSource = dbdataset_1;
            Pregunta1Cbx.ValueMember = "id_pregunta";
            Pregunta1Cbx.DisplayMember = "Pregunta";



            SqlDataAdapter cmdDataBase2 = new SqlDataAdapter("select * from Preguntas_Usuario", conDataBase);

            DataTable dbdataset_2 = new DataTable();

            cmdDataBase2.Fill(dbdataset_2);

            Pregunta2Cbx.DataSource = dbdataset_2;
            Pregunta2Cbx.ValueMember = "id_pregunta";
            Pregunta2Cbx.DisplayMember = "Pregunta";


            SqlDataAdapter cmdDataBase3 = new SqlDataAdapter("select * from Preguntas_Usuario", conDataBase);

            DataTable dbdataset_3 = new DataTable();

            cmdDataBase3.Fill(dbdataset_3);

            Pregunta3Cbx.DataSource = dbdataset_3;
            Pregunta3Cbx.ValueMember = "id_pregunta";
            Pregunta3Cbx.DisplayMember = "Pregunta";


        }





        private void btnIngresarRespuestas_Click(object sender, EventArgs e)
        {


            int Preg1 = Convert.ToInt32(this.Pregunta1Cbx.SelectedValue);
            int Preg2 = Convert.ToInt32(this.Pregunta2Cbx.SelectedValue);
            int Preg3 = Convert.ToInt32(this.Pregunta3Cbx.SelectedValue);

            string Resp1 = this.txtResp1.Text.Trim().ToUpper();
            string Resp2 = this.txtResp2.Text.Trim().ToUpper();
            string Resp3 = this.txtResp3.Text.Trim().ToUpper();


            int id_user = Session_Actual.Idusuario;



            if (this.txtResp1.Text == "" || this.txtResp2.Text == "" || this.txtResp3.Text == "")
            {

                MessageBox.Show("No deje campos vacios ");

            }
            else
            {

                if (VerificarSiYaPoseeRespuestas(Session_Actual.Idusuario) == false)
                {
                    //insertar

                    string rpta = "";

                    rpta = InsertarRespuestasSeguridad(id_user, Preg1, Resp1);
                    rpta = InsertarRespuestasSeguridad(id_user, Preg2, Resp2);
                    rpta = InsertarRespuestasSeguridad(id_user, Preg3, Resp3);


                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Se configuraron correctamente las preguntas y respuestas de seguridad");
                    }
                    else
                    {
                        MessageBox.Show("ocurrio un error al configurar las preguntas respuestas");
                    }

                }
                else if (VerificarSiYaPoseeRespuestas(Session_Actual.Idusuario) == true)
                {
                    //editar
                    

                    string rpta = "";

                    rpta = EditarRespuestasSeguridad(id_user, Preg1, Resp1, Preg2, Resp2, Preg3, Resp3);


                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Se configuraron correctamente las preguntas y respuestas de seguridad");
                    }
                    else
                    {
                        MessageBox.Show("ocurrio un error al configurar las preguntas respuestas");
                    }

                }

               









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
                string Query = "select * from Preguntas_Usuario where Pregunta = '" + Pregunt1 + "' ;";
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
                    MessageBox.Show(ex.ToString());

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
                string Query = "select * from Preguntas_Usuario where Pregunta = '" + Pregunt2 + "' ;";
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
                string Query = "select * from Preguntas_Usuario where Pregunta = '" + Pregunt3 + "' ;";
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


        // Insertar 
        private string InsertarRespuestasSeguridad( int Id_Usuario, int Preg, string Resp )
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



            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se configuraron las Respuestas de seguridad";

            return rpta2;



        }



        // Editar (Falta por terminar)
        private string EditarRespuestasSeguridad(int Id_Usuario, int Preg1, string Resp1, int Preg2, string Resp2, int Preg3, string Resp3)
        {




            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);

            SqlDataAdapter cmdDataBase = new SqlDataAdapter("select * from Respuestas_Usuario where idusuario = '" + Id_Usuario + "' ;", conDataBase);

            DataTable tablita = new DataTable();

            cmdDataBase.Fill(tablita);

            int cant_registros = 0;

                cant_registros = tablita.Rows.Count;

            int cellValue1 = Convert.ToInt32(tablita.Rows[0][0]);
            int cellValue2 = Convert.ToInt32(tablita.Rows[1][0]);
            int cellValue3 = Convert.ToInt32(tablita.Rows[2][0]);

            string rpta2 = "";

                DataTable dbdataset = new DataTable();

                SqlConnection SqlCon2 = new SqlConnection();


                SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                SqlCon2.Open();

                SqlCommand SqlCmd2 = new SqlCommand();
                SqlCmd2.Connection = SqlCon2;

                SqlCmd2.CommandText = "UPDATE Respuestas_Usuario SET idpregunta = '" + Preg1 + "', respuesta = '" + Resp1 + "', estado = 'Activo' WHERE id =" + cellValue1 + ";";
                rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se configuraron las Respuestas de seguridad";

                SqlCmd2.CommandText = "UPDATE Respuestas_Usuario SET idpregunta = '" + Preg2 + "', respuesta = '" + Resp2 + "', estado = 'Activo' WHERE id =" + cellValue2 + ";";
                rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se configuraron las Respuestas de seguridad";

                SqlCmd2.CommandText = "UPDATE Respuestas_Usuario SET idpregunta = '" + Preg3 + "', respuesta = '" + Resp3 + "', estado = 'Activo' WHERE id =" + cellValue3 + ";";
                rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se configuraron las Respuestas de seguridad";



            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se configuraron las Respuestas de seguridad";

                return rpta2;



            





         



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




        private bool VerificarSiYaPoseeRespuestas(int id_user)
        {
            bool resp;



            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);

            SqlDataAdapter cmdDataBase = new SqlDataAdapter("select * from Respuestas_Usuario where idusuario = '" + id_user + "' ;", conDataBase);

            DataTable tablita = new DataTable();

            cmdDataBase.Fill(tablita);

            if (tablita.Rows.Count <= 0)
            {
                //MessageBox.Show("Ingrese sus Preguntas/Respuestas");
                resp = false;
            }
            else if (tablita.Rows.Count > 0)
            {
                //MessageBox.Show("Ya posee Preguntas/Respuestas configuradas, si continua, estas serán sobreescritas");
                resp = true;
            }
            else
            {
                MessageBox.Show("ERROR WTF");
                resp = false;
            }


            return resp;

        }

  

        private void Pregunta1Cbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show("cambiaste la pregunta 1 wenaaa");

            int pregunta_repetida = Convert.ToInt32(Pregunta1Cbx.SelectedValue);

            if (Convert.ToInt32(Pregunta2Cbx.SelectedValue) == pregunta_repetida || Convert.ToInt32(Pregunta3Cbx.SelectedValue) == pregunta_repetida)
            {
                MessageBox.Show("No puede seleccionar la misma pregunta!");
                Pregunta1Cbx.SelectedIndex = -1;
            }

        }

        private void Pregunta2Cbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show("cambiaste la pregunta 2 wenaaa");

            int pregunta_repetida = Convert.ToInt32(Pregunta2Cbx.SelectedValue);

            if (Convert.ToInt32(Pregunta1Cbx.SelectedValue) == pregunta_repetida || Convert.ToInt32(Pregunta3Cbx.SelectedValue) == pregunta_repetida)
            {
                MessageBox.Show("No puede seleccionar la misma pregunta!");
                Pregunta2Cbx.SelectedIndex = -1;
            }

        }

        private void Pregunta3Cbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show("cambiaste la pregunta 3 wenaaa");

            int pregunta_repetida = Convert.ToInt32(Pregunta3Cbx.SelectedValue);

            if (Convert.ToInt32(Pregunta1Cbx.SelectedValue) == pregunta_repetida || Convert.ToInt32(Pregunta2Cbx.SelectedValue) == pregunta_repetida)
            {
                MessageBox.Show("No puede seleccionar la misma pregunta!");
                Pregunta3Cbx.SelectedIndex = -1;
            }
        }
    }
}
