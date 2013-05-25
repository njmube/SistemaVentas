using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ventas_Milton.Datos;
using Ventas_Milton.Manejadores;
using System.Collections;

namespace Ventas_Milton.Vista
{
    public partial class frmFactores : Form
    {
        public frmFactores()
        {
            InitializeComponent();
        }

        public int tipoGuardado;
        public string param_tabla;
        public int param_idFactor;
        public string p_concepto;
        public string p_monto;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        funciones funciones = new funciones();
        Manejador_Factores mFactores = new Manejador_Factores();

        #region ////////////////////// Personalizar Ventana /////////////////////////

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtBuscar, 0);
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtBuscar, 1);
        }

        private void txtConcepto_Enter(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtConcepto, 0);
        }

        private void txtConcepto_Leave(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtConcepto, 1);
        }

        private void txtMonto_Enter(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtMonto, 1);
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            funciones.textBoxFocus(txtMonto, 0);
        }

        private void frmFactores_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void frmFactores_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void frmFactores_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            frmFactores_MouseMove(sender, e);
        }
        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            frmFactores_MouseDown(sender, e);
        }
        private void lblTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            frmFactores_MouseUp(sender, e);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;
                btnMaximizar.Image = Ventas_Milton.Properties.Resources.Maximizar;

            }
            else
            {

                this.WindowState = FormWindowState.Maximized;
                btnMaximizar.Image = Ventas_Milton.Properties.Resources.Restaurar;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        private int obtenerTabla(string tabla) 
        {
            int idtabla = 0;
            Hashtable parametros = new Hashtable();
            parametros.Add("TipoDocumento", 1);
            parametros.Add("Moneda", 2);
            parametros.Add("Parametros", 3);

            for (int i = 0; i <= parametros.Count; i++)
            {
                if (parametros.Contains(tabla))
                {
                    idtabla = int.Parse(parametros[tabla].ToString());
                    break;
                }
                else
                {
                    idtabla = -1;
                }
            }
            return idtabla;
        }

        void cargarDatosPrevios() {
            csFactores f = new csFactores();
            f.Tabla = obtenerTabla(param_tabla).ToString();
            funciones.CargarDataGrid(mFactores.BuscarFactor("Tabla", f), dgvFactores);
        }
        void inicio() {
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = true;
            funciones.LimpiarTextBox(gbBuscar);
            funciones.LimpiarTextBox(pnlPrincipal);
            pnlBuscar.Enabled = true;
            pnlPrincipal.Enabled = false;
            pnlTabla.Enabled = true;
            tipoGuardado = 0;
            cargarDatosPrevios();
            txtBuscar.Focus();
            lblConceptos.Text = p_concepto;
            lblMonto.Text = p_monto;
            lblBuscar.Text = p_concepto;
        }
        void nuevo() {
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnImprimir.Enabled = false;
            funciones.LimpiarTextBox(gbBuscar);
            funciones.LimpiarTextBox(pnlPrincipal);
            pnlBuscar.Enabled = false;
            pnlPrincipal.Enabled = true;
            pnlTabla.Enabled = false;
            tipoGuardado = 0;
            txtBuscar.Focus();
        }
        void modificar() {
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnImprimir.Enabled = false;
            pnlBuscar.Enabled = false;
            pnlPrincipal.Enabled = true;
            pnlTabla.Enabled = false;
            tipoGuardado = 1;
            //txtBuscar.Focus();
            seleccionar();
        }
        void eliminar() {
            if (dgvFactores.CurrentRow == null) 
            {
                MessageBox.Show("No a seleccionado ninguna fia, seleccione una fila");
            }
            DataGridViewRow fila = new DataGridViewRow();
            fila = dgvFactores.CurrentRow;
            param_idFactor = Convert.ToInt32(fila.Cells[0].Value);
            csFactores factor = new csFactores();
            factor.IdFactores = param_idFactor;
            factor.Eliminado = 1;
            mFactores.ActualizarRegistro_Factores("Eliminar", factor);
            inicio();

        }
        void guardar() {
            csFactores f = new csFactores();
            if (tipoGuardado == 0) 
            {
                f.Tabla = obtenerTabla(param_tabla).ToString();
                f.Monto = txtMonto.Text;
                f.Concepto = txtConcepto.Text.ToUpper();
                f.Eliminado = 0;
                int r = mFactores.RegistrarNuevoFactor(f);

                if (r > 0) 
                {
                    lblEstado.Text = "Se agrego nuevo registro";
                }
                else if(r <= 0)
                {
                    lblEstado.Text = "No se agrego ningun registro";
                }
                inicio();
            }
            else if (tipoGuardado == 1) 
            {
                f.IdFactores = param_idFactor;
                f.Monto = txtMonto.Text;
                f.Concepto = txtConcepto.Text;
                mFactores.ActualizarRegistro_Factores("Concepto", f);
                mFactores.ActualizarRegistro_Factores("Monto", f);
                inicio();
            }
        }
        void cancelar() {
            inicio();
        }
        void imprimir() { 

        }
        void seleccionar()
        {
            if (dgvFactores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila para modificar");
            }
            DataGridViewRow fila = new DataGridViewRow();
            fila = dgvFactores.CurrentRow;
            param_idFactor = Convert.ToInt32(fila.Cells[0].Value);
            txtConcepto.Text = Convert.ToString(fila.Cells["conceptos"].Value);
            txtMonto.Text = Convert.ToString(fila.Cells["monto"].Value);           

        }

        private void frmFactores_Load(object sender, EventArgs e)
        {
            conceptos.HeaderText = p_concepto;
            monto.HeaderText = p_monto;
            inicio();
            
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (funciones.ElementoObligatorio(txtConcepto, "Campo " + p_concepto + " obligatorio") == false ){
                return;
            }
            if (funciones.ElementoObligatorio(txtMonto, "Campo " + p_monto + " obligatorio") == false)
            {
                return;
            }
            guardar();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimir();
        }



        
    }
}
