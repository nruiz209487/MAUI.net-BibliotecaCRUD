using DAL_Biblioteca;
using ENT_Bibloteca;

namespace BL_Biblioteca
{
    public class ClsListadosBL
    {

        #region Genero
        /// <summary>
        /// LLAMA A LA DAL
        /// </summary>
        /// <returns List<Genero>></returns>
        public static List<Genero> ObtenerListadoGeneros()
        {
            return Service.ObtenerListadoGeneros();
        }
        /// <summary>
        ///  LLAMA A LA DAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Genero</returns>
        public static Genero ObtenerGenero(int id)
        {
            return Service.ObtenerGenero(id);
        }
        #endregion
        /// <summary>
        ///  LLAMA A LA DAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns> List<Libro></returns>

        #region Libros

        public static List<Libro> ObtenerListadoDeLibrosPorGenero(int id)
        {
            return Service.ObtenerListadoDeLibrosPorGenero(id);
        }
        /// <summary>
        ///  LLAMA A LA DAL
        /// </summary>
        /// <param name="id"></param>
        public static void EliminarLibro(int id)
        {
            Service.EliminarLibro(id);

        }
        /// <summary>
        ///  LLAMA A LA DAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Libro</returns>
        public static Libro ObtenerLibro(int id)
        {
            return Service.ObtenerLibro(id);
        }
        /// <summary>
        ///  LLAMA A LA DAL
        /// </summary>
        /// <param name="obj"></param>
        public static void ModificarLibro(Libro obj)
        {
            Service.ModificarLibro(obj);
        }
        /// <summary>
        ///  LLAMA A LA DAL
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="sinopsis"></param>
        /// <param name="autor"></param>
        /// <param name="fechaDeSalida"></param>
        /// <param name="idGenero"></param>
        /// <param name="img"></param>
        public static void AnyadirLibro(string titulo, string sinopsis, string autor, DateTime fechaDeSalida, int idGenero, string img)
        {
            Service.AnyadirLibro(titulo, sinopsis, autor, fechaDeSalida, idGenero, img);
        }
        #endregion
    }

}


