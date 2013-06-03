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
    class Manejador_Existencias
    {
        static dExistencias de = new dExistencias();

        /**********************************************CONSULTAS************************************************/
        public DataTable BuscarExistencia(string parametro, csExistencias ex)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Codigo", 1);
            parametros.Add("CodigoInterno", 2);
            parametros.Add("PrecioVenta", 3);
            parametros.Add("PrecioCompra", 4);
            parametros.Add("FechaCompra", 5);
            parametros.Add("FechaVencimiento", 6);
            parametros.Add("Estado", 7);
            parametros.Add("Ubicacion", 8);
            parametros.Add("NroMovimiento", 9);

            for (int i = 0; i <= parametros.Count; i++)
            {
                if (parametros.Contains(parametro))
                {
                    opcion = int.Parse(parametros[parametro].ToString());
                }
                else
                {
                    opcion = -1;
                }
            }

            switch (opcion)
            {
                case 1: dt = de.ConsultarExistenciaXCodigo(ex);
                    break;
                case 2: dt = de.ConsultarExistenciaXCodInterno(ex);
                    break;
                case 3: dt = de.ConsultarExistenciaXPrecioVenta(ex);
                    break;
                case 4: dt = de.ConsultarExistenciaXPrecioCompra(ex);
                    break;
                case 5: dt = de.ConsultarExistenciaXFechaCompra(ex);
                    break;
                case 6: dt = de.ConsultarExistenciaXFechaVencimiento(ex);
                    break;
                case 7: dt = de.ConsultarExistenciaXEstado(ex);
                    break;
                case 8: dt = de.ConsultarExistenciaXUbicacion(ex);
                    break;
                case 9: dt = de.ConsultarExistenciaXNroMovimiento(ex);
                    break;
            }
            return dt;
        }

        /***************************************ACTUALIZACIONES Y ELIMINACIONES*********************************/
        public void ActualizarRegistro(string parametro, csExistencias ex)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("PrecioVenta", 1);
            parametros.Add("PrecioCompra", 2);
            parametros.Add("FechaCompra", 3);
            parametros.Add("FechaVencimiento", 4);
            parametros.Add("Estado", 5);
            parametros.Add("Ubicacion", 6);
            parametros.Add("NroMovimiento", 7);

            for (int i = 0; i <= parametros.Count; i++)
            {
                if (parametros.Contains(parametro))
                {
                    opcion = int.Parse(parametros[parametro].ToString());
                }
                else
                {
                    opcion = -1;
                }
            }

            switch (opcion)
            {
                case 1: de.ModificarPrecioVenta(ex);
                    break;
                case 2: de.ModificarPrecioCompra(ex);
                    break;
                case 3: de.ModificarFechaCompra(ex);
                    break;
                case 4: de.ModificarFechaVencimiento(ex);
                    break;
                case 5: de.ModificarEstado(ex);
                    break;
                case 6: de.ModificarUbicacion(ex);
                    break;
                case 7: de.ModificarNroMovimiento(ex);
                    break;
            }
        }

        /********************************************INSERCIONES***********************************************/
        public int RegistrarNuevaExistencia(csExistencias ex)
        {
            int idInsertado;
            idInsertado = de.InsertarNuevaExistencia(ex);
            return idInsertado;
        }

        public DataTable BuscarporCodigoBarras(string p)
        {
            return de.BuscarporCodigoBarras(p);
        }

        public int ventaExistencia(int e, int dm, string em)
        {
            return de.ventaExistencia(e, dm, em);
        }
    }
}
