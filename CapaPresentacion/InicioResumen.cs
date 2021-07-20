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


using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class InicioResumen : Form
    {
        string cantidadPacientes;


        public InicioResumen()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnAyuda, "Ayuda");
        
        }


        public static DUsuario Session_Actual = frmPrincipal.User_Actual;



        private void InicioResumen_Load(object sender, EventArgs e)
        {
            cantidadpacientes();
            cantidadusuarios();
            cantidadcitas();
            cantidadhistorias();
            cantidaddiagnosticos();
            cantidadservicios();
            cantidadrecetas();
        }


        public void cantidadpacientes()
        {

            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select count(*) AS Cantidad from Paciente where estado = 'Activo' ;";
            SqlConnection conDataBase = new SqlConnection(CN);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader Lectura;

            try
            {

                conDataBase.Open();
                Lectura = cmdDataBase.ExecuteReader();

                while (Lectura.Read())
                {

                    lblcantidadpacientes.Text = Lectura["Cantidad"].ToString();



                }



            }
            catch (Exception ex)
            {


            }
        }

        public void cantidadusuarios()
        {

            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select count(*) AS Cantidad from Usuario where estado = 'Activo' ;";
            SqlConnection conDataBase = new SqlConnection(CN);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader Lectura;

            try
            {

                conDataBase.Open();
                Lectura = cmdDataBase.ExecuteReader();

                while (Lectura.Read())
                {

                    lblcantidadusuarios.Text = Lectura["Cantidad"].ToString();



                }



            }
            catch (Exception ex)
            {


            }
        }


        public void cantidadcitas()
        {

            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select count(*) AS Cantidad from Cita where estado = 'Activo' ;";
            SqlConnection conDataBase = new SqlConnection(CN);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader Lectura;

            try
            {

                conDataBase.Open();
                Lectura = cmdDataBase.ExecuteReader();

                while (Lectura.Read())
                {

                    lblcitasactivas.Text = Lectura["Cantidad"].ToString();



                }



            }
            catch (Exception ex)
            {


            }
        }


        public void cantidadhistorias()
        {

            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select count(*) AS Cantidad from Historia where estado = 'Activo' ;";
            SqlConnection conDataBase = new SqlConnection(CN);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader Lectura;

            try
            {

                conDataBase.Open();
                Lectura = cmdDataBase.ExecuteReader();

                while (Lectura.Read())
                {

                    lblhistoriasactivas.Text = Lectura["Cantidad"].ToString();



                }



            }
            catch (Exception ex)
            {


            }
        }


        public void cantidaddiagnosticos()
        {

            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select count(*) AS Cantidad from Diagnostico;";
            SqlConnection conDataBase = new SqlConnection(CN);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader Lectura;

            try
            {

                conDataBase.Open();
                Lectura = cmdDataBase.ExecuteReader();

                while (Lectura.Read())
                {

                    lbldiagnosticos.Text = Lectura["Cantidad"].ToString();



                }



            }
            catch (Exception ex)
            {


            }
        }



        public void cantidadservicios()
        {

            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select count(*) AS Cantidad from Servicio;";
            SqlConnection conDataBase = new SqlConnection(CN);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader Lectura;

            try
            {

                conDataBase.Open();
                Lectura = cmdDataBase.ExecuteReader();

                while (Lectura.Read())
                {

                    lblservicios.Text = Lectura["Cantidad"].ToString();



                }



            }
            catch (Exception ex)
            {


            }
        }


        public void cantidadrecetas()
        {

            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select count(*) AS Cantidad from Receta;";
            SqlConnection conDataBase = new SqlConnection(CN);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader Lectura;

            try
            {

                conDataBase.Open();
                Lectura = cmdDataBase.ExecuteReader();

                while (Lectura.Read())
                {

                    lblRecetas.Text = Lectura["Cantidad"].ToString();



                }



            }
            catch (Exception ex)
            {


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }


        private void btnAyuda_Click(object sender, EventArgs e)
        {

            frmModuloAyuda frm = new frmModuloAyuda();

            frm.ShowDialog();

        }

        private void btnAyuda_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.btnAyuda, "Ayuda");
        }
    }
}
