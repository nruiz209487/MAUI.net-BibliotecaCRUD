using BL_Biblioteca;
using ENT_Bibloteca;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCRUD.VM
{
    internal class MainPageVM
    {
        public ObservableCollection<Genero> Generos { get { return new ObservableCollection<Genero>(ClsListadosBL.ObtenerListadoGeneros()); } }

        public Genero SelectedGenero { get; set; }
        public MainPageVM() { }
    }
}
