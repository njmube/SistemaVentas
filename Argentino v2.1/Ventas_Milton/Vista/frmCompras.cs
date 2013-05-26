using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ventas_Milton.Datos;
using Ventas_Milton.Entidades;
using Ventas_Milton.Manejadores;

namespace Ventas_Milton.Vista
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        funciones funciones = new funciones();
        Manejador_Factores mFactores = new Manejador_Factores();


        #region /////////////////////////////////////// PERSONALIZAR VENTANA ///////////////////////////////////

        public void personalizarVentana(){



        }

        #endregion

        void cargarDatosPrevios() {
            csFactores f = new csFactores();
            f.Tabla = "2";
            funciones.CargarComboBox(mFactores.BuscarFactor("Tabla", f), cboTipoDocumento, 1);
            f.Tabla = "3";
            funciones.CargarComboBox(mFactores.BuscarFactor("Tabla", f), cboMoneda, 1);
        }

        void inicio() {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = true;
            funciones.LimpiarTextBox(pnlPrincipal);
            funciones.LimpiarTextBox(pnlProducto);
            funciones.LimpiarTextBox(pnlExistencias);
            dgvExistencias.Rows.Clear();
            dgvProductos.Rows.Clear();
            pnlPrincipal.Enabled = false;
            pnlProducto.Enabled = false;
            pnlExistencias.Enabled = false;
            pnlTotal.Enabled = false;
            btnNuevo.Focus();
        }

        void nuevo() { 

        }

        void guardar() { 

        }

        void cancelar() { 

        }

        void imprimir() { 

        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            cargarDatosPrevios();
        }

        private void cboEvitarEntradaRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
    }
}
