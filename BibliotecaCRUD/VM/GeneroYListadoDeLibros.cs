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
                    OnPropertyChanged(nameof(Id)); 
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
                    OnPropertyChanged(nameof(Titulo)); 
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
                    OnPropertyChanged(nameof(Sinopsis)); 
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
                    OnPropertyChanged(nameof(Autor)); 
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
                    OnPropertyChanged(nameof(FechaDeSalida)); 
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
                    OnPropertyChanged(nameof(IdGenero)); 
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
                    OnPropertyChanged(nameof(Img)); 
                }
            }
        }
        /// Propiedad pública para atribto
        public Genero Obj
        {
            get => obj;
            set
            {
                if (obj != value)
                {
                    obj = value;
                    OnPropertyChanged(nameof(Obj)); 
                }
            }
        }

        /// Propiedad pública para atribto
        public ObservableCollection<Libro> Libros
        {
            get => libros;
            set
            {
                if (libros != value)
                {
                    libros = value;
                    OnPropertyChanged(nameof(Libros));
                }
            }
        }
        /// Propiedad pública para atribto
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

        /// Propiedades pública para commands
        public ICommand NuevoLibroCommand { get; }
        public ICommand EliminarLibroCommand { get; }
        /// <summary>
        /// Constructor inicializa las lista por id y los commands
        /// </summary>
        /// <param name="id"></param>
        public GeneroYListadoDeLibros(int id)
        {
            obj = ClsListadosBL.ObtenerGenero(id);
            Libros = new ObservableCollection<Libro>(ClsListadosBL.ObtenerListadoDeLibrosPorGenero(Obj.Id));
            NuevoLibroCommand = new Command(AgregarNuevoLibro);
            EliminarLibroCommand = new Command(EliminarUnLibro);

        }



        /// <summary>
        /// Actauliza el listado para que se refrsque al hacer cambios 
        /// </summary>
        public void ActalizarLista()
        {
            Libros.Clear();
            Libros = new ObservableCollection<Libro>(ClsListadosBL.ObtenerListadoDeLibrosPorGenero(Obj.Id));
        }
        /// <summary>
        /// agrega un nuevo libropor medio de los parametros del vm
        /// </summary>
        public void AgregarNuevoLibro()
        {
            ClsListadosBL.AnyadirLibro(titulo, sinopsis, autor, fechaDeSalida, idGenero, img);
            ActalizarLista();


        }
        /// <summary>
        /// Elimina un libro por id usa el id del libro seleccionado 
        /// </summary>
        public void EliminarUnLibro()
        {
            if (LibroSeleccionado != null)
            {
                ClsListadosBL.EliminarLibro(LibroSeleccionado.Id);
                ActalizarLista();
            }
        }


        /// <summary>
        /// Implementacion del INOTIFYPROPERTYCHANGED
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}