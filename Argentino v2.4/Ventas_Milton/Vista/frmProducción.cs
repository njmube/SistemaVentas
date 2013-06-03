using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ventas_Milton.Entidades;
using Ventas_Milton.Datos;
using Ventas_Milton.Manejadores;
using System.Collections;

namespace Ventas_Milton.Vista
{
    public partial class frmProducción : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        funciones funciones = new funciones();
        Manejador_Categorias mc = new Manejador_Categorias();
        Manejador_Mercaderia mm = new Manejador_Mercaderia();
        Manejador_Movimientos mmov = new Manejador_Movimientos();
        Manejador_Existencias me = new Manejador_Existencias();
        Manejador_DetMovimiento mdm = new Manejador_DetMovimiento();
        Manejador_AccionUsuario ma = new Manejador_AccionUsuario();
        Manejador_Factores mf = new Manejador_Factores();
        Manejador_UnidadMedida mum = new Manejador_UnidadMedida();

        static DataTable dt = new DataTable();
        ArrayList cods = new ArrayList();
        ArrayList codsExistencias = new ArrayList();

        int idUsuario;
        int idMerc;
        int contador = 0;
        
        public frmProducción(string Usuario)
        {
            InitializeComponent();
            cargarDatosPrevios();
            idUsuario = int.Parse(Usuario);
            pnlEmpaquetacion.Visible = true;
            pnlProductosRacionamiento.Visible = false;
        }



        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            frmProducción_MouseMove(sender, e);
        }
        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            frmProducción_MouseDown(sender, e);
        }
        private void lblTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            frmProducción_MouseUp(sender, e);
        }
        private void frmProducción_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void frmProducción_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void frmProducción_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbDestino.SelectedValue.ToString());
            csMercaderia m = new csMercaderia();
            int index = cmbCategoria.SelectedIndex + 1;
            m.CodCategoria = index;
            funciones.CargarDataGrid(mm.BuscarMercaderia("Categoria", m), dgrSeleccionProductos);
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgrSeleccionProductos.Rows.Count; i++) 
            {
                bool seleccionado;
                if (dgrSeleccionProductos.Rows[i].Cells["Seleccionar"].Value == null)
                {
                    seleccionado = false;
                }
                else 
                {
                    seleccionado = true;
                }
                
                if(seleccionado == true)
                {
                    int codigo = int.Parse(dgrSeleccionProductos.Rows[i].Cells["CodProducto"].Value.ToString());
                    cods.Add(codigo);
                    MessageBox.Show("Codigo de Producto en Posicion [" + i + "] es => " + cods[i]);
                }
            }
            cargarDatosMercaderiaProduccion(cods);
            cods.Clear();
        }
        private void btnProducir_Click(object sender, EventArgs e)
        {
            csMovimiento mov = new csMovimiento();
            csDetMovimiento dm = new csDetMovimiento();

            csExistencias existencia = new csExistencias();

            int yyyy = System.DateTime.Today.Year;
            int MM = System.DateTime.Today.Month;
            int dd = System.DateTime.Today.Day;
            DateTime f = new DateTime(yyyy, MM, dd);

            #region//Registro de un Movimiento

            mov.TipoMovimiento = "PRODUCCION";
            mov.Fecha = f;
            mov.Hora = DateTime.Now.ToShortTimeString();
            mov.IdPersona = idUsuario;
            mov.UbicacionFinal = 10;
            mov.UbicacionInicial = 10;
            mov.idTipoDocumento = 12;            
            int idMov = mmov.RegistrarNuevoMovimiento(mov);
            ma.Log("MOVIMIENTO", "REGISTRO MOVIMIENTO - PRODUCCION", idUsuario, idMov);


            #endregion

            #region//Registro de Detalles de Movimiento
            for (int i = 0; i < dgrProductosProduccion.Rows.Count; i++) 
            {
                dm.IdMovimiento = idMov;
                dm.IdMercaderia = int.Parse(dgrProductosProduccion.Rows[i].Cells[0].Value.ToString());
                dm.Cantidad = int.Parse(nudCantProducir.Value.ToString());
                dm.Precio = double.Parse(txtPrecioAcumulado.Text);
                dm.Eliminado = 0;
                int idDetMov = mdm.RegistrarNuevoDetalleMov(dm);
                ma.Log("DETALLEMOVIMIENTO", "REGISTRO DETALLE MOVIMIENTO - PRODUCCION", idUsuario, idDetMov);
            }
            #endregion            

            #region//Registro de Nueva Existencia
            Random random = new Random();
            int codBar = random.Next(0, 9999999);
            for (int i = 0; i < int.Parse(nudCantProducir.Value.ToString()); i++)
            {
                if (rbtEmpaquetacion.Checked == true) { existencia.CodInternoMercaderia = "EMPQ100" + codBar; }
                else { existencia.CodInternoMercaderia = "RAC200" + codBar; }
                existencia.PrecioVenta = double.Parse(txtPrecioAcumulado.Text);
                existencia.FechaAdquisicion = f;
                existencia.FechaVencimiento = f;
                existencia.EstadoMercaderia = "POR PRODUCIR... ";
                existencia.Eliminado = 0;
                existencia.IdMovimiento = idMov;
                existencia.Ubicacion = 10;
                existencia.IdMercaderia = idMerc;
                int idExistencia = me.RegistrarNuevaExistencia(existencia);
                codsExistencias.Add(idExistencia);
                ma.Log("EXISTENCIAS", "REGISTRO NUEVA EXISTENCIA - PRODUCCION", idUsuario, idExistencia);
            }
            #endregion

            MessageBox.Show("Carácteristicas de producto registradas");
        }        

        private void dgrProductosProduccion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgrProductosProduccion.Rows.RemoveAt(dgrProductosProduccion.CurrentRow.Index);
        }
        private void dgrProductosProduccion_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double precioReferencial = 0;
            for (int i = 0; i < dgrProductosProduccion.Rows.Count; i++) 
            {
                string precio = dgrProductosProduccion.Rows[i].Cells[4].Value.ToString();
                precioReferencial = precioReferencial + double.Parse(precio);
                txtPrecioAcumulado.Text = precioReferencial.ToString();
            }
        }
        private void dgrProductosProduccion_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double precioReferencial = 0;
            for (int i = 0; i < dgrProductosProduccion.Rows.Count; i++)
            {
                string precio = dgrProductosProduccion.Rows[i].Cells[5].Value.ToString();
                precioReferencial = precioReferencial + double.Parse(precio);
                txtPrecioAcumulado.Text = precioReferencial.ToString();
            }
        }
        private void txtPorcGanancia_TextChanged_1(object sender, EventArgs e)
        {
      
        }

        //private void btnMostrarOrdProd_Click(object sender, EventArgs e)
        //{
        //    cargarDatosMercaderiasEnProduccion(idMerc);
        //}

        //CARGA DE DATOS EN DATAGRIDVIEW Y COMBOBOX
        private void cargarDatosPrevios()
        {
            csCategorias cat = new csCategorias();
            funciones.CargarComboBox(mc.BuscarCategoria("Todos", cat), cmbCategoria, 1);
            csUnidadMedida um = new csUnidadMedida();
            funciones.CargarComboBox(mum.BuscarUndMedida("Todos", um), cmbUndMedida);
            //csFactores fact = new csFactores();
            //fact.Tabla = "4";
            //funciones.CargarComboBox(mf.BuscarFactor("Tabla", fact), cmbDestino, 1);
        }
        private void cargarDatosMercaderiaProduccion(ArrayList array) 
        {
            for (int i = 0; i < array.Count; i++) 
            {
                string precio = null;
                csMercaderia m = new csMercaderia();
                m.IdMercaderia = int.Parse(array[i].ToString());
                dt = mm.BuscarMercaderia("AProduccion", m);
                if (dt.Rows.Count != 0)
                {
                    string cod = dt.Rows[0]["Codigo"].ToString();
                    string Mercaderia = dt.Rows[0]["Mercaderia"].ToString();
                    string stock = dt.Rows[0]["Stock"].ToString();
                    precio = dt.Rows[0]["Precio"].ToString();
                    string[] row = new string[] { cod, Mercaderia,stock,"1",precio };
                    dgrProductosProduccion.Rows.Add(row);    
                
                }else { MessageBox.Show("ERROR CARGANDO DATOS"); }
            }            
        }
        private void cargarDatosMercaderiaProduccion(int codigo)
        {
            string precio = null;
            csMercaderia m = new csMercaderia();
            m.IdMercaderia = codigo;
            dt = mm.BuscarMercaderia("AProduccion", m);
            if (dt.Rows.Count != 0)
            {
                string cod = dt.Rows[0]["Codigo"].ToString();
                txtCategoria.Text = cmbCategoria.SelectedValue.ToString();
                //string Mercaderia = dt.Rows[0]["Mercaderia"].ToString();
                //string stock = dt.Rows[0]["Stock"].ToString();
                txtPrecioReferencia_Rac.Text = dt.Rows[0]["Precio"].ToString();
                //string[] row = new string[] { cod, Mercaderia, stock, "1", precio };
                //dgrProductosProduccion.Rows.Add(row);

            }
            else 
            {
                frmMessageBox mb = new frmMessageBox("ERROR CARGANDO DATOS");
                mb.Show();
            }
        }


        private void dgvProdcutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbtEmpaquetacion.Checked == true)
            {
                int codigo = int.Parse(dgrSeleccionProductos.Rows[dgrSeleccionProductos.CurrentRow.Index].Cells["CodProducto"].Value.ToString());
                cods.Add(codigo);
                cargarDatosMercaderiaProduccion(cods);
                cods.Clear();
            }
            else 
            {                
                if (contador < 1)
                {
                    int codigo = int.Parse(dgrSeleccionProductos.Rows[dgrSeleccionProductos.CurrentRow.Index].Cells["CodProducto"].Value.ToString());
                    cargarDatosMercaderiaProduccion(codigo);
                    contador = 1;
                }
                else 
                {
                    frmMessageBox mb = new frmMessageBox("Solo puede Seleccionar un Producto a la vez");
                }
            }            
        }
        private void dgrEnProduccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.dgrEnProduccion.Columns[e.ColumnIndex].Name.Equals("Detalles"))
            //{
            //    MessageBox.Show("OLA K ASE?");

            //}
        }
        private void cmbTipoProduccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Rac_Click(object sender, EventArgs e)
        {
            csMercaderia m = new csMercaderia();
            //Registro de Nueva Mercaderia
            m.StockDisponible = 0;
            m.NomMercaderia = txtNombreProducto_Racionamiento.Text;
            m.PrecioVenta = calcularPv(txtPrecioReferencia_Rac.Text, txtGanancia_Rac.Text);
            m.Descripcion = "PRODUCTO DE RACIONAMIENTO";
            m.idCategoria = int.Parse(cmbCategoria.SelectedValue.ToString());
            m.Eliminado = 1;
            idMerc = mm.RegistrarNuevaMercaderia(m);
            m.IdMercaderia = idMerc;
            ma.Log("MERCADERIA", "REGISTRO MERCADERIA - PRODUCCION(Empaquetamiento)", idUsuario, idMerc);
            OrdenDeProduccion ordProd = new OrdenDeProduccion(m,"Racionamiento",idUsuario);
            ordProd.Show();
            //frmWarningBox wb = new frmWarningBox("El Producto Ha Sido Creado Satisfactoriamente, Desea Generar la Orden de Produccion?", 1);
        }
        private double calcularPv(string v1,string v2)
        {
            double val1 = double.Parse(v1);
            double val2 = double.Parse("0."+v2);
            double total;

            total = val1 + (val1 * val2);

            return total;
        }

        private void btnGuardar_Empq_Click(object sender, EventArgs e)
        {
            csMercaderia m = new csMercaderia();
            //Registro de Nueva Mercaderia
            m.StockDisponible = 0;
            m.NomMercaderia = txtNombreProducto.Text;
            m.PrecioVenta = double.Parse(txtPrecioAcumulado.Text);
            m.Descripcion = "PRODUCTO DE EMPAQUETADO";
            m.CodCategoria = int.Parse(cmbCategoria.SelectedValue.ToString());
            m.Eliminado = 1;
            idMerc = mm.RegistrarNuevaMercaderia(m);
            ma.Log("MERCADERIA", "REGISTRO MERCADERIA - PRODUCCION(Empaquetamiento)", idUsuario, idMerc);
            frmWarningBox wb = new frmWarningBox("El Producto Ha Sido Creado Satisfactoriamente, Desea Generar la Orden de Produccion?", 1);
        }

        private void rbtEmpaquetacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEmpaquetacion.Checked == true)
            {
                pnlEmpaquetacion.Visible = true;
                pnlProductosRacionamiento.Visible = false;
            }
            else
            {
                pnlProductosRacionamiento.Visible = true;
                pnlEmpaquetacion.Visible = false;
            }
        }

        private void rbtXUndIntegra_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtXUndIntegra.Checked == true)
            {
                lblUndMedida.Visible = false;
                cmbUndMedida.Visible = false;
            }
            else
            {
                lblUndMedida.Visible = true;
                cmbUndMedida.Visible = true;
            }
        }

        private void txtGanancia_Rac_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecioAcumulado.Text != null)
            {
                double pReferencial = double.Parse(txtPrecioReferencia_Rac.Text);
                double porcGanancia = double.Parse("0." + txtGanancia_Rac.Text);
                double pVentaAlPublico = pReferencial + (pReferencial * porcGanancia);
                txtPrecioVenta_Rac.Text = pVentaAlPublico.ToString();
            } 
        }

        private void frmProducción_Load(object sender, EventArgs e)
        {

        }
    }
}
