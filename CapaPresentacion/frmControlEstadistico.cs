using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion
{
    public partial class frmControlEstadistico : Form
    {


        private bool IsNuevo = false;

        public static DUsuario Session_Actual = frmPrincipal.User_Actual;

        public frmControlEstadistico()
        {
            InitializeComponent();
        }

        private void frmControlEstadistico_Load(object sender, EventArgs e)
        {
            this.CargarCamposParametros();
            this.Habilitar();
            this.Botones();

            lblFechaHora.Text = DateTime.Now.ToString();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
        }


        //Habilitar los botones
        private void Botones()
        {
            //if (this.IsNuevo) //Alt + 124
            //{
            //    this.Habilitar();
            //    this.btnNuevo.Enabled = false;
            //    this.btnGuardar.Enabled = true;
            //    this.btnCancelar.Enabled = true;
            //}
            //else
            //{
            //    this.Deshabilitar();
            //    this.btnNuevo.Enabled = true;
            //    this.btnGuardar.Enabled = false;
            //    this.btnCancelar.Enabled = false;
            //}

        }

        //Cargar campos para el informe
        private void CargarCamposParametros()
        {
            this.cbTipoGrafico.SelectedIndex = 0; //por defecto seleccionar el primero
            this.cbRangoFecha.SelectedIndex = 0;
            this.rbGraficoColumnas.Checked = true;
            this.cbCampo.Enabled = true;
            this.cbCampo.SelectedIndex = 0;
            CargarFiltroTipo();
        }

        private void onChangeCbTipo(object sender, EventArgs e)
        {
            CargarFiltroTipo();
        }

        ///Cuando se selecciona un item del combo Tipo se filtra el list de abajo.
        private void CargarFiltroTipo()
        {
            this.cbTipoGrafico.Enabled = false;
            this.lbFiltroTipo.Enabled = false;

            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = (this.cbTipoGrafico.SelectedIndex == 0) ? "select ltrim(rtrim(upper(enfermedad))) as tipo from Diagnostico order by 1" : "select ltrim(rtrim(upper(tipo))) as tipo from Diagnostico group by tipo order by 1;";

            System.Data.SqlClient.SqlConnection conDataBase = new System.Data.SqlClient.SqlConnection(CN);
            System.Data.SqlClient.SqlCommand cmdDataBase = new System.Data.SqlClient.SqlCommand(Query, conDataBase);
            System.Data.SqlClient.SqlDataReader Lectura;

            try
            {

                this.lbFiltroTipo.Items.Clear();
                this.lbFiltroTipo.Items.Add("TODOS");

                conDataBase.Open();
                Lectura = cmdDataBase.ExecuteReader();

                while (Lectura.Read())
                {
                    this.lbFiltroTipo.Items.Add(Lectura["tipo"].ToString());
                }
                this.lbFiltroTipo.SelectedIndex = 0;

                this.cbTipoGrafico.Enabled = true;
                this.lbFiltroTipo.Enabled = true;
            }
            catch (Exception ex)
            {
                this.cbTipoGrafico.Enabled = true;
                this.lbFiltroTipo.Enabled = true;
            }
        }

        private void lbFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lbFiltroTipo.SelectedIndex == 0)
                {
                    this.lbFiltroTipo.SelectionMode = SelectionMode.One;
                    this.lbFiltroTipo.SelectedIndex = 0;
                }
                else
                {
                    this.lbFiltroTipo.SelectionMode = SelectionMode.MultiSimple;
                }

                if (this.rbGraficoTorta.Checked)
                {
                    this.lbFiltroTipo.SelectionMode = SelectionMode.One;
                }
            }
            catch (Exception)
            {

            }

        }

        private void cbRangoFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EfectoFechas();
        }

        private void EfectoFechas()
        {
            if (this.cbRangoFecha.SelectedIndex == 4)
            {
                this.dpDesde.Visible = true;
                this.dpHasta.Visible = true;
            }
            else
            {
                this.dpDesde.Visible = false;
                this.dpHasta.Visible = false;
            }
        }

        private void HabilitarControlesGraficos()
        {
            this.cbTipoGrafico.Enabled = true;
            this.lbFiltroTipo.Enabled = true;
            this.cbCampo.Enabled = true;
            this.cbRangoFecha.Enabled = true;
            this.dpDesde.Enabled = true;
            this.dpHasta.Enabled = true;
            this.btnCrearGrafico.Enabled = true;
        }

        private void InhabilitarControlesGraficos()
        {
            this.cbTipoGrafico.Enabled = false;
            this.lbFiltroTipo.Enabled = false;
            this.cbCampo.Enabled = false;
            this.cbRangoFecha.Enabled = false;
            this.dpDesde.Enabled = false;
            this.dpHasta.Enabled = false;
            this.btnCrearGrafico.Enabled = false;

        }

        private void GenerarGrafico()
        {
            this.lblDataNotFound.Visible = false;

            int cantidadElegidos = this.lbFiltroTipo.SelectedItems.Count;
            if (this.lbFiltroTipo.SelectedItems[0].ToString() == "TODOS")
                cantidadElegidos++;

            if (cantidadElegidos > 1 && rbGraficoTorta.Checked)
            {
                MessageBox.Show("el grafico de tortas se debe de utilizar para 1 tipo de enfermedad o tipo de enfermedad");
                return;
            }

            InhabilitarControlesGraficos();


            try
            {




                string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                string Query = (this.cbTipoGrafico.SelectedIndex == 0) ? "GraficoEnfermedades" : "GraficoEnfermedadesTipo";


                using (System.Data.SqlClient.SqlConnection sql_conexion = new System.Data.SqlClient.SqlConnection())
                {
                    sql_conexion.ConnectionString = CN;
                    sql_conexion.Open();

                    using (System.Data.SqlClient.SqlCommand sql_comando = new System.Data.SqlClient.SqlCommand())
                    {
                        sql_comando.Connection = sql_conexion;
                        sql_comando.CommandType = CommandType.StoredProcedure;
                        sql_comando.CommandText = Query;


                        //parametros de fecha
                        DateTime fIni = DateTime.Now;
                        DateTime fFin = DateTime.Now;
                        string parteFecha = "";
                        switch (this.cbRangoFecha.SelectedIndex)
                        {
                            case 0: //Hoy
                                fIni = DateTime.Now;
                                fFin = DateTime.Now;
                                parteFecha = " del día " + fIni.ToString("dd/MM/yyyy");
                                break;
                            case 1: //Esta semana
                                fIni = DateTime.Now.AddDays(-7);
                                fFin = DateTime.Now;
                                parteFecha = " del día " +fIni.ToString("dd/MM/yyyy") + " al " + fFin.ToString("dd/MM/yyyy");
                                MessageBox.Show(parteFecha.ToString());
                                break;
                            case 2: //ultimos 15 dias 
                                fIni = DateTime.Now.AddDays(-15);
                                fFin = DateTime.Now;
                                parteFecha = " del día " + fIni.ToString("dd/MM/yyyy") + " al " + fFin.ToString("dd/MM/yyyy");
                                break;
                            case 3: //Este mes
                                fIni = DateTime.Now.AddDays((DateTime.Now.Day - 1) * -1);
                                fFin = DateTime.Now;
                                parteFecha = " del día " + fIni.ToString("dd/MM/yyyy") + " al " + fFin.ToString("dd/MM/yyyy");
                                break;
                            case 4: //Rango específico
                                fIni = dpDesde.Value;
                                fFin = dpHasta.Value;
                                parteFecha = " del día " + fIni.ToString("dd/MM/yyyy") + " al " + fFin.ToString("dd/MM/yyyy");

                                MessageBox.Show(parteFecha.ToString());

                                if (Convert.ToInt32(fIni.ToString("yyyMMdd")) > Convert.ToInt32(fFin.ToString("yyyMMdd")))
                                {
                                    MessageBox.Show("Rango de Fechas Incorrectas");
                                    HabilitarControlesGraficos();
                                    return;
                                }
                                break;


                        }

                        sql_comando.Parameters.Add("FIni", SqlDbType.SmallDateTime).Value = fIni;
                        sql_comando.Parameters.Add("FFin", SqlDbType.SmallDateTime).Value = fFin;

                        
                        DataTable dta_consulta = new DataTable();
                        dta_consulta.Load(sql_comando.ExecuteReader());

                        if (!DatosEncontrados(dta_consulta))
                        {
                            HabilitarControlesGraficos();
                            this.lblDataNotFound.Visible = true;
                            return;
                        }


                        SeriesChartType type = SeriesChartType.Column;

                        if (rbGraficoColumnasApiladas.Checked)
                            type = SeriesChartType.StackedColumn;

                        if (rbGraficoBarras.Checked)
                            type = SeriesChartType.Bar;

                        if (rbGraficoBarrasApiladas.Checked)
                            type = SeriesChartType.StackedBar;

                        if (rbGraficoTorta.Checked)
                            type = SeriesChartType.Pie;

                        if (this.cbTipoGrafico.SelectedIndex == 0)
                            this.GraficosPorEnfermedad(dta_consulta, type, parteFecha);
                        else this.GraficosPorTipoEnfermedad(dta_consulta, type, parteFecha);


                    }
                }

                HabilitarControlesGraficos();
            }
            catch (Exception ex)
            {
                HabilitarControlesGraficos();
                MessageBox.Show(ex.ToString());
            }

            Application.DoEvents();
        }

        private bool DatosEncontrados(DataTable datos)
        {
            this.lblDataNotFound.Visible = false;
            string campo = (this.cbCampo.SelectedIndex == 0) ? "Sexo" : "Rango de Edad";
            string tipoGrafico = (this.cbTipoGrafico.SelectedIndex == 0) ? "enfermedad" : "tipo";

            double cont = 0;

            foreach (DataRow r in datos.Rows)
            {
                foreach (var series in lbFiltroTipo.SelectedItems)
                {
                    string tipo = series.ToString();

                    bool si = false;
                    if (tipo == "TODOS")
                    {
                        si = true;
                    }
                    else if (tipo.Trim().ToUpper() == r[tipoGrafico].ToString().ToUpper())
                    {
                        si = true;
                    }

                    if (si)
                    {
                        if (campo == "Sexo")
                        {

                            double mas = Convert.ToInt32(r["Sexo_Masculino"].ToString());
                            double fem = Convert.ToInt32(r["Sexo_Femenino"].ToString());

                            cont += mas + fem;


                        }
                        else
                        {
                            int Edad_0_11 = Convert.ToInt32(r["Edad_0_11"].ToString());
                            int Edad_12_18 = Convert.ToInt32(r["Edad_12_18"].ToString());
                            int Edad_19_25 = Convert.ToInt32(r["Edad_19_25"].ToString());
                            int Edad_26_39 = Convert.ToInt32(r["Edad_26_39"].ToString());
                            int Edad_40_49 = Convert.ToInt32(r["Edad_40_49"].ToString());
                            int Edad_50_59 = Convert.ToInt32(r["Edad_50_59"].ToString());
                            int Edad_60_69 = Convert.ToInt32(r["Edad_60_69"].ToString());
                            int Edad_70_79 = Convert.ToInt32(r["Edad_70_79"].ToString());
                            int Edad_80_89 = Convert.ToInt32(r["Edad_80_89"].ToString());
                            int Edad_90_00 = Convert.ToInt32(r["Edad_90_100"].ToString());

                            cont += Edad_0_11 + Edad_12_18 + Edad_19_25 + Edad_26_39 + Edad_40_49 + Edad_50_59 + Edad_60_69 + Edad_70_79 + Edad_80_89 + Edad_90_00;

                        }
                    }
                }
            }

            return (cont > 0) ? true : false;
        }

        private void GraficosPorEnfermedad(DataTable datos, SeriesChartType type, string parteFecha)
        {
            string campo = (this.cbCampo.SelectedIndex == 0) ? "Sexo" : "Rango de Edad";
            bool esPie = rbGraficoTorta.Checked;

            this.myChart.Titles.Clear();
            this.myChart.Titles.Add("Graficos Por Enfermedades " + campo + parteFecha);
            this.myChart.Series.Clear();
            this.myChart.Legends.Clear();

            if (campo == "Sexo")
            {
                if (!esPie)
                {
                    Series serieHombres = new Series();
                    serieHombres.ChartType = type;
                    serieHombres.Name = "Hombres";
                    this.myChart.Series.Add(serieHombres);

                    Series serieMujeres = new Series();
                    serieMujeres.ChartType = type;
                    serieMujeres.Name = "Mujeres";
                    this.myChart.Series.Add(serieMujeres);

                    this.myChart.Legends.Add("Legend1");
                    this.myChart.Legends[0].LegendStyle = LegendStyle.Table;
                    this.myChart.Legends[0].Docking = Docking.Bottom;
                    this.myChart.Legends[0].Alignment = StringAlignment.Center;
                    this.myChart.Legends[0].Title = "Datos por Sexo";
                    this.myChart.Legends[0].BorderColor = Color.Black;
                }
                else
                {
                    Series serieSexo = new Series();
                    serieSexo.ChartType = type;
                    serieSexo.Name = "Sexo";
                    this.myChart.Series.Add(serieSexo);

                    this.myChart.Legends.Add("Legend1");
                    this.myChart.Legends[0].LegendStyle = LegendStyle.Table;
                    this.myChart.Legends[0].Docking = Docking.Bottom;
                    this.myChart.Legends[0].Alignment = StringAlignment.Center;
                    this.myChart.Legends[0].Title = "Datos por Sexo";
                    this.myChart.Legends[0].BorderColor = Color.Black;
                }
            }
            else
            {
                if (!esPie)
                {
                    Series año11 = new Series();
                    año11.ChartType = type;
                    año11.Name = "hasta 11 años";
                    this.myChart.Series.Add(año11);

                    Series año12 = new Series();
                    año12.ChartType = type;
                    año12.Name = "de 12 a 18";
                    this.myChart.Series.Add(año12);

                    Series año19 = new Series();
                    año19.ChartType = type;
                    año19.Name = "de 19 a 25";
                    this.myChart.Series.Add(año19);

                    Series año26 = new Series();
                    año26.ChartType = type;
                    año26.Name = "de 26 a 39";
                    this.myChart.Series.Add(año26);

                    Series año40 = new Series();
                    año40.ChartType = type;
                    año40.Name = "de 40 a 49";
                    this.myChart.Series.Add(año40);

                    Series año50 = new Series();
                    año50.ChartType = type;
                    año50.Name = "de 50 a 59";
                    this.myChart.Series.Add(año50);

                    Series año60 = new Series();
                    año60.ChartType = type;
                    año60.Name = "de 60 a 69";
                    this.myChart.Series.Add(año60);

                    Series año70 = new Series();
                    año70.ChartType = type;
                    año70.Name = "de 70 a 79";
                    this.myChart.Series.Add(año70);

                    Series año80 = new Series();
                    año80.ChartType = type;
                    año80.Name = "de 80 a 89";
                    this.myChart.Series.Add(año80);

                    Series año90 = new Series();
                    año90.ChartType = type;
                    año90.Name = "de 90 a 100";
                    this.myChart.Series.Add(año90);

                    this.myChart.Legends.Add("Legend1");
                    this.myChart.Legends[0].LegendStyle = LegendStyle.Table;
                    this.myChart.Legends[0].Docking = Docking.Bottom;
                    this.myChart.Legends[0].Alignment = StringAlignment.Center;
                    this.myChart.Legends[0].Title = "Datos por Edad";
                    this.myChart.Legends[0].BorderColor = Color.Black;
                }
                else
                {
                    Series serieEdad = new Series();
                    serieEdad.ChartType = type;
                    serieEdad.Name = "Edad";
                    this.myChart.Series.Add(serieEdad);

                    this.myChart.Legends.Add("Legend1");
                    this.myChart.Legends[0].LegendStyle = LegendStyle.Table;
                    this.myChart.Legends[0].Docking = Docking.Bottom;
                    this.myChart.Legends[0].Alignment = StringAlignment.Center;
                    this.myChart.Legends[0].Title = "Datos por Edad";
                    this.myChart.Legends[0].BorderColor = Color.Black;

                }

            }

            foreach (DataRow r in datos.Rows)
            {
                foreach (var series in lbFiltroTipo.SelectedItems)
                {
                    string tipo = series.ToString();

                    bool si = false;
                    if (tipo == "TODOS")
                    {
                        si = true;
                    }
                    else if (tipo.Trim().ToUpper() == r["enfermedad"].ToString().ToUpper())
                    {
                        si = true;
                    }

                    if (si)
                    {
                        if (campo == "Sexo")
                        {

                            double mas = Convert.ToInt32(r["Sexo_Masculino"].ToString());
                            this.myChart.Series[(esPie) ? "Sexo" : "Hombres"].Points.AddXY((esPie) ? "Hombres" : r["enfermedad"].ToString(), mas);
                            this.myChart.Series[(esPie) ? "Sexo" : "Hombres"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Sexo" : "Hombres"].Label = ((esPie) ? "Hombres " : "");

                            double fem = Convert.ToInt32(r["Sexo_Femenino"].ToString());
                            this.myChart.Series[(esPie) ? "Sexo" : "Mujeres"].Points.AddXY((esPie) ? "Mujeres" : r["enfermedad"].ToString(), fem);
                            this.myChart.Series[(esPie) ? "Sexo" : "Mujeres"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Sexo" : "Mujeres"].Label = ((esPie) ? "Mujeres " : "");



                        }
                        else
                        {
                            int Edad_0_11 = Convert.ToInt32(r["Edad_0_11"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "hasta 11 años"].Points.AddXY((esPie) ? "hasta 11 años" : r["enfermedad"].ToString(), Edad_0_11);
                            this.myChart.Series[(esPie) ? "Edad" : "hasta 11 años"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "hasta 11 años"].Label = ((esPie) ? "hasta 11 años" : "");

                            int Edad_12_18 = Convert.ToInt32(r["Edad_12_18"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 12 a 18"].Points.AddXY((esPie) ? "de 12 a 18" : r["enfermedad"].ToString(), Edad_12_18);
                            this.myChart.Series[(esPie) ? "Edad" : "de 12 a 18"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 12 a 18"].Label = ((esPie) ? "de 12 a 18" : "");

                            int Edad_19_25 = Convert.ToInt32(r["Edad_19_25"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 19 a 25"].Points.AddXY((esPie) ? "de 19 a 25" : r["enfermedad"].ToString(), Edad_19_25);
                            this.myChart.Series[(esPie) ? "Edad" : "de 19 a 25"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 19 a 25"].Label = ((esPie) ? "de 19 a 25" : "");

                            int Edad_26_39 = Convert.ToInt32(r["Edad_26_39"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 26 a 39"].Points.AddXY((esPie) ? "de 26 a 39" : r["enfermedad"].ToString(), Edad_26_39);
                            this.myChart.Series[(esPie) ? "Edad" : "de 26 a 39"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 26 a 39"].Label = ((esPie) ? "de 26 a 39" : "");

                            int Edad_40_49 = Convert.ToInt32(r["Edad_40_49"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 40 a 49"].Points.AddXY((esPie) ? "de 40 a 49" : r["enfermedad"].ToString(), Edad_40_49);
                            this.myChart.Series[(esPie) ? "Edad" : "de 40 a 49"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 40 a 49"].Label = ((esPie) ? "de 40 a 49" : "");

                            int Edad_50_59 = Convert.ToInt32(r["Edad_50_59"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 50 a 59"].Points.AddXY((esPie) ? "de 50 a 59" : r["enfermedad"].ToString(), Edad_50_59);
                            this.myChart.Series[(esPie) ? "Edad" : "de 50 a 59"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 50 a 59"].Label = ((esPie) ? "de 50 a 59" : "");

                            int Edad_60_69 = Convert.ToInt32(r["Edad_60_69"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 60 a 69"].Points.AddXY((esPie) ? "de 60 a 69" : r["enfermedad"].ToString(), Edad_60_69);
                            this.myChart.Series[(esPie) ? "Edad" : "de 60 a 69"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 60 a 69"].Label = ((esPie) ? "de 60 a 69" : "");

                            int Edad_70_79 = Convert.ToInt32(r["Edad_70_79"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 70 a 79"].Points.AddXY((esPie) ? "de 70 a 79" : r["enfermedad"].ToString(), Edad_70_79);
                            this.myChart.Series[(esPie) ? "Edad" : "de 70 a 79"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 70 a 79"].Label = ((esPie) ? "de 70 a 79" : "");

                            int Edad_80_89 = Convert.ToInt32(r["Edad_80_89"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 80 a 89"].Points.AddXY((esPie) ? "de 80 a 89" : r["enfermedad"].ToString(), Edad_80_89);
                            this.myChart.Series[(esPie) ? "Edad" : "de 80 a 89"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 80 a 89"].Label = ((esPie) ? "de 80 a 89" : "");

                            int Edad_90_00 = Convert.ToInt32(r["Edad_90_100"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 90 a 100"].Points.AddXY((esPie) ? "de 90 a 100" : r["enfermedad"].ToString(), Edad_90_00);
                            this.myChart.Series[(esPie) ? "Edad" : "de 90 a 100"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 90 a 100"].Label = ((esPie) ? "de 90 a 100" : "");
                        }
                    }
                }
            }

            this.Refresh();
            Application.DoEvents();

        }

        private void GraficosPorTipoEnfermedad(DataTable datos, SeriesChartType type, string parteFecha)
        {
            string campo = (this.cbCampo.SelectedIndex == 0) ? "Sexo" : "Rango de Edad";
            bool esPie = rbGraficoTorta.Checked;

            this.myChart.Titles.Clear();
            this.myChart.Titles.Add("Graficos Por Tipos de Enfermedades " + campo + parteFecha);
            this.myChart.Series.Clear();
            this.myChart.Legends.Clear();

            if (campo == "Sexo")
            {
                if (!esPie)
                {
                    Series serieHombres = new Series();
                    serieHombres.ChartType = type;
                    serieHombres.Name = "Hombres";
                    this.myChart.Series.Add(serieHombres);

                    Series serieMujeres = new Series();
                    serieMujeres.ChartType = type;
                    serieMujeres.Name = "Mujeres";
                    this.myChart.Series.Add(serieMujeres);

                    this.myChart.Legends.Add("Legend1");
                    this.myChart.Legends[0].LegendStyle = LegendStyle.Table;
                    this.myChart.Legends[0].Docking = Docking.Bottom;
                    this.myChart.Legends[0].Alignment = StringAlignment.Center;
                    this.myChart.Legends[0].Title = "Datos por Sexo";
                    this.myChart.Legends[0].BorderColor = Color.Black;
                }
                else
                {
                    Series serieSexo = new Series();
                    serieSexo.ChartType = type;
                    serieSexo.Name = "Sexo";
                    this.myChart.Series.Add(serieSexo);

                    this.myChart.Legends.Add("Legend1");
                    this.myChart.Legends[0].LegendStyle = LegendStyle.Table;
                    this.myChart.Legends[0].Docking = Docking.Bottom;
                    this.myChart.Legends[0].Alignment = StringAlignment.Center;
                    this.myChart.Legends[0].Title = "Datos por Sexo";
                    this.myChart.Legends[0].BorderColor = Color.Black;
                }
            }
            else
            {
                if (!esPie)
                {
                    Series año11 = new Series();
                    año11.ChartType = type;
                    año11.Name = "hasta 11 años";
                    this.myChart.Series.Add(año11);

                    Series año12 = new Series();
                    año12.ChartType = type;
                    año12.Name = "de 12 a 18";
                    this.myChart.Series.Add(año12);

                    Series año19 = new Series();
                    año19.ChartType = type;
                    año19.Name = "de 19 a 25";
                    this.myChart.Series.Add(año19);

                    Series año26 = new Series();
                    año26.ChartType = type;
                    año26.Name = "de 26 a 39";
                    this.myChart.Series.Add(año26);

                    Series año40 = new Series();
                    año40.ChartType = type;
                    año40.Name = "de 40 a 49";
                    this.myChart.Series.Add(año40);

                    Series año50 = new Series();
                    año50.ChartType = type;
                    año50.Name = "de 50 a 59";
                    this.myChart.Series.Add(año50);

                    Series año60 = new Series();
                    año60.ChartType = type;
                    año60.Name = "de 60 a 69";
                    this.myChart.Series.Add(año60);

                    Series año70 = new Series();
                    año70.ChartType = type;
                    año70.Name = "de 70 a 79";
                    this.myChart.Series.Add(año70);

                    Series año80 = new Series();
                    año80.ChartType = type;
                    año80.Name = "de 80 a 89";
                    this.myChart.Series.Add(año80);

                    Series año90 = new Series();
                    año90.ChartType = type;
                    año90.Name = "de 90 a 100";
                    this.myChart.Series.Add(año90);

                    this.myChart.Legends.Add("Legend1");
                    this.myChart.Legends[0].LegendStyle = LegendStyle.Table;
                    this.myChart.Legends[0].Docking = Docking.Bottom;
                    this.myChart.Legends[0].Alignment = StringAlignment.Center;
                    this.myChart.Legends[0].Title = "Datos por Edad";
                    this.myChart.Legends[0].BorderColor = Color.Black;
                }
                else
                {
                    Series serieEdad = new Series();
                    serieEdad.ChartType = type;
                    serieEdad.Name = "Edad";
                    this.myChart.Series.Add(serieEdad);

                    this.myChart.Legends.Add("Legend1");
                    this.myChart.Legends[0].LegendStyle = LegendStyle.Table;
                    this.myChart.Legends[0].Docking = Docking.Bottom;
                    this.myChart.Legends[0].Alignment = StringAlignment.Center;
                    this.myChart.Legends[0].Title = "Datos por Edad";
                    this.myChart.Legends[0].BorderColor = Color.Black;

                }
            }

            foreach (DataRow r in datos.Rows)
            {
                foreach (var series in lbFiltroTipo.SelectedItems)
                {
                    string tipo = series.ToString();

                    bool si = false;
                    if (tipo == "TODOS")
                    {
                        si = true;
                    }
                    else if (tipo.Trim().ToUpper() == r["tipo"].ToString().ToUpper())
                    {
                        si = true;
                    }

                    if (si)
                    {
                        if (campo == "Sexo")
                        {
                            double mas = Convert.ToInt32(r["Sexo_Masculino"].ToString());
                            this.myChart.Series[(esPie) ? "Sexo" : "Hombres"].Points.AddXY((esPie) ? "Hombres" : r["tipo"].ToString(), mas);
                            this.myChart.Series[(esPie) ? "Sexo" : "Hombres"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Sexo" : "Hombres"].Label = ((esPie) ? "Hombres " : "");

                            double fem = Convert.ToInt32(r["Sexo_Femenino"].ToString());
                            this.myChart.Series[(esPie) ? "Sexo" : "Mujeres"].Points.AddXY((esPie) ? "Mujeres" : r["tipo"].ToString(), fem);
                            this.myChart.Series[(esPie) ? "Sexo" : "Mujeres"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Sexo" : "Mujeres"].Label = ((esPie) ? "Mujeres " : "");
                        }
                        else
                        {
                            int Edad_0_11 = Convert.ToInt32(r["Edad_0_11"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "hasta 11 años"].Points.AddXY((esPie) ? "hasta 11 años" : r["tipo"].ToString(), Edad_0_11);
                            this.myChart.Series[(esPie) ? "Edad" : "hasta 11 años"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "hasta 11 años"].Label = ((esPie) ? "hasta 11 años" : "");

                            int Edad_12_18 = Convert.ToInt32(r["Edad_12_18"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 12 a 18"].Points.AddXY((esPie) ? "de 12 a 18" : r["tipo"].ToString(), Edad_12_18);
                            this.myChart.Series[(esPie) ? "Edad" : "de 12 a 18"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 12 a 18"].Label = ((esPie) ? "de 12 a 18" : "");

                            int Edad_19_25 = Convert.ToInt32(r["Edad_19_25"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 19 a 25"].Points.AddXY((esPie) ? "de 19 a 25" : r["tipo"].ToString(), Edad_19_25);
                            this.myChart.Series[(esPie) ? "Edad" : "de 19 a 25"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 19 a 25"].Label = ((esPie) ? "de 19 a 25" : "");

                            int Edad_26_39 = Convert.ToInt32(r["Edad_26_39"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 26 a 39"].Points.AddXY((esPie) ? "de 26 a 39" : r["tipo"].ToString(), Edad_26_39);
                            this.myChart.Series[(esPie) ? "Edad" : "de 26 a 39"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 26 a 39"].Label = ((esPie) ? "de 26 a 39" : "");

                            int Edad_40_49 = Convert.ToInt32(r["Edad_40_49"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 40 a 49"].Points.AddXY((esPie) ? "de 40 a 49" : r["tipo"].ToString(), Edad_40_49);
                            this.myChart.Series[(esPie) ? "Edad" : "de 40 a 49"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 40 a 49"].Label = ((esPie) ? "de 40 a 49" : "");

                            int Edad_50_59 = Convert.ToInt32(r["Edad_50_59"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 50 a 59"].Points.AddXY((esPie) ? "de 50 a 59" : r["tipo"].ToString(), Edad_50_59);
                            this.myChart.Series[(esPie) ? "Edad" : "de 50 a 59"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 50 a 59"].Label = ((esPie) ? "de 50 a 59" : "");

                            int Edad_60_69 = Convert.ToInt32(r["Edad_60_69"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 60 a 69"].Points.AddXY((esPie) ? "de 60 a 69" : r["tipo"].ToString(), Edad_60_69);
                            this.myChart.Series[(esPie) ? "Edad" : "de 60 a 69"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 60 a 69"].Label = ((esPie) ? "de 60 a 69" : "");

                            int Edad_70_79 = Convert.ToInt32(r["Edad_70_79"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 70 a 79"].Points.AddXY((esPie) ? "de 70 a 79" : r["tipo"].ToString(), Edad_70_79);
                            this.myChart.Series[(esPie) ? "Edad" : "de 70 a 79"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 70 a 79"].Label = ((esPie) ? "de 70 a 79" : "");

                            int Edad_80_89 = Convert.ToInt32(r["Edad_80_89"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 80 a 89"].Points.AddXY((esPie) ? "de 80 a 89" : r["tipo"].ToString(), Edad_80_89);
                            this.myChart.Series[(esPie) ? "Edad" : "de 80 a 89"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 80 a 89"].Label = ((esPie) ? "de 80 a 89" : "");

                            int Edad_90_00 = Convert.ToInt32(r["Edad_90_100"].ToString());
                            this.myChart.Series[(esPie) ? "Edad" : "de 90 a 100"].Points.AddXY((esPie) ? "de 90 a 100" : r["tipo"].ToString(), Edad_90_00);
                            this.myChart.Series[(esPie) ? "Edad" : "de 90 a 100"].IsValueShownAsLabel = true;
                            if (!esPie)
                                this.myChart.Series[(esPie) ? "Edad" : "de 90 a 100"].Label = ((esPie) ? "de 90 a 100" : "");
                        }
                    }
                }
            }

        }




        //Habilitar los controles del formulario
        private void Habilitar()
        {
            //this.rbPaciente.Enabled = true;
            //this.rbHistoriaMedica.Enabled = true;
            //this.rbUsuarios.Enabled = true;
            this.cbCampo.Enabled = true;
            this.lblFechaHora.Enabled = true;

        }

        //Deshabilitar los controles del formulario
        private void Deshabilitar()
        {
            //this.rbPaciente.Enabled = false;
            //this.rbHistoriaMedica.Enabled = false;
            //this.rbUsuarios.Enabled = false;
            this.cbCampo.Enabled = false;
            this.lblFechaHora.Enabled = false;

        }


        //Método Mostrar
        private void Mostrar_Graficos()
        {

            //if (this.rbPaciente.Checked)
            //{
            //    MessageBox.Show("se mostrará la bd de pacientes");
            //    //this.dataListado.DataSource = NControlEstadistico.Mostrar_Graficos_Pacientes();

            //}
            //else if (this.rbHistoriaMedica.Checked)
            //{
            //    MessageBox.Show("se mostrará la bd de pacientes");
            //    //this.dataListado.DataSource = NControlEstadistico.Mostrar_Graficos_HistoriasMedicas();
            //}
            //else if (this.rbUsuarios.Checked)
            //{
            //    MessageBox.Show("se mostrará la bd de usuarios");
            //    //this.dataListado.DataSource = NControlEstadistico.Mostrar_Graficos_Usuarios();
            //}

            //lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);


        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //tomar el id del usuario actual

            //seleccionar el nombre del tipo de grafica

            //seleccionar el origen de datos

            //seleccionar el campo

            //seleccionar la fecha y hora en que se creo el grafico
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Deshabilitar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //rbHistoriaMedica.Checked = false;
            //rbPaciente.Checked = false;
            //rbUsuarios.Checked = false;

            //cbCampo.SelectedIndex = -1;

            //cblBusqueda.SelectedIndex = 0;
            //this.txtBuscar.Clear();


        }

        private void rbPaciente_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbPaciente.Checked)
            //{
            //    //cargar los campos
            //    //Edad, Sexo, Estado Civil 
            //    //en el cbCampo
            //}
        }

        private void rbHistoriaMedica_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbHistoriaMedica.Checked)
            //{
            //    //cargar los campos
            //    //Diagnosticos, Tipo de Sangre, Razon consulta
            //    //en el cbCampo
            //}
        }

        private void rbUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbUsuarios.Checked)
            //{
            //    //cargar los campos
            //    //calcular la cantidad de Pacientes registrados por Asistente
            //    //calcular la cantidad de Citas registradas por Asistentes
            //    //calcular la cantidad de dinero que ha ganado cada Asistente por dia
            //    //calcular la cantidad de dinero que ha ganado cada Asistente por mes
            //    //calcular la cantidad de dinero que ha ganado cada Asistente por año
            //    //en el cbCampo
            //}
        }

        private void btnCrearGrafico_Click(object sender, EventArgs e)
        {
            this.GenerarGrafico();
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.lbFiltroTipo.SelectionMode = SelectionMode.MultiSimple;
        }

        private void rbBarrasApiladas_CheckedChanged(object sender, EventArgs e)
        {
            this.lbFiltroTipo.SelectionMode = SelectionMode.MultiSimple;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.lbFiltroTipo.SelectionMode = SelectionMode.MultiSimple;
        }

        private void rbGraficoColumnasApiladas_CheckedChanged(object sender, EventArgs e)
        {
            this.lbFiltroTipo.SelectionMode = SelectionMode.MultiSimple;
        }

        private void rbGraficoTorta_CheckedChanged(object sender, EventArgs e)
        {
            this.lbFiltroTipo.SelectionMode = SelectionMode.One;

            MessageBox.Show("Aviso!: este tipo de grafico permite solo 1 campo para generar la grafica.");
            
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.saveFileDialog1.FileName.Length > 0)
                {
                    this.myChart.SaveImage(this.saveFileDialog1.FileName, ChartImageFormat.Jpeg);
                    MessageBox.Show("Se ha exportado");
                }
            }
            catch (Exception)
            {

            }
        }

    }
}
