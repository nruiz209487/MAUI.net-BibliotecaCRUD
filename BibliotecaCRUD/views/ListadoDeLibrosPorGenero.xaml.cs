using ENT_Bibloteca;
using UIBiblioteca.VM;

namespace BibliotecaCRUD.views;

public partial class ListadoDeLibrosPorGenero : ContentPage
{
    /// <summary>
    /// CONTRCUTOR DE LA PAGINA DE LIBROS COJE POR PARAMETRO EL ID DEL LIBRO
    /// </summary>
    /// <param name="id"></param>
    public ListadoDeLibrosPorGenero(int id)
    {
        InitializeComponent();
        //BINDING VM
        BindingContext = new GeneroYListadoDeLibros(id);
    }
}