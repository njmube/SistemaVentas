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
    class dCategoria
    {
        static csConexion con = new csConexion();
        public DataTable Categoria_Listar()
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "Categoria_Listar";
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
        public DataTable Categoria_ListarxNombre(String nombre)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "Categoria_ListarxNombre";
                    cn.Open();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
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
        public Int32 Categoria_Ingresar(csCategorias cCategoria)
        {
            MySqlConnection cn = con.getConexion();
            Int32 idCategoria = 0;
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "Categoria_Ingresar";
                    cmd.Parameters.AddWithValue("param_nombre", cCategoria.Nombre);
                    cmd.Parameters.AddWithValue("param_descripcion", cCategoria.Descripcion);
                    cmd.Parameters.AddWithValue("param_idCategoriaDepende", cCategoria.IdCategoriaDepende);
                    cmd.Parameters.AddWithValue("param_idUsuario", cCategoria.IdUsuario);
                    cn.Open();
                    idCategoria=Convert.ToInt32(cmd.ExecuteScalar());
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
            return idCategoria;
        }
        public void Categoria_Actualizar(csCategorias cCategoria)
        {
            MySqlConnection cn = con.getConexion();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "Categoria_Actualizar";
                    cmd.Parameters.AddWithValue("param_idcategoriaM", cCategoria.IdCategoras);
                    cmd.Parameters.AddWithValue("param_nombre", cCategoria.Nombre);
                    cmd.Parameters.AddWithValue("param_descripcion", cCategoria.Descripcion);
                    cmd.Parameters.AddWithValue("param_idCategoriaDepende", cCategoria.IdCategoriaDepende);
                    cmd.Parameters.AddWithValue("param_idUsuario", cCategoria.IdUsuario);
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
        public void Categoria_Anular(csCategorias cCategoria)
        {
            MySqlConnection cn = con.getConexion();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "Categoria_Anular";
                    cmd.Parameters.AddWithValue("param_idcategoriaM", cCategoria.IdCategoras);
                    cmd.Parameters.AddWithValue("param_idUsuario", cCategoria.IdUsuario);
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
    }
}
