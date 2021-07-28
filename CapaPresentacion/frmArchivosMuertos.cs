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
using System.Text.RegularExpressions;
using CapaDatos;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class frmArchivosMuertos : Form
    {
        public frmArchivosMuertos()
        {
            InitializeComponent();
        }

        private void frmArchivosMuertos_Load(object sender, EventArgs e)
        {
            this.MostrarHistoriasAnuladas();



        }


        //Método Mostrar
        private void MostrarHistoriasAnuladas()
        {


            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("SELECT Historia.idhistoria, Historia.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Historia.fecha_consulta, Historia.razon_consulta, Historia.enfermedad_actual, Historia.historia_familiar, Historia.historia_personal, Historia.tratamiento_actual, Historia.examen_fisico, Historia.ecg, Historia.laboratorio, Historia.rayos_x, Historia.ecocardiograma, Historia.plan_estudio, Historia.plan_terapeutico, Historia.estado FROM Paciente INNER JOIN Historia ON Paciente.idpaciente = Historia.idpaciente where Historia.estado = 'Inactivo'; ", conDataBase);





            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadoMuertos.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }




            lblCantidadArchivosMuertos.Text = "Total de Historias: " + Convert.ToString(datalistadoMuertos.Rows.Count);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage4"])
            {
                datalistadoMuertos.Columns["idhistoria"].Visible = false;
                datalistadoMuertos.Columns["idpaciente"].Visible = false;
            }
        }
    }
}
