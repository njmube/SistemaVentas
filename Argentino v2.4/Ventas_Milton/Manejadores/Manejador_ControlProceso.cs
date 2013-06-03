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
    class Manejador_ControlProceso
    {
        static dRegistroDeProcesos drp = new dRegistroDeProcesos();

        /**********************************************CONSULTAS************************************************/
        public DataTable BuscarRegistroDeProceso(string parametro, csRegistroDeProcesos rp)
        {
            int opcion = 0;
            DataTable dt = new DataTable();
            Hashtable parametros = new Hashtable();

            parametros.Add("Codigo", 1);
            parametros.Add("CodigoProduccion", 2);
            parametros.Add("Tarea", 3);
            parametros.Add("HoraInicioReinicio", 4);
            parametros.Add("HoraFinalizacion", 5);
            parametros.Add("CodigoProceso", 6);
            parametros.Add("Fecha", 7);
            parametros.Add("Registros", 8);

            opcion = int.Parse(parametros[parametro].ToString());

            switch (opcion)
            {
                case 1: dt = drp.ConsultarDetalleMovXCodigoRegistro(rp);
                    break;
                case 2: dt = drp.ConsultarDetalleMovXCodigoProduccion(rp);
                    break;
                case 3: dt = drp.ConsultarDetalleMovXTarea(rp);
                    break;
                case 4: dt = drp.ConsultarDetalleMovXHoraInicioReinicio(rp);
                    break;
                case 5: dt = drp.ConsultarDetalleMovXHoraFinalizacion(rp);
                    break;
                case 6: dt = drp.ConsultarDetalleMovXCodigoProceso(rp);
                    break;
                case 7: dt = drp.ConsultarDetalleMovXFecha(rp);
                    break;
                case 8: dt = drp.ConsultarRegistrosControl(rp);
                    break;
            }
            return dt;
        }

        /***************************************ACTUALIZACIONES Y ELIMINACIONES*********************************/
        public void ActualizarRegistroDeProceso(string parametro, csRegistroDeProcesos rp)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("CodigoProduccion", 2);
            parametros.Add("Tarea", 3);
            parametros.Add("HoraInicioReinicio", 4);
            parametros.Add("HoraFinalizacion", 5);
            parametros.Add("CodigoProceso", 6);
            parametros.Add("Fecha", 7);
            parametros.Add("Estado", 8);

            opcion = int.Parse(parametros[parametro].ToString());

            switch (opcion)
            {
                case 2: drp.ModificarCodigoProduccion(rp);
                    break;
                case 3: drp.ModificarTarea(rp);
                    break;
                case 4: drp.ModificarHoraInicioReinicio(rp);
                    break;
                case 5: drp.ModificarHoraFinalizacion(rp);
                    break;
                case 6: drp.ModificarCodigoProceso(rp);
                    break;
                case 7: drp.ModificarFecha(rp);
                    break;
                case 8: drp.ModificarEstado(rp);
                    break;
            }
        }

        /********************************************INSERCIONES***********************************************/
        public int RegistrarRegistroDeProceso(csRegistroDeProcesos rp)
        {
            int idInsertado;
            idInsertado = drp.InsertarNuevoRegistroProceso(rp);
            return idInsertado;
        }
    }
}
