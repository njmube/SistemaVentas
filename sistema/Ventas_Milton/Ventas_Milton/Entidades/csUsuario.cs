using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas_Milton.Entidades
{
    class csUsuario
    {
        int _idUsuario;
        string _nombre;
        string _login;
        string _clave;
        string _cargo;
        int _modo;
        int _estado;
        int _eliminado;

        public int Eliminado
        {
            get { return _eliminado; }
            set { _eliminado = value; }
        }

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        public int Modo
        {
            get { return _modo; }
            set { _modo = value; }
        }

        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

    }
}
