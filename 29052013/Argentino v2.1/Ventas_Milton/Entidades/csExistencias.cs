using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas_Milton.Entidades
{
    class csExistencias
    {
        private int _idMercaderia;
        private string _codInternoMercaderia;
        private double _precioVenta;
        private double _precioCompra;
        private DateTime _fechaAdquisicion;
        private DateTime _fechaVencimiento;
        private string _estadoMercaderia;
        private int _eliminado;        
        private int _idMovimiento;
        private int _ubicacion;

        public int Ubicacion
        {
            get { return _ubicacion; }
            set { _ubicacion = value; }
        }

        public int IdMercaderia
        {
            get { return _idMercaderia; }
            set { _idMercaderia = value; }
        }

        public string CodInternoMercaderia
        {
            get { return _codInternoMercaderia; }
            set { _codInternoMercaderia = value; }
        }

        public double PrecioVenta
        {
            get { return _precioVenta; }
            set { _precioVenta = value; }
        }

        public double PrecioCompra
        {
            get { return _precioCompra; }
            set { _precioCompra = value; }
        }

        public DateTime FechaAdquisicion
        {
            get { return _fechaAdquisicion; }
            set { _fechaAdquisicion = value; }
        }

        public DateTime FechaVencimiento
        {
            get { return _fechaVencimiento; }
            set { _fechaVencimiento = value; }
        }

        public string EstadoMercaderia
        {
            get { return _estadoMercaderia; }
            set { _estadoMercaderia = value; }
        }

        public int Eliminado
        {
            get { return _eliminado; }
            set { _eliminado = value; }
        }

        public int IdMovimiento
        {
            get { return _idMovimiento; }
            set { _idMovimiento = value; }
        }
    }
}
