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
    public partial class frmModuloAyuda : Form
    {
        public frmModuloAyuda()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/u/0/folders/1G8cinwenhFmeDiVYBdMFqnaH8gbcohUK");
        }
    }
}
