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
using CapaDatos;

namespace CapaPresentacion
{
    public partial class frmPlanEstudio : Form
    {

        private bool IsNuevo = false;

        private bool IsEditar = false;

        public static DUsuario Session_Actual = frmPrincipal.User_Actual;


        public frmPlanEstudio()
        {
            InitializeComponent();

            LlenarComboPacientes();

            this.cmbPacientes.SelectedIndex = -1;

            this.ttMensaje.SetToolTip(this.cmbPacientes, "Seleccione el paciente");

            this.ttMensaje.SetToolTip(this.listboxEstudios, "Seleccione los estudios");

            this.btnAnular.Enabled = false;
        }

        private void frmPlanEstudio_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        DataTable dbdataset;

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
            this.txtidPlanEstudio.Text = string.Empty;
            this.cmbPacientes.SelectedIndex = -1;
            this.listboxEstudios.SelectedIndex = -1;



        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtidPlanEstudio.ReadOnly = !valor;
            this.cmbPacientes.Enabled = valor;
            this.listboxEstudios.Enabled = valor;


            //this.btnLimpiar.Enabled = valor;

        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }

        }

        private void LlenarComboPacientes()
        {
            this.cmbPacientes.DataSource = NPacientes.Mostrar();
            cmbPacientes.ValueMember = "idpaciente";
            cmbPacientes.DisplayMember = "nombre";

        }


        //Método para ocultar columnas
        private void OcultarColumnas()
        {

            this.dataListado.Columns[0].Visible = false;
            //this.dataListado.Columns[1].Visible = false;

        }

        //Método Mostrar
        private void Mostrar()
        {


            this.dataListado.DataSource = NPlanEstudio.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Recetas: " + Convert.ToString(dataListado.Rows.Count);
        }



        //Método BuscarPlanEstudio
        private void BuscarPlanEstudio()
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("estudios LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;


            this.OcultarColumnas();


            lblTotal.Text = "Total de Recetas: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarPaciente
        private void BuscarPaciente()
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("paciente LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;


            this.OcultarColumnas();


            lblTotal.Text = "Total de Recetas: " + Convert.ToString(dataListado.Rows.Count);
        }

        // Metodo BuscarPacienteporCedula

            private void BuscarCedulaPaciente() 
        {

           

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.cmbPacientes.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            





            try
            {
                string rpta = "";
                if ( this.listboxEstudios.SelectedIndex == -1 ||
                    string.IsNullOrEmpty(lblCodPac.Text) || this.cmbPacientes.SelectedIndex == -1)
                {
                    MensajeError("No se pueden dejar campos vacios");

                }
                else
                {



                    if (this.IsNuevo)
                    {


                        string estudiosSeleccionados = "";

                        foreach (object estudios in listboxEstudios.SelectedItems)
                        {
                            estudiosSeleccionados += (estudiosSeleccionados == "" ? "" : ", ") + estudios.ToString();


                        }

                        MessageBox.Show(estudiosSeleccionados);


                        // Operacion Insertar

                        //rpta = NPlanEstudio.Insertar(Convert.ToInt32(this.lblCodPac.Text), estudiosSeleccionados);







                    }
                    else
                    {

                                //codigo de editar
                
                    }



                    }

                    if (rpta.Equals("OK"))
                    {




                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el plan de estudio");
                            this.OperacionInsertarPlanEstudio();
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el plan de estudio");
                            this.OperacionEditarPlanEstudio();

                        }

                    }
                    else
                    {


                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.txtidPlanEstudio.Text = "";


                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }




        private void OperacionInsertarPlanEstudio()
        {


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





        }

        private void OperacionEditarPlanEstudio()
        {


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "Se editó una receta");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }

        private void OperacionAnularPlanEstudio()
        {


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "Se anuló una receta");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtidPlanEstudio.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el plan de estudio a Modificar");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cmbTipoReceta.Text.Equals("Paciente"))
            {
                this.BuscarPaciente();

            }
            else
            {

                this.BuscarPlanEstudio();
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            //codigo de Anular registro
        }

        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void cmbPacientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cmbPacientes_DropDownClosed(object sender, EventArgs e)
        {

            if (this.cmbPacientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un paciente de la lista");
            }
            else
            {
                //MessageBox.Show(Convert.ToString(this.cmbPacientes.Text));

                string nombrepac = this.cmbPacientes.Text;


                string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                string Query = "select * from Paciente where nombre = '" + nombrepac + "' ;";
                SqlConnection conDataBase = new SqlConnection(CN);
                SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
                SqlDataReader myReader;

                try
                {

                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();

                    while (myReader.Read())
                    {

                        string idpaciente = myReader["idpaciente"].ToString();
                        string nombre = myReader["nombre"].ToString();

                        //MessageBox.Show(idpaciente);

                        this.lblCodPac.Text = idpaciente;



                    }



                }
                catch (Exception ex)
                {


                }


            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
