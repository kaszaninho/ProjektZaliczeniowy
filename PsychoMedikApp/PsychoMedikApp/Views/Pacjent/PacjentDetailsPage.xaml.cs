using PsychoMedikApp.ViewModels.PacjentVM;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

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