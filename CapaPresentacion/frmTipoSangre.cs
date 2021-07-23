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
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmTipoSangre : Form
    {

        DataTable dbdataset;


        public frmTipoSangre()
        {
            InitializeComponent();
        }

        private void frmTipoSangre_Load(object sender, EventArgs e)
        {
            this.MostrarHistoriasActivas();
            this.Top = 0;
            this.Left = 0;
        }

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

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {





        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {

            //this.datalistadohistorias.Columns[0].Visible = false;


        }


        //Método Mostrar
        private void MostrarHistoriasActivas()
        {


            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("select Historia.idhistoria, Historia.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Paciente.direccion, Paciente.telefono, Paciente.correo, Historia.fecha_consulta, Historia.estado, Historia.tipo_sangre, Historia.diagnosticos FROM Paciente INNER JOIN Historia ON Paciente.idpaciente = Historia.idpaciente where Historia.estado = 'Activo' and Paciente.estado = 'Activo'; ", conDataBase);





            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadohistorias.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }






            lblTotalHistorias.Text = "Total de Historias : " + Convert.ToString(datalistadohistorias.Rows.Count);
        }



        //Método Mostrar
        private void MostrarPacientesAPositivo()
        {


            string Cn2 = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase2 = new SqlConnection(Cn2);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase2 = new SqlCommand("select Historia.idhistoria, Historia.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Paciente.direccion, Paciente.telefono, Paciente.correo, Historia.tipo_sangre, Historia.diagnosticos FROM Paciente INNER JOIN Historia ON Paciente.idpaciente = Historia.idpaciente where Historia.estado = 'Activo' and Historia.tipo_sangre = 'O+' and Historia.idpaciente != '" + Convert.ToInt32(this.lblCodigoPaciente.Text) + "' and Paciente.estado = 'Activo' or Historia.tipo_sangre = 'O-' or Historia.tipo_sangre = 'A+' or Historia.tipo_sangre = 'A-'; ", conDataBase2);





            try
            {

                SqlDataAdapter sda2 = new SqlDataAdapter();
                sda2.SelectCommand = cmdDataBase2;
                dbdataset = new DataTable();
                sda2.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadohistorias2.DataSource = bSource;
                sda2.Update(dbdataset);


            }
            catch (Exception ex)
            {


                //MessageBox.Show("Ha ocurrido un error");
                MessageBox.Show(ex.Message);

            }






            lblTotalPacientes.Text = "Total de Pacientes compatibles : " + Convert.ToString(datalistadohistorias2.Rows.Count);
        }



        //Método Mostrar
        private void MostrarPacientesANegativo()
        {

            string Cn2 = "Data Source=Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase2 = new SqlConnection(Cn2);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase2 = new SqlCommand("select Historia.idhistoria, Historia.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Paciente.direccion, Paciente.telefono, Paciente.correo, Historia.tipo_sangre, Historia.diagnosticos FROM Paciente INNER JOIN Historia ON Paciente.idpaciente = Historia.idpaciente where Historia.estado = 'Activo' and Historia.tipo_sangre = 'A-' and Historia.idpaciente != '" + Convert.ToInt32(this.lblCodigoPaciente.Text) + "' and Paciente.estado = 'Activo' or Historia.tipo_sangre = 'O-'; ", conDataBase2);





            try
            {

                SqlDataAdapter sda2 = new SqlDataAdapter();
                sda2.SelectCommand = cmdDataBase2;
                dbdataset = new DataTable();
                sda2.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadohistorias2.DataSource = bSource;
                sda2.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }






            lblTotalPacientes.Text = "Total de Pacientes compatibles : " + Convert.ToString(datalistadohistorias2.Rows.Count);
        }


        //Método Mostrar
        private void MostrarPacientesBPositivo()
        {


            string Cn2 = "Data Source=Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase2 = new SqlConnection(Cn2);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase2 = new SqlCommand("select Historia.idhistoria, Historia.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Paciente.direccion, Paciente.telefono, Paciente.correo, Historia.tipo_sangre, Historia.diagnosticos FROM Paciente INNER JOIN Historia ON Paciente.idpaciente = Historia.idpaciente where Historia.estado = 'Activo' and Historia.tipo_sangre = 'B+' and Historia.idpaciente != '" + Convert.ToInt32(this.lblCodigoPaciente.Text) + "' and Paciente.estado = 'Activo' or Historia.tipo_sangre = 'B-' or Historia.tipo_sangre = 'O+' or Historia.tipo_sangre = 'O-' ; ", conDataBase2);





            try
            {

                SqlDataAdapter sda2 = new SqlDataAdapter();
                sda2.SelectCommand = cmdDataBase2;
                dbdataset = new DataTable();
                sda2.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadohistorias2.DataSource = bSource;
                sda2.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }






            lblTotalPacientes.Text = "Total de Pacientes compatibles : " + Convert.ToString(datalistadohistorias2.Rows.Count);
        }



        //Método Mostrar
        private void MostrarPacientesBNegativo()
        {


            string Cn2 = "Data Source=Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase2 = new SqlConnection(Cn2);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase2 = new SqlCommand("select Historia.idhistoria, Historia.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Paciente.direccion, Paciente.telefono, Paciente.correo, Historia.tipo_sangre, Historia.diagnosticos FROM Paciente INNER JOIN Historia ON Paciente.idpaciente = Historia.idpaciente where Historia.estado = 'Activo' and Historia.tipo_sangre = 'B-' and Historia.idpaciente != '" + Convert.ToInt32(this.lblCodigoPaciente.Text) + "' and Paciente.estado = 'Activo' or Historia.tipo_sangre = 'O-' ; ", conDataBase2);





            try
            {

                SqlDataAdapter sda2 = new SqlDataAdapter();
                sda2.SelectCommand = cmdDataBase2;
                dbdataset = new DataTable();
                sda2.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadohistorias2.DataSource = bSource;
                sda2.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }






            lblTotalPacientes.Text = "Total de Pacientes compatibles : " + Convert.ToString(datalistadohistorias2.Rows.Count);
        }



        //Método Mostrar
        private void MostrarPacientesABPositivo()
        {


            string Cn2 = "Data Source=Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase2 = new SqlConnection(Cn2);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase2 = new SqlCommand("select Historia.idhistoria, Historia.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Paciente.direccion, Paciente.telefono, Paciente.correo, Historia.tipo_sangre, Historia.diagnosticos FROM Paciente INNER JOIN Historia ON Paciente.idpaciente = Historia.idpaciente where Historia.estado = 'Activo' and Historia.tipo_sangre = 'A+' and Historia.idpaciente != '" + Convert.ToInt32(this.lblCodigoPaciente.Text) + "' and Paciente.estado = 'Activo' or Historia.tipo_sangre = 'A-' or Historia.tipo_sangre = 'B+' or Historia.tipo_sangre = 'B-' or Historia.tipo_sangre = 'AB+' or Historia.tipo_sangre = 'AB-' or Historia.tipo_sangre = 'O+' or Historia.tipo_sangre = 'O-'; ", conDataBase2);





            try
            {

                SqlDataAdapter sda2 = new SqlDataAdapter();
                sda2.SelectCommand = cmdDataBase2;
                dbdataset = new DataTable();
                sda2.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadohistorias2.DataSource = bSource;
                sda2.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }






            lblTotalPacientes.Text = "Total de Pacientes compatibles : " + Convert.ToString(datalistadohistorias2.Rows.Count);

        }



        //Método Mostrar
        private void MostrarPacientesABNegativo()
        {


            string Cn2 = "Data Source=Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase2 = new SqlConnection(Cn2);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase2 = new SqlCommand("select Historia.idhistoria, Historia.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Paciente.direccion, Paciente.telefono, Paciente.correo, Historia.tipo_sangre, Historia.diagnosticos FROM Paciente INNER JOIN Historia ON Paciente.idpaciente = Historia.idpaciente where Historia.estado = 'Activo' and Historia.tipo_sangre = 'A-' and Historia.idpaciente != '" + Convert.ToInt32(this.lblCodigoPaciente.Text) + "' and Paciente.estado = 'Activo' or Historia.tipo_sangre = 'B-' or Historia.tipo_sangre = 'AB-' or Historia.tipo_sangre = 'O-'; ", conDataBase2);





            try
            {

                SqlDataAdapter sda2 = new SqlDataAdapter();
                sda2.SelectCommand = cmdDataBase2;
                dbdataset = new DataTable();
                sda2.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadohistorias2.DataSource = bSource;
                sda2.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }






            lblTotalPacientes.Text = "Total de Pacientes compatibles : " + Convert.ToString(datalistadohistorias2.Rows.Count);
        }



        //Método Mostrar
        private void MostrarPacientesOPositivo()
        {

            string Cn2 = "Data Source=Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase2 = new SqlConnection(Cn2);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase2 = new SqlCommand("select Historia.idhistoria, Historia.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Paciente.direccion, Paciente.telefono, Paciente.correo, Historia.tipo_sangre, Historia.diagnosticos FROM Paciente INNER JOIN Historia ON Paciente.idpaciente = Historia.idpaciente where Historia.estado = 'Activo' and Historia.tipo_sangre = 'O+' and Historia.idpaciente != '" + Convert.ToInt32(this.lblCodigoPaciente.Text) + "' and Paciente.estado = 'Activo' or Historia.tipo_sangre = 'O-'; ", conDataBase2);





            try
            {

                SqlDataAdapter sda2 = new SqlDataAdapter();
                sda2.SelectCommand = cmdDataBase2;
                dbdataset = new DataTable();
                sda2.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadohistorias2.DataSource = bSource;
                sda2.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }






            lblTotalPacientes.Text = "Total de Pacientes compatibles : " + Convert.ToString(datalistadohistorias2.Rows.Count);
        }



        //Método Mostrar
        private void MostrarPacientesONegativo()
        {


            string Cn2 = "Data Source=Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase2 = new SqlConnection(Cn2);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase2 = new SqlCommand("select Historia.idhistoria, Historia.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Paciente.direccion, Paciente.telefono, Paciente.correo, Historia.tipo_sangre, Historia.diagnosticos FROM Paciente INNER JOIN Historia ON Paciente.idpaciente = Historia.idpaciente where Historia.estado = 'Activo' and Historia.idpaciente != '" + Convert.ToInt32(this.lblCodigoPaciente.Text) + "' and Historia.tipo_sangre = 'O-' and Paciente.estado = 'Activo'; ", conDataBase2);





            try
            {

                SqlDataAdapter sda2 = new SqlDataAdapter();
                sda2.SelectCommand = cmdDataBase2;
                dbdataset = new DataTable();
                sda2.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadohistorias2.DataSource = bSource;
                sda2.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }






            lblTotalPacientes.Text = "Total de Pacientes compatibles : " + Convert.ToString(datalistadohistorias2.Rows.Count);
        }

        private void datalistadohistorias_DoubleClick(object sender, EventArgs e)
        {
            this.lblCodigoHistoria.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["idhistoria"].Value);
            this.lblCodigoPaciente.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["idpaciente"].Value);
            this.txtPaciente.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["Paciente"].Value);
            this.cblTipo_Documento.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["tipo_cedula"].Value);
            this.txtNumero_Documento.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["num_cedula"].Value);
            this.txtDireccion.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["direccion"].Value);
            this.txtTelefono.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["telefono"].Value);
            this.txtCorreo.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["correo"].Value);
            this.cblTipo_Sangre.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["tipo_sangre"].Value);
        }

        private void btnBuscarCompatibles_Click(object sender, EventArgs e)
        {
            if (this.cblTipo_Sangre.Text.Equals("A+"))
            {
                MostrarPacientesAPositivo();

            }
            else if (this.cblTipo_Sangre.Text.Equals("A-"))
            {
                MostrarPacientesANegativo();
            }
            else if (this.cblTipo_Sangre.Text.Equals("B+"))
            {
                MostrarPacientesBPositivo();
            }
            else if (this.cblTipo_Sangre.Text.Equals("B-"))
            {
                MostrarPacientesBNegativo();
            }
            else if (this.cblTipo_Sangre.Text.Equals("AB+"))
            {
                MostrarPacientesABPositivo();
            }
            else if (this.cblTipo_Sangre.Text.Equals("AB-"))
            {
                MostrarPacientesABNegativo();
            }
            else if (this.cblTipo_Sangre.Text.Equals("O+"))
            {
                MostrarPacientesOPositivo();
            }
            else if (this.cblTipo_Sangre.Text.Equals("O-"))
            {
                MostrarPacientesONegativo();
            }
        }

        private void datalistadohistorias2_DoubleClick(object sender, EventArgs e)
        {
            this.lblCodigoHistoria2.Text = Convert.ToString(this.datalistadohistorias2.CurrentRow.Cells["idhistoria"].Value);
            this.lblCodigoPaciente2.Text = Convert.ToString(this.datalistadohistorias2.CurrentRow.Cells["idpaciente"].Value);
            this.txtPaciente2.Text = Convert.ToString(this.datalistadohistorias2.CurrentRow.Cells["Paciente"].Value);
            this.cblTipo_Documento2.Text = Convert.ToString(this.datalistadohistorias2.CurrentRow.Cells["tipo_cedula"].Value);
            this.txtNumero_Documento2.Text = Convert.ToString(this.datalistadohistorias2.CurrentRow.Cells["num_cedula"].Value);
            this.txtDireccion2.Text = Convert.ToString(this.datalistadohistorias2.CurrentRow.Cells["direccion"].Value);
            this.txtTelefono2.Text = Convert.ToString(this.datalistadohistorias2.CurrentRow.Cells["telefono"].Value);
            this.txtCorreo2.Text = Convert.ToString(this.datalistadohistorias2.CurrentRow.Cells["correo"].Value);
            this.cblTipo_Sangre2.Text = Convert.ToString(this.datalistadohistorias2.CurrentRow.Cells["tipo_sangre"].Value);
        }


    }
}
