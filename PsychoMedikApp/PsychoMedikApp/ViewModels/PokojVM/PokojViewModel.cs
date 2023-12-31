﻿using PsychoMedik.Service.Reference;
using PsychoMedikApp.ViewModels.Abstract;
using PsychoMedikApp.Views.PokojView;
using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels.PokojVM
{
    public class PokojViewModel : AListViewModel<Pokoj>
    {
        public PokojViewModel()
            : base("Pokoje")
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