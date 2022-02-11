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
using CapaPresentacion.Reportes;

namespace CapaPresentacion
{
    public partial class frmEstudios : Form
    {

        private bool IsNuevo = false;

        private bool IsEditar = false;


        public static DUsuario Session_Actual = frmPrincipal.User_Actual;


        public frmEstudios()
        {
            InitializeComponent();

            this.ttMensaje.SetToolTip(this.txtNombreEstudio, "Ingrese nombre del estudio");

            this.btnAnular.Enabled = false;

        }

        private void frmEstudios_Load(object sender, EventArgs e)
        {


            this.Deshabilitar();
            this.Botones();

            this.Mostrar();


            lblTotal.Text = "Total de Estudios: " + Convert.ToString(dataListado.Rows.Count);

            this.OcultarColumnas();

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

            this.txtNombreEstudio.Text = string.Empty;
            this.btnBuscar.Text = string.Empty;

        }

        //Habilitar los controles del formulario
        private void Habilitar()
        {
            this.txtBuscar.Enabled = true;
            this.txtBuscar.Enabled = true;


        }

        //Deshabilitar los controles del formulario
        private void Deshabilitar()
        {
            this.txtBuscar.Enabled = false;
            this.txtBuscar.Enabled = false;


        }



        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar();
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Deshabilitar();
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }

        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {

            this.dataListado.Columns["id"].Visible = false;
            this.dataListado.Columns["estado"].Visible = false;
        }


        //Método Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NEstudio.Mostrar();

            this.OcultarColumnas();
            if (dataListado.Rows.Count == 0) { MessageBox.Show("Actualmente no tiene ningun registro"); }
            lblTotal.Text = "Total de Estudios: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarMedicamento
        private void BuscarEstudio()
        {

            this.dataListado.DataSource = NEstudio.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();


            lblTotal.Text = "Total de Estudio: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombreEstudio.Text == string.Empty )
                {
                    MensajeError("No se pueden dejar campos vacios");

                }
                else
                {



                    if (this.IsNuevo)
                    {


                        rpta = NEstudio.Insertar(this.txtNombreEstudio.Text.Trim().ToUpper(), "Activo");





                        //rpta = OperacionInsertar_Estudio();




                    }
                    else
                    {



                        //rpta = NEstudio.Editar(Convert.ToInt32(this.txtidReceta.Text), this.txtMedicamento.Text.Trim().ToUpper(), this.txtPresentacion.Text.Trim().ToUpper(), this.txtDosis.Text.Trim().ToUpper());





                    }

                    if (rpta.Equals("OK"))
                    {




                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el estudio");
                            //this.OperacionInsertarReceta();
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el estudio");
                            //this.OperacionEditarReceta();

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


                    lblTotal.Text = "Total de Estudios: " + Convert.ToString(dataListado.Rows.Count);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Deshabilitar();
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
            this.BuscarEstudio();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarEstudio();
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
            //this.txtidReceta.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["id"].Value);
            this.txtNombreEstudio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells[1].Value);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular el/los estudios?", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NEstudio.Anular(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Anuló Correctamente el estudio");
                                //this.OperacionAnularEstudio();
                                this.Mostrar();
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }


                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporteEstudios frm = new frmReporteEstudios();
            frm.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Deshabilitar();
        }
    }
}
