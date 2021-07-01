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

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmOperacion : Form
    {


        public DataTable dbdataset;



        SqlDataReader dr;




        public frmOperacion()
        {
            InitializeComponent();

        }

        private void frmOperacion_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.lblNombreUsuario.Hide();
            this.txtNombre.Hide();

            this.lblFecha.Hide();
            this.dtpFecha.Hide();

            this.lblSuceso.Hide();
            this.cbSuceso.Hide();
        }

        //Método Mostrar
        private void Mostrar()
        {

            this.datalistadoOperaciones.DataSource = NOperacion.Mostrar();



            lblCantidadOperaciones.Text = "Total de Operaciones: " + Convert.ToString(datalistadoOperaciones.Rows.Count);
        }



        //Método BuscarFecha
        private void BuscarFecha()
        {
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("nombre LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/




            lblCantidadOperaciones.Text = "Total de Operaciones: " + Convert.ToString(datalistadoOperaciones.Rows.Count);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cblBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Nombre"))
            {
                this.lblNombreUsuario.Show();
                this.txtNombre.Show();

                this.lblFecha.Hide();
                this.dtpFecha.Hide();

                this.lblSuceso.Hide();
                this.cbSuceso.Hide();

                this.BuscarSegunNombreUsuario();
            }
            else if (this.cblBusqueda.Text.Equals("Fecha"))
            {
                this.lblFecha.Show();
                this.dtpFecha.Show();

                this.lblNombreUsuario.Hide();
                this.txtNombre.Hide();

                this.lblSuceso.Hide();
                this.cbSuceso.Hide();

                this.BuscarSegunFecha();
            }
            else if (this.cblBusqueda.Text.Equals("Suceso"))
            {
                this.lblSuceso.Show();
                this.cbSuceso.Show();

                this.lblNombreUsuario.Hide();
                this.txtNombre.Hide();

                this.lblFecha.Hide();
                this.dtpFecha.Hide();

                this.BuscarSegunSuceso();
            }
        }


        //Método BuscarSegunNombreUsuario
        private void BuscarSegunNombreUsuario()
        {

           DataView DV = new DataView(NOperacion.Mostrar());
           DV.RowFilter = string.Format("descripcion LIKE '%{0}%'", this.txtNombre.Text);
           datalistadoOperaciones.DataSource = DV;


            lblCantidadOperaciones.Text = "Total de Operaciones: " + Convert.ToString(datalistadoOperaciones.Rows.Count);

        }

        //Método BuscarSegunFecha
        private void BuscarSegunFecha()
        {
            DataView DV = new DataView(NOperacion.Mostrar());
            DV.RowFilter = string.Format("fecha LIKE '%{0}%'", this.dtpFecha.Text);
            datalistadoOperaciones.DataSource = DV;


            lblCantidadOperaciones.Text = "Total de Operaciones: " + Convert.ToString(datalistadoOperaciones.Rows.Count);

        }

        //Método BuscarSegunSuceso
        private void BuscarSegunSuceso()
        {

            DataView DV = new DataView(NOperacion.Mostrar());
            DV.RowFilter = string.Format("descripcion LIKE '%{0}%'", this.cbSuceso.Text);
            datalistadoOperaciones.DataSource = DV;


            lblCantidadOperaciones.Text = "Total de Operaciones: " + Convert.ToString(datalistadoOperaciones.Rows.Count);

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Nombre"))
            {
                this.lblNombreUsuario.Show();
                this.txtNombre.Show();

                this.lblFecha.Hide();
                this.dtpFecha.Hide();

                this.BuscarSegunNombreUsuario();
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
           if (this.cblBusqueda.Text.Equals("Fecha"))
            {
                this.lblFecha.Show();
                this.dtpFecha.Show();

                this.lblNombreUsuario.Hide();
                this.txtNombre.Hide();

                this.BuscarSegunFecha();
            }
        }


        private void cbSuceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Suceso"))
            {
                this.lblSuceso.Show();
                this.cbSuceso.Show();

                this.lblFecha.Hide();
                this.dtpFecha.Hide();

                this.lblNombreUsuario.Hide();
                this.txtNombre.Hide();

                this.BuscarSegunSuceso();
            }
        }
    }
}
