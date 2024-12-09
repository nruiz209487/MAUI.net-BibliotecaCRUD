using DAL;
using ENT_Bibloteca;
using Microsoft.Data.SqlClient;

namespace DAL_Biblioteca
{
    public class ListadoDeGeneros
    {
        /// <summary>
        /// OBTIENENE EL LISTADO DE GENEROS DE LA BD
        /// </summary>
        /// <returns>UN LISTADO DE List<Genero></returns>
        public static List<Genero> listadoCompletoGenerosDAL()
        {
            List<Genero> listado = new List<Genero>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            Genero genero;

            try
            {
                conexion = clsConexionDB.getConexion();

                if (conexion.State == System.Data.ConnectionState.Open)
                {

                    miComando.CommandText = "SELECT * FROM GenerosDeLibros";
                    miComando.Connection = conexion;
                    miLector = miComando.ExecuteReader();


                    if (miLector.HasRows)
                    {
                        while (miLector.Read())
                        {

                            genero = new Genero();
                            genero.Id = (int)miLector["Id"];
                            genero.Nombre = (string)miLector["Nombre"];
                            genero.Descripcion = (string)miLector["Descripcion"];


                            listado.Add(genero);
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
