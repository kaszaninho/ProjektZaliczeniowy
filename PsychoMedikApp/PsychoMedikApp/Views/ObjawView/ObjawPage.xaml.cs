using PsychoMedikApp.ViewModels.ObjawVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoMedikApp.Views.ObjawView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObjawPage : ContentPage
    {
        private ObjawViewModel _viewModel;

        public ObjawPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ObjawViewModel();
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