﻿using System;
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
    public partial class frmListaHistorialTotal : Form
    {
        public frmListaHistorialTotal()
        {
            InitializeComponent();
        }

        private void frmListaHistorialTotal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spListaHistorialTotal' Puede moverla o quitarla según sea necesario.
            this.spListaHistorialTotalTableAdapter.Fill(this.dsPrincipal.spListaHistorialTotal);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
