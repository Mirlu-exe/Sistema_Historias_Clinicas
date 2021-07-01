using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);


            if (progressBar1.Value == 20)
            {

                lblCarga.Text = "Cargando base de datos";

            }

            if (progressBar1.Value == 40)
            {

                lblCarga.Text = "Cargando Archivos";

            }


            if (progressBar1.Value == 60)
            {

                lblCarga.Text = "Cargando Historias Medicas";

            }



            if (progressBar1.Value == 80)
            {

                lblCarga.Text = "Iniciando";

            }

            if (progressBar1.Value == 100)
            {

                timer1.Stop();
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }
    }
}
