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
            personalizarVentana();
        }
        funciones funciones = new funciones();

        //Propiedades
        private int param_idTercero;
        private int param_idProducto;

        //Manejadores
        Manejador_Factores mFactores = new Manejador_Factores();
        Manejador_Persona mPersona = new Manejador_Persona();
        Manejador_Mercaderia mMercaderia = new Manejador_Mercaderia();

        //Entidades
        csPersona csPersona = new csPersona();

        //Banderas auxiliares
        bool listaProductos = false;

        #region /////////////////////////////////////// PERSONALIZAR VENTANA ///////////////////////////////////

        //Banderas para Movimiento de Ventana
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public void personalizarVentana(){

            lvTerceroDocumento.Size = new Size(829, 254);
            lvTerceroNombre.Location = new Point(105, 98);
            lvTerceroNombre.Size = new Size(829, 254);
            lvProductos.Size = new Size(925, 207);
        }

        #endregion

        void cargarDatosPrevios() {
            csFactores f = new csFactores();
            f.Tabla = "2";
            funciones.CargarComboBox(mFactores.BuscarFactor("Tabla", f), cboTipoDocumento, 1);
            f.Tabla = "3";
            funciones.CargarComboBox(mFactores.BuscarFactor("Tabla", f), cboMoneda, 1);
            f.Tabla = "4";
            funciones.CargarComboBox(mFactores.BuscarFactor("Tabla", f), cboAlmacen, 1);
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

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            lvTerceroDocumento.Visible = true;
            funciones.CargarListView(mPersona.BuscarClienteporDNI(txtIdentificacion.Text), lvTerceroDocumento);
            this.lvTerceroDocumento.Columns[0].Width = 0;
            this.lvTerceroDocumento.Columns[1].Width = 720;
            this.lvTerceroDocumento.Columns[2].Width = 100;
            this.lvTerceroDocumento.Columns[3].Width = 0;
            this.lvTerceroDocumento.Columns[4].Width = 0;

        }

        private void txtTercero_TextChanged(object sender, EventArgs e)
        {
            lvTerceroNombre.Visible = true;
            funciones.CargarListView(mPersona.BuscarClienteporRzn(txtTercero.Text), lvTerceroNombre);
            this.lvTerceroNombre.Columns[0].Width = 0;
            this.lvTerceroNombre.Columns[1].Width = 720;
            this.lvTerceroNombre.Columns[2].Width = 100;
            this.lvTerceroNombre.Columns[3].Width = 0;
            this.lvTerceroNombre.Columns[4].Width = 0;
        }

        private void lvTerceroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.lvTerceroDocumento.Visible = false;
                this.txtIdentificacion.Focus();
                return;
            }

            if (e.KeyChar == 13)
            {
                cargarTercero(lvTerceroDocumento);
            }
        }

        void cargarTercero( ListView lv ) {
            if (lv.Items.Count > 0 && lv.SelectedIndices.Count > 0)
            {
                param_idTercero = Convert.ToInt32(lv.SelectedItems[0].SubItems[0].Text);
                txtTercero.Text = lv.SelectedItems[0].SubItems[1].Text;
                this.txtTelefono.Text = lv.SelectedItems[0].SubItems[4].Text;
                this.txtDireccion.Text = lv.SelectedItems[0].SubItems[3].Text;
                this.txtIdentificacion.Text = lv.SelectedItems[0].SubItems[2].Text;
                lvTerceroDocumento.Visible = false;
                lvTerceroNombre.Visible = false;
                txtProducto.Focus();
            }
        }

        private void lvTerceroNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.lvTerceroNombre.Visible = false;
                this.txtTercero.Focus();
                return;
            }

            if (e.KeyChar == 13)
            {
                cargarTercero(lvTerceroNombre);
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if(listaProductos == true){
                lvProductos.Visible = true;
                funciones.CargarListView(mMercaderia.buscarMercaderiaCompra(txtProducto.Text), lvProductos);
                this.lvProductos.Columns[0].Width = 0;
                this.lvProductos.Columns[1].Width = 620;
                this.lvProductos.Columns[2].Width = 100;
                this.lvProductos.Columns[3].Width = 100;
                this.lvProductos.Columns[4].Width = 100;
            }

        }

        private void lvProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.lvProductos.Visible = false;
                this.txtProducto.Focus();
                return;
            }

            if (e.KeyChar == 13)
            {
                if (lvProductos.Items.Count > 0 && lvProductos.SelectedIndices.Count > 0)
                {
                    param_idProducto = Convert.ToInt32(lvProductos.SelectedItems[0].SubItems[0].Text);
                    lblPrecioVenta.Text = lvProductos.SelectedItems[0].SubItems[2].Text;
                    lblStockDisponible.Text = lvProductos.SelectedItems[0].SubItems[3].Text;
                    lblUM.Text = lvProductos.SelectedItems[0].SubItems[4].Text;
                    txtProducto.Text = lvProductos.SelectedItems[0].SubItems[1].Text;
                    lvProductos.Visible = false;
                    txtCantidadCompra.Focus();
                }
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.lvProductos.Visible = false;
                this.txtProducto.Focus();
                return;
            }
            if (e.KeyChar == 13)
            {
                lvProductos.Focus();
                return;
            }
        }

        private void txtTercero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.lvTerceroNombre.Visible = false;
                this.txtTercero.Focus();
                return;
            }

            if (e.KeyChar == 13)
            {
                lvTerceroNombre.Focus();
                return;
            }
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.lvTerceroDocumento.Visible = false;
                this.txtIdentificacion.Focus();
                return;
            }

            if (e.KeyChar == 13)
            {
                lvTerceroDocumento.Focus();
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = dgvProductos.Rows.Count;
            //object [] nFila = new object[7];
            //nFila[0] = param_idProducto;
            //nFila[1] = c + 1;
            //nFila[2] = txtProducto.Text;
            //nFila[3] = Math.Round( Convert.ToDouble(txtPrecioCompra.Text), 2);
            //nFila[4] = Math.Round( Convert.ToDouble(txtCantidadCompra.Text), 2 );
            //nFila[5] = Math.Round(Convert.ToDouble(txtCantidadCompra.Text) * Convert.ToDouble(txtPrecioCompra.Text), 2);
            //nFila[6] = Convert.ToInt32(cboAlmacen.SelectedValue);
            //dgvProductos.Rows.Add(nFila);
            DataGridViewRow nFila = new DataGridViewRow();
            nFila.CreateCells(dgvProductos);
            nFila.Cells[0].Value = param_idProducto;
            nFila.Cells[1].Value = c + 1;
            nFila.Cells[2].Value = txtProducto.Text;
            nFila.Cells[3].Value = Math.Round(Convert.ToDouble(txtPrecioCompra.Text), 2);
            nFila.Cells[4].Value = Math.Round(Convert.ToDouble(txtCantidadCompra.Text), 2);
            nFila.Cells[5].Value = Math.Round(Convert.ToDouble(txtCantidadCompra.Text) * Convert.ToDouble(txtPrecioCompra.Text), 2);
            nFila.Cells[6].Value = Convert.ToInt32(cboAlmacen.SelectedValue);
            colorearFila(nFila);
            dgvProductos.Rows.Add(nFila);
            param_idProducto = 0;
            txtProducto.Clear();
            lblPrecioVenta.Text = "------";
            lblStockDisponible.Text = "------";
            txtCantidadCompra.Text = "0";
            txtPrecioCompra.Text = "0.00";
            lblUM.Text = "?";
        }

        public bool verificarColor(DataGridView dgv, Color color, bool r){
            foreach(DataGridViewRow row in dgv.Rows ){
                    Color c = row.Cells[0].Style.BackColor;
                    if (c == color)
                    {
                        r = false;
                        break;
                    }
                    else {
                        r = true;
                    }
            }
            return r;
        }

        public void colorearFila(DataGridViewRow fila) {
            // creamos el color aleatorio;
            Color colorAleatorio = funciones.colorAleatorio(255,255,255,100);
            //verificamos si el color no se encuentra en el Datagridview
            bool r = true;

            while (verificarColor(dgvProductos, colorAleatorio, r) == false){
                colorAleatorio = funciones.colorAleatorio(255, 255, 255, 100);
            }
            fila.DefaultCellStyle.BackColor = colorAleatorio;

        }

        private void dgvProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvProductos.Columns[e.ColumnIndex].Name.Equals("PrecioUnitario") || this.dgvProductos.Columns[e.ColumnIndex].Name.Equals("Cantidad"))
            {
                DataGridViewRow fila = dgvProductos.CurrentRow;

                double precio = Math.Round(Convert.ToDouble( fila.Cells["PrecioUnitario"].Value), 2);
                int cantidad = Convert.ToInt32( fila.Cells["Cantidad"].Value);

                fila.Cells["SubTotal"].Value = Math.Round( precio * cantidad ,2);
            }
        }

        private void txtProducto_Enter(object sender, EventArgs e)
        {
            listaProductos = true;
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            listaProductos = false;
        }

        private void dgvProductos_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null){
                return;
            }

            DataGridViewRow dr = dgvProductos.CurrentRow;
            lblProducto.Text = "Item: " + dr.Cells["item"].Value.ToString() ;
            param_idProducto = Convert.ToInt32( dr.Cells[0].Value);
        }

        private void frmCompras_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmCompras_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmCompras_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void lblTitulo_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {

        }

        
         
    }
}
