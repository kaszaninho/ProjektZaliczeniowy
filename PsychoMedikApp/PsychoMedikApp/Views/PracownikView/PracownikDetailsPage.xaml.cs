using PsychoMedikApp.ViewModels.PracownikVM;

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
            BindingContext = _viewModel = new PracownikDetailsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}