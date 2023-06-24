using PsychoMedik.Service.Reference;
using PsychoMedikApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoMedikApp.Views.HistoriaChorobyView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddHistoriaChorobyPage : ContentPage
    {
        public HistoriaChorobyForView Item { get; set; }

        public AddHistoriaChorobyPage()
        {
            InitializeComponent();
            BindingContext = new AddHistoriaChorobyViewModel();
        }
    }
}
