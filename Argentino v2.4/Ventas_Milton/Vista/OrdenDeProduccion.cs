using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ventas_Milton.Entidades;
using Ventas_Milton.Manejadores;
using Ventas_Milton.Datos;
using System.Collections;

namespace Ventas_Milton.Vista
{
    public partial class OrdenDeProduccion : Form
    {
        #region //Manejadores
        Manejador_Movimientos mmov = new Manejador_Movimientos();
        Manejador_AccionUsuario ma = new Manejador_AccionUsuario();
        Manejador_DetMovimiento mdm = new Manejador_DetMovimiento();
        Manejador_Existencias me = new Manejador_Existencias();
        Manejador_Mercaderia mm = new Manejador_Mercaderia();
        #endregion

        #region //Creacion Instancias
        csMovimiento mov = new csMovimiento();
        csDetMovimiento dm = new csDetMovimiento();
        csExistencias existencia = new csExistencias();
        csMercaderia merc = new csMercaderia();
        #endregion

        #region //Variables Varios
        DataTable dt = new DataTable();
        int idUsuario, idMerc;
        ArrayList codsExistencias = new ArrayList();
        double PvMercaderia;
        string tipoProduccion;
        #endregion     
        

        public OrdenDeProduccion()
        {
            InitializeComponent();
            dgrEnProduccion.Columns["Detalles"].DisplayIndex = 6;
        }

        public OrdenDeProduccion( csMercaderia m, string tpProd,int iduser)
        {
            InitializeComponent();
            merc = m;
            tipoProduccion = tpProd;
            idUsuario = iduser;
            CargarDatos(merc);
            dgrEnProduccion.Columns["Detalles"].DisplayIndex = 6;
        }

        private void CargarDatos(csMercaderia m)
        {
            txtNombreDelProducto.Text = m.NomMercaderia;
            idMerc = m.IdMercaderia;
            PvMercaderia = m.PrecioVenta;
            DataTable dt = mm.BuscarMercaderia("Codigo", m);
            //lblNroOrdProd.Text = dt.Rows[0]["Ord. Prod."].ToString();
        }

        //private void cargarDatosMercaderiasEnProduccion(int idMercaderia)
        //{
            
        //    mov.IdMercaderia = idMercaderia;
        //    dt = mmov.BuscarMovimiento("OrdenesDeProduccion", mov);
        //    if (dt.Rows.Count != 0)
        //    {
        //        string cod = dt.Rows[0]["codMercaderia"].ToString();
        //        string fchOP = dt.Rows[0]["Fecha"].ToString();
        //        string CodOP = dt.Rows[0]["Ord. Prod."].ToString();
        //        string Serie = dt.Rows[0]["Serie"].ToString();
        //        string Estado = dt.Rows[0]["Estado"].ToString();
        //        string Cantidad = dt.Rows[0]["Cantidad"].ToString();
        //        string[] row = new string[] { cod, fchOP, CodOP, Serie, Estado, Cantidad };
        //        dgrEnProduccion.Rows.Add(row);
        //    }
        //    else
        //    {
        //        MessageBox.Show("ERROR CARGANDO DATOS");
        //    }
        //}

        private void btnGenerarOrdProd_Click(object sender, EventArgs e)
        {
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
            mov.IdMercaderia = idMerc;
            int idMov = mmov.RegistrarNuevoMovimiento(mov);
            ma.Log("MOVIMIENTO", "REGISTRO MOVIMIENTO - PRODUCCION", idUsuario, idMov);
            #endregion

            #region//Registro de Detalles de Movimiento
            if (tipoProduccion == "Racionamiento")
            {
                dm.IdMovimiento = idMov;
                dm.IdMercaderia = merc.IdMercaderia;
                dm.Cantidad = int.Parse(nudCantidadAProducir.Value.ToString());
                dm.Precio = PvMercaderia;
                dm.Eliminado = 0;
                int idDetMov = mdm.RegistrarNuevoDetalleMov(dm);
                ma.Log("DETALLEMOVIMIENTO", "REGISTRO DETALLE MOVIMIENTO - PRODUCCION", idUsuario, idDetMov);
            }
            else 
            {
                
            }
            #endregion

            #region//Registro de Nueva Existencia
            Random random = new Random();
            int codBar = random.Next(0, 9999999);
            for (int i = 0; i < int.Parse(nudCantidadAProducir.Value.ToString()); i++)
            {
                existencia.CodInternoMercaderia = codBar.ToString();
                existencia.PrecioVenta = PvMercaderia;
                existencia.FechaAdquisicion = f;
                existencia.FechaVencimiento = f;
                existencia.EstadoMercaderia = "POR PRODUCIR";
                existencia.Eliminado = 0;
                existencia.IdMovimiento = idMov;
                existencia.Ubicacion = 10;
                existencia.IdMercaderia = idMerc;
                int idExistencia = me.RegistrarNuevaExistencia(existencia);
                codsExistencias.Add(idExistencia);
                ma.Log("EXISTENCIAS", "REGISTRO NUEVA EXISTENCIA - PRODUCCION", idUsuario, idExistencia);
            }
            #endregion
            dgrEnProduccion.DataSource = mmov.BuscarMovimiento("OrdenesDeProduccion", mov);
            dgrEnProduccion.Columns["Detalles"].DisplayIndex = 6;
        }

        private void btnMostrarOrdProd_Click(object sender, EventArgs e)
        {
            dgrEnProduccion.DataSource = mmov.BuscarMovimiento("OrdenesDeProduccion", mov);
            dgrEnProduccion.Columns["Detalles"].DisplayIndex = 6;
        }

        private void dgrEnProduccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgrEnProduccion.Columns[e.ColumnIndex].Name.Equals("Detalles"))
            {
                frmControlProduccion cp = new frmControlProduccion(e.RowIndex);
                cp.Show();
            }
        }

        private void OrdenDeProduccion_Load(object sender, EventArgs e)
        {

        }
    }
}
