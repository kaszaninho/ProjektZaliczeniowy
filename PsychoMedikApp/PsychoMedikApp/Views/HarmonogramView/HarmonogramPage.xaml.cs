using PsychoMedikApp.ViewModels.HarmonogramVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoMedikApp.Views.HarmonogramView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HarmonogramPage : ContentPage
    {
        private HarmonogramViewModel _viewModel;

        public HarmonogramPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new HarmonogramViewModel();
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