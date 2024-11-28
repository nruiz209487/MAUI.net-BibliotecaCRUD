using DAL_Biblioteca;
using ENT_Bibloteca;

namespace BL_Biblioteca
{
    public class ClsListadosBL
    {

        #region Genero
        public static List<Genero> ObtenerListadoGeneros()
        {
            return Service.ObtenerListadoGeneros();
        }

        public static Genero ObtenerGenero(int id)
        {
            return Service.ObtenerGenero(id);
        }
        #endregion


        #region Libros

        public static List<Libro> ObtenerListadoDeLibrosPorGenero(int id)
        {
            return Service.ObtenerListadoDeLibrosPorGenero(id);
        }

        public static void EliminarLibro(int id)
        {
            Service.EliminarLibro(id);

        }

        public static Libro ObtenerLibro(int id)
        {
            return Service.ObtenerLibro(id);
        }

        public static void AnyadirLibro(Libro obj)
        {
            Service.AnyadirLibro(obj);

        }

        public static void ModificarLibro(Libro libroSeleccionado)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

}


