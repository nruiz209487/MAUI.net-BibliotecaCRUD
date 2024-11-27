using BL_Biblioteca;
using ENT_Bibloteca;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIBiblioteca.VM
{
    public class GeneroYListadoDeLibros : INotifyPropertyChanged
    {
        private Genero obj;
        private ObservableCollection<Libro> libros;

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

        public GeneroYListadoDeLibros(int id)
        {
            obj = ClsListadosBL.ObtenerGenero(id);
            Libros = new ObservableCollection<Libro>(ClsListadosBL.ObtenerListadoDeLibrosPorGenero(id));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}