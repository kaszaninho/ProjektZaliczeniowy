using PsychoMedikApp.ViewModels.HistoriaChorobyVM;
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