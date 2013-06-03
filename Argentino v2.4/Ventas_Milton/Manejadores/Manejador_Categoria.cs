using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Ventas_Milton.Datos;
using Ventas_Milton.Entidades;
namespace Ventas_Milton.Manejadores
{
    class Manejador_Categoria
    {
        public DataTable Categoria_Listar()
        {
            DataTable dt = new DataTable();
            dCategoria categoria = new dCategoria();
            dt = categoria.Categoria_Listar();
            return dt;
        }
        public DataTable Categoria_ListarxNombre(String nombre)
        {
            DataTable dt = new DataTable();
            dCategoria categoria = new dCategoria();
            dt = categoria.Categoria_ListarxNombre(nombre);
            return dt;
        }
        public Int32 Categoria_Ingresar(csCategorias cCategoria) 
        {
            dCategoria categoria = new dCategoria();
            Int32 idCategoria;
            idCategoria=categoria.Categoria_Ingresar(cCategoria);
            return idCategoria;
        }
        public void Categoria_Actualizar(csCategorias cCategoria)
        {
            dCategoria categoria = new dCategoria();
            categoria.Categoria_Actualizar(cCategoria);
        }
        public void Categoria_Anular(csCategorias cCategoria)
        {
            dCategoria categoria = new dCategoria();
            categoria.Categoria_Anular(cCategoria);
        }
    }
}
