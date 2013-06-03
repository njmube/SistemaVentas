using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ventas_Milton.Manejadores;
using Ventas_Milton.Entidades;
using Ventas_Milton.Datos;
using System.Collections;

namespace Ventas_Milton.Vista
{
    public partial class Procesos : Form
    {
        Manejador_Factores mf = new Manejador_Factores();
        funciones f = new funciones();
        DataTable dt = new DataTable();
        

        public Procesos()
        {
            InitializeComponent();
        }
        private void CargarCombo() 
        {
            csFactores factor = new csFactores();
            factor.Tabla = "5";
            dt = mf.BuscarFactor("Tabla", factor);
            f.CargarComboBox(dt, cmbProceso);
        }

        int Nomproceso;

        public int Nomproceso1
        {
            get { return Nomproceso; }
            set { Nomproceso = value; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string seleccion = cmbProceso.SelectedItem.ToString();
            Hashtable parametros = new Hashtable();
            parametros.Add("ALISTADO",12);
            parametros.Add("LLENADO",13);
            parametros.Add("CERRADO",14);
            parametros.Add("ETIQUETADO",15);
            parametros.Add("ALMACENADO",16);
            Nomproceso = int.Parse(parametros[seleccion].ToString());
            MessageBox.Show(Nomproceso.ToString());
            this.Dispose();
        }

        private void Procesos_Load(object sender, EventArgs e)
        {

        }
    }
}
