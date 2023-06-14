using PsychoMedikApp.ViewModels.Abstract;
using PsychoMedikApp.ViewModels.PracownikVM;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoMedikApp.Views.PracownikView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PracownikDetailsPage : ContentPage
    {
        //public ObservableCollection<string> Items { get; set; }

        private PracownikDetailsViewModel _viewModel;

        public PracownikDetailsPage()
        {
            InitializeComponent();
            BindingContext = new PracownikDetailsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}