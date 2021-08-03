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
            SqlCommand cmdDataBase = new SqlCommand("SELECT Historia.idhistoria, Historia.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Historia.fecha_consulta, Historia.razon_consulta, Historia.enfermedad_actual, Historia.historia_familiar, Historia.historia_personal, Historia.tratamiento_actual, Historia.examen_fisico, Historia.ecg, Historia.laboratorio, Historia.rayos_x, Historia.ecocardiograma, Historia.plan_estudio, Historia.plan_terapeutico, Historia.estado, Historia.diagnosticos FROM Paciente INNER JOIN Historia ON Paciente.idpaciente = Historia.idpaciente where Historia.estado = 'Inactivo'; ", conDataBase);





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

     /*   private void buscarCedula() 
       {

            string cedula_del_pac = this.txtNumero_Documento.Text;

            DataTable paciente_tabla = new DataTable();

            paciente_tabla = NPacientes.Mostrar();

            DataView DV = new DataView(paciente_tabla);

            DV.RowFilter = string.Format("estado = 'Inactivo'");

            


            int id_del_pac = 0;

            if (paciente_tabla.Rows.Count == 0)
            {
                MessageBox.Show("no existe ese paciente");
                id_del_pac = 0;
            }
            else
            {

                id_del_pac = Convert.ToInt32(paciente_tabla.Rows[0][0]);
                string nombre_del_pac = Convert.ToString(paciente_tabla.Rows[0][1]);
                string sexo_del_pac = Convert.ToString(paciente_tabla.Rows[0][5]);

                this.txtNombre_Paciente.Text = nombre_del_pac;
                //this.txtSexo.Text = sexo_del_pac;



                //lblTotal.Text = "Total de Pacientes: " + Convert.ToString(paciente_tabla.Rows.Count);
            }

            return id_del_pac;

        }

        /** filtro citas con fechas y activos
        string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
        SqlConnection conDataBase = new SqlConnection(Cn);
        SqlCommand cmdDataBase = new SqlCommand("select from paciente where estado= 'inactivo'", conDataBase);
        
        try
        {

            string Citashoy = DateTime.Now.ToShortDateString();

            // MessageBox.Show("hoy es: " + Citashoy + " :)");

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmdDataBase;
            DataTable tablita = new DataTable();
            sda.Fill(tablita);
            BindingSource bSource = new BindingSource();

            bSource.DataSource = tablita;
            datalistadoMuertos.DataSource = bSource;
            sda.Update(tablita);

            DataView DV = new DataView(tablita);

            //DV.RowFilter = string.Format("fecha LIKE '%{0}' AND estado = 'Activo'", Citashoy);

            datalistadoMuertos.DataSource = DV;




        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());

            MessageBox.Show("Ha ocurrido un error");
        }

        */

    

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage4"])
            {
                datalistadoMuertos.Columns["idhistoria"].Visible = false;
                datalistadoMuertos.Columns["idpaciente"].Visible = false;
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }




        private int Buscar_idPac_por_cedula()
        {

            string ci_pac_muerto = this.txtcedulabuscar.Text;

            int id_pac_muerto = 0;

            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            SqlCommand cmdDataBase = new SqlCommand("select idpaciente from Paciente where num_cedula like '" + ci_pac_muerto + "' ; ", conDataBase);





            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable tablita = new DataTable();
                sda.Fill(tablita);

                id_pac_muerto = Convert.ToInt32(tablita.Rows[0][0]);

                MessageBox.Show("holiwis el id del paciente muerto es " + id_pac_muerto.ToString() + " :D");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error");

                MessageBox.Show(ex.ToString());
            }


            return id_pac_muerto;


        }

        private void Traer_info_por_id_paciente( int id_pac_muerto)
        {


            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            SqlCommand cmdDataBase = new SqlCommand("SELECT Historia.idhistoria, Historia.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Historia.fecha_consulta, Historia.razon_consulta, Historia.enfermedad_actual, Historia.historia_familiar, Historia.historia_personal, Historia.tratamiento_actual, Historia.examen_fisico, Historia.ecg, Historia.laboratorio, Historia.rayos_x, Historia.ecocardiograma, Historia.plan_estudio, Historia.plan_terapeutico, Historia.estado, Historia.diagnosticos FROM Paciente INNER JOIN Historia ON Paciente.idpaciente = Historia.idpaciente WHERE Historia.idpaciente =  '" + id_pac_muerto + "' ; ", conDataBase);





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

                MessageBox.Show("holiwis");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error");

                MessageBox.Show(ex.ToString());
            }




        }

        private void datalistadoMuertos_DoubleClick(object sender, EventArgs e)
        {

            // tengo que hacer un if aca para validar que el campo esta vacio !!

            if (datalistadoMuertos.Rows != null && datalistadoMuertos.Rows.Count != 0)
            {


                //this.txtIdpaciente.Text = Convert.ToString(this.dataListadoMuertos.CurrentRow.Cells["idpaciente"].Value);
                this.txtNombre_Paciente.Text = Convert.ToString(this.datalistadoMuertos.CurrentRow.Cells["nombre"].Value);
                this.cblTipo_Documento.Text = Convert.ToString(this.datalistadoMuertos.CurrentRow.Cells["tipo_cedula"].Value);
                this.txtNumero_Documento.Text = Convert.ToString(this.datalistadoMuertos.CurrentRow.Cells["num_cedula"].Value);
                this.dtpFecha_Nacimiento.Value = Convert.ToDateTime(this.datalistadoMuertos.CurrentRow.Cells["fecha_nacimiento"].Value);
                this.cblSexo.Text = Convert.ToString(this.datalistadoMuertos.CurrentRow.Cells["sexo"].Value);

                //this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
                this.txtOcupacion.Text = Convert.ToString(this.datalistadoMuertos.CurrentRow.Cells["ocupacion"].Value);
                this.txtTelefono.Text = Convert.ToString(this.datalistadoMuertos.CurrentRow.Cells["telefono"].Value);
                //this.txtCorreo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["correo"].Value);



                this.txtMostrarPeso.Text = Convert.ToString(this.datalistadoMuertos.CurrentRow.Cells["peso"].Value);
                this.txtMostrarTalla.Text = Convert.ToString(this.datalistadoMuertos.CurrentRow.Cells["talla"].Value);
                //this.cblEstado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["estado"].Value);


                
            }
            else
            {

                MessageBox.Show("ERROR!! La lista esta vacia, por favor revise bien las credenciales que desea buscar");

            }

        }



    }
}
