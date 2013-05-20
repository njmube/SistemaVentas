using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas_Milton.Datos
{
    class csMovimieto
    {
        private int _idMovimiento;
        private string _tipoMovimiento;
        private DateTime _fecha;
        private DateTime _hora;
        private int _idPersona;
        private int _codOfertas; 
        private int _eliminado;
        private string _ubicacionInicial;
        private string _ubicacionFinal;
        private int _idMercaderia;
        private double _montoPago;
        private int _idTipoDocumento;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public DateTime Hora
        {
            get { return _hora; }
            set { _hora = value; }
        }

        public string UbicacionInicial
        {
            get { return _ubicacionInicial; }
            set { _ubicacionInicial = value; }
        }

        public string UbicacionFinal
        {
            get { return _ubicacionFinal; }
            set { _ubicacionFinal = value; }
        }

        public int IdMercaderia
        {
            get { return _idMercaderia; }
            set { _idMercaderia = value; }
        }

        public int Eliminado
        {
            get { return _eliminado; }
            set { _eliminado = value; }
        }

        

        public csMovimieto(
            string tipoMovimiento,
            DateTime fecha,
            DateTime hora,
            double montoPago,
            int codOfertas,
            int idPersona,
            string ubicacionInicial,
            string ubicacionFinal,
            int idTipoDocumento)
        {
            this.TipoMovimiento = tipoMovimiento;
            this.Fecha = fecha;
            this.Hora = hora;
            this.MontoPago = montoPago;
            this.CodOfertas = codOfertas;
            this.IdPersona = idPersona;
            this.UbicacionInicial = ubicacionInicial;
            this.UbicacionFinal = ubicacionFinal;
            this.idTipoDocumento = idTipoDocumento;

        }

        public int IdMovimiento
        {
            get { return _idMovimiento; }
            set { _idMovimiento = value; }
        }

        public string TipoMovimiento
        {
            get { return _tipoMovimiento; }
            set { _tipoMovimiento = value; }
        }

        public double MontoPago
        {
            get { return _montoPago; }
            set { _montoPago = value; }
        }

        public int CodOfertas
        {
            get { return _codOfertas; }
            set { _codOfertas = value; }
        }

        public int IdPersona
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }

        public int idTipoDocumento {
            get { return _idTipoDocumento; }
            set {  _idTipoDocumento = value;}
        }
    }
}
