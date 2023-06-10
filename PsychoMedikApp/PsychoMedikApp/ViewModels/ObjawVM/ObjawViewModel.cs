using PsychoMedik.Service.Reference;
using PsychoMedikApp.ViewModels.Abstract;
using PsychoMedikApp.Views.ObjawView;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels.ObjawVM
{
    public class ObjawViewModel : AListViewModel<Objaw>
    {
        public ObjawViewModel()
            : base("Choroby")
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