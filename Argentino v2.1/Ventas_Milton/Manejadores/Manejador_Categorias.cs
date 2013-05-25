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
    class Manejador_Categorias
    {
        static dCategorias dc = new dCategorias();

        /**********************************************CONSULTAS************************************************/
        public DataTable BuscarCategoria(string parametro, csCategorias c)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Codigo", 1);
            parametros.Add("Nombre", 2);
            parametros.Add("Descripcion", 3);
            parametros.Add("Padre", 4);
            parametros.Add("Todos", 5);

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
                case 1: dt = dc.ConsultarCategoriaXCodigo(c);
                    break;
                case 2: dt = dc.ConsultarCategoriaXNombre(c);
                    break;
                case 3: dt = dc.ConsultarCategoriaXDescripcion(c);
                    break;
                case 4: dt = dc.ConsultarCategoriaXCategoriaSuperior(c);
                    break;
                case 5: dt = dc.ConsultarMercaderiaXTodos(c);
                    break;
            }
            return dt;
        }

        /***************************************ACTUALIZACIONES Y ELIMINACIONES*********************************/
        public void ActualizarRegistro(string parametro, csCategorias c)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Nombre", 1);
            parametros.Add("Descripcion", 2);
            parametros.Add("Padre", 3);

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
                case 1: dc.ModificarNombre(c);
                    break;
                case 2: dc.ModificarDescripcion(c);
                    break;
                case 3: dc.ModificarCategoriaSuperior(c);
                    break;
            }
        }

        /********************************************INSERCIONES***********************************************/
        public int RegistrarNuevaMercaderia(csCategorias c)
        {
            int idInsertado;
            idInsertado = dc.InsertarNuevaCategoria(c);
            return idInsertado;
        }

    }
}
