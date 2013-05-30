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
    class dDetMovimiento
    {
        csConexion con = new csConexion();
        int e;
        /********************CONSULTAS************************/
        public DataTable ConsultarDetalleMovXCodigo(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.IdDetalleMovimiento);
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
        public DataTable ConsultarDetalleMovXMercaderia(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.IdMercaderia);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Mercaderia");
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
        public DataTable ConsultarDetalleMovXMovimiento(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.IdMovimiento);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Movimiento");
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
        public DataTable ConsultarDetalleMovXPrecio(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.Precio);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Precio");
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
        public DataTable ConsultarDetalleMovXCantidad(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.Cantidad);
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
        public DataTable ConsultarDetalleMovXSubtotal(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.Subtotal);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "SubTotal");
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
        public DataTable ConsultarDetalleMovXDescuento(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.Descuento);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Descuento");
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
        public DataTable ConsultarDetalleMovXTotal(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.Total);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Total");
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
        public DataTable ConsultarDetalleMovXOferta(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.IdOferta);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Oferta");
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
        public void ModificarMercaderia(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.IdMercaderia);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Mercaderia");
                    cmd.Parameters.AddWithValue("cod", dm.IdDetalleMovimiento);

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
        public void ModificarMovimiento(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.IdMovimiento);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Movimiento");
                    cmd.Parameters.AddWithValue("cod", dm.IdDetalleMovimiento);

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
        public void ModificarPrecio(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.Precio);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Precio");
                    cmd.Parameters.AddWithValue("cod", dm.IdDetalleMovimiento);

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
        public void ModificarCantidad(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.Cantidad);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Cantidad");
                    cmd.Parameters.AddWithValue("cod", dm.IdDetalleMovimiento);

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
        public void ModificarSubTotal(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.Subtotal);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "SubTotal");
                    cmd.Parameters.AddWithValue("cod", dm.IdDetalleMovimiento);

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
        public void ModificarDescuento(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.Descuento);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Descuento");
                    cmd.Parameters.AddWithValue("cod", dm.IdDetalleMovimiento);

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
        public void ModificarTotal(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.Total);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Total");
                    cmd.Parameters.AddWithValue("cod", dm.IdDetalleMovimiento);

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
        public void ModificarOferta(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.IdOferta);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Oferta");
                    cmd.Parameters.AddWithValue("cod", dm.IdDetalleMovimiento);

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
        public void EliminarDetalleMov(csDetMovimiento dm)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "DetalleMovimiento");
                    cmd.Parameters.AddWithValue("parm", dm.Eliminado);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", " ");
                    cmd.Parameters.AddWithValue("cod", dm.IdDetalleMovimiento);

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
        public int InsertarNuevoDetalleMov(csDetMovimiento dm)
        {
            string sqlquery =
                "INSERT INTO detallemovimiento(idMercaderia,idMovimiento,precio,cantidad,subtotal,descuento,total,eliminado,idOferta)" +
                "Values(@idMercaderia,@idMovimiento,@precio,@cantidad,@subtotal,@descuento,@total,@eliminado,@idOferta)";

            MySqlConnection cn = con.getConexion();
            cn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlquery, cn);
                cmd.Parameters.Add("@idMercaderia", dm.IdMercaderia);
                cmd.Parameters.Add("@idMovimiento", dm.IdMovimiento);
                cmd.Parameters.Add("@precio", dm.Precio);
                cmd.Parameters.Add("@cantidad", dm.Cantidad);
                cmd.Parameters.Add("@subtotal", dm.Subtotal);
                cmd.Parameters.Add("@descuento", dm.Descuento);
                cmd.Parameters.Add("@total", dm.Total);
                cmd.Parameters.Add("@eliminado", dm.Eliminado);
                cmd.Parameters.Add("@idOferta", dm.IdOferta);
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
