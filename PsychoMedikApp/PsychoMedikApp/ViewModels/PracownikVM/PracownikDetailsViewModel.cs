using PsychoMedik.Service.Reference;
using PsychoMedikApp.Helpers;
using PsychoMedikApp.Models;
using PsychoMedikApp.Services;
using PsychoMedikApp.ViewModels.Abstract;
using PsychoMedikApp.ViewModels.WizytaVM;
using PsychoMedikApp.Views.PracownikView;
using PsychoMedikApp.Views.WizytaView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels.PracownikVM
{
    public class PracownikDetailsViewModel : AItemDetailsListViewModel<PracownikForView, WizytaForView>
    {
        public PracownikDetailsViewModel()
            : base("Pracownik")
        {
            Wizyty = new ObservableCollection<WizytaForView>();
            AddWizytaCommand = new Command(async () => await Shell.Current.GoToAsync($"{nameof(AddWizytaPage)}?{nameof(AddWizytaViewModel.IdPracownika)}={ItemId}"));
        }

        #region Pola
        private int id;
        private string imie;
        private string nazwisko;
        private DateTime? dataUrodzenia;
        private DateTime? dataZatrudnienia;
        private DateTime? dataRezygnacji;
        private string plec;
        private string stanCywilny;
        private string opis;
        private DateTime dataUtworzenia;
        private DateTime dataModyfikacji;
        private string nazwaStanowisko;
        #endregion
        #region Właściwości
        public int Id { get => id; set => SetProperty(ref id, value); }
        public string Opis { get => opis; set => SetProperty(ref opis, value); }
        public DateTime DataUtworzenia { get => dataUtworzenia; set => SetProperty(ref dataUtworzenia, value); }
        public DateTime DataModyfikacji { get => dataModyfikacji; set => SetProperty(ref dataModyfikacji, value); }
        public string Imie { get => imie; set => SetProperty(ref imie, value); }
        public string Nazwisko { get => nazwisko; set => SetProperty(ref nazwisko, value); }
        public string StanCywilny { get => stanCywilny; set => SetProperty(ref stanCywilny, value); }
        public DateTime? DataUrodzenia { get => dataUrodzenia; set => SetProperty(ref dataUrodzenia, value); }
        public DateTime? DataZatrudnienia { get => dataZatrudnienia; set => SetProperty(ref dataZatrudnienia, value); }
        public DateTime? DataRezygnacji { get => dataRezygnacji; set => SetProperty(ref dataRezygnacji, value); }
        public string Plec { get => plec; set => SetProperty(ref plec, value); }
        public string NazwaStanowisko { get => nazwaStanowisko; set => SetProperty(ref nazwaStanowisko, value); }
        public ObservableCollection<WizytaForView> Wizyty { get; }
        public Command AddWizytaCommand { get; }
        #endregion


        public override async void LoadProperties(PracownikForView item)
        {
            Opis = item.Opis;
            DataModyfikacji = item.DataModyfikacji?.DateTime ?? DateTime.Now;
            DataUtworzenia = item.DataUtworzenia?.DateTime ?? DateTime.Now;
            Imie = item.Imie;
            Nazwisko = item.Nazwisko;
            StanCywilny = item.StanCywilny;
            Plec = (item.Plec == true) ? "Mężczyzna" : "Kobieta";
            NazwaStanowisko = item.NazwaStanowisko;
            DataUrodzenia = item.DataUrodzenia.Date;
            DataZatrudnienia = item.DataZatrudnienia.Date;
            await ExecuteLoadItemsCommand();
            //DataRezygnacji = item.DataRezygnacji;
        }
        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;
            try
            {
                Wizyty.Clear();
                var dataStore = DependencyService.Get<WizytaDataStore>();
                var items = (await dataStore.GetItemsAsync(true)).Where(wizyta => wizyta.IdPracownika == ItemId);
                foreach (var item in items)
                {
                    Wizyty.Add(item);
                }
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

        public async override void OnItemSelected(WizytaForView item)
        {
            if (item == null)
            {
                return;
            }
            await Shell.Current.GoToAsync($"{nameof(WizytaDetailsPage)}?{nameof(WizytaDetailsViewModel.ItemId)}={item.Id}");
        }

        public override void GoToAddPage()
        {
        }
    }
}