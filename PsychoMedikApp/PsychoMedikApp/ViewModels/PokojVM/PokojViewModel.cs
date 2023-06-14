using PsychoMedik.Service.Reference;
using PsychoMedikApp.ViewModels.Abstract;
using PsychoMedikApp.Views.PokojView;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels.PokojVM
{
    public class PokojViewModel : AListViewModel<Pokoj>
    {
        public PokojViewModel()
            : base("Pokojy")
        {
        }

        public override async void GoToAddPage()
        {
            await Shell.Current.GoToAsync(nameof(NewPokojPage));
        }

        public override async void OnItemSelected(Pokoj item)
        {
            if (item == null)
            {
                return;
            }
            await Shell.Current.GoToAsync($"{nameof(PokojDetailsPage)}?{nameof(PokojDetailsViewModel.ItemId)}={item.Id}");
        }
    }
}