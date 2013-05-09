using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas_Milton.Entidades
{
    class csUsuarioAccion
    {
        int _idUsuarioAccion;
        int _idUsuario;
        int _idTabla;
        string _nombreTabla;
        string _tipoAccion;

        public string TipoAccion
        {
            get { return _tipoAccion; }
            set { _tipoAccion = value; }
        }

        public int IdUsuarioAccion
        {
            get { return _idUsuarioAccion; }
            set { _idUsuarioAccion = value; }
        }

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public int IdTabla
        {
            get { return _idTabla; }
            set { _idTabla = value; }
        }

        public string NombreTabla
        {
            get { return _nombreTabla; }
            set { _nombreTabla = value; }
        }
    }
}
