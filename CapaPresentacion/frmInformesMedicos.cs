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
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
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
                string examenes = Convert.ToString(TablaUltimaEvolucion.Rows[0]["examen_fisico"]);
                string laboratorio = Convert.ToString(TablaUltimaEvolucion.Rows[0]["laboratorio"]);
                string examenes_paraclinicos = Convert.ToString(TablaUltimaEvolucion.Rows[0]["examenes_paraclinicos"]);
                string ekg = Convert.ToString(TablaUltimaEvolucion.Rows[0]["EKG"]);
                string eco = Convert.ToString(TablaUltimaEvolucion.Rows[0]["ecocardiograma"]);
                string diagnosticos_evol = Convert.ToString(TablaUltimaEvolucion.Rows[0]["diagnosticos"]);

                int id_plan_terapeutico = Convert.ToInt32(TablaUltimaEvolucion.Rows[0]["plan_terapeutico"]);
                int id_plan_estudio = Convert.ToInt32(TablaUltimaEvolucion.Rows[0]["plan_estudio"]);


                //Fetch PlanEstudio de UltimaEvolucion
                DataTable TablaPlanEstudio;
                TablaPlanEstudio = NPlanEstudio.Buscar_PlanEstudio_segun_id(id_plan_estudio);
                string estudios_solicitados = Convert.ToString(TablaPlanEstudio.Rows[0]["estudios"]);
                string laboratorios_solicitados = Convert.ToString(TablaPlanEstudio.Rows[0]["laboratorios"]);

                //Fetch PlanTerapeutico de UltimaEvolucion
                DataTable TablaPlanTerapeutico;
                TablaPlanTerapeutico = NReceta.Buscar_PlanTerapeutico_segun_id(id_plan_terapeutico);
                string recipe_indicaciones = Convert.ToString(TablaPlanTerapeutico.Rows[0]["recipe_indicaciones"]);


                // Armar toda la plantilla

                string Plantilla_Informe = "ID del paciente: " + id_paciente + " \n ID historia: " + id_historia + " \n ID Ultima evolucion:" + id_evol + " \n " +

                    "\n INFORME MEDICO \n" +
                    
                    "Fecha informe: " + DateTime.Today.Date + ". " + nombre_pac + " C.I.#: " + ci_pac + " Edad: " + edad_evol + " años. Sexo: " + sexo_pac + " \n " +

                    "Se trata de paciente de " + edad_evol + " años de edad, quién acude a consulta, por presentar " + motivo_consulta_evol + " por lo que se decide indicar tratamiento y exámenes paraclínicos. \n " +

                    "Con Antecedentes Familiares de " + antecedentes_fam + " y Antecedentes Personales de " + antecedentes_personales + " \n " +

                    "Examen: " + examenes + "\n" +

                    "Laboratorio: " + laboratorio + "\n" +

                    "Otros paraclinicos: " + examenes_paraclinicos + "\n" +

                    "EKG: " + ekg + "\n" +

                    "Ecocardiograma: " + eco + "\n" +

                    "Diagnosticos: " + diagnosticos_evol + "\n" +


                    // aqui va el Plan Terapeutico
                    "Se indica: " +  recipe_indicaciones  + "\n" +

                    // aqui va el Plan Estudio
                    "Se solicita: " + estudios_solicitados + laboratorios_solicitados + "\n" + 


                    "Dr. Félix Eduardo Montaño Vallés \n Médico Internista Cardiólogo Clínico \n CI#: 6.320.809 \n MPPS#: 50.859. CMA#: 6.445"

                    ; //fin del informe




                //Aqui se vacia el string dentro del richtextbox
                this.richTextBox1.Text = Plantilla_Informe.ToString();




            }
            else
            {
                MessageBox.Show("Este paciente no esta registrado");
            }



        }



    }
}




////
////GUIA PARA EL MARKDOWN DE RTF:

//int monthlyAmountNeeded = 10;

//StringBuilder text = new StringBuilder();

////append format header information;

//text.Append(@"{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Times New Roman;}" +

//                    @"{\f1\fnil Times New Roman;}}\viewkind4\uc1\pard\lang2052\f0\fs34");

//                //append content

//                text.Append(@"For an annual desired salary of :");

//                // the \b and \b0 stands for bolden

//                text.Append(@"\b " + monthlyAmountNeeded.ToString() + @"\b0");


//                // the \par stands for newline, equal to '\n'

//                text.Append(@"\par\par");

//                // the \i and \i0 stands for Italicization

//                text.Append(@"\i*these figures are assuming a 12% " +

//                    @"return on your investment minus 4% inflation\i0");

//                // the end

//                text.Append(@"}");



//                this.richTextBox1.Rtf = text.ToString();
