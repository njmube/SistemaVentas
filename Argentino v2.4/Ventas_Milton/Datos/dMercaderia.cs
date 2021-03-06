﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Ventas_Milton.Datos
{
    class dMercaderia
    {
        funciones funciones = new funciones();
        static csConexion con = new csConexion();
        public void Mercaderia_Ingresar(csMercaderia mercaderia)
        {
            MySqlConnection cn = con.getConexion();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "Mercaderia_Ingresar";
                    cmd.Parameters.AddWithValue("param_stockDisponible", mercaderia.stockDisponible);
                    cmd.Parameters.AddWithValue("param_stockMinimo", mercaderia.stockMinimo);
                    cmd.Parameters.AddWithValue("param_precioVenta", mercaderia.precioVenta);
                    cmd.Parameters.AddWithValue("param_nombre", mercaderia.nombre);
                    cmd.Parameters.AddWithValue("param_descripcion", mercaderia.descripcion);
                    cmd.Parameters.AddWithValue("param_idUndMedida", mercaderia.idUnidadMedida);
                    cmd.Parameters.AddWithValue("param_idCategoria", mercaderia.idCategoria);
                    cmd.Parameters.AddWithValue("param_idUsuario", mercaderia.idUsuario);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public void Mercaderia_Anular(csMercaderia mercaderia)
        {
            MySqlConnection cn = con.getConexion();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "Mercaderia_Anular";
                    cmd.Parameters.AddWithValue("param_idMercaderia", mercaderia.idMercaderia);
                    cmd.Parameters.AddWithValue("param_idUsuario", mercaderia.idUsuario);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public void Mercaderia_Actualizar(csMercaderia mercaderia)
        {
            MySqlConnection cn = con.getConexion();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "Mercaderia_Actualizar";
                    cmd.Parameters.AddWithValue("param_idMercaderia", mercaderia.idMercaderia);
                    cmd.Parameters.AddWithValue("param_stockDisponible", mercaderia.stockDisponible);
                    cmd.Parameters.AddWithValue("param_stockMinimo", mercaderia.stockMinimo);
                    cmd.Parameters.AddWithValue("param_precioVenta", mercaderia.precioVenta);
                    cmd.Parameters.AddWithValue("param_nombre", mercaderia.nombre);
                    cmd.Parameters.AddWithValue("param_descripcion", mercaderia.descripcion);
                    cmd.Parameters.AddWithValue("param_idUndMedida", mercaderia.idUnidadMedida);
                    cmd.Parameters.AddWithValue("param_idCategoria", mercaderia.idCategoria);
                    cmd.Parameters.AddWithValue("param_idUsuario", mercaderia.idUsuario);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public DataTable Mercaderia_ListarxIdCategoria(Int32 idCategoria)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "Mercaderia_ListarxIdCategoria";
                    cn.Open();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.SelectCommand.Parameters.AddWithValue("param_idCategoria", idCategoria);
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
        public DataTable Mercaderia_ListarxIdCategoriaxNombre(Int32 idCategoria,String nombre)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "Mercaderia_ListarxIdCategoriaxNombre";
                    cn.Open();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.SelectCommand.Parameters.AddWithValue("param_idCategoria", idCategoria);
                    da.SelectCommand.Parameters.AddWithValue("param_nombre", nombre);
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

        static int e;

        /********************CONSULTAS************************/
        public DataTable ConsultarMercaderiaXCodigo(csMercaderia m)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", m.IdMercaderia);
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
        public DataTable ConsultarMercaderiaXNombre(csMercaderia m)
        {
            MySqlConnection cn = con.getConexion();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", m.NomMercaderia);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Nombre");
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
        public DataTable ConsultarMercaderiaXStockDisponible(csMercaderia m)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", m.StockDisponible);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Stock");
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
        public DataTable ConsultarMercaderiaXStockMinimo(csMercaderia m)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", m.StockMinimo);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Stock");
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
        public DataTable ConsultarMercaderiaXUnidadMedida(csMercaderia m)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", m.CodUndMedida);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "UnidadMedida");
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
        public DataTable ConsultarMercaderiaXCategoria(csMercaderia m)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", m.CodCategoria);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Categoria");
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
        public DataTable ConsultarMercaderiaParaProducir(csMercaderia m)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", m.IdMercaderia);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "AProduccion");
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
        public void ModificarNombre(csMercaderia m)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", m.NomMercaderia);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Nombre");
                    cmd.Parameters.AddWithValue("cod", m.IdMercaderia);

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

        public void ModificarStockDisponible(csMercaderia m)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", m.StockDisponible);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Stock");
                    cmd.Parameters.AddWithValue("cod", m.IdMercaderia);

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
        public void ModificarStockMinimo(csMercaderia m)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", m.StockDisponible);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Stock");
                    cmd.Parameters.AddWithValue("cod", m.IdMercaderia);

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
        public void ModificarPrecioVenta(csMercaderia m)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", m.PrecioVenta);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "PrecioVenta");
                    cmd.Parameters.AddWithValue("cod", m.IdMercaderia);

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
        public void ModificarMinimo(csMercaderia m)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", m.StockMinimo);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Minimo");
                    cmd.Parameters.AddWithValue("cod", m.IdMercaderia);

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
        public void ModificarMedida(csMercaderia m)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", m.CodUndMedida);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Medida");
                    cmd.Parameters.AddWithValue("cod", m.IdMercaderia);

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
        public void EliminarMercaderia(csMercaderia m)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", m.Eliminado);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Eliminado");
                    cmd.Parameters.AddWithValue("cod", m.IdMercaderia);

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
        public int InsertarNuevaMercaderia(csMercaderia m)
        {
            string sqlquery =
                "INSERT INTO mercaderia (stockDisponible,stockMinimo,precioVenta,nombre,descripcion,idUndMedida,idCategoria,eliminado)" +
                "Values(@stockDisponible,@stockMinimo,@precioVenta,@nombre,@descripcion,@idUndMedida,@idCategoria,@eliminado)";

            MySqlConnection cn = con.getConexion();
            cn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlquery, con.getConexion());
                cmd.Parameters.Add("@stockDisponible", m.StockDisponible);
                cmd.Parameters.Add("@stockMinimo", m.StockMinimo);
                cmd.Parameters.Add("@precioVenta", m.PrecioVenta);
                cmd.Parameters.Add("@nombre", m.NomMercaderia);
                cmd.Parameters.Add("@descripcion", m.Descripcion);
                cmd.Parameters.Add("@idUndMedida", m.CodUndMedida);
                cmd.Parameters.Add("@idCategoria", m.CodCategoria);
                cmd.Parameters.Add("@eliminado", m.Eliminado);
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


        public void actualizarStock(int id, int cantidad, string SUMAoRESTA)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "Mercaderia_actualizarStock";

                    cmd.Parameters.AddWithValue("_idMercaderia", id);
                    cmd.Parameters.AddWithValue("_cantidad", cantidad);
                    cmd.Parameters.AddWithValue("_SUMAoRESTA", SUMAoRESTA);

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

        public DataTable buscarMercaderiaCompra(string p)
        {
            string q = "Select 	m.idMercaderia 'Codigo', m.nombre 'Producto', m.precioVenta 'Precio', m.stockDisponible 'Stock', f.`descripcion` 'UM' from mercaderia m inner join unidadmedida f on m.`idUndMedida` = f.`idUnidadMedida` where m.nombre LIKE concat('%', '" + p + "','%') and m.`eliminado` = 0";
            return funciones.QueryReturnDataTable(q);
        }
    }
}
