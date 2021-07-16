using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmGenerarGraficos : Form
    {
        public frmGenerarGraficos()
        {
            InitializeComponent();
        }


        public static DUsuario Session_Actual = frmPrincipal.User_Actual;

        private void btnCrearGrafico_Click(object sender, EventArgs e)
        {

            try
            {
                if (cbCampo.SelectedIndex == -1)
                {
                    MessageBox.Show("Para generar un grafico es necesario seleccionar el campo que le interesa visualizar");
                }
                else
                {

                    DataTable TablaPac = new DataTable();

                    TablaPac = NPacientes.Mostrar();


                    if (cbCampo.SelectedItem.Equals("Sexo"))
                    {


                        int numberOfWomen = TablaPac.Select("sexo = 'Femenino'").Length;
                        int numberOfMen = TablaPac.Select("sexo = 'Masculino'").Length;

                        //Grafica de Barras
                        chartBarras.Series.Add("Sexo");
                        chartBarras.Series["Sexo"].ChartType = SeriesChartType.Column;
                        chartBarras.Series["Sexo"].Points.AddXY("Femenino", numberOfWomen);
                        chartBarras.Series["Sexo"].Points.AddXY("Masculino", numberOfMen);

                        //Grafica Circular
                        chartCircular.Series.Add("Sexo");
                        chartCircular.Series["Sexo"].ChartType = SeriesChartType.Pie;
                        chartCircular.Series["Sexo"].Points.AddXY("Femenino", numberOfWomen);
                        chartCircular.Series["Sexo"].Points.AddXY("Masculino", numberOfMen);

                        //Grafica de Linea
                        chartLinea.Series.Add("Sexo");
                        chartLinea.Series["Sexo"].ChartType = SeriesChartType.Line;
                        chartLinea.Series["Sexo"].Points.AddXY("Femenino", numberOfWomen);
                        chartLinea.Series["Sexo"].Points.AddXY("Masculino", numberOfMen);


                    }

                    else if (cbCampo.SelectedItem.Equals("Estado Civil"))
                    {


                        int numberOfSingles = TablaPac.Select("estado_civil = 'soltero'").Length;
                        int numberOfMarried = TablaPac.Select("sexo = 'casado'").Length;

                        //Grafica de Barras
                        chartBarras.Series.Add("Estado Civil");
                        chartBarras.Series["Estado Civil"].ChartType = SeriesChartType.Column;

                        chartBarras.Series["Estado Civil"].Points.AddXY("Solteros", numberOfSingles);
                        chartBarras.Series["Estado Civil"].Points.AddXY("Casados", numberOfMarried);

                        //Grafica Circular
                        chartCircular.Series.Add("Estado Civil");
                        chartCircular.Series["Estado Civil"].ChartType = SeriesChartType.Pie;
                        chartCircular.Series["Estado Civil"].Points.AddXY("Solteros", numberOfSingles);
                        chartCircular.Series["Estado Civil"].Points.AddXY("Casados", numberOfMarried);

                        //Grafica de Linea
                        chartLinea.Series.Add("Estado Civil");
                        chartLinea.Series["Estado Civil"].ChartType = SeriesChartType.Line;
                        chartLinea.Series["Estado Civil"].Points.AddXY("Solteros", numberOfSingles);
                        chartLinea.Series["Estado Civil"].Points.AddXY("Casados", numberOfMarried);

                    }

                    else if (cbCampo.SelectedItem.Equals("Edad"))
                    {


                        //TO DO calcular edades y organizarlas aqui

                        int numberOfPac = TablaPac.Rows.Count;

                        //Grafica de Barras
                        chartBarras.Series.Add("Edad");
                        chartBarras.Series["Edad"].ChartType = SeriesChartType.Column;
                        chartBarras.Series["Edad"].Points.AddXY("edad", numberOfPac);

                        //Grafica Circular
                        chartCircular.Series.Add("Edad");
                        chartCircular.Series["Edad"].ChartType = SeriesChartType.Pie;
                        chartCircular.Series["Edad"].Points.AddXY("edad", numberOfPac);

                        //Grafica de Linea
                        chartLinea.Series.Add("Edad");
                        chartLinea.Series["Edad"].ChartType = SeriesChartType.Line;
                        chartLinea.Series["Edad"].Points.AddXY("edad", numberOfPac);

                    }

                    this.btnCrearGrafico.Enabled = false;

                    this.btnLimpiarGrafico.Enabled = true;

                    chartBarras.DataSource = TablaPac;
                    chartBarras.DataBind();


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLimpiarGrafico_Click(object sender, EventArgs e)
        {
            //limpiar todo
            cbCampo.SelectedIndex = -1;
            tabControl1.SelectedIndex = -1;

            chartBarras.Series.Clear();
            chartCircular.Series.Clear();
            chartLinea.Series.Clear();

            //luego activar el boton de generar
            this.btnCrearGrafico.Enabled = true;
        }

        private void btnImprimirGrafico_Click(object sender, EventArgs e)
        {
            //TO DO: añadir el codigo de importar PDF
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void graficoPaciente_Load(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString();
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmControlEstadistico frm = new frmControlEstadistico();
            frm.Show();

        }
    }
}
