using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Bibloteca
{
    public class Genero
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Genero() { }

        public Genero(int id, string nombre, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }


        public override bool Equals(object? obj)
        {
            return obj is Genero genero &&
                   Id == genero.Id;
        }
    }
}
