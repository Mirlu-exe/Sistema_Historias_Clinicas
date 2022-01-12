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
    public partial class frmInformesMedicos : Form
    {
        public frmInformesMedicos()
        {
            InitializeComponent();
        }

        private void txtNumero_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)13)
            //{

            //    int id_del_paciente_a_cargar;

            //    id_del_paciente_a_cargar = Buscar_idPac_por_cedula();

            //    if (id_del_paciente_a_cargar > 0)
            //    {

            //        BuscarHistoria_por_Pac_id(id_del_paciente_a_cargar);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Este paciente no esta registrado");
            //    }


            //}

        }

        private void frmInformesMedicos_Load(object sender, EventArgs e)
        {

        }
    }
}
