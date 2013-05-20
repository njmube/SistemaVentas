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
    class Manejador_Usuarios
    {
        static dUsuarios du = new dUsuarios();
        /**********************************************CONSULTAS************************************************/
        public DataTable BuscarUsuario(string parametro, csUsuario u)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Codigo", 1);
            parametros.Add("Nombre", 2);
            parametros.Add("Login", 3);
            parametros.Add("Clave", 4);
            parametros.Add("Modo", 5);
            parametros.Add("Estado", 6);
            parametros.Add("Todos", 7);

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
                case 1: dt = du.ConsultarXCodigo(u);
                    break;
                case 2: dt = du.ConsultarXNombre(u);
                    break;
                case 3: dt = du.ConsultarXLogin(u);
                    break;
                case 4: dt = du.ConsultarXClave(u);
                    break;
                case 5: dt = du.ConsultarXModo(u);
                    break;
                case 6: dt = du.ConsultarXEstado(u);
                    break;
                case 7: dt = du.ConsultarXTodos(u);
                    break;
            }
            return dt;
        }

        /************************ACTUALIZACIONES Y ELIMINACIONES******************/
        public void ActualizarRegistro_Usuario(string parametro, csUsuario u)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Nombre", 1);
            parametros.Add("Login", 2);
            parametros.Add("Clave", 3);
            parametros.Add("Modo", 4);
            parametros.Add("Estado", 5);
            parametros.Add("Eliminado", 6);

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
                case 1: du.ModificarNombre(u);
                    break;
                case 2: du.ModificarLogin(u);
                    break;
                case 3: du.ModificarClave(u);
                    break;
                case 4: du.ModificarModo(u);
                    break;
                case 5: du.ModificarEstado(u);
                    break;
                case 6: du.EliminarUsuario(u);
                    break;
            }
        }

        /********************************INSERCIONES******************************/
        public int RegistrarNuevoUsuario(csUsuario u)
        {
            int idInsertado;
            idInsertado = du.InsertarNuevoUsuario(u);
            return idInsertado;
        }
    }
}
