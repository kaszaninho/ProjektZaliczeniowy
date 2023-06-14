using PsychoMedikApp.ViewModels.PracownikVM;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoMedikApp.Views.PracownikView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPracownikPage : ContentPage
    {
        //public ObservableCollection<string> Items { get; set; }
        public PsychoMedik.Service.Reference.PracownikForView Item { get; set; }

        public NewPracownikPage()
        {
            InitializeComponent();
            BindingContext = new NewPracownikViewModel();
        }

    }
}