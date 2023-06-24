using PsychoMedik.Service.Reference;
using PsychoMedikApp.ViewModels.Abstract;
using PsychoMedikApp.Views.PacjentView;
using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels.PacjentVM
{
    public class PacjentViewModel : AListViewModel<PacjentForView>
    {
        public PacjentViewModel()
            : base("Pacjenty")
        {
        }

        public override async void GoToAddPage()
        {
            await Shell.Current.GoToAsync(nameof(NewPacjentPage));
        }

        public override async void OnItemSelected(PacjentForView item)
        {
            if (item == null)
            {
                return;
            }
            await Shell.Current.GoToAsync($"{nameof(PacjentDetailsPage)}?{nameof(PacjentDetailsViewModel.ItemId)}={item.Id}");
        }
    }
}