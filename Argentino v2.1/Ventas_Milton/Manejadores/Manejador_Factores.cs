using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Ventas_Milton.Datos;
using System.Collections;

namespace Ventas_Milton.Manejadores
{
    class Manejador_Factores
    {
        dFactores dfactores = new dFactores();
        /***********************************CONSULTAS*****************************/
        public DataTable BuscarFactor(string parametro, csFactores factor) 
        {
            DataTable dt = new DataTable();
            int opcion = 0;

            Hashtable parametros = new Hashtable();
            parametros.Add("Codigo", 1);
            parametros.Add("Tabla", 2);
            parametros.Add("Concepto", 3);
            parametros.Add("Monto", 4);
            parametros.Add("Todos", 5);

            for (int i = 0; i <= parametros.Count; i++)
            {
                if (parametros.Contains(parametro))
                {
                    opcion = int.Parse(parametros[parametro].ToString());
                    break;
                }
                else
                {
                    opcion = -1;
                }
            }            

            switch (opcion) 
            {
                case 1: dt = dfactores.ConsultarXCodigo(factor);
                    break;
                case 2: dt = dfactores.ConsultarXTabla(factor);
                    break;
                case 3: dt = dfactores.ConsultarXConcepto(factor);
                    break;
                case 4: dt = dfactores.ConsultarXMonto(factor);
                    break;
                case 5: dt = dfactores.ConsultaTodos();
                    break;
                default: dt = dfactores.ConsultaTodos();
                    break;
            }
            return dt;
        }

        /************************ACTUALIZACIONES Y ELIMINACIONES******************/
        public void ActualizarRegistro_Factores(string parametro, csFactores factor) 
        {
            int opcion = 0;

            Hashtable parametros = new Hashtable();
            parametros.Add("Tabla", 1);
            parametros.Add("Concepto", 2);
            parametros.Add("Monto", 3);
            parametros.Add("Eliminar", 4);

            for (int i = 0; i <= parametros.Count; i++)
            {
                if (parametros.Contains(parametro))
                {
                    opcion = int.Parse(parametros[parametro].ToString());
                    break;
                }
                else
                {
                    opcion = -1;
                }
            }            

            switch(opcion)
            {
                case 1: dfactores.ModificarTabla(factor);
                    break;
                case 2: dfactores.ModificarConcepto(factor);
                    break;
                case 3: dfactores.ModificarMonto(factor);
                    break;
                case 4: dfactores.EliminarFactores(factor);
                    break;
            }
        }

        /********************************INSERCIONES******************************/
        public int RegistrarNuevoFactor(csFactores factor)
        {
            int idInsertado;
            idInsertado = dfactores.InsertarNuevoFactor(factor);
            return idInsertado;
        }

        public string buscarIGV()
        {
            return dfactores.buscarIGV();
        }

    }
}
