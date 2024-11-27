using BibliotecaCRUD.views;
using BL_Biblioteca;
using ENT_Bibloteca;
using System.Collections.ObjectModel;

namespace BibliotecaCRUD
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Genero> Generos { get; set; }
        public Genero SelectedGenero { get; set; }

        public MainPage()
        {
            InitializeComponent();

            // Llenar la lista de géneros
            Generos = new ObservableCollection<Genero>(ClsListadosBL.ObtenerListadoGeneros());
            BindingContext = this; // Configura el BindingContext para los bindings
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Genero generoSeleccionado)
            {
                SelectedGenero = generoSeleccionado;

                // Navega a la página de detalle pasando el Id del género seleccionado
                await Navigation.PushAsync(new DetallesGeneros(generoSeleccionado.Id));

                // Limpia la selección del ListView para evitar problemas de navegación repetida
                ((ListView)sender).SelectedItem = null;
            }
        }
    }
}
