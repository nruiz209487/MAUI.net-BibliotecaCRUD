using BibliotecaCRUD.views;
using BL_Biblioteca;
using ENT_Bibloteca;
using System.Collections.ObjectModel;

namespace BibliotecaCRUD
{
    public partial class MainPage : ContentPage
    {
        /// <summary>
        ///lISTADO
        /// </summary>
        public ObservableCollection<Genero> Generos { get; set; }
        /// <summary>
        /// GENERO SELECIONADO
        /// </summary>
        public Genero SelectedGenero { get; set; }

        public MainPage()
        {
            InitializeComponent();

            // Llenar la lista de géneros
            Generos = new ObservableCollection<Genero>(ClsListadosBL.ObtenerListadoGeneros());
            BindingContext = this; // Configura el BindingContext para los bindings
        }


        /// <summary>
        /// AL SELECIONAR UN GEENRO NAVEGA A LA SIGUIENTE PAGINA PASANDOLO POR ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Genero generoSeleccionado)
            {
                SelectedGenero = generoSeleccionado;

                // Navega a la página de detalle pasando el Id del género seleccionado
                await Navigation.PushAsync(new ListadoDeLibrosPorGenero(generoSeleccionado.Id));

                // Limpia la selección del ListView para evitar problemas de navegación repetida
                ((ListView)sender).SelectedItem = null;
            }
        }
    }
}
