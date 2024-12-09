using ENT_Bibloteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ListadoDeLibros
{
    internal static List<Libro> listado = new List<Libro>()
        {
            // Género Fantasía
            new Libro()
            {
                Id = 1,
                Titulo = "El Señor de los Anillos",
                Sinopsis = "Una épica aventura en la Tierra Media donde un hobbit debe destruir un anillo poderoso.",
                Autor = "J.R.R. Tolkien",
                fechaDeSalida = new DateTime(1954, 7, 29),
                IdGenero = 1,
                Img = "https://th.bing.com/th/id/OIP.PLIy0lcp6ZQOvMaf-lZDdgHaEK?rs=1&pid=ImgDetMain" },
            new Libro()
            {
                Id = 2,
                Titulo = "Harry Potter y la Piedra Filosofal",
                Sinopsis = "El inicio de la historia de un joven mago que lucha contra las fuerzas del mal.",
                Autor = "J.K. Rowling",
                fechaDeSalida = new DateTime(1997, 6, 26),
                IdGenero = 1,
                Img = "https://th.bing.com/th/id/OIP.Rbco1c73zdSj7N-Sw_6JNAHaEK?w=317&h=180&c=7&r=0&o=5&dpr=1.4&pid=1.7"
            },
            new Libro()
            {
                Id = 3,
                Titulo = "La rueda del tiempo",
                Sinopsis = "Un joven llamado Rand al'Thor debe enfrentarse al Oscuro para evitar la destrucción del mundo.",
                Autor = "Robert Jordan",
                fechaDeSalida = new DateTime(1990, 1, 15),
                IdGenero = 1,
                Img = "https://th.bing.com/th/id/R.938cd1d1a5933cc29ee43530e0fa62b2?rik=4uh3zzfCGN4lEg&pid=ImgRaw&r=0"    },
            new Libro()
            {
                Id = 4,
                Titulo = "Eragon",
                Sinopsis = "Un joven granjero descubre que es el último de los jinetes de dragones y lucha contra un imperio malvado.",
                Autor = "Christopher Paolini",
                fechaDeSalida = new DateTime(2002, 8, 26),
                IdGenero = 1,
                Img = "https://th.bing.com/th/id/OIP.OizDdq61-CVO-Tf6fS_WtgHaKe?w=207&h=293&c=7&r=0&o=5&dpr=1.4&pid=1.7"
            },
            // Género Ciencia Ficción
            new Libro()
            {
                Id = 5,
                Titulo = "1984",
                Sinopsis = "Un inquietante retrato de un mundo distópico gobernado por un régimen totalitario.",
                Autor = "George Orwell",
                fechaDeSalida = new DateTime(1949, 6, 8),
                IdGenero = 2,
                Img = "https://th.bing.com/th/id/OIP.wLteJKSgn57YZsA3n8a0ygHaLS?w=202&h=308&c=7&r=0&o=5&dpr=1.4&pid=1.7"
            },
            new Libro()
            {
                Id = 6,
                Titulo = "Fahrenheit 451",
                Sinopsis = "En un futuro distópico, los libros son prohibidos y quemados por los bomberos.",
                Autor = "Ray Bradbury",
                fechaDeSalida = new DateTime(1953, 10, 19),
                IdGenero = 2,
                Img = "https://th.bing.com/th/id/OIP.xw46VePSGvbo5MU1WreVDAHaLI?w=203&h=306&c=7&r=0&o=5&dpr=1.4&pid=1.7"
            },
            new Libro()
            {
                Id = 7,
                Titulo = "Dune",
                Sinopsis = "En un futuro lejano, la lucha por el control de un planeta desértico con una valiosa especia.",
                Autor = "Frank Herbert",
                fechaDeSalida = new DateTime(1965, 8, 1),
                IdGenero = 2,
                Img = "https://th.bing.com/th/id/OIP.gVElrKSmJ7rXhZQM4HK4hgHaEK?w=324&h=181&c=7&r=0&o=5&dpr=1.4&pid=1.7"      },
            new Libro()
            {
                Id = 8,
                Titulo = "Neuromante",
                Sinopsis = "Un hacker caído en desgracia es contratado para realizar una misión en un futuro cibernético.",
                Autor = "William Gibson",
                fechaDeSalida = new DateTime(1984, 7, 1),
                IdGenero = 2,
                Img = "https://assets.lectulandia.co/b/William%20Gibson/Neuromante%20(353)/big.jpg"
            },
            // Género Terror
            new Libro()
            {
                Id = 9,
                Titulo = "It",
                Sinopsis = "Un grupo de amigos enfrenta a un mal ancestral que toma la forma de sus peores miedos.",
                Autor = "Stephen King",
                fechaDeSalida = new DateTime(1986, 9, 15),
                IdGenero = 3,
                Img = "https://th.bing.com/th/id/OIP.2RjBzXJOxFN20U9Sweb_DAHaKg?rs=1&pid=ImgDetMain"      },
            new Libro()
            {
                Id = 10,
                Titulo = "El Resplandor",
                Sinopsis = "Un escritor y su familia se mudan a un hotel aislado, donde fuerzas sobrenaturales empiezan a influir en él.",
                Autor = "Stephen King",
                fechaDeSalida = new DateTime(1977, 1, 28),
                IdGenero = 3,
                Img = "https://th.bing.com/th/id/OIP.OT4EpJ7ITKZW2tk457JDvgHaEK?w=308&h=180&c=7&r=0&o=5&dpr=1.4&pid=1.7"
            },
            new Libro()
            {
                Id = 11,
                Titulo = "La casa de los espíritus",
                Sinopsis = "Una familia atrapada en los vicios de la política, la pasión y lo sobrenatural.",
                Autor = "Isabel Allende",
                fechaDeSalida = new DateTime(1982, 11, 2),
                IdGenero = 3,
                Img = "https://th.bing.com/th/id/OIP.gcyPTKqRmKOBeglDH18I-wAAAA?w=201&h=309&c=7&r=0&o=5&dpr=1.4&pid=1.7"
            },
            new Libro()
            {
                Id = 12,
                Titulo = "El Exorcista",
                Sinopsis = "Una niña es poseída por una fuerza demoníaca, y un sacerdote lucha por salvarla.",
                Autor = "William Peter Blatty",
                fechaDeSalida = new DateTime(1971, 6, 10),
                IdGenero = 3,
                Img = "https://th.bing.com/th/id/OIP.b3mKuGd-hkXb_5xm8-0GnQHaEK?w=207&h=116&c=7&r=0&o=5&dpr=1.4&pid=1.7"      },
            // Género Romance
            new Libro()
            {
                Id = 13,
                Titulo = "Orgullo y Prejuicio",
                Sinopsis = "Una joven lucha contra sus prejuicios y se enamora de un hombre con el que no se llevaba bien.",
                Autor = "Jane Austen",
                fechaDeSalida = new DateTime(1813, 1, 28),
                IdGenero = 4,
                Img = "https://image.tmdb.org/t/p/original/bfyPaBUHThQYJspwlW8UQ0nNzUt.jpg"
            },
            new Libro()
            {
                Id = 14,
                Titulo = "Bajo la misma estrella",
                Sinopsis = "Una conmovedora historia de dos jóvenes con cáncer que se enamoran.",
                Autor = "John Green",
                fechaDeSalida = new DateTime(2012, 1, 10),
                IdGenero = 4,
                Img = "https://es.web.img3.acsta.net/pictures/14/05/23/16/58/494713.jpg"
            },
            new Libro()
            {
                Id = 15,
                Titulo = "Cumbres Borrascosas",
                Sinopsis = "La tormentosa relación entre Heathcliff y Catherine en los páramos de Yorkshire.",
                Autor = "Emily Brontë",
                fechaDeSalida = new DateTime(1847, 12, 1),
                IdGenero = 4,
                Img = "https://th.bing.com/th/id/OIP.JQ1DDH4yGssJ78MFMXXwlgHaLY?w=178&h=274&c=7&r=0&o=5&dpr=1.1&pid=1.7"
            },
            new Libro()
            {
                Id = 16,
                Titulo = "Bajo el sol de la Toscana",
                Sinopsis = "Una mujer compra una villa en la Toscana y, al restaurarla, encuentra el amor y la renovación.",
                Autor = "Frances Mayes",
                fechaDeSalida = new DateTime(1996, 7, 1),
                IdGenero = 4,
                Img = "https://prod-ripcut-delivery.disney-plus.net/v1/variant/disney/931B1F5CAF6F992CFA1592D68C7EF507DEF0D497C99F4653A864A82C41971DA2/scale?width=1200&aspectRatio=1.78&format=jpeg"
            },
            // Género Aventura
            new Libro()
            {
                Id = 17,
                Titulo = "La Isla del Tesoro",
                Sinopsis = "La aventura de un joven que busca un tesoro perdido en una isla misteriosa.",
                Autor = "Robert Louis Stevenson",
                fechaDeSalida = new DateTime(1883, 1, 1),
                IdGenero = 5,
                Img = "https://th.bing.com/th/id/OIP.Fj6M5HKB6o147R7yjIoZNwHaKS?w=205&h=284&c=7&r=0&o=5&dpr=1.4&pid=1.7"
            },
            new Libro()
            {
                Id = 18,
                Titulo = "Las Aventuras de Huckleberry Finn",
                Sinopsis = "Huckle Finn y su amigo Jim viven emocionantes peripecias mientras navegan por el río Misisipi.",
                Autor = "Mark Twain",
                fechaDeSalida = new DateTime(1884, 12, 10),
                IdGenero = 5,
                Img = "https://th.bing.com/th/id/OIP.3QgG4Aqvkho6U0jfY6aHwwHaL2?w=197&h=316&c=7&r=0&o=5&dpr=1.4&pid=1.7"
            },
            new Libro()
            {
                Id = 19,
                Titulo = "Viaje al Centro de la Tierra",
                Sinopsis = "Un científico y su sobrino viajan al centro de la Tierra, donde descubren un mundo subterráneo.",
                Autor = "Jules Verne",
                fechaDeSalida = new DateTime(1864, 1, 1),
                IdGenero = 5,
                Img = "https://th.bing.com/th/id/OIP.429AxLe2NspL1ufaXaF5PwHaKc?w=207&h=292&c=7&r=0&o=5&dpr=1.4&pid=1.7"     },
            new Libro()
            {
                Id = 20,
                Titulo = "El Hobbit",
                Sinopsis = "La historia de Bilbo Bolsón, quien vive una aventura que cambiará su vida.",
                Autor = "J.R.R. Tolkien",
                fechaDeSalida = new DateTime(1937, 9, 21),
                IdGenero = 5,
                Img = "https://th.bing.com/th/id/OIP.To2r-UghMb79tPasgHo37wHaLH?w=204&h=306&c=7&r=0&o=5&dpr=1.4&pid=1.7"
            },
            // Género Historia
            new Libro()
            {
                Id = 21,
                Titulo = "Los Pilares de la Tierra",
                Sinopsis = "Una saga épica que relata la construcción de una catedral en la Edad Media.",
                Autor = "Ken Follett",
                fechaDeSalida = new DateTime(1989, 5, 1),
                IdGenero = 6,
                Img = "https://th.bing.com/th/id/R.28a77bbc60a450db35617c63650f0ad0?rik=Vc0YSlsQEvw6eQ&pid=ImgRaw&r=0"
            },
            new Libro()
            {
                Id = 22,
                Titulo = "El Nombre de la Rosa",
                Sinopsis = "Un monje franciscano investiga una serie de asesinatos en una abadía medieval.",
                Autor = "Umberto Eco",
                fechaDeSalida = new DateTime(1989, 5, 1),
                IdGenero = 6,
                Img = "https://th.bing.com/th/id/OIP.jku4-MZvd6-o8nQzG_NbxgHaLh?rs=1&pid=ImgDetMain"      } };
}
