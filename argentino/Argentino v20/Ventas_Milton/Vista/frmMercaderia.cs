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
        DataTable dtControles = new DataTable();
        int tipoGuardado=0;
        Manejador_Mercaderia mMercaderia = new Manejador_Mercaderia();
        Manejador_UnidadMedida mUnidadMedida = new Manejador_UnidadMedida();
        Manejador_Categorias mCategoria = new Manejador_Categorias();
        static csCategorias c = new csCategorias();
        funciones funciones = new funciones();
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
            DataView dataViewHijos = new DataView(dtControles);
            dataViewHijos.RowFilter = dtControles.Columns["idCategoriaDepende"].ColumnName + " = " + indicePadre;
            // Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = dataRowCurrent["NombreCategoria"].ToString().ToUpper().Trim();
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
        private void tvEstructura_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblProducto.Text = tvEstructura.SelectedNode.Text;
            c.Nombre = lblProducto.Text;
            lblCodigoCategoria.Text = mCategoria.BuscarCategoria("Nombre",c).Rows[0][0].ToString();
        }
        public void cargarGrid()
        {
            //codCategoria
            Int32 codCategoria = Convert.ToInt32(lblCodigoCategoria.Text);
            //funciones.CargarDataGrid(mMercaderia.ConsultarMercaderiaXCategoria(codCategoria), dgvProductos);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
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
            tipoGuardado = 0;
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
            cboEstado.SelectedIndex = -1;
            pnlFiltro.Enabled = false;
            pnlPrincipal.Enabled = true;
            tipoGuardado = 0;
            txtCodInterno.Focus();
        }
        void cargarDatosPrevios(){
            //Cargamos el Arbol
            tvEstructura.Nodes.Clear();
            dtControles = mMercaderia.BuscarMercaderia("TodosRecursivo", null);
            crearNodosDelPadre(0, null);
            //Cargamos los Combos
            funciones.CargarComboBox(mUnidadMedida.BuscarUnidad("Todos",null),cboUnidad);
        }
        void modificar()
        {
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnImprimir.Enabled = false;
            tipoGuardado = 1;
        }
        void eliminar()
        { 
        
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (funciones.ValidarTexto(txtCodGrupoMercaderia, "Debe Cod.Grupo Mercaderia") == false)
            {
                return;
            }
            if (funciones.EsEntero(txtCodGrupoMercaderia) == false)
            {
                return;
            }
            if (funciones.ValidarTexto(txtCodInterno, "Ingrese el Cod.Interno") == false)
            {
                return;
            }
            if (funciones.ValidarComboBox(cboEstado, "Debe Seleccionar Estado Mercadería") == false)
            {
                return;
            }
            if (funciones.ValidarTexto(txtNombre, "Ingrese el Nombre Mercadería") == false)
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
            if (funciones.ValidarTexto(txtDescripcion, "Ingrese una Descripcion") == false)
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
            if (funciones.ValidarComboBox(cboUnidad, "Debe Seleccionar la Unidad.Medida") == false)
            {
                return;
            }
            if (funciones.ValidarTexto(txtPrecioUnid, "Ingrese un Precio x Unidad") == false)
            {
                return;
            }
            if (funciones.ValidarTexto(txtIdProveedor, "Seleccione un Proveedor") == false)
            {
                return;
            }
            if (funciones.ValidarTexto(txtPrecioAdquisicion, "Ingrese Precio Adquisicion") == false)
            {
                return;
            }
            if (funciones.ValidarTexto(txtIdLote, "Seleccione un Lote") == false)
            {
                return;
            }
            csMercaderia cMercaderia = new csMercaderia();
            //cMercaderia.CodInternoMercaderia = txtCodInterno.Text;
            //cMercaderia.CodMercaderiaIntegral = Convert.ToInt32(txtCodGrupoMercaderia.Text);
            cMercaderia.NomMercaderia = txtNombre.Text;
            //cMercaderia.DescripcionMercaderia = txtDescripcion.Text;
            //cMercaderia.StockDisponible = Convert.ToDouble(txtStockDisponible.Text);
            //cMercaderia.StockMinimo = Convert.ToDouble(txtStockMinimo.Text);
            //cMercaderia.PrecioXUndMedida = Convert.ToDouble(txtPrecioUnid.Text);
            //cMercaderia.PrecioAdquisicion = Convert.ToDouble(txtPrecioAdquisicion.Text);
            //cMercaderia.FchAdquisicionProduccion = Convert.ToDateTime(fechaAdquisicion.Value);
            //cMercaderia.FechVencimiento = Convert.ToDateTime(fechaVencimiento.Value);
            //cMercaderia.EstadoMercaderia = cboEstado.Text;
            cMercaderia.Eliminado = 0;
            cMercaderia.CodUndMedida = Convert.ToInt32(cboUnidad.SelectedValue);
            //cMercaderia.Proveedor = Convert.ToInt32(txtIdProveedor.Text);
            //cMercaderia.IdUsuario = 3;
            //cMercaderia.IdCategoria = Convert.ToInt32(lblCodigoCategoria.Text);
            //cMercaderia.IdLote = Convert.ToInt32(txtIdLote.Text);
            switch (tipoGuardado)
            {
                case 0:
                    mMercaderia.RegistrarNuevaMercaderia(cMercaderia);
                    inicio();
                    cargarGrid();
                    break;
                case 1:
                    cMercaderia.IdMercaderia = Convert.ToInt32(txtIdMercaderia.Text);
                    //mMercaderia.mercaderia_Actualizar(cMercaderia);
                    inicio();
                    cargarGrid();
                    break;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicio();
        }
        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.LvProveedor.Visible = false;
                txtProveedor.Focus();
                return;
            }
        }
        private void txtProveedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
                this.LvProveedor.Focus();
            }
        }
        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtProveedor.Text.Trim() != "")
            {
                Manejador_Persona mPersona = new Manejador_Persona();
                LvProveedor.Visible = true;
                //funciones.CargarListView(mPersona.persona_ListarxNombre(txtProveedor.Text), LvProveedor);
                FormatearLvProveedor();
            }
        }
        public void FormatearLvProveedor()
        {
            LvProveedor.Columns[0].Width = 0;
            LvProveedor.Columns[1].Width = 260;
        }
        private void LvProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                LvProveedor.Visible = false;
                txtNombre.Focus();
                return;
            }
            if (e.KeyChar == 13)
            {
                CargarProveedor();
            }
        }
        public void CargarProveedor()
        {
            if (this.LvProveedor.Items.Count > 0 && LvProveedor.SelectedIndices.Count > 0)
            {
                txtIdProveedor.Text = this.LvProveedor.SelectedItems[0].SubItems[0].Text;
                txtProveedor.Text = this.LvProveedor.SelectedItems[0].SubItems[1].Text.ToUpper();
                LvProveedor.Visible = false;
            }
        }
        private void LvProveedor_DoubleClick(object sender, EventArgs e)
        {
            CargarProveedor();
        }
    }
}
