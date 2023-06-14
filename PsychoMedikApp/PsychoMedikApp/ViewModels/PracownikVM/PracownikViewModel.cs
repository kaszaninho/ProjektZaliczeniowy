using PsychoMedik.Service.Reference;
using PsychoMedikApp.ViewModels.Abstract;
using PsychoMedikApp.Views.PracownikView;
using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels.PracownikVM
{
    public class PracownikViewModel : AListViewModel<PracownikForView>
    {
        public PracownikViewModel()
            : base("Pracownicy")
        {
        }

        public override async void GoToAddPage()
        {
            await Shell.Current.GoToAsync(nameof(NewPracownikPage));
        }

        public override async void OnItemSelected(PracownikForView item)
        {
            if (item == null)
            {
                return;
            }
            await Shell.Current.GoToAsync($"{nameof(PracownikDetailsPage)}?{nameof(PracownikDetailsViewModel.ItemId)}={item.Id}");
        }
    }
}