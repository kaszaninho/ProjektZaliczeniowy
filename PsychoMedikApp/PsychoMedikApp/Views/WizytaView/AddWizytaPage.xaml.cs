using PsychoMedik.Service.Reference;
using PsychoMedikApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoMedikApp.Views.WizytaView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddWizytaPage : ContentPage
    {
        public WizytaForView Item { get; set; }

        public AddWizytaPage()
        {
            InitializeComponent();
            BindingContext = new AddWizytaViewModel();
        }
    }
}
