using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas_Milton.Entidades
{
    class csRegistroDeProcesos
    {
        int _idControlProduccion;
        int _idProduccion;
        string _tarea;
        DateTime _fecha;
        string _horaInicioReinicio;
        string _finalizacion;
        int _idProceso;
        int _eliminado;
        string _estado;

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public int IdControlProduccion
        {
            get { return _idControlProduccion; }
            set { _idControlProduccion = value; }
        }

        public int IdProduccion
        {
            get { return _idProduccion; }
            set { _idProduccion = value; }
        }

        public string Tarea
        {
            get { return _tarea; }
            set { _tarea = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public string HoraInicioReinicio
        {
            get { return _horaInicioReinicio; }
            set { _horaInicioReinicio = value; }
        }

        public string Finalizacion
        {
            get { return _finalizacion; }
            set { _finalizacion = value; }
        }

        public int IdProceso
        {
            get { return _idProceso; }
            set { _idProceso = value; }
        }

        public int Eliminado
        {
            get { return _eliminado; }
            set { _eliminado = value; }
        }
    }
}
