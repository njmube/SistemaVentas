using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using Ventas_Milton.Entidades;

namespace Ventas_Milton.Datos
{
    class dUsuarioAccion
    {
        static csConexion con = new csConexion();

        //Consulta de REGISTRO DE ACCIONES
        public DataTable ConsultarRegistroAccionesUsuario(csUsuario u)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Registro");
                    cmd.Parameters.AddWithValue("parm", u.Nombre);
                    cmd.Parameters.AddWithValue("t_accion", " ");
                    cmd.Parameters.AddWithValue("att", " ");
                    cmd.Parameters.AddWithValue("cod", u.IdUsuario);

                    cn.Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}
