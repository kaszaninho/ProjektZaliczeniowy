using PsychoMedikApp.ViewModels.WizytaVM;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoMedikApp.Views.WizytaView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WizytaDetailsPage : ContentPage
    {
        //public ObservableCollection<string> Items { get; set; }


        public WizytaDetailsPage()
        {
            InitializeComponent();
            BindingContext = new WizytaDetailsViewModel();
        }
    }
}