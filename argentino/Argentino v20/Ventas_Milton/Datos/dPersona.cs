using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Ventas_Milton.Datos
{
    class dPersona
    {
        static csConexion con = new csConexion();
        static int e;

        /*******************************CONSULTAS**********************************/
        public DataTable ConsultarXCodigo(csPersona p)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", p.IdPersona);
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
        public DataTable ConsultarXNombre(csPersona p)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", p.Nombres);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "PrimerNombre");
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
        public DataTable ConsultarXSegundoNombre(csPersona p)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", p.Apellidos);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Apellido_NE");
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
        public DataTable ConsultarXFechaNacimiento(DateTime fch1, DateTime fch2)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operaFechas_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("fch1", fch1);
                    cmd.Parameters.AddWithValue("att", "FechaNacimiento");
                    cmd.Parameters.AddWithValue("fch2", fch2);

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
        public DataTable ConsultarXDireccion(csPersona p)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", p.DireccionRasonSocial);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Direccion");
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
        public DataTable ConsultarXTelefono(csPersona p)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", p.Telefono);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Telefono");
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
        public DataTable ConsultarXNroId(csPersona p)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", p.NroIdentificacion);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "NroId");
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
        public DataTable ConsultarXTipoId(csPersona p)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", p.TipoIdentificacion);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "TipoId");
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
        public DataTable ConsultarXFechaRegistro(DateTime fch1, DateTime fch2)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operaFechas_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("fch1", fch1);
                    cmd.Parameters.AddWithValue("att", "FechaRegistro");
                    cmd.Parameters.AddWithValue("fch2", fch2);

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

        /******************************ACTUALIZACIONES*****************************/
        public void ModificarNombre(csPersona p)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", p.Nombres);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "PrimerNombre");
                    cmd.Parameters.AddWithValue("cod", p.IdPersona);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación Nombres, ERROR!");
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
        public void ModificarSegundoNombre(csPersona p)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", p.Apellidos);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Apellido_NE");
                    cmd.Parameters.AddWithValue("cod", p.IdPersona);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación Apellidos, ERROR!");
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
        public void ModificarFechaNacimiento(csPersona p)
        {
            MySqlConnection cn = con.getConexion();
            funciones f = new funciones();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";
                    string fecha = f.ConvertMysqlDate( p.FchNacimiento);

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", fecha);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "FechaNacimiento");
                    cmd.Parameters.AddWithValue("cod", p.IdPersona);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación fechaNac, ERROR!");
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
        public void ModificarDireccion(csPersona p)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", p.DireccionRasonSocial);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Direccion");
                    cmd.Parameters.AddWithValue("cod", p.IdPersona);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación direccion, ERROR!");
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
        public void ModificarTelefono(csPersona p)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", p.Telefono);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Telefono");
                    cmd.Parameters.AddWithValue("cod", p.IdPersona);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación telefono, ERROR!");
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
        public void ModificarNroId(csPersona p)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", p.NroIdentificacion);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "NroId");
                    cmd.Parameters.AddWithValue("cod", p.IdPersona);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación nroId, ERROR!");
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
        public void ModificarTipoId(csPersona p)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", p.TipoIdentificacion);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "TipoId");
                    cmd.Parameters.AddWithValue("cod", p.IdPersona);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación tipoId, ERROR!");
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
        public void ModificarFechaRegistro(csPersona p)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", p.FechaRegistro);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "FechaReg");
                    cmd.Parameters.AddWithValue("cod", p.IdPersona);

                    cn.Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación fecReg, ERROR!");
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

        /**********************************ELIMINACION******************************/
        public void EliminarPersona(csPersona p)
        {
            MySqlConnection cn = con.getConexion();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "Persona");
                    cmd.Parameters.AddWithValue("parm", p.Eliminado);
                    cmd.Parameters.AddWithValue("t_accion", "E");
                    cmd.Parameters.AddWithValue("att", "Eliminado");
                    cmd.Parameters.AddWithValue("cod", p.IdPersona);

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

        /**********************************INSERCIONES******************************/
        public int InsertarNuevaPersona(csPersona p)
        {
            string sqlquery = 
                "INSERT INTO persona(primerNombre,segundoNombre,fechaNacimiento,direccionRasonSocial,telefono,nroIdentificacion,tipoIdentificacion,fechaRegistro,eliminado)"
                + "VALUES(@primerNombre,@segundoNombre,@fechaNacimiento,@direccionRasonSocial,@telefono,@nroIdentificacion,@tipoIdentificacion,@fechaRegistro,@eliminado)";
            MySqlConnection cn = con.getConexion();
            cn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlquery, cn);
                cmd.Parameters.Add("@primerNombre", p.Nombres);
                cmd.Parameters.Add("@segundoNombre", p.Apellidos);
                cmd.Parameters.Add("@fechaNacimiento", p.FchNacimiento);
                cmd.Parameters.Add("@direccionRasonSocial", p.DireccionRasonSocial);
                cmd.Parameters.Add("@telefono", p.Telefono);
                cmd.Parameters.Add("@nroIdentificacion", p.NroIdentificacion);
                cmd.Parameters.Add("@tipoIdentificacion", p.TipoIdentificacion);
                cmd.Parameters.Add("@fechaRegistro", p.FechaRegistro);
                cmd.Parameters.Add("@eliminado", p.Eliminado);
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

        public DataTable BuscarClienteporDNI(string p)
        {
            DataTable dt = new DataTable();
            MySqlConnection cn = con.getConexion();
            string q = "select idPersona, concat(segundoNombre, ' ' ,primerNombre) 'Persona' , nroIdentificacion 'Identificacion', direccionRasonSocial 'direccion', telefono from persona where tipoIdentificacion = 'C' and nroIdentificacion Like concat('%', @dni,'%') ";
            cn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(q, cn);
                cmd.Parameters.Add("@dni", p);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                da.SelectCommand.Connection.Close();

            }
            catch (Exception e)
            {
                dt = null;
                MessageBox.Show("Se encontró el siguente problema " + e.Message);
            }
            finally
            {

                cn.Close();
            }
            return dt;
        }

        public DataTable BuscarClienteporRzn(string p)
        {
            DataTable dt = new DataTable();
            MySqlConnection cn = con.getConexion();
            string q = "select idPersona, concat(segundoNombre, ' ' ,primerNombre) 'Persona' , nroIdentificacion 'Identificacion', direccionRasonSocial 'direccion', telefono from persona where tipoIdentificacion = 'C' and concat(segundoNombre, ' ' ,primerNombre) Like concat('%', @dni,'%') ";
            cn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(q, cn);
                cmd.Parameters.Add("@dni", p);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                da.SelectCommand.Connection.Close();

            }
            catch (Exception e)
            {
                dt = null;
                MessageBox.Show("Se encontró el siguente problema " + e.Message);
            }
            finally
            {

                cn.Close();
            }
            return dt;
        }
    }
}
