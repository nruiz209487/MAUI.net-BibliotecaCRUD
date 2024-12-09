using DAL;
using ENT_Bibloteca;
using Microsoft.Data.SqlClient;

namespace DAL_Biblioteca
{
    public class ListadoDeLibros
    {
        public static List<Libro> listadoCompletoLibrosDAL()
        {
            List<Libro> listado = new List<Libro>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            Libro libro;

            try
            {
                conexion = clsConexionDB.getConexion();

                if (conexion.State == System.Data.ConnectionState.Open)
                {

                    miComando.CommandText = "SELECT * FROM Libros";
                    miComando.Connection = conexion;
                    miLector = miComando.ExecuteReader();

                    if (miLector.HasRows)
                    {
                        while (miLector.Read())
                        {

                            libro = new Libro();
                            libro.Id = (int)miLector["Id"];
                            libro.Titulo = (string)miLector["Titulo"];
                            libro.Sinopsis = (string)miLector["Sinopsis"];
                            libro.Autor = (string)miLector["Autor"];
                            libro.fechaDeSalida = (DateTime)miLector["fechaDeSalida"];
                            libro.IdGenero = (int)miLector["IdGenero"];
                            libro.Img = (string)miLector["Img"];


                            listado.Add(libro);
                        }
                    }
                    miLector.Close();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return listado;
        }
    }
}
