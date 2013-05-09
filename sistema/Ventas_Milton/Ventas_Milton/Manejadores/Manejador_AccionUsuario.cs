using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Ventas_Milton.Entidades;
using Ventas_Milton.Datos;
using System.Collections;

namespace Ventas_Milton.Manejadores
{
    class Manejador_AccionUsuario
    {
        static dUsuarioAccion dua = new dUsuarioAccion();
        /**********************************************CONSULTAS************************************************/
        public DataTable BuscarUsuario(string parametro, csUsuario u)
        {
            DataTable dt = new DataTable();
            dt = dua.ConsultarRegistroAccionesUsuario(u);
            return dt;
        }
    }
}
