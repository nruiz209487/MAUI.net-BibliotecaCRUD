using UIBiblioteca.VM;

namespace BibliotecaCRUD.views;

public partial class DetallesGeneros : ContentPage
{
    public DetallesGeneros(int generoId)
    {
        InitializeComponent();

        // Carga el ViewModel con el g�nero y su lista de libros
        BindingContext = new GeneroYListadoDeLibros(generoId);
    }
}
