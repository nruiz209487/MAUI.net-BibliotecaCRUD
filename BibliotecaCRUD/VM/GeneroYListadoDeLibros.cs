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
        public Libro libroObj { get; set; } = new Libro();
        private int IdGenero { get; set; }
        private ObservableCollection<Libro> libros;
        private Libro libroSeleccionado;
        public ObservableCollection<Libro> Libros
        {
            get
            {
                return libros;
            }
            set
            {
                if (libros != value && value != null)
                {
                    libros = value;
                    OnPropertyChanged(nameof(Libros));
                }
            }
        }
        public void ActalizarLista()
        {
            Libros = new ObservableCollection<Libro>(ClsListadosBL.ObtenerListadoDeLibrosPorGenero(IdGenero));
        }
        public Libro LibroSeleccionado
        {
            get => libroSeleccionado;
            set
            {
                if (libroSeleccionado != value)
                {
                    libroSeleccionado = value;
                }
            }
        }

        public ICommand NuevoLibroCommand { get; }
        public ICommand EliminarLibroCommand { get; }
        public GeneroYListadoDeLibros(int id)
        {
            IdGenero = id;
            NuevoLibroCommand = new Command(AgregarNuevoLibro);
            EliminarLibroCommand = new Command(EliminarUnLibro);
            ActalizarLista();

        }



        public void AgregarNuevoLibro()
        {

            ClsListadosBL.AnyadirLibro(libroObj);
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