using PsychoMedik.Service.Reference;
using PsychoMedikApp.Services;
using PsychoMedikApp.ViewModels.Abstract;
using PsychoMedikApp.Views.HarmonogramView;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace PsychoMedikApp.ViewModels.HarmonogramVM
{
    public class HarmonogramViewModel : AListViewModel<HarmonogramForView>
    {
        public HarmonogramViewModel()
            : base("Harmonogram")
        {
            dataKoncowa = new DateTime(2023, 12, 31);
            dataPoczatkowa = new DateTime(2023, 1, 1);
            var pracownikDataStore = new PracownikDataStore();
            pracownikDataStore.RefreshListFromService();
            pracownicy = pracownikDataStore.items;
            WylistujCommand = new Command(async () => await WylistujHarmonogram(dataPoczatkowa, dataKoncowa, wybranyPracownik));
        }

        private async Task WylistujHarmonogram(DateTime? dataPoczatkowa, DateTime? dataKoncowa, PracownikForView wybranyPracownik)
        {
            IsBusy = true;
            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);

                if (wybranyPracownik == null)
                {
                    items.ForEach(item =>
                    {
                        if (item.DataPracy <= dataKoncowa && item.DataPracy >= dataPoczatkowa)
                            Items.Add(item);
                    }
                    );
                }
                else
                {
                    items.ForEach(item =>
                    {
                        if (item.DataPracy <= dataKoncowa && item.DataPracy >= dataPoczatkowa
                        && item.IdPracownika == wybranyPracownik.Id) Items.Add(item);
                    }
                    );

                }
                items.OrderBy(item => item.DataPracy);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        #region Pola
        private DateTime? dataPoczatkowa;
        private DateTime? dataKoncowa;
        private PracownikForView wybranyPracownik;
        private List<PracownikForView> pracownicy;
        #endregion
        #region Właściwości
        public DateTime? DataPoczatkowa { get => dataPoczatkowa; set => SetProperty(ref dataPoczatkowa, value); }
        public DateTime? DataKoncowa { get => dataKoncowa; set => SetProperty(ref dataKoncowa, value); }
        public PracownikForView WybranyPracownik { get => wybranyPracownik; set => SetProperty(ref wybranyPracownik, value); }
        public List<PracownikForView> Pracownicy { get => pracownicy; }
        public Command WylistujCommand { get; }
        #endregion

        public override async void GoToAddPage()
        {
            await Shell.Current.GoToAsync(nameof(NewHarmonogramPage));
        }

        public override async void OnItemSelected(HarmonogramForView item)
        {
            if (item == null)
            {
                return;
            }
            await Shell.Current.GoToAsync($"{nameof(HarmonogramDetailsPage)}?{nameof(HarmonogramDetailsViewModel.ItemId)}={item.Id}");
        }
    }
}