using PsychoMedik.Service.Reference;
using PsychoMedikApp.ViewModels;
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
