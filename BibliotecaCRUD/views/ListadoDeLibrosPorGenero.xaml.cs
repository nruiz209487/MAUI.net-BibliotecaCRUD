using ENT_Bibloteca;
using UIBiblioteca.VM;

namespace BibliotecaCRUD.views;

public partial class ListadoDeLibrosPorGenero : ContentPage
{
    public ListadoDeLibrosPorGenero(int generoId)
    {
        InitializeComponent();
        BindingContext = new GeneroYListadoDeLibros(generoId);
    }
    private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Libro seleccionado)
        {
            // Navega a la página de detalles con el ID del libro seleccionado
            await Navigation.PushAsync(new DetallesLibro(seleccionado.Id));

            // Limpia la selección del ListView
            ((ListView)sender).SelectedItem = null;
        }
    }
}

