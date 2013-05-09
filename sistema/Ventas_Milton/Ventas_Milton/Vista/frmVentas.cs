using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ventas_Milton.Manejadores;
using Ventas_Milton.Datos;

namespace Ventas_Milton.Vista
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }
        funciones funciones = new funciones();

        Manejador_Factores mFactores = new Manejador_Factores();

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public string param_tipoMovimiento;
        public int param_idPersona;

        #region /********** Personalizar Ventana ******/

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

        private void frmVentas_MouseMove(object sender, MouseEventArgs e)
        {
            //if (dragging)
            //{
            //    Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
            //    this.Location = Point.Add(dragFormPoint, new Size(dif));
            //}
        }

        private void frmVentas_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmVentas_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            frmVentas_MouseMove(sender, e);
        }

        private void lblTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            frmVentas_MouseUp(sender, e);
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            frmVentas_MouseDown(sender, e);
        }




        #endregion

        void cargarDatosPrevios() {
            csFactores f = new csFactores();
            f.Tabla = "1";
            funciones.CargarComboBox(mFactores.BuscarFactor("Tabla",f),cboTipoDocumento,1);
            f.Tabla = "2";
            funciones.CargarComboBox(mFactores.BuscarFactor("Tabla", f), cboMoneda, 1);
            lblIgv.Text = mFactores.buscarIGV() ;
        }

        void inicio() {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = true;
            funciones.LimpiarTextBox(pnlPrincipal);
            funciones.LimpiarTextBox(pnlProducto);
            funciones.LimpiarTextBox(pnlProductos);
            pnlPrincipal.Enabled = false;
            pnlProducto.Enabled = false;
            pnlProductos.Enabled = false;
            pnlTotal.Enabled = false;
            cargarDatosPrevios();
            btnNuevo.Focus();
        }

        void nuevo() {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnImprimir.Enabled = false;
            pnlPrincipal.Enabled = true;
            pnlProducto.Enabled = true;
            pnlProductos.Enabled = true;
            pnlTotal.Enabled = true;
        }

        void guardar() { 
        }

        void cancelar() { 
        }

        void imprimir() { 
        }


        private void frmVentas_Load(object sender, EventArgs e)
        {
            inicio();
            nuevo();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
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

        

        private void txtTercero_TextChanged(object sender, EventArgs e)
        {
            Manejador_Persona mp = new Manejador_Persona();
            lvClientes.Visible = true;

            funciones.CargarListView(mp.BuscarClienteporRzn(txtTercero.Text), lvClientes);

            this.lvClientes.Columns[0].Width = 1;
            this.lvClientes.Columns[1].Width = 393;
            this.lvClientes.Columns[2].Width = 95;
            this.lvClientes.Columns[3].Width = 1;
            this.lvClientes.Columns[4].Width = 1;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            Manejador_Persona mp = new Manejador_Persona();
            lvTercerosPorDNI.Visible = true;
            
            funciones.CargarListView(mp.BuscarClienteporDNI(txtIdentificacion.Text), lvTercerosPorDNI);

            this.lvTercerosPorDNI.Columns[0].Width = 1;
            this.lvTercerosPorDNI.Columns[1].Width = 393;
            this.lvTercerosPorDNI.Columns[2].Width = 95;
            this.lvTercerosPorDNI.Columns[3].Width = 1;
            this.lvTercerosPorDNI.Columns[4].Width = 1;
        }

        private void lvTercerosPorDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) 
            {
                this.lvTercerosPorDNI.Visible = false;
                this.txtIdentificacion.Focus();
                return;
            }
            if(e.KeyChar == 13){
                CargarClienteporDNI();
            }
        }

        public void CargarClienteporDNI()
        {
            if (lvTercerosPorDNI.Items.Count > 0 && lvTercerosPorDNI.SelectedIndices.Count > 0)
            {
                param_idPersona = Convert.ToInt32(this.lvTercerosPorDNI.SelectedItems[0].SubItems[0].Text);
                txtTercero.Text = this.lvTercerosPorDNI.SelectedItems[0].SubItems[1].Text;
                this.txtTelefono.Text = this.lvTercerosPorDNI.SelectedItems[0].SubItems[4].Text;
                this.txtDireccion.Text = this.lvTercerosPorDNI.SelectedItems[0].SubItems[3].Text;
                this.txtIdentificacion.Text = this.lvTercerosPorDNI.SelectedItems[0].SubItems[2].Text;
                lvTercerosPorDNI.Visible = false;
                txtCodBarras.Focus();
            }
        }

        public void CargarClienteporRz()
        {
            if (lvClientes.Items.Count > 0 && lvClientes.SelectedIndices.Count > 0)
            {
                param_idPersona = Convert.ToInt32(this.lvClientes.SelectedItems[0].SubItems[0].Text);
                this.txtIdentificacion.Text = this.lvClientes.SelectedItems[0].SubItems[2].Text;
                this.txtDireccion.Text = this.lvClientes.SelectedItems[0].SubItems[3].Text;
                this.txtTelefono.Text = this.lvClientes.SelectedItems[0].SubItems[4].Text;
                txtTercero.Text = this.lvClientes.SelectedItems[0].SubItems[1].Text;
                lvClientes.Visible = false;
                txtCodBarras.Focus();
            }
        }

        private void lvClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.lvClientes.Visible = false;
                this.txtTercero.Focus();
                return;
            }
            if (e.KeyChar == 13)
            {
                CargarClienteporRz();
            }
        }


        private void txtCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                csMercaderia m = new csMercaderia();
                m.CodInternoMercaderia = txtCodBarras.Text;
                if (verificarProducto(m.CodInternoMercaderia) == false)
                {
                    Manejador_Mercaderia mM = new Manejador_Mercaderia();
                    DataTable dM = new DataTable();
                    dM = mM.BuscarMercaderia("CodigoInterno", m);
                    if(dM.Rows.Count != 0)
                    {
                        object[] nFila = new object[6];
                        nFila[0] = Convert.ToInt32(dM.Rows[0][0].ToString());
                        nFila[1] = dM.Rows[0][1].ToString();
                        nFila[2] = dM.Rows[0][3].ToString();
                        decimal precioUnit = Math.Round(Convert.ToDecimal(dM.Rows[0][6].ToString()), 2);
                        nFila[3] = precioUnit;
                        nFila[4] = 1;
                        nFila[5] = precioUnit;
                        dgvProdcutos.Rows.Add(nFila);
                        
                    }
                }
                txtCodBarras.Text = "";
                txtCodBarras.Focus();
                calcularTotalFactura();
            }
        }

        private void calcularTotalFactura() {
            if (dgvProdcutos.Rows.Count == 0)
            {
                return;
            }
            double NETO = 0.00;
            double IGV = Math.Round(Convert.ToDouble(lblIgv.Text) / 100,2);
            double TOTAL = 0.00;
            foreach (DataGridViewRow r in dgvProdcutos.Rows) {
                NETO = Math.Round(NETO + Convert.ToDouble(r.Cells["SubTotal"].Value), 2);
            }
            IGV = NETO * IGV;
            TOTAL = NETO + IGV;
            txtNeto.Text = NETO.ToString();
            txtIgv.Text = IGV.ToString();
            txtTotal.Text = TOTAL.ToString();
        }

        private bool verificarProducto(string codBarras) {
            bool res = false;
            if (dgvProdcutos.Rows.Count == 0)
            {
                res = false;
            }
            else {
                foreach (DataGridViewRow r in dgvProdcutos.Rows)
                {
                    string codBarrasFila = r.Cells["Codigo"].Value.ToString();
                    if (codBarrasFila == codBarras)
                    {
                        int c = Convert.ToInt32(r.Cells["Cantidad"].Value.ToString());
                        double precio = Convert.ToInt32(r.Cells["PrecioUnitario"].Value);
                        double subTotal;
                        c = c + 1;
                        r.Cells["Cantidad"].Value = c;
                        subTotal = Math.Round(precio * c, 2);
                        r.Cells["SubTotal"].Value = subTotal;
                        res = true;
                    }
                    else {
                        res = false;
                    }

                }
            }
            return res;
        }

        private void dgvProdcutos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
