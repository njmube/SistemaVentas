using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas_Milton.Datos
{
    class csMercaderia
    {
        private int _idMercaderia;
        private string _nomMercaderia;
        private int _stockDisponible;
        private int _stockMinimo;
        private int _codUndMedida; 
        private int _codCategoria;
        private int _eliminado;

        public csMercaderia(int idMercaderia, string nomMercaderia, int stockDisponible, int stockMinimo,int codUndMedida, int codCategoria, int eliminado)
        {
            this.IdMercaderia = idMercaderia;
            this.NomMercaderia = nomMercaderia;
            this.StockDisponible = stockDisponible;
            this.StockMinimo = stockMinimo;
            this.CodUndMedida = codUndMedida;
            this.CodCategoria = codCategoria;
            this.Eliminado = eliminado;
        }

        public int IdMercaderia
        {
            get { return _idMercaderia; }
            set { _idMercaderia = value; }
        }
        public string NomMercaderia
        {
            get { return _nomMercaderia; }
            set { _nomMercaderia = value; }
        }
        public int StockDisponible
        {
            get { return _stockDisponible; }
            set { _stockDisponible = value; }
        }
        public int StockMinimo
        {
            get { return _stockMinimo; }
            set { _stockMinimo = value; }
        }
        public int CodUndMedida
        {
            get { return _codUndMedida; }
            set { _codUndMedida = value; }
        }        
        public int CodCategoria
        {
            get { return _codCategoria; }
            set { _codCategoria = value; }
        }
        public int Eliminado
        {
            get { return _eliminado; }
            set { _eliminado = value; }
        }        
    }
}
