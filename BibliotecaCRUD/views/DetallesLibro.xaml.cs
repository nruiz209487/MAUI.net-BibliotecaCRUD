using BL_Biblioteca;
using ENT_Bibloteca;

namespace BibliotecaCRUD.views;

public partial class DetallesLibro : ContentPage
{
    public Libro SelectedLibro { get; set; }
    public DetallesLibro(int id)
	{


        InitializeComponent();
        SelectedLibro = ClsListadosBL.ObtenerLibro(id);
        BindingContext = this; // Configura el BindingContext para los bindings
    }
}