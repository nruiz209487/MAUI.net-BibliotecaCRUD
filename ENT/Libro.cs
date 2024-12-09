using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Bibloteca
{
    /// <summary>
    /// clase libro con us satributos y cponstructores
    /// </summary>
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string Autor { get; set; }
        public DateTime fechaDeSalida { get; set; }
        public int IdGenero { get; set; }
        public string Img { get; set; }
        public Libro() { }

        public Libro(int id, string titulo, string sinopsis, string autor, DateTime fechaDeSalida, int idGenero, string img)
        {
            Id = id;
            Titulo = titulo;
            Sinopsis = sinopsis;
            Autor = autor;
            this.fechaDeSalida = fechaDeSalida;
            this.IdGenero = idGenero;
            Img = img;
        }

        /// <summary>
        /// compareto que funciona por id 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return obj is Libro libro &&
                   Id == libro.Id;

        }
    }
}
