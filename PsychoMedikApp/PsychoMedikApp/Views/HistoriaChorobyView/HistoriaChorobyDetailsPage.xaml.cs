using PsychoMedikApp.ViewModels.HistoriaChorobyVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoMedikApp.Views.HistoriaChorobyView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoriaChorobyDetailsPage : ContentPage
    {
        //public ObservableCollection<string> Items { get; set; }


        public HistoriaChorobyDetailsPage()
        {
            InitializeComponent();
            BindingContext = new HistoriaChorobyDetailsViewModel();
        }
    }
}