using PsychoMedikApp.ViewModels.PacjentVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoMedikApp.Views.PacjentView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PacjentDetailsPage : ContentPage
    {
        //public ObservableCollection<string> Items { get; set; }


        public PacjentDetailsPage()
        {
            InitializeComponent();
            BindingContext = new PacjentDetailsViewModel();
        }
    }
}