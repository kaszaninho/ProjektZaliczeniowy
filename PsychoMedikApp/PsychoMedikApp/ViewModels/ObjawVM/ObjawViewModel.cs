﻿using PsychoMedik.Service.Reference;
using PsychoMedikApp.ViewModels.Abstract;
using PsychoMedikApp.Views.ObjawView;
using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels.ObjawVM
{
    public class ObjawViewModel : AListViewModel<Objaw>
    {
        public ObjawViewModel()
            : base("Objawy")
        {
        }

        public override async void GoToAddPage()
        {
            await Shell.Current.GoToAsync(nameof(NewObjawPage));
        }

        public override async void OnItemSelected(Objaw item)
        {
            if (item == null)
            {
                return;
            }
            await Shell.Current.GoToAsync($"{nameof(ObjawDetailsPage)}?{nameof(ObjawDetailsViewModel.ItemId)}={item.Id}");
        }
    }
}