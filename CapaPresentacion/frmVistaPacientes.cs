using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class frmVistaPacientes : Form
    {
        public frmVistaPacientes()
        {
            InitializeComponent();
        }


        public static DUsuario Session_Actual = frmPrincipal.User_Actual;


        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            //this.dataListado.Columns[1].Visible = false;
        }

        //Método Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NPacientes.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void frmVistaPacientes_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //this.BuscarNombre();
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            
        }

        //Método BuscarNombre
        /*private void BuscarNombre()
        {
            this.dataListado.DataSource = NCategoria.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }*/

    }
}
