using DAL_Biblioteca;
using ENT_Bibloteca;

namespace BL_Biblioteca
{
    public class ClsListadosBL
    {

        public static List<Genero> ObtenerListadoGeneros()
        {
            return Service.ObtenerListadoGeneros();
        }

        public static List<Libro> ObtenerListadoDeLibrosPorGenero(int id)
        {
            return Service.ObtenerListadoDeLibrosPorGenero(id);
        }
        public static Libro ObtenerLibro(int id)
        {
            return Service.ObtenerLibro(id);
        }

        public static Genero ObtenerGenero(int id)
        {
            return Service.ObtenerGenero(id); ;
        }

    }

}


