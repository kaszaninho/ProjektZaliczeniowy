using PsychoMedikApp.ViewModels.PacjentVM;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoMedikApp.Views.PacjentView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PacjentPage : ContentPage
    {
        private PacjentViewModel _viewModel;

        public PacjentPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PacjentViewModel();
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