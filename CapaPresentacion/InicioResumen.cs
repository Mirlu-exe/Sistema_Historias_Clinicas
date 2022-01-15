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
using System.Text.RegularExpressions;


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
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Cita' Puede moverla o quitarla según sea necesario.
            this.citaTableAdapter.Fill(this.dsPrincipal.Cita);
            cantidadpacientes();
            cantidadusuarios();
            cantidadcitas();
            cantidadhistorias();
            cantidaddiagnosticos();
            cantidadservicios();
            cantidadrecetas();

            ContarCitasParaHoy();

        }



        public void cantidadpacientes()
        {

            string CN = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
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

            string CN = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
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


            string CN = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select count(*) AS Cantidad from Cita where estado = 'Activo'";
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

            string CN = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
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

            string CN = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
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

            string CN = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
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

            string CN = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select count(*) AS Cantidad from Medicamentos_Pivote;";
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



        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btnCuposDisponiblesHoy_Click(object sender, EventArgs e)
        {

           
        }

        
        private void ContarCitasParaHoy()
        {
          

            string Cn = "Data Source=ADRIAN-PC\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.num_cedula, Paciente.telefono, Paciente.nombre as Paciente, Cita.idusuario, Usuario.login, Cita.fecha, Cita.idservicio, Servicio.nombre as Servicio, Cita.Estado from Cita INNER JOIN dbo.Paciente ON dbo.Cita.idpaciente = dbo.Paciente.idpaciente INNER JOIN dbo.Servicio ON dbo.Cita.idservicio = dbo.Servicio.idservicio INNER JOIN dbo.Usuario ON dbo.Cita.idusuario = dbo.Usuario.idusuario where fecha LIKE '" + DateTime.Now.ToShortDateString() + "' AND Cita.estado = 'Activo'", conDataBase);

            try
            {

                string Citashoy = DateTime.Now.ToShortDateString();

                // MessageBox.Show("hoy es: " + Citashoy + " :)");

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable tablita = new DataTable();
                sda.Fill(tablita);


                //contar los row desde aqui!!! ojo
                int citas_para_hoy = tablita.Rows.Count;



                int cant_max_cupos = 5;

                int total_cupos_disponibles = (cant_max_cupos - citas_para_hoy);

                btnCuposDisponiblesHoy.Text = "Para el día de hoy hay " + Convert.ToString(total_cupos_disponibles) + " cupos disponibles!!";
                 
                if (total_cupos_disponibles == 0 ) 
                {

                    btnCuposAgotados.Visible = true;

                    btnCuposDisponiblesHoy.Visible = false;
                }
                else 
                {

                    btnCuposAgotados.Visible = false;

                    btnCuposDisponiblesHoy.Visible = true;


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                MessageBox.Show("Ha ocurrido un error");
            }




        }

        private void btnCuposAgotados_Click(object sender, EventArgs e)
        {

            MessageBox.Show("No hay mas cupos disponibles!!, intente otro dia por favor");

        }


    }
}
