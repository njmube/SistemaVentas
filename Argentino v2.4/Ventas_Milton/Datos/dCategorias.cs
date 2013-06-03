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
    class dCategorias
    {
        static csConexion con = new csConexion();
        static int e;

        /********************CONSULTAS************************/
        public DataTable ConsultarCategoriaXCodigo(csCategorias c)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Categorias");
                    cmd.Parameters.AddWithValue("parm", c.IdCategoras);
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
        public DataTable ConsultarCategoriaXNombre(csCategorias c)
        {
            MySqlConnection cn = con.getConexion();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Categorias");
                    cmd.Parameters.AddWithValue("parm", c.Nombre);
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
        public DataTable ConsultarCategoriaXDescripcion(csCategorias c)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Categorias");
                    cmd.Parameters.AddWithValue("parm", c.Descripcion);
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
        public DataTable ConsultarCategoriaXCategoriaSuperior(csCategorias c)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Categorias");
                    cmd.Parameters.AddWithValue("parm", c.IdCategoriaDepende);
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
        public DataTable ConsultarMercaderiaXTodos(csCategorias c)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Categorias");
                    cmd.Parameters.AddWithValue("parm", " ");
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Todos");
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
        public void ModificarNombre(csCategorias c)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Categorias");
                    cmd.Parameters.AddWithValue("parm", c.Nombre);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Nombre");
                    cmd.Parameters.AddWithValue("cod", c.IdCategoras);

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
        public void ModificarDescripcion(csCategorias c)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Categorias");
                    cmd.Parameters.AddWithValue("parm", c.Descripcion);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Descripcion");
                    cmd.Parameters.AddWithValue("cod", c.IdCategoras);

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
        public void ModificarCategoriaSuperior(csCategorias c)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Categorias");
                    cmd.Parameters.AddWithValue("parm", c.IdCategoriaDepende);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Padre");
                    cmd.Parameters.AddWithValue("cod", c.IdCategoras);

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
        public void EliminarCategoria(csCategorias c)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Categorias");
                    cmd.Parameters.AddWithValue("parm", c.Eliminado);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Eliminado");
                    cmd.Parameters.AddWithValue("cod", c.IdCategoras);

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
        public int InsertarNuevaCategoria(csCategorias c)
        {
            string sqlquery =
                "INSERT INTO CategoriaM(nombre,descripcion,idCategoriaDepende,eliminado) values (@nombre,@descripcion,@Padre, @eliminado)";

            MySqlConnection cn = con.getConexion();
            cn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlquery, con.getConexion());
                cmd.Parameters.Add("@nombre", c.Nombre);
                cmd.Parameters.Add("@descripcion", c.Descripcion);
                cmd.Parameters.Add("@Padre", c.IdCategoriaDepende);
                cmd.Parameters.Add("@eliminado", c.Eliminado);
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
