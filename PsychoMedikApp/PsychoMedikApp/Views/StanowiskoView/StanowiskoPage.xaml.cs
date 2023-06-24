using PsychoMedikApp.ViewModels.StanowiskoVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoMedikApp.Views.StanowiskoView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StanowiskoPage : ContentPage
    {
        private StanowiskoViewModel _viewModel;

        public StanowiskoPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new StanowiskoViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

        //async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    if (e.Item == null)
        //        return;

        //    await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

        //    //Deselect Item
        //    ((ListView)sender).SelectedItem = null;
        //}
    }
}