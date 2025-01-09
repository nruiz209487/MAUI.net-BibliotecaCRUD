using ENT_Bibloteca;
using UIBiblioteca.VM;

namespace BibliotecaCRUD.views;

public partial class ListadoDeLibrosPorGenero : ContentPage
{
    /// <summary>
    /// CONTRCUTOR DE LA PAGINA DE LIBROS COJE POR PARAMETRO EL ID DEL LIBRO
    /// </summary>
    /// <param name="id"></param>
    GeneroYListadoDeLibros objVM;
    public ListadoDeLibrosPorGenero(int id)
    {
        try
        {
            objVM = new GeneroYListadoDeLibros(id);
            BindingContext = objVM;
            InitializeComponent();
        }
        catch (Exception)
        {
            Navigation.PushAsync(new Error());
        }

    }
}