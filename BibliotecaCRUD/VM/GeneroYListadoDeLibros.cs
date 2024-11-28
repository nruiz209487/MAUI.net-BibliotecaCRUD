using BL_Biblioteca;
using ENT_Bibloteca;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UIBiblioteca.VM
{
    public class GeneroYListadoDeLibros : INotifyPropertyChanged
    {
        private Genero obj;
        private ObservableCollection<Libro> libros;
        private Libro libroSeleccionado;
        public int id;
        public string titulo;
        public string autor;
        public string sinopsis;
        public DateTime fechaDeSalida;
        public int idGenero;
        public string img;
        public int Id
        {
            get => id;
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged(nameof(Id)); // Notifica el cambio
                }
            }
        }
        public string Titulo
        {
            get => titulo;
            set
            {
                if (titulo != value)
                {
                    titulo = value;
                    OnPropertyChanged(nameof(Titulo)); // Notifica el cambio
                }
            }
        }
        public string Sinopsis
        {
            get => sinopsis;
            set
            {
                if (sinopsis != value)
                {
                    sinopsis = value;
                    OnPropertyChanged(nameof(Sinopsis)); // Notifica el cambio
                }
            }
        }
        public string Autor
        {
            get => autor;
            set
            {
                if (autor != value)
                {
                    autor = value;
                    OnPropertyChanged(nameof(Autor)); // Notifica el cambio
                }
            }
        }
        public DateTime FechaDeSalida
        {
            get => fechaDeSalida;
            set
            {
                if (fechaDeSalida != value)
                {
                    fechaDeSalida = value;
                    OnPropertyChanged(nameof(FechaDeSalida)); // Notifica el cambio
                }
            }
        }
        public int IdGenero
        {
            get => idGenero;
            set
            {
                if (idGenero != value)
                {
                    idGenero = value;
                    OnPropertyChanged(nameof(IdGenero)); // Notifica el cambio
                }
            }
        }
        public string Img
        {
            get => img;
            set
            {
                if (img != value)
                {
                    img = value;
                    OnPropertyChanged(nameof(Img)); // Notifica el cambio
                }
            }
        }
        public Genero Obj
        {
            get => obj;
            set
            {
                if (obj != value)
                {
                    obj = value;
                    OnPropertyChanged(nameof(Obj)); // Notifica el cambio
                }
            }
        }

        // Propiedad pública para la colección de libros
        public ObservableCollection<Libro> Libros
        {
            get => libros;
            set
            {
                if (libros != value)
                {
                    libros = value;
                    OnPropertyChanged(nameof(Libros)); // Notifica el cambio
                }
            }
        }
        public Libro LibroSeleccionado
        {
            get => libroSeleccionado;
            set
            {
                if (libroSeleccionado != value)
                {
                    libroSeleccionado = value;
                    OnPropertyChanged(nameof(LibroSeleccionado)); // Notifica el cambio
                }
            }
        }


        public ICommand NuevoLibroCommand { get; }
        public ICommand EliminarLibroCommand { get; }

        public GeneroYListadoDeLibros(int id)
        {
            obj = ClsListadosBL.ObtenerGenero(id);
            Libros = new ObservableCollection<Libro>(ClsListadosBL.ObtenerListadoDeLibrosPorGenero(Obj.Id));
            NuevoLibroCommand = new Command(AgregarNuevoLibro);
            EliminarLibroCommand = new Command(EliminarUnLibro);

        }




        public void ActalizarLista()
        {
            Libros.Clear();
            Libros = new ObservableCollection<Libro>(ClsListadosBL.ObtenerListadoDeLibrosPorGenero(Obj.Id));
        }
        public void AgregarNuevoLibro()
        {

            Libro obj = new Libro(id, titulo, sinopsis, autor, fechaDeSalida, idGenero, img
            );

            ClsListadosBL.AnyadirLibro(obj);
            ActalizarLista();


        }
        public void EliminarUnLibro()
        {
            if (LibroSeleccionado != null)
            {
                ClsListadosBL.EliminarLibro(LibroSeleccionado.Id);
                ActalizarLista();
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}