using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using SenatiPractica.common.instructor;

namespace SenatiPractica.datos.instructor
{
    internal class DatosInstructor
    {
        public EntidadInstructor ObtenerInstructor(int idInstructor)
        {
            return null;
        }
        public int InsertarInstructor(EntidadInstructor instructor)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("insertarInstructor", Connection.Singleton.SqlConnetionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Dni", instructor.Dni);
                    cmd.Parameters.AddWithValue("@Nombres", instructor.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", instructor.Apellidos);
                    int numRes = cmd.ExecuteNonQuery();
                    return numRes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }
        public int EditarInstructor(EntidadInstructor instructor)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("editarInstructor", Connection.Singleton.SqlConnetionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", instructor.Id);
                    cmd.Parameters.AddWithValue("@Dni", instructor.Dni);
                    cmd.Parameters.AddWithValue("@Nombres", instructor.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", instructor.Apellidos);
                    int numRes = cmd.ExecuteNonQuery();
                    return numRes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }
        public int EliminarInstructor(int idInstructor)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("eliminarInstructor", Connection.Singleton.SqlConnetionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", idInstructor);
                    int numRes = cmd.ExecuteNonQuery();
                    return numRes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }
        public DataTable ObtenerTodosInstructores()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("obtenerTodosInstructores", Connection.Singleton.SqlConnetionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable BuscarInstructorByTipoAndParametro(ETipoBusquedaInstructor tipo, string parametro)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("buscarInstructorByTipoAndParametro", Connection.Singleton.SqlConnetionFactory))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Parametro", parametro);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
