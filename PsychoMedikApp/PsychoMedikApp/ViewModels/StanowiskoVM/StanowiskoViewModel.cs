using PsychoMedik.Service.Reference;
using PsychoMedikApp.ViewModels.Abstract;
using PsychoMedikApp.Views.StanowiskoView;
using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels.StanowiskoVM
{
    public class StanowiskoViewModel : AListViewModel<Stanowisko>
    {
        public StanowiskoViewModel()
            : base("Stanowiska")
        {
        }

        public override async void GoToAddPage()
        {
            await Shell.Current.GoToAsync(nameof(NewStanowiskoPage));
        }

        public override async void OnItemSelected(Stanowisko item)
        {
            if (item == null)
            {
                return;
            }
            await Shell.Current.GoToAsync($"{nameof(StanowiskoDetailsPage)}?{nameof(StanowiskoDetailsViewModel.ItemId)}={item.Id}");
        }
    }
}