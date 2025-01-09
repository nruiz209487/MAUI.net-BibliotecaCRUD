using BibliotecaCRUD.views;
using BibliotecaCRUD.VM;
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
        MainPageVM objVm;

        public MainPage()
        {

            try
            {
                objVm = new MainPageVM();
                BindingContext = objVm; // Configura el BindingContext para los bindings
                InitializeComponent();
            }
            catch (Exception)
            {
                Navigation.PushAsync(new Error());
            }




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
                objVm.SelectedGenero = generoSeleccionado;
                await Navigation.PushAsync(new ListadoDeLibrosPorGenero(generoSeleccionado.Id));
                ((ListView)sender).SelectedItem = null;
            }
        }
    }
}
