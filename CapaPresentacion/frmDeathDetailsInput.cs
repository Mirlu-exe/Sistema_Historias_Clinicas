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
    public partial class frmDeathDetailsInput : Form
    {
        public frmDeathDetailsInput(string id_pac_muerto)
        {
            InitializeComponent();

            this.lblidpac.Text = id_pac_muerto;
        }

        private void frmDeathDetailsInput_Load(object sender, EventArgs e)
        {
            MostrarInformacionPacienteMuerto();



        }

        //Método Mostrar
        private void MostrarInformacionPacienteMuerto()
        {

            DataTable dbdataset;

            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            SqlCommand cmdDataBase = new SqlCommand("Select * from Paciente where idpaciente = " + this.lblidpac.Text + "", conDataBase);





            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dgv_Paciente_fallecido.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error" + ex);
            }

        }

        private void btnGuardarDeathDetails_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string rpta_estadomuerto = "";

                    string rpta_detallesmuerte = "";

                    if (string.IsNullOrEmpty(this.txtCausaMuerte.Text) )

                    {
                        MessageBox.Show("No se pueden dejar campos vacios");

                    }


                    // Cambiar el estado de is_dead en el registro del Paciente.
                    rpta_estadomuerto = NPacientes.CambiarEstadoMuerto(Convert.ToInt32(this.lblidpac.Text));

                    InsertarFichaFallecido(); //aca es donde se ingresa la ficha de fallecimiento en la tabla DeathDetails


                    if (rpta_estadomuerto.Equals("OK"))
                    {
                    MessageBox.Show("Se ha movido el Paciente al Archivo Muerto exitosamente.");
                    this.OperacionPacienteMuerto();
                    }
                        
                    else
                    {
                    MessageBox.Show(rpta_estadomuerto);
                    MessageBox.Show(rpta_detallesmuerte);
                    }



                    //cerrar ventana
                    this.Close();


                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            



        }



        private void InsertarFichaFallecido()
        {


            // Operacion InsertarFichaFallecido en la tabla DeathDetails
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into DeathDetails (id_Paciente, fecha_muerte, causa_muerte) values (@d1,@d2,@d3)";





            SqlCmd2.Parameters.AddWithValue("@d1", this.lblidpac.Text);
            SqlCmd2.Parameters.AddWithValue("@d2", this.dtp_FechaMuerte.Value);
            SqlCmd2.Parameters.AddWithValue("@d3", this.txtCausaMuerte.Text);





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro en DeathDetails";




        }

        private void OperacionPacienteMuerto()
        {

            // Operacion PacienteMuerto
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();


            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";


            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "Se ha movido un paciente al Archivo Muerto");


            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

        }




    }
}
