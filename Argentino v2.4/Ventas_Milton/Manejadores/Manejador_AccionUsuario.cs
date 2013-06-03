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
        Manejador_Usuarios mu = new Manejador_Usuarios();
        /**********************************************CONSULTAS************************************************/
        public DataTable BuscarRegistroUsuario(string parametro, csUsuarioAccion ua)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Codigo", 1);
            parametros.Add("CodUsuario", 2);
            parametros.Add("LoginUsuario", 3);
            parametros.Add("Tabla", 4);
            parametros.Add("CodEnTabla", 5);
            parametros.Add("TipoAccion", 6);

            for (int i = 0; i <= parametros.Count; i++)
            {
                if (parametros.Contains(parametro))
                {
                    opcion = int.Parse(parametros[parametro].ToString());
                    break;
                }
                else
                {
                    opcion = -1;
                }
            }

            switch (opcion)
            {
                case 1: dt = dua.ConsultarRegistroXCodigo(ua);
                    break;
                case 2: dt = dua.ConsultarRegistroXCodUsuario(ua);
                    break;
                case 3:
                        DataTable dt2 = new DataTable();
                        csUsuario u = new csUsuario();
                        u.IdUsuario = ua.IdUsuario;
                        dt2 = mu.BuscarUsuario("Codigo", u);
                        u.Login = dt2.Rows[0]["Login"].ToString();
                        dt = dua.ConsultarRegistroXNombreUsuario(u);
                    break;
                case 4: dt = dua.ConsultarRegistroXTabla(ua);
                    break;
                case 5: dt = dua.ConsultarRegistroXCodEnTabla(ua);
                    break;
                case 6: dt = dua.ConsultarRegistroXTipoAccion(ua);
                    break;
            }
            return dt;
        }

        /********************************************INSERCIONES***********************************************/
        public int RegistrarNuevoRegistro(csUsuarioAccion ua)
        {
            int idInsertado;
            idInsertado = dua.InsertarNuevoRegistro(ua);
            return idInsertado;
        }

        /******************************************CAPTURA DE ACCION*******************************************/
        public void Log(string Tabla, string Accion, int idUsuario, int idTabla) 
        {
            csUsuarioAccion ua = new csUsuarioAccion();
            ua.NombreTabla = Tabla;
            ua.TipoAccion = Accion;
            ua.IdUsuario = idUsuario;
            ua.IdTabla = idTabla;
            int yyyy = System.DateTime.Today.Year;
            int MM = System.DateTime.Today.Month;
            int dd = System.DateTime.Today.Day;
            DateTime f = new DateTime(yyyy, MM, dd);
            ua.Fecha = f;
            ua.Hora = DateTime.Now.ToShortTimeString();
            RegistrarNuevoRegistro(ua);
        }
    }
}
