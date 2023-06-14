using PsychoMedik.Service.Reference;
using PsychoMedikApp.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

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
