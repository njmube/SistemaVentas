using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Ventas_Milton.Vista
{
    public partial class frmWarningBox : Form
    {
        int opcion;
        public frmWarningBox(string mensaje,int op)
        {
            InitializeComponent();
            txtMensaje.Text = mensaje;
            opcion = op;
        }

        private void frmWarningBox_Load(object sender, EventArgs e)
        {

        }
        private void ManipularOpcion(int op) 
        {
            int opcion = op;

            switch (opcion)
            {
                case 1: 
                    OrdenDeProduccion odp = new OrdenDeProduccion();
                    odp.Show();
                    this.Dispose();
                    break;
                //case 2: dt = de.ConsultarExistenciaXCodInterno(ex);
                //    break;
            }
        }

    }
}
