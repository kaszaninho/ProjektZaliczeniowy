using PsychoMedikApp.ViewModels.PokojVM;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoMedikApp.Views.PokojView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokojPage : ContentPage
    {
        private PokojViewModel _viewModel;

        public PokojPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PokojViewModel();
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