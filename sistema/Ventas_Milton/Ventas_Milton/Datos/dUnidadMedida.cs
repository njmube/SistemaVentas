using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Ventas_Milton.Datos
{
    class dUnidadMedida
    {
        static csConexion con = new csConexion();
        static int e;

        /*************************CONSULTAS*****************************/
        public DataTable ConsultarXCodigo(csUnidadMedida um)
        {
            MySqlConnection cn = con.getConexion();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "UnidadMedida");
                    cmd.Parameters.AddWithValue("parm", um.IdUndMedida);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Codigo");
                    cmd.Parameters.AddWithValue("cod", -1);

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
        public DataTable ConsultarXDescripcion(csUnidadMedida um)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "UnidadMedida");
                    cmd.Parameters.AddWithValue("parm", um.Descripcion);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Descripcion");
                    cmd.Parameters.AddWithValue("cod", -1);

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
        public DataTable ConsultarXValor(csUnidadMedida um)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "UnidadMedida");
                    cmd.Parameters.AddWithValue("parm", um.Valor);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Valor");
                    cmd.Parameters.AddWithValue("cod", -1);

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
        public DataTable ConsultarXPadre(csUnidadMedida um)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "UnidadMedida");
                    cmd.Parameters.AddWithValue("parm", um.IdUndMedidaPadre);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Padre");
                    cmd.Parameters.AddWithValue("cod", -1);

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

        /***********************ACTUALIZACIONES*************************/
        public void ModificarDescripcion(csUnidadMedida um)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "UnidadMedida");
                    cmd.Parameters.AddWithValue("parm", um.Descripcion);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Descripcion");
                    cmd.Parameters.AddWithValue("cod", um.IdUndMedida);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
                    
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
        public void ModificarValor(csUnidadMedida um)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "UnidadMedida");
                    cmd.Parameters.AddWithValue("parm", um.Valor);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Valor");
                    cmd.Parameters.AddWithValue("cod", um.IdUndMedida);

                    cn.Open();

                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
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
        public void ModificarPadre(csUnidadMedida um)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "UnidadMedida");
                    cmd.Parameters.AddWithValue("parm", um.IdUndMedidaPadre);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Padre");
                    cmd.Parameters.AddWithValue("cod", um.IdUndMedida);

                    cn.Open();

                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
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

        /*************************ELIMINACION***************************/
        public void EliminarUnidadMedida(csUnidadMedida um)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "UnidadMedida");
                    cmd.Parameters.AddWithValue("parm", um.Eliminado);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Eliminado");
                    cmd.Parameters.AddWithValue("cod", um.IdUndMedida);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
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

        /*************************INSERCIONES****************************/
        public int InsertarNuevaUndMedida(csUnidadMedida um)
        {
            string sqlquery = "INSERT INTO unidadmedida(descripcion,valor,eliminado,unidadMedida_idUnidadMedida)"
                            + " VALUES(@descripcion,@valor,@eliminado,@unidadMedida_idUnidadMedida);";
            MySqlConnection cn = con.getConexion();
            cn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlquery, cn);
                cmd.Parameters.Add("@descripcion", um.Descripcion);
                cmd.Parameters.Add("@valor", um.Valor);
                cmd.Parameters.Add("@eliminado", um.Eliminado);
                cmd.Parameters.Add("@unidadMedida_idUnidadMedida", um.IdUndMedidaPadre);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@IDENTITY";

                int ID_Insertado = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.Dispose();
                cmd = null;

                return ID_Insertado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
            finally
            {
                cn.Close();
            }
            MessageBox.Show("La Inserción se realizó Existosamente!");
        }
    }
}
