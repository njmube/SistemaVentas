using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Ventas_Milton.Manejadores;
using Ventas_Milton.Datos;
using Ventas_Milton.Entidades;

namespace Ventas_Milton.Vista
{
    public partial class frmTareas : Form
    {
        Manejador_ControlProceso mcp = new Manejador_ControlProceso();
        csRegistroDeProcesos rp = new csRegistroDeProcesos();
        int idRegistro;
        public frmTareas(int id)
        {
            InitializeComponent();
            idRegistro = id;
        }       

        string tarea;

        public string Tarea
        {
            get { return tarea; }
            set { tarea = value; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int seleccion = cmbTarea.SelectedIndex;
            Hashtable parametros = new Hashtable();
            parametros.Add(0, "Tarea 1");
            parametros.Add(1, "Tarea 2");
            parametros.Add(2, "Tarea 3");
            parametros.Add(3, "Tarea 4");
            parametros.Add(4, "Tarea 5");
            tarea = parametros[seleccion].ToString();
            MessageBox.Show(tarea);
            rp.Tarea = tarea;
            rp.IdControlProduccion = idRegistro;
            mcp.ActualizarRegistroDeProceso("Tarea", rp);
            this.Dispose();
        }
    }
}
