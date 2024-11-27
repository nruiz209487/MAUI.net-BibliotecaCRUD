using ENT_Bibloteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Biblioteca
{
    public class Service
    {

        public static List<Genero> ObtenerListadoGeneros()
        {
            return ListadoDeGeneros.listado;
        }

        public static List<Libro> ObtenerListadoDeLibrosPorGenero(int id)
        {
            List<Libro> libros = new List<Libro>();
            foreach (Libro x in ListadoDeLibros.listado)
            {

                if (x.IdGenero == id)
                {

                    libros.Add(x);
                }
            }
            return libros;
        }

        public static Libro ObtenerLibro(int id)
        {
            Libro obj = ListadoDeLibros.listado.FirstOrDefault(i => i.Id == id);
            return obj;
        }

        public static Genero ObtenerGenero(int id)
        {
            Genero obj = ListadoDeGeneros.listado.FirstOrDefault(i => i.Id == id);
            return obj;
        }



    }
}
