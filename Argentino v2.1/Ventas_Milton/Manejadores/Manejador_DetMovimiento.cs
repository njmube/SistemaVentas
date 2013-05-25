using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using Ventas_Milton.Datos;
using Ventas_Milton.Entidades;

namespace Ventas_Milton.Manejadores
{
    class Manejador_DetMovimiento
    {
        static dDetMovimiento ddm = new dDetMovimiento();

        /**********************************************CONSULTAS************************************************/
        public DataTable BuscarDetalleMov(string parametro,  csDetMovimiento dm)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Codigo", 1);
            parametros.Add("Mercaderia", 2);
            parametros.Add("Movimiento", 3);
            parametros.Add("Precio", 4);
            parametros.Add("Cantidad", 5);
            parametros.Add("SubTotal", 6);
            parametros.Add("Descuento", 7);
            parametros.Add("Total", 8);
            parametros.Add("Oferta", 9);

            opcion = int.Parse(parametros[parametro].ToString());                    

            switch (opcion)
            {
                case 1: dt = ddm.ConsultarDetalleMovXCodigo(dm);
                    break;
                case 2: dt = ddm.ConsultarDetalleMovXMercaderia(dm);
                    break;
                case 3: dt = ddm.ConsultarDetalleMovXMovimiento(dm);
                    break;
                case 4: dt = ddm.ConsultarDetalleMovXPrecio(dm);
                    break;
                case 5: dt = ddm.ConsultarDetalleMovXCantidad(dm);
                    break;
                case 6: dt = ddm.ConsultarDetalleMovXSubtotal(dm);
                    break;
                case 7: dt = ddm.ConsultarDetalleMovXDescuento(dm);
                    break;
                case 8: dt = ddm.ConsultarDetalleMovXTotal(dm);
                    break;
                case 9: dt = ddm.ConsultarDetalleMovXOferta(dm);
                    break;
            }
            return dt;
        }

        /***************************************ACTUALIZACIONES Y ELIMINACIONES*********************************/
        public void ActualizarRegistro(string parametro, csDetMovimiento dm)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Mercaderia", 2);
            parametros.Add("Movimiento", 3);
            parametros.Add("Precio", 4);
            parametros.Add("Cantidad", 5);
            parametros.Add("SubTotal", 6);
            parametros.Add("Descuento", 7);
            parametros.Add("Total", 8);
            parametros.Add("Oferta", 9);
            parametros.Add("Eliminado", 10);

            opcion = int.Parse(parametros[parametro].ToString());

            switch (opcion)
            {
                case 2: ddm.ModificarMercaderia(dm);
                    break;
                case 3: ddm.ModificarMovimiento(dm);
                    break;
                case 4: ddm.ModificarPrecio(dm);
                    break;
                case 5: ddm.ModificarCantidad(dm);
                    break;
                case 6: ddm.ModificarSubTotal(dm);
                    break;
                case 7: ddm.ModificarDescuento(dm);
                    break;
                case 8: ddm.ModificarTotal(dm);
                    break;
                case 9: ddm.ModificarOferta(dm);
                    break;
                case 10: ddm.EliminarDetalleMov(dm);
                    break;
            }
        }

        /********************************************INSERCIONES***********************************************/
        public int RegistrarNuevoDetalleMov(csDetMovimiento dm)
        {
            int idInsertado;
            idInsertado = ddm.InsertarNuevoDetalleMov(dm);
            return idInsertado;
        }
    }
}
