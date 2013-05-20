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
    class dExistencias
    {
        static csConexion con = new csConexion();
        static int e;
        funciones funciones = new funciones();

        /********************CONSULTAS************************/
        public DataTable ConsultarExistenciaXCodigo(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm",ex.IdMercaderia);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Codigo");
                    cmd.Parameters.AddWithValue("cod", -1);

                    cn.Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;

                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public DataTable ConsultarExistenciaXCodInterno(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm", ex.CodInternoMercaderia);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "CodigoBar");
                    cmd.Parameters.AddWithValue("cod", -1);

                    cn.Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public DataTable ConsultarExistenciaXPrecioVenta(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm",ex.PrecioVenta);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "PrecioVenta");
                    cmd.Parameters.AddWithValue("cod", -1);

                    cn.Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public DataTable ConsultarExistenciaXPrecioCompra(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm",ex.PrecioCompra);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "PrecioCompra");
                    cmd.Parameters.AddWithValue("cod", -1);

                    cn.Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public DataTable ConsultarExistenciaXFechaCompra(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm", ex.FechaAdquisicion);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "FechaCompra");
                    cmd.Parameters.AddWithValue("cod", -1);

                    cn.Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public DataTable ConsultarExistenciaXFechaVencimiento(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm", ex.FechaVencimiento);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "FechaVencimiento");
                    cmd.Parameters.AddWithValue("cod", -1);

                    cn.Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public DataTable ConsultarExistenciaXEstado(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm", ex.EstadoMercaderia);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Estado");
                    cmd.Parameters.AddWithValue("cod", -1);

                    cn.Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public DataTable ConsultarExistenciaXUbicacion(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm",ex.Ubicacion);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Ubicacion");
                    cmd.Parameters.AddWithValue("cod", -1);

                    cn.Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public DataTable ConsultarExistenciaXNroMovimiento(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm",ex.IdMovimiento);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "NroMovimiento");
                    cmd.Parameters.AddWithValue("cod", -1);

                    cn.Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }


        /*******************ACTUALIZACIONES******************/
        public void ModificarPrecioVenta(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm", ex.PrecioVenta);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "PrecioVenta");
                    cmd.Parameters.AddWithValue("cod", ex.IdMercaderia);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public void ModificarPrecioCompra(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm", ex.PrecioCompra);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "PrecioCompra");
                    cmd.Parameters.AddWithValue("cod", ex.IdMercaderia);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public void ModificarFechaCompra(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm", ex.FechaAdquisicion);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "FechaCompra");
                    cmd.Parameters.AddWithValue("cod", ex.IdMercaderia);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public void ModificarFechaVencimiento(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm", ex.FechaVencimiento);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "FechaVencimiento");
                    cmd.Parameters.AddWithValue("cod", ex.IdMercaderia);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public void ModificarEstado(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm", ex.EstadoMercaderia);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Estado");
                    cmd.Parameters.AddWithValue("cod", ex.IdMercaderia);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public void ModificarUbicacion(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm", ex.Ubicacion);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Ubicacion");
                    cmd.Parameters.AddWithValue("cod", ex.IdMercaderia);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public void ModificarNroMovimiento(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Existencia");
                    cmd.Parameters.AddWithValue("parm", ex.IdMovimiento);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "NroMovimiento");
                    cmd.Parameters.AddWithValue("cod", ex.IdMercaderia);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        /***************************ELIMINACIONES******************************/
        public void EliminarMercaderia(csExistencias ex)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Existencias");
                    cmd.Parameters.AddWithValue("parm", ex.Eliminado);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Eliminado");
                    cmd.Parameters.AddWithValue("cod", ex.IdMercaderia);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        /****************************INSERCIONES*******************************/
        public int InsertarNuevaExistencia(csExistencias ex)
        {
            string sqlquery =
                "INSERT INTO Existencias(codInternoMercaderia,precioUnitario,precioAdquisicion,fechaAdquisicion,fechaVencimiento,estadoMercaderia,eliminado,Ubicacion,idMovimiento)"
                + " Values(@codInternoMercaderia,@precioUnitario,@precioAdquisicion,@fechaAdquisicion,@fechaVencimiento,@estadoMercaderia,@eliminado,@Ubicacion,@idMovimiento); ";

            MySqlConnection cn = con.getConexion();
            cn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlquery, con.getConexion());
                cmd.Parameters.Add("@codInternoMercaderia", ex.CodInternoMercaderia);
                cmd.Parameters.Add("@precioUnitario", ex.PrecioVenta);
                cmd.Parameters.Add("@precioAdquisicion", ex.PrecioCompra);
                cmd.Parameters.Add("@fechaAdquisicion", ex.FechaAdquisicion);
                cmd.Parameters.Add("@fechaVencimiento", ex.FechaVencimiento);
                cmd.Parameters.Add("@estadoMercaderia", ex.EstadoMercaderia);
                cmd.Parameters.Add("@eliminado", ex.Eliminado);
                cmd.Parameters.Add("@Ubicacion", ex.Ubicacion);
                cmd.Parameters.Add("@idMovimiento", ex.IdMovimiento);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@IDENTITY";

                int ID_Insertado = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.Dispose();
                cmd = null;

                return ID_Insertado;
            }
            catch (Exception e)
            {
                throw new Exception(ex.ToString(), e);
            }
            finally
            {
                cn.Close();
            }
            MessageBox.Show("La Inserción se realizó Existosamente!");
        }

        public DataTable BuscarporCodigoBarras(string p)
        {
            string c = "SELECT e.idExistencias 'Codigo', e.`codInternoMercaderia` 'Codigo Barras', m.`descripcion` 'Producto',  m.`precioVenta` 'Precio' FROM `existencias` e  inner JOIN `mercaderia` m  on e.`idMercaderia` = m.`idMercaderia` Where e.codInternoMercaderia Like concat('%','" + p + "', '%') and e.eliminado = 0";
            return funciones.QueryReturnDataTable(c);
        }
    }
}
