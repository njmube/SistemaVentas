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

namespace Ventas_Milton.Vista
{
    public partial class frmMercaderia : Form
    {
        public frmMercaderia()
        {
            InitializeComponent();
        }
        DataTable dtCategoria = new DataTable();
        int tipoGuardado=0;
        Manejador_Mercaderia mMercaderia = new Manejador_Mercaderia();
        Manejador_UnidadMedida mUnidadMedida = new Manejador_UnidadMedida();
        Manejador_Categoria mCategoria = new Manejador_Categoria();
        csCategorias csCategoria = new csCategorias();
        funciones funciones = new funciones();
        Int32 acccionCategoria = 0;
        private void frmMercaderia_Load(object sender, EventArgs e)
        {
            cargarDatosPrevios();
            inicio();
        }
        #region /////////////////////////////////////////////// PersonalizarVentana ///////////////////////////////////////////////////////////



        #endregion

        public void crearNodosDelPadre(Int32 indicePadre, TreeNode nodoPadre)
        {
            // Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.
            DataView dataViewHijos = new DataView(dtCategoria);
            dataViewHijos.RowFilter = dtCategoria.Columns["idCategoriaDepende"].ColumnName + " = " + indicePadre;
            // Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = dataRowCurrent["nombre"].ToString().ToUpper().Trim();
                nuevoNodo.Name = dataRowCurrent["idcategoriaM"].ToString();
                // si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
                // del primer nivel que no dependen de otro nodo.
                if (nodoPadre == null)
                {
                    tvEstructura.Nodes.Add(nuevoNodo);
                }
                // se añade el nuevo nodo al nodo padre.
                else
                {
                    nodoPadre.Nodes.Add(nuevoNodo);
                }
                // Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
                crearNodosDelPadre(Int32.Parse(dataRowCurrent["idcategoriaM"].ToString()), nuevoNodo);
            }
        }
        public void cargarGrid()
        {
            //codCategoria
            Int32 codCategoria = Convert.ToInt32(lblCodigoCategoria.Text);
            funciones.CargarDataGrid(mMercaderia.Mercaderia_ListarxIdCategoria(codCategoria), dgvProductos);
        }
        void inicio()
        {
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = true;
            pnlFiltro.Enabled = true;
            pnlPrincipal.Enabled = false;
            dgvProductos.Enabled = true;
            tvEstructura.Enabled = true;
            tipoGuardado = 0;
            txtBuscarProducto.Focus();
        }
        void nuevo()
        {
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnImprimir.Enabled = false;
            funciones.LimpiarTextBox(pnlFiltro);
            funciones.LimpiarTextBox(pnlPrincipal);
            cboUnidad.SelectedIndex = -1;
            pnlFiltro.Enabled = false;
            pnlPrincipal.Enabled = true;
            dgvProductos.Enabled = false;
            tvEstructura.Enabled = false;
            tipoGuardado = 0;
            txtNombre.Focus();
        }
        void cargarDatosPrevios(){
            //Cargamos el Arbol
            tvEstructura.Nodes.Clear();
            dtCategoria = mCategoria.Categoria_Listar();
            crearNodosDelPadre(0, null);
            //Cargamos los Combos
            funciones.CargarComboBox(mUnidadMedida.UnidadMedida_Listar(), cboUnidad);
        }
        void modificar()
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("No se ha Seleccionado ningún registro para Modificar", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnImprimir.Enabled = false;
            pnlPrincipal.Enabled = true;
            tipoGuardado = 1;
        }
        private void tvEstructura_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            lblProducto.Text = tvEstructura.SelectedNode.Text;
            if (tvEstructura.SelectedNode.Name !="")
            {
                lblCodigoCategoria.Text = tvEstructura.SelectedNode.Name;
                funciones.CargarDataGrid(mMercaderia.Mercaderia_ListarxIdCategoria(Convert.ToInt32(lblCodigoCategoria.Text)), dgvProductos);
            }
            else
            {
                lblCodigoCategoria.Text = "-";
                funciones.CargarDataGrid(mMercaderia.Mercaderia_ListarxIdCategoria(0), dgvProductos);
            }
            
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            if (lblCodigoCategoria.Text == "-")
            {
                MessageBox.Show("No se pueda agregar una Producto"+Environment.NewLine+ " sin antes especificar su Categoria", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nuevo();
        }
        private void txtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones.Validacion_Precio(sender,e);
        }
        private void txtStockDisponible_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones.Validacion_Precio(sender, e);
        }
        private void txtPrecioUnid_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones.Validacion_Precio(sender, e);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicio();
        }
        private void dgvProductos_CurrentCellChanged(object sender, EventArgs e)
        {
            seleccionar();
        }
        void seleccionar()
        {
            if (dgvProductos.CurrentRow == null)
            {
                txtIdMercaderia.Text ="";
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                cboUnidad.SelectedIndex=-1;
                txtStockMinimo.Text ="";
                txtStockDisponible.Text ="";
                txtPrecioUnid.Text = "";
                return;
            }
            DataGridViewRow f = new DataGridViewRow();
            f = dgvProductos.CurrentRow;
            txtIdMercaderia.Text = Convert.ToString(f.Cells["codMercaderia"].Value);
            txtNombre.Text = Convert.ToString(f.Cells["nombre"].Value);
            txtDescripcion.Text = Convert.ToString(f.Cells["descripcion"].Value);
            cboUnidad.SelectedValue = Convert.ToInt32(f.Cells["idUndMedida"].Value);
            txtStockMinimo.Text = Convert.ToDouble(f.Cells["stockMinimo"].Value).ToString("N");
            txtStockDisponible.Text = Convert.ToDouble(f.Cells["stockDisponible"].Value).ToString("N");
            txtPrecioUnid.Text = Convert.ToDouble(f.Cells["precioVenta"].Value).ToString("N");
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //Validaciones

            if (funciones.ValidarTexto(txtNombre, "Ingrese el Nombre Mercadería") == false)
            {
                return;
            }
            if (funciones.ValidarTexto(txtDescripcion, "Ingrese una Descripcion") == false)
            {
                return;
            }
            if (funciones.ValidarComboBox(cboUnidad, "Debe Seleccionar la Unidad.Medida") == false)
            {
                return;
            }
            if (funciones.ValidarTexto(txtStockMinimo, "Ingrese el Stock Mínimo") == false)
            {
                return;
            }
            if (funciones.EsDouble(txtStockMinimo) == false)
            {
                return;
            }

            if (funciones.ValidarTexto(txtStockDisponible, "Ingrese un Stock") == false)
            {
                return;
            }
            if (funciones.EsDouble(txtStockDisponible) == false)
            {
                return;
            }

            if (funciones.ValidarTexto(txtPrecioUnid, "Ingrese un Precio x Unidad") == false)
            {
                return;
            }
            csMercaderia cMercaderia = new csMercaderia();
            cMercaderia.stockDisponible = Convert.ToDouble(txtStockDisponible.Text);
            cMercaderia.stockMinimo = Convert.ToDouble(txtStockMinimo.Text);
            cMercaderia.precioVenta = Convert.ToDouble(txtPrecioUnid.Text);
            cMercaderia.nombre = txtNombre.Text;
            cMercaderia.descripcion = txtDescripcion.Text;
            cMercaderia.idUnidadMedida = Convert.ToInt32(cboUnidad.SelectedValue);
            cMercaderia.idCategoria = Convert.ToInt32(lblCodigoCategoria.Text);
            cMercaderia.idUsuario = 4;
            switch (tipoGuardado)
            {
                case 0:
                    mMercaderia.Mercaderia_Ingresar(cMercaderia);
                    inicio();
                    cargarGrid();
                    break;
                case 1:
                    cMercaderia.idMercaderia = Convert.ToInt32(txtIdMercaderia.Text);
                    mMercaderia.Mercaderia_Actualizar(cMercaderia);
                    inicio();
                    cargarGrid();
                    break;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }
        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            funciones.CargarDataGrid(mMercaderia.Mercaderia_ListarxIdCategoriaxNombre(Convert.ToInt32(lblCodigoCategoria.Text), txtBuscarProducto.Text), dgvProductos);
        }
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtBuscarProducto.Text = "";
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        void eliminar()
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("No se ha Seleccionado ningún registro para Anular", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (funciones.MostrarMensajeConfirmacion("¿Desea Eliminar este elemento?") == DialogResult.Yes)
            {
                csMercaderia cMercaderia=new csMercaderia();
                cMercaderia.idMercaderia=Convert.ToInt32(txtIdMercaderia.Text);
                mMercaderia.Mercaderia_Anular(cMercaderia);
                inicio();
                cargarGrid();
            }
        }
        private void tvEstructura_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tvEstructura.SelectedNode = e.Node;
            }
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tvEstructura.SelectedNode.Nodes.Add("NuevaCategoria");
            tvEstructura.SelectedNode.Expand();
            tvEstructura.SelectedNode = tvEstructura.SelectedNode.LastNode;
            csCategoria.Nombre = "NuevaCategoria";
            csCategoria.Descripcion = "NuevaCategoria";
            csCategoria.IdCategoriaDepende = Convert.ToInt32(tvEstructura.SelectedNode.Parent.Name);
            csCategoria.IdUsuario = 4;
            tvEstructura.SelectedNode.Name = mCategoria.Categoria_Ingresar(csCategoria).ToString();
        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tvEstructura.SelectedNode.BeginEdit();
        }
        private void tvEstructura_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            csCategoria.Nombre = e.Label;
            csCategoria.Descripcion = e.Label;
            csCategoria.IdCategoriaDepende = Convert.ToInt32(e.Node.Parent.Name);
            csCategoria.IdUsuario = 4;
            csCategoria.IdCategoras = Convert.ToInt32(e.Node.Name);
            mCategoria.Categoria_Actualizar(csCategoria);
        }
        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            csCategoria.IdCategoras = Convert.ToInt32(tvEstructura.SelectedNode.Name);
            csCategoria.IdUsuario = 4;
            mCategoria.Categoria_Anular(csCategoria);
            tvEstructura.SelectedNode.Remove();
        }
    }
}
