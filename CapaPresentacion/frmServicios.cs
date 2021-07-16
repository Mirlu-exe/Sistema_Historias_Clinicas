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
    public partial class frmServicios : Form
    {

        private bool IsNuevo = false;

        private bool IsEditar = false;


        public static DUsuario Session_Actual = frmPrincipal.User_Actual;


        public frmServicios()
        {
            InitializeComponent();

            this.ttMensaje.SetToolTip(this.txtNombreServicio, "Ingrese el Nombre del Servicio");

            this.ttMensaje.SetToolTip(this.txtCosto, "Ingrese el costo del servicio");

            this.btnAnular.Enabled = false;
        }

        private void frmServicios_Load(object sender, EventArgs e)
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
            this.txtidServicio.Text = string.Empty;
            this.txtNombreServicio.Text = string.Empty;
            this.txtCosto.Text = string.Empty;





        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtidServicio.ReadOnly = !valor;
            this.txtNombreServicio.ReadOnly = !valor;
            this.txtCosto.ReadOnly = !valor;






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


        //Método para ocultar columnas
        private void OcultarColumnas()
        {

            this.dataListado.Columns[0].Visible = false;
            //this.dataListado.Columns[1].Visible = false;

        }


        //Método Mostrar
        private void Mostrar()
        {



            this.dataListado.DataSource = NServicio.Mostrar();




            this.OcultarColumnas();
            lblTotal.Text = "Total de Servicios: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarNombre
        private void BuscarNombre()
        {
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("nombre LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/


            this.dataListado.DataSource = NServicio.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();


            lblTotal.Text = "Total de Servicios: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombreServicio.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombreServicio.Text == string.Empty || this.txtCosto.Text == string.Empty)
                {
                    MensajeError("No se pueden dejar campos vacios");

                }
                else
                {




                    if (this.IsNuevo)
                    {


                        rpta = NServicio.Insertar(this.txtNombreServicio.Text.Trim().ToUpper(),
                        Convert.ToDecimal(this.txtCosto.Text),
                        this.cmbEstado.Text);





                        // Operacion Insertar


                        /*SqlConnection SqlCon2 = new SqlConnection();




                        SqlCon2.ConnectionString = Conexion.Cn;
                        SqlCon2.Open();

                        SqlCommand SqlCmd2 = new SqlCommand();
                        SqlCmd2.Connection = SqlCon2;
                        SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





                        SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
                        SqlCmd2.Parameters.AddWithValue("@d2", "Se ha registrado un nuevo diagnostico al sistema");





                        //Ejecutamos nuestro comando

                        rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";*/






                    }
                    else
                    {



                        rpta = NServicio.Editar(Convert.ToInt32(this.txtidServicio.Text), this.txtNombreServicio.Text.Trim().ToUpper(),
                        Convert.ToDecimal(this.txtCosto.Text),
                        this.cmbEstado.Text);





                    }

                    if (rpta.Equals("OK"))
                    {




                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el servicio");
                            this.OperacionInsertarServicio();
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el servicio");
                            this.OperacionEditarServicio();
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
                    this.txtidServicio.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtidServicio.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el servicio a Modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Anular"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnular.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
                this.btnAnular.Enabled = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
                this.btnAnular.Enabled = false;
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtidServicio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idservicio"].Value);
            this.txtNombreServicio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtCosto.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["costo"].Value);
            this.cmbEstado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["estado"].Value);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular los/el servicio?", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NServicio.Anular(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Anuló Correctamente El Servicio");
                                this.OperacionAnularServicio();
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }






                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }





        private void OperacionInsertarServicio()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "Se ha registrado un nuevo servicio al sistema");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionEditarServicio()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "Se editó un servicio");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            



        }



        private void OperacionAnularServicio()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "Se anuló un servicio");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if ((!(char.IsDigit(ch))) && Convert.ToInt32(ch) != 8)
            {
                e.Handled = true;

            }
            else if (char.IsControl(ch))
            {
                e.Handled = false;
            }
        }









    }


}
