using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using CapaPresentacion.Reportes;

namespace CapaPresentacion
{
    public partial class frmInformesMedicos : Form
    {

        public string rptCabecera1;
        public string rptCabecera2;
        public string rptDetalle;
        public string rptAntecedentes;
        public string rptExamen;
        public string rptLaboratorio;
        public string rptOtrosParaclinicos;
        public string rptEKG;
        public string rptEcocardiograma;
        public string rptDiagnosticos;
        public string rptIndica;
        public string rptSolicita;
        public string rptFirma;

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
            this.btnImprimir.Enabled = false;
        }

        private void BuscarInfo()
        {


            //Fetch Paciente
            DataTable TablaPaciente;

            TablaPaciente = NPacientes.BuscarNum_Cedula(this.txtNumero_Cedula.Text);

           



            if (TablaPaciente.Rows.Count > 0) //verificar si el paciente existe
            {

                //Asignar variables del Paciente

                int id_paciente = Convert.ToInt32(TablaPaciente.Rows[0]["idpaciente"]);
                string nombre_pac = TablaPaciente.Rows[0]["nombre"].ToString();
                string ci_pac = TablaPaciente.Rows[0]["num_cedula"].ToString();
                string sexo_pac = TablaPaciente.Rows[0]["sexo"].ToString();


                //Fetch Historia
                DataTable TablaHistoria;

                TablaHistoria = NHistoria.Buscar_Historia_segun_idpac(id_paciente);

                if (TablaHistoria.Rows.Count > 0) //verificar si el paciente tiene historia medica
                {

                    //Asignar variables de la historia

                    int id_historia = Convert.ToInt32(TablaHistoria.Rows[0]["idhistoria"]);
                    string antecedentes_fam = Convert.ToString(TablaHistoria.Rows[0]["historia_familiar"]);
                    string antecedentes_personales = Convert.ToString(TablaHistoria.Rows[0]["historia_personal"]);



                    //Fetch Ultima Evolucion
                    DataTable TablaUltimaEvolucion;

                    TablaUltimaEvolucion = NEvolucion.Buscar_Ultima_Evol_segun_idhistoria(id_historia);

                    if(TablaUltimaEvolucion.Rows.Count > 0) //verificar si el paciente tiene evolucion
                    {

                        //Asignar variables de la Ultima Evolucion

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
                        string estudios_solicitados = "-";
                        string laboratorios_solicitados = "-";

                        if (TablaPlanEstudio.Rows.Count > 0)
                        {
                            estudios_solicitados = Convert.ToString(TablaPlanEstudio.Rows[0]["estudios"]);
                            laboratorios_solicitados = Convert.ToString(TablaPlanEstudio.Rows[0]["laboratorios"]);
                        }

                        //Fetch PlanTerapeutico de UltimaEvolucion
                        DataTable TablaPlanTerapeutico;
                        TablaPlanTerapeutico = NReceta.Buscar_PlanTerapeutico_segun_id(id_plan_terapeutico);
                        string recipe_indicaciones = "-";

                        if (TablaPlanTerapeutico.Rows.Count > 0)
                        {
                            recipe_indicaciones = Convert.ToString(TablaPlanTerapeutico.Rows[0]["recipe_indicaciones"]);
                        }



                        /////////////////////////////////////////
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
                            "Se indica: " + recipe_indicaciones + "\n" +

                            // aqui va el Plan Estudio
                            "Se solicita: " + estudios_solicitados + laboratorios_solicitados + "\n" +


                            "Dr. Félix Eduardo Montaño Vallés \n Médico Internista Cardiólogo Clínico \n CI#: 6.320.809 \n MPPS#: 50.859. CMA#: 6.445"

                            ; //fin del informe





                        //para generar el informe en crystal
                        rptCabecera1 = "ID del paciente: " + id_paciente + " \n ID historia: " + id_historia + " \n ID Ultima evolucion:" + id_evol;
                        rptCabecera2 = "Fecha informe: " + DateTime.Today.Date + ". " + nombre_pac + " C.I.#: " + ci_pac + " Edad: " + edad_evol + " años. Sexo: " + sexo_pac;
                        rptDetalle = "Se trata de paciente de " + edad_evol + " años de edad, quién acude a consulta, por presentar " + motivo_consulta_evol + " por lo que se decide indicar tratamiento y exámenes paraclínicos.";
                        rptAntecedentes = "Con Antecedentes Familiares de " + antecedentes_fam + " y Antecedentes Personales de " + antecedentes_personales;
                        rptExamen = examenes;
                        rptLaboratorio = laboratorio;
                        rptOtrosParaclinicos = examenes_paraclinicos;
                        rptEKG = ekg;
                        rptEcocardiograma = eco;
                        rptDiagnosticos = diagnosticos_evol;
                        rptIndica = recipe_indicaciones;
                        rptSolicita = estudios_solicitados + laboratorios_solicitados;
                        rptFirma = "Dr. Félix Eduardo Montaño Vallés \n Médico Internista Cardiólogo Clínico \n CI#: 6.320.809 \n MPPS#: 50.859. CMA#: 6.445";



                        //Aqui se vacia el string dentro del richtextbox
                        this.richTextBox1.Text = Plantilla_Informe;



                        //Activar boton de Imprimir
                        this.btnImprimir.Enabled = true;


                    }
                    else
                    {
                        this.btnImprimir.Enabled = false;
                        MessageBox.Show("Este paciente no tiene Evolucion, no se puede generar Informe");
                    }


                }
                else
                {
                    this.btnImprimir.Enabled = false;
                    MessageBox.Show("Este paciente no tiene Historia medica, no se puede generar Informe");
                }



            }
            else
            {
                this.btnImprimir.Enabled = false;
                MessageBox.Show("Este paciente no esta registrado, no se puede generar Informe");
            }



        }


        ////funcion para buscar campos vacios en un datatable
        //public static bool HasNull(this DataTable table)
        //{
        //    foreach (DataColumn column in table.Columns)
        //    {
        //        if (table.Rows.OfType<DataRow>().Any(r => r.IsNull(column)))
        //            return true;
        //    }

        //    return false;
        //}


        private void btnImprimir_Click(object sender, EventArgs e)
        {

            try
            {

                CrystalReport_InformeMedico miReporte = new CrystalReport_InformeMedico();
                miReporte.SetParameterValue("rptCabecera1", rptCabecera1);
                miReporte.SetParameterValue("rptCabecera2", rptCabecera2);
                miReporte.SetParameterValue("rptDetalle", rptDetalle);
                miReporte.SetParameterValue("rptAntecedentes", rptAntecedentes);
                miReporte.SetParameterValue("rptExamen", rptExamen);
                miReporte.SetParameterValue("rptLaboratorio", rptLaboratorio);
                miReporte.SetParameterValue("rptOtrosParaclinicos", rptOtrosParaclinicos);
                miReporte.SetParameterValue("rptEKG", rptEKG);
                miReporte.SetParameterValue("rptEcocardiograma", rptEcocardiograma);
                miReporte.SetParameterValue("rptDiagnosticos", rptDiagnosticos);
                miReporte.SetParameterValue("rptIndica", rptIndica);
                miReporte.SetParameterValue("rptSolicita", rptSolicita);
                miReporte.SetParameterValue("rptFirma", rptFirma);

                frmVisualizadorCrystal visu = new frmVisualizadorCrystal();
                visu.cryVisualizador.ReportSource = miReporte;
                visu.cryVisualizador.ShowRefreshButton = false;
                visu.cryVisualizador.ShowGroupTreeButton = false;

                visu.Show();

       
            }
            catch (Exception)
            {

            }


        }

        private void btnNuevo_informe_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero_Cedula.Clear();
            lbl_idhistoria.Text = "";
            richTextBox1.Clear();
        }
    }
}
