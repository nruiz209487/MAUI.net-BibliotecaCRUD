using ENT_Bibloteca;

namespace DAL_Biblioteca
{
    public class ListadoDeGeneros
    {
        internal static List<Genero> listado = new List<Genero>()
{
    new Genero() { Id = 1, Nombre = "Fantasía", Descripcion = "Libros con elementos mágicos y mundos ficticios." },
    new Genero() { Id = 2, Nombre = "Ciencia Ficción", Descripcion = "Historias futuristas y tecnológicas." },
    new Genero() { Id = 3, Nombre = "Terror", Descripcion = "Narraciones diseñadas para causar miedo o suspense." },
    new Genero() { Id = 4, Nombre = "Romance", Descripcion = "Relatos centrados en historias de amor." },
    new Genero() { Id = 5, Nombre = "Aventura", Descripcion = "Cuentos llenos de acción y exploración." },
    new Genero() { Id = 6, Nombre = "Historia", Descripcion = "Obras que se basan en hechos históricos o épocas pasadas." },
    new Genero() { Id = 7, Nombre = "Biografía", Descripcion = "Relatos sobre la vida de personas reales." }
};

    }
}
