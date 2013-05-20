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
using Ventas_Milton.Entidades;
using System.Transactions;

namespace Ventas_Milton.Vista
{
    public partial class frmVentas : Form
    {


        funciones funciones = new funciones();
        Manejador_Factores mFactores = new Manejador_Factores();
        Manejador_Existencias mE = new Manejador_Existencias();
        Manejador_Movimientos mMovimientos = new Manejador_Movimientos();

        private int param_idProducto;
        public string param_tipoMovimiento;
        public int param_idPersona;
        private int codOfertaTotal = 0;
        private int ubicacionI = 0;
        private int ubicacionF = 0;


        public frmVentas()
        {
            InitializeComponent();
            personalizarForm();
        }

        #region ///////////////////////////////////////////// Personalizar Ventana /////////////////////////////////////////////

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public void personalizarForm(){
            lvClientes.Size = new Size(489, 173);
            lvTercerosPorDNI.Size = new Size(490, 145);
            lvProductos.Size = new Size(703, 117);
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

        private void frmVentas_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
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
            f.Tabla = "2";
            funciones.CargarComboBox(mFactores.BuscarFactor("Tabla",f),cboTipoDocumento,1);
            f.Tabla = "3";
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
            if( funciones.ElementoObligatorio(cboTipoDocumento, "Campo Tipo de Documento Obligatorio") == false ){return;}
            if (funciones.ElementoObligatorio(txtSerie, "Campo Serie Obligatorio") == false) { return;    }
            if (funciones.ElementoObligatorio(txtNumero, "Campo Numero es obligatorio") == false) { return; }
            if (funciones.ElementoObligatorio(cboMoneda, "Campo Moneda es obligatorio") == false) { return; }
            if (funciones.ElementoObligatorio(txtTercero, "Campo Razon Social es obligatorio") == false) { return; }
            if (funciones.ElementoObligatorio(txtIdentificacion, "Campo DNI / RUC es obligatorio") == false) { return; }
            if (dgvProdcutos.Rows.Count == 0) {
                MessageBox.Show("Debe ingresar por lo menos un producto");
                return;
            }
            TransactionScope ts = new TransactionScope();
            using (ts) {

                csMovimieto movimiento = new csMovimieto(param_tipoMovimiento, 
                    dtpFechaEmision.Value.Date,
                    dtpFechaEmision.Value,
                    Math.Round(Convert.ToDouble(txtTotal.Text)),
                    codOfertaTotal,
                    param_idPersona,
                    ubicacionI.ToString(),
                    ubicacionF.ToString(),
                    Convert.ToInt32(cboTipoDocumento.SelectedValue));
                movimiento.IdMovimiento = mMovimientos.RegistrarNuevoMovimiento(movimiento);

                foreach (DataGridViewRow Producto in dgvProdcutos.Rows ){
                    
                }
            }
        }

        void cancelar() { 
        }

        void imprimir() { 
        }


        private void frmVentas_Load(object sender, EventArgs e)
        {
            cargarDatosPrevios();
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

            this.lvClientes.Columns[0].Width = 1;
            this.lvClientes.Columns[1].Width = 393;
            this.lvClientes.Columns[2].Width = 95;
            this.lvClientes.Columns[3].Width = 1;
            this.lvClientes.Columns[4].Width = 1;

        }

        private void txtCodBarras_TextChanged(object sender, EventArgs e)
        {
            Manejador_Existencias mE = new Manejador_Existencias();
            lvProductos.Visible = true;

            funciones.CargarListView(mE.BuscarporCodigoBarras(txtCodBarras.Text), lvProductos);

            this.lvProductos.Columns[0].Width = 1;
            this.lvProductos.Columns[1].Width = 1;
            this.lvProductos.Columns[2].Width = 100;
            this.lvProductos.Columns[3].Width = 500;
            this.lvProductos.Columns[4].Width = 100;

        }

        private void txtCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                lvProductos.Focus();

            }

            //if (e.KeyChar == 13)
            //{
            //    csExistencias ex = new csExistencias();
            //    ex.CodInternoMercaderia = txtCodBarras.Text;
            //    if (verificarProducto(ex.CodInternoMercaderia) == false)
            //    {
            //        Manejador_Existencias mE = new Manejador_Existencias();
            //        DataTable dM = new DataTable();
            //        dM = mE.BuscarporCodigoBarras(ex.CodInternoMercaderia);
            //        if(dM.Rows.Count != 0)
            //        {
            //            param_idProducto = Convert.ToInt32(dM.Rows[0][0].ToString());
            //            txtCodBarras.Text = dM.Rows[0][1].ToString();
            //            txtProducto.Text = dM.Rows[0][3].ToString();
            //            txtPrecio.Text = Math.Round(Convert.ToDecimal(dM.Rows[0][6].ToString()), 2).ToString();
            //            decimal precioUnit = Math.Round(Convert.ToDecimal(dM.Rows[0][6].ToString()), 2);

            //            object[] nFila = new object[7];
            //            nFila[0] = Convert.ToInt32(dM.Rows[0][0].ToString()); //codigoMercaderias
            //            nFila[1] = dM.Rows[0][1].ToString(); //Mercaderia
            //            nFila[2] = ; //Precio
                        
            //            nFila[3] = 1; //cantidad;
            //            nFila[4] = ;
            //            nFila[5] = 0;
            //            nFila[5] = 0;
            //            nFila[6] = 0;
            //            dgvProdcutos.Rows.Add(nFila);
            //        }
            //    }
            //    txtCantidad.Text = "";
            //    txtCantidad.Focus();
            //    calcularTotalFactura();
            //}
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

        private void calcularTotalFactura() {
            if (dgvProdcutos.Rows.Count == 0)
            {
                return;
            }
            double NETO = 0.00;
            double IGV = Math.Round(Convert.ToDouble(lblIgv.Text) / 100,2);
            double TOTAL = 0.00;
            foreach (DataGridViewRow r in dgvProdcutos.Rows) {
                NETO = Math.Round(NETO + Convert.ToDouble(r.Cells["Total"].Value), 2);
            }
            IGV = NETO * IGV;
            TOTAL = NETO + IGV;
            txtNeto.Text = NETO.ToString();
            txtIgv.Text = IGV.ToString();
            txtTotal.Text = TOTAL.ToString();
        }

        private void lvProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.lvProductos.Visible = false;
                this.txtCodBarras.Focus();
                return;
            }

            if (e.KeyChar == 13)
            {
                if (lvProductos.Items.Count > 0 && lvProductos.SelectedIndices.Count > 0)
                {
                    int p_idMercaderia = Convert.ToInt32(this.lvProductos.SelectedItems[0].SubItems[0].Text);
                    int p_idExistencias = Convert.ToInt32(this.lvProductos.SelectedItems[0].SubItems[1].Text);
                    string p_CodBarras = this.lvProductos.SelectedItems[0].SubItems[2].Text;
                    string p_Prducto = this.lvProductos.SelectedItems[0].SubItems[3].Text;
                    double p_Precio = Math.Round(Convert.ToDouble(this.lvProductos.SelectedItems[0].SubItems[4].Text), 2);                    
                    lvProductos.Visible = false;
                    bool resultado = verificarProducto(p_idMercaderia.ToString());
                    if (resultado == false)
                    {
                        object[] nFila = new object[7];
                        nFila[0] = p_idMercaderia;
                        nFila[1] = p_Prducto;
                        nFila[2] = p_Precio;
                        nFila[3] = 1;
                        nFila[4] = p_Precio;
                        nFila[5] = 0.00;
                        nFila[6] = p_Precio;
                        dgvProdcutos.Rows.Add(nFila);
                    }
                    object[] fExistencia = new object[3];
                    fExistencia[0] = p_idMercaderia;
                    fExistencia[1] = p_idExistencias;
                    fExistencia[2] = p_CodBarras;
                    dgvExistencias.Rows.Add(fExistencia);
                    txtCodBarras.Text = "";
                    txtCodBarras.Focus();
                    lvProductos.Visible = false;
                    calcularTotalFactura();
                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13)
            //{
            //    csExistencias ex = new csExistencias();
            //    ex.CodInternoMercaderia = txtCodBarras.Text;
            //    bool resultado = verificarProducto(ex.CodInternoMercaderia);
            //    if ( resultado == false)
            //    {
                    
            //        //Manejador_Existencias mE = new Manejador_Existencias();
            //        //DataTable dM = new DataTable();
            //        //dM = mE.BuscarporCodigoBarras(ex.CodInternoMercaderia);
            //        if (funciones.ElementoObligatorio(txtCodBarras, "Codigo de Barras") == false){return;}
            //        if (funciones.ElementoObligatorio(txtProducto, "Codigo de Barras") == false){return;}
            //        if (funciones.ElementoObligatorio(txtPrecio, "Codigo de Barras") == false){return;}
            //        if (funciones.ElementoObligatorio(txtCantidad, "Codigo de Barras") == false){return;}

            //            //param_idProducto = Convert.ToInt32(dM.Rows[0][0].ToString());
            //            //txtCodBarras.Text = dM.Rows[0][1].ToString();
            //            //txtProducto.Text = dM.Rows[0][3].ToString();
            //            //txtPrecio.Text = Math.Round(Convert.ToDecimal(dM.Rows[0][6].ToString()), 2).ToString();

            //            object[] nFila = new object[6];
            //            nFila[0] = param_idProducto;
            //            nFila[1] = txtCodBarras.Text;
            //            nFila[2] = txtProducto.Text;
            //            decimal precio = Math.Round(Convert.ToDecimal(txtPrecio.Text) , 2);
            //            decimal subTotal = Math.Round(Convert.ToDecimal(txtPrecio.Text) * Convert.ToDecimal(txtCantidad.Text), 2);
            //            nFila[3] = precio;
            //            nFila[4] = txtCantidad.Text;
            //            nFila[5] = subTotal;
            //            dgvProdcutos.Rows.Add(nFila);
            //    }
            //    txtCantidad.Text = "";
            //    txtCodBarras.Text = "";
            //    txtProducto.Text = "";
            //    txtPrecio.Text = "0.00";
            //    txtCodBarras.Focus();
            //    calcularTotalFactura();
            //}
        }

        private bool verificarProducto(string idMercaderia)
        {
            bool res = false;

            if (dgvProdcutos.Rows.Count == 0)
            {
                res = false;
            }
            else
            {
                foreach (DataGridViewRow r in dgvProdcutos.Rows)
                {
                    string merca = r.Cells[0].Value.ToString();
                    if (merca == idMercaderia)
                    {
                        int c = Convert.ToInt32(r.Cells["Cantidad"].Value.ToString());
                        double precio = Convert.ToInt32(r.Cells["PrecioUnitario"].Value);
                        double subTotal;
                        c = c + 1;
                        r.Cells["Cantidad"].Value = c;
                        subTotal = Math.Round(precio * c, 2);
                        r.Cells["SubTotal"].Value = subTotal;
                        double descuento = consultarDescuento(Convert.ToDouble(r.Cells["Cantidad"].Value.ToString()));
                        r.Cells["Total"].Value = Math.Round(subTotal,2);
                        res = true;
                    }
                    else
                    {
                        res = false;
                    }
                    if (res == true)
                    {
                        break;
                    }
                }
            }
            return res;
        }

        private double consultarDescuento(double p)
        {
            return 0;
        }

        private void dgvExistencias_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //calcularTotalFactura();
        }

        private void dgvProdcutos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }

        private void dgvExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvExistencias.Rows.Count != 0) {
                if (e.KeyChar == 08)
                {
                    int celda = dgvExistencias.CurrentRow.Index;
                    int c_idmercaderia = Convert.ToInt32(dgvExistencias.CurrentRow.Cells[0].Value);
                    dgvExistencias.Rows.RemoveAt(celda);

                    foreach (DataGridViewRow fila in dgvProdcutos.Rows)
                    {
                        int id = Convert.ToInt32( fila.Cells[0].Value);
                        if (id == c_idmercaderia)
                        {
                            int f = fila.Index;
                            double precio = Convert.ToDouble(fila.Cells["PrecioUnitario"].Value);
                            double cant = Convert.ToDouble(fila.Cells["Cantidad"].Value);
                            cant = cant - 1;
                            if (cant == 0)
                            {
                                dgvProdcutos.Rows.RemoveAt(f);
                                calcularTotalFactura();
                                break;
                            }
                            fila.Cells["Cantidad"].Value = cant;
                            fila.Cells["SubTotal"].Value = Math.Round(Convert.ToDouble(fila.Cells["SubTotal"].Value) - precio, 2);
                            //AQUI VA CODIGO PARA EL DESCUENTO
                            fila.Cells["Total"].Value = Math.Round(Convert.ToDouble(fila.Cells["SubTotal"].Value) - Convert.ToDouble(fila.Cells["Descuento"].Value), 2);
                            calcularTotalFactura();
                        }
                    }
                }
            }
            
        }

        private void dgvProdcutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvProdcutos.Rows.Count != 0)
            {
                if (e.KeyChar == 08)
                {
                    int index = dgvProdcutos.CurrentRow.Index;
                    int id = Convert.ToInt32( dgvProdcutos.CurrentRow.Cells[0].Value);
                    int nFilas = dgvExistencias.Rows.Count;

                    for (int i = 0; i< nFilas; i++) {
                        nFilas = dgvExistencias.Rows.Count;
                        int c_id = Convert.ToInt32( dgvExistencias.Rows[i].Cells[0].Value);
                        if (c_id == id)
                        {
                            dgvExistencias.Rows.RemoveAt(i);
                            i = i - 1;
                        }
                    }

                    //foreach (DataGridViewRow r in dgvExistencias.Rows) {
                    //    int c_index = r.Index;
                    //    int c_id = Convert.ToInt32(r.Cells[0].Value);
                    //    if (c_id == id) {
                    //        dgvExistencias.Rows.RemoveAt(c_index);
                    //    }
                    //}

                    dgvProdcutos.Rows.RemoveAt(index);
                    calcularTotalFactura();
                }
            }
        }

        

    }
}
