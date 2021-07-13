using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CapaPresentacion
{
    public partial class frmGestionReportes : Form
    {
        public frmGestionReportes()
        {
            InitializeComponent();
        }


        private void frmGestionReportes_Load(object sender, EventArgs e)
        {
            
        }


        void CargarArchivos()
        {

            //asignar ubicación de la carpeta
            string direccion = @"C:\Users\Usuario\Desktop\Sistema_Historias_Clinicas\Reportes Guardados";

            string tipo_archivo = "tipo archivo vacio";

            if (rbPDF.Checked == true)
            {
                tipo_archivo = "*.pdf";
            }

            else if (rbEXCEL.Checked == true)
            {
                tipo_archivo = "*.xls";
            }

            else if (rbWORD.Checked == true)
            {
                tipo_archivo = "*.docx";
            }

            else
            {
                MessageBox.Show("Seleccione un tipo de archivo a mostrar");
            }


            //obtener todas las ubicaciones de cada archivo especifico (en forma de array string)
            string[] reporte_Files = Directory.GetFiles(direccion, tipo_archivo);

            //crear una datatable para manejar el array
            DataTable tabla_reportes = new DataTable();

            //añadir las columnas en el datatable
            tabla_reportes.Columns.Add("Ubicacion");
            tabla_reportes.Columns.Add("Nombre de Reporte");
            tabla_reportes.Columns.Add("Fecha de Creación");






            //cargar todos los archivos en el datatable 

            int i = reporte_Files.Length;

            while (i != 0)
            {
                //asignar la URL
                string url = reporte_Files[i - 1].ToString();

                //buscar la fecha en que fue creado el archivo que la URL dice
                DateTime fecha_creacion_url = Directory.GetCreationTime(url);

                //conseguir el nombre del archivo, recortando la url obtenida
                string nombre_url = reporte_Files[i - 1].Substring(direccion.Length + 1);



                //añadir dicho archivo a la tabla con sus respectivos datos
                tabla_reportes.Rows.Add(url, nombre_url, fecha_creacion_url);

                //disminuir el contador
                i--;
            }





            //cargar TODA la datatable en el datagridview
            dataListadoReportes.DataSource = tabla_reportes;

        }//fin de la funcion CargarArchivosPDF

        private void dataListadoReportes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ubicacion_archivo;

            ubicacion_archivo = Convert.ToString(this.dataListadoReportes.CurrentRow.Cells["Ubicacion"].Value);

            MessageBox.Show(ubicacion_archivo);

            System.Diagnostics.Process.Start(ubicacion_archivo);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarArchivos();
        }
    }
}
