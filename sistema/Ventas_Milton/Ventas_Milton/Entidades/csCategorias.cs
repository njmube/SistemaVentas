using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas_Milton.Entidades
{
    class csCategorias
    {
        private int _idCategoras;
        private string _nombre;
        private string _descripcion;
        private int _idCategoriaDepende;
        private int _eliminado;

        public int IdCategoras
        {
            get { return _idCategoras; }
            set { _idCategoras = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int IdCategoriaDepende
        {
            get { return _idCategoriaDepende; }
            set { _idCategoriaDepende = value; }
        }

        public int Eliminado
        {
            get { return _eliminado; }
            set { _eliminado = value; }
        }
    }
}
