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
            if (e.KeyChar == (char)13)
            {

                BuscarInfo();

            }

        }

        private void frmInformesMedicos_Load(object sender, EventArgs e)
        {

        }

        private void BuscarInfo()
        {


            //Fetch Paciente
            DataTable TablaPaciente;

            TablaPaciente = NPacientes.BuscarNum_Cedula(this.txtNumero_Cedula.Text);

            int id_paciente = Convert.ToInt32(TablaPaciente.Rows[0]["idpaciente"]);
            string nombre_pac = TablaPaciente.Rows[0]["nombre"].ToString();
            string ci_pac = TablaPaciente.Rows[0]["num_cedula"].ToString();
            string sexo_pac = TablaPaciente.Rows[0]["sexo"].ToString();



            if (id_paciente > 0)
            {

                //Fetch Historia
                DataTable TablaHistoria;

                TablaHistoria = NHistoria.Buscar_Historia_segun_idpac(id_paciente);

                int id_historia = Convert.ToInt32(TablaHistoria.Rows[0]["idhistoria"]);
                string antecedentes_fam = Convert.ToString(TablaHistoria.Rows[0]["historia_familiar"]);
                string antecedentes_personales = Convert.ToString(TablaHistoria.Rows[0]["historia_personal"]);



                //Fetch Ultima Evolucion
                DataTable TablaUltimaEvolucion;

                TablaUltimaEvolucion = NEvolucion.Buscar_Ultima_Evol_segun_idhistoria(id_historia);

                int id_evol = Convert.ToInt32(TablaUltimaEvolucion.Rows[0]["id"]);
                int edad_evol = Convert.ToInt32(TablaUltimaEvolucion.Rows[0]["edad_suc"]);
                string motivo_consulta_evol = Convert.ToString(TablaUltimaEvolucion.Rows[0]["motivo_consulta"]);
                string prox_consulta = Convert.ToString(TablaUltimaEvolucion.Rows[0]["prox_consulta"]);







                this.richTextBox1.Text = "ID del paciente: " + id_paciente + " \n ID historia: " + id_historia + " \n ID Ultima evolucion:" + id_evol + " \n " +
                    " INFORME MEDICO \n" +
                    "Fecha informe: " + DateTime.Today.Date + ". " + nombre_pac + " C.I.#: " + ci_pac + " Edad: " + edad_evol + " años. Sexo: " + sexo_pac + " \n " +

                    "Se trata de paciente de " + edad_evol + " años de edad, quién acude a consulta, por presentar " + motivo_consulta_evol + " por lo que se decide indicar tratamiento y exámenes paraclínicos. \n " +

                    "Con Antecedentes Familiares de " + antecedentes_fam + " y Antecedentes Personales de " + antecedentes_personales + " \n "

                    ; //fin del informe


            }
            else
            {
                MessageBox.Show("Este paciente no esta registrado");
            }



        }



    }
}
