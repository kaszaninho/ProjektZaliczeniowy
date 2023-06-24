using System.Windows.Input;
using PsychoMedikApp.ViewModels.Abstract;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/kaszaninho/ProjektZaliczeniowy"));
        }

        public ICommand OpenWebCommand { get; }
    }
}