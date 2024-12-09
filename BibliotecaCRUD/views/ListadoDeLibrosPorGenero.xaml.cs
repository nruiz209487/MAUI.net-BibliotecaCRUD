using ENT_Bibloteca;
using UIBiblioteca.VM;

namespace BibliotecaCRUD.views;

public partial class ListadoDeLibrosPorGenero : ContentPage
{
	public ListadoDeLibrosPorGenero(int id)
	{
		InitializeComponent();
        BindingContext = new GeneroYListadoDeLibros(id);
    }
}