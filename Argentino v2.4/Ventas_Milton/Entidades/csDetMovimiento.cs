using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas_Milton.Entidades
{
    class csDetMovimiento
    {
        private int _idDetalleMovimiento;
        private int _idMercaderia;
        private int _idMovimiento;
        private double _precio;
        private int _cantidad;
        private double _subtotal;
        private double _descuento;
        private double _total;
        private int _idOferta;
        private int _eliminado;

        public int Eliminado
        {
            get { return _eliminado; }
            set { _eliminado = value; }
        }
        public int IdDetalleMovimiento
        {
            get { return _idDetalleMovimiento; }
            set { _idDetalleMovimiento = value; }
        }
        public int IdMercaderia
        {
            get { return _idMercaderia; }
            set { _idMercaderia = value; }
        }
        public int IdMovimiento
        {
            get { return _idMovimiento; }
            set { _idMovimiento = value; }
        }
        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        public double Subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }
        public double Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }
        public double Total
        {
            get { return _total; }
            set { _total = value; }
        }
        public int IdOferta
        {
            get { return _idOferta; }
            set { _idOferta = value; }
        }       
    }
}
