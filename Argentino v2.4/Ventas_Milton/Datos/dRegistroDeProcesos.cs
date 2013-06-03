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
    class dRegistroDeProcesos
    {
        csConexion con = new csConexion();
        int e;
        /********************CONSULTAS************************/
        public DataTable ConsultarDetalleMovXCodigoRegistro(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.IdControlProduccion);
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
        public DataTable ConsultarDetalleMovXCodigoProduccion(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.IdProduccion);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "CodProduccion");
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
        public DataTable ConsultarDetalleMovXTarea(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.Tarea);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Tarea");
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
        public DataTable ConsultarDetalleMovXFecha(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.Fecha);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "HoraInicioReinicio");
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
        public DataTable ConsultarDetalleMovXHoraInicioReinicio(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.HoraInicioReinicio);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Cantidad");
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
        public DataTable ConsultarDetalleMovXHoraFinalizacion(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.Finalizacion);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "HoraFinalizacion");
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
        public DataTable ConsultarDetalleMovXCodigoProceso(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.IdProceso);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Fecha");
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
        public DataTable ConsultarRegistrosControl(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.IdProceso);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Registros");
                    cmd.Parameters.AddWithValue("cod", rp.IdProduccion);

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
        public DataTable ConsultarEstados(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.Estado);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Estado");
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

        /*******************ACTUALIZACIONES******************/
        public void ModificarCodigoProduccion(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.IdProduccion);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "CodProduccion");
                    cmd.Parameters.AddWithValue("cod", rp.IdControlProduccion);

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
        public void ModificarTarea(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.Tarea);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Tarea");
                    cmd.Parameters.AddWithValue("cod", rp.IdControlProduccion);

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
        public void ModificarFecha(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.Fecha);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Fecha");
                    cmd.Parameters.AddWithValue("cod", rp.IdControlProduccion);

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
        public void ModificarHoraInicioReinicio(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.HoraInicioReinicio);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "HoraInicioReinicio");
                    cmd.Parameters.AddWithValue("cod", rp.IdControlProduccion);

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
        public void ModificarHoraFinalizacion(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.Finalizacion);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "HoraFinalizacion");
                    cmd.Parameters.AddWithValue("cod", rp.IdControlProduccion);

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
        public void ModificarCodigoProceso(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.IdProceso);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "CodProceso");
                    cmd.Parameters.AddWithValue("cod", rp.IdControlProduccion);

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
        public void ModificarEstado(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.Estado);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Estado");
                    cmd.Parameters.AddWithValue("cod", rp.IdControlProduccion);

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

        /***************************ELIMINACIONES******************************/
        public void EliminarRegistroProceso(csRegistroDeProcesos rp)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "ControlProduccion");
                    cmd.Parameters.AddWithValue("parm", rp.Eliminado);
                    cmd.Parameters.AddWithValue("t_accion", "E");
                    cmd.Parameters.AddWithValue("att", " ");
                    cmd.Parameters.AddWithValue("cod", rp.IdControlProduccion);

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

        /****************************INSERCIONES*******************************/
        public int InsertarNuevoRegistroProceso(csRegistroDeProcesos rp)
        {
            string sqlquery =
                "INSERT INTO controlproduccion(idProduccion,tarea,hInicioReinicio,hFinalizado,idProceso,eliminado,fecha,estado)"+
                "Values (@idProduccion,@tarea,@hInicioReinicio,@hFinalizado,@idProceso,@eliminado,@fecha,@estado)";

            MySqlConnection cn = con.getConexion();
            cn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlquery, cn);
                cmd.Parameters.Add("@idProduccion", rp.IdProduccion );
                cmd.Parameters.Add("@tarea", rp.Tarea);
                cmd.Parameters.Add("@hInicioReinicio", rp.HoraInicioReinicio );
                cmd.Parameters.Add("@hFinalizado", rp.Finalizacion);
                cmd.Parameters.Add("@idProceso", rp.IdProceso);
                cmd.Parameters.Add("@eliminado", rp.Eliminado);
                cmd.Parameters.Add("@fecha", rp.Fecha);
                cmd.Parameters.Add("@estado", rp.Estado);
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
