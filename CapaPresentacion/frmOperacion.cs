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

            this.lblFechaInicio.Hide();
            this.dtpFechaInicio.Hide();

            this.lblFechaFin.Hide();
            this.dtpFechaFin.Hide();

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


            lblCantidadOperaciones.Text = "Total de Operaciones: " + Convert.ToString(datalistadoOperaciones.Rows.Count);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
            DV.RowFilter = string.Format("fecha LIKE '%{0}%'", this.dtpFechaInicio.Text);
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

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            DataView DV = new DataView(NOperacion.Mostrar());

            StringBuilder sb = new StringBuilder();

            if (chkNombreUsuario.Checked)
            {
                if (sb.Length > 0)
                {
                    sb.Append(" and ");
                }

                sb.Append("usuario like '%" + this.txtNombre.Text + "%'");

            }

            if (chkSuceso.Checked)
            {
                if (sb.Length > 0)
                {
                    sb.Append(" and ");
                }

                sb.Append("descripcion like '%" + this.cbSuceso.Text + "%'");

            }

            if (chkRangoFechas.Checked)
            {
                if (sb.Length > 0)
                {
                    sb.Append(" and ");
                }

                sb.Append("fecha >= '" + this.dtpFechaInicio.Value.ToString() + "' AND fecha <= '" + this.dtpFechaFin.Value.ToString() + "'" );


            }



            DV.RowFilter = sb.ToString();

            datalistadoOperaciones.DataSource = DV;


        }

        private void chkNombreUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNombreUsuario.Checked)
            {
                this.lblNombreUsuario.Show();
                this.txtNombre.Show();
            }
            else
            {
                this.lblNombreUsuario.Hide();
                this.txtNombre.Hide();
            }
        }

        private void chkSuceso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSuceso.Checked)
            {
                this.lblSuceso.Show();
                this.cbSuceso.Show();
            }
            else
            {
                this.lblSuceso.Hide();
                this.cbSuceso.Hide();
            }
        }

        private void chkRangoFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRangoFechas.Checked)
            {
                this.lblFechaInicio.Show();
                this.dtpFechaInicio.Show();

                this.lblFechaFin.Show();
                this.dtpFechaFin.Show();

            }
            else
            {
                this.lblFechaInicio.Hide();
                this.dtpFechaInicio.Hide();

                this.lblFechaFin.Hide();
                this.dtpFechaFin.Hide();
            }
        }
    }
}
