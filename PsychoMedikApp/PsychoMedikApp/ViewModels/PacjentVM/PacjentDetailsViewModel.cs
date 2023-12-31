﻿using PsychoMedik.Service.Reference;
using PsychoMedikApp.Services;
using PsychoMedikApp.ViewModels.Abstract;
using PsychoMedikApp.ViewModels.HistoriaChorobyVM;
using PsychoMedikApp.Views.HistoriaChorobyView;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels.PacjentVM
{
    public class PacjentDetailsViewModel : AItemDetailsListViewModel<PacjentForView, HistoriaChorobyForView>
    {
        public PacjentDetailsViewModel()
            : base("Pacjent")
        {
            HistorieChoroby = new ObservableCollection<HistoriaChorobyForView>();
            AddHistoriaChorobyCommand = new Command(async () => await Shell.Current.GoToAsync($"{nameof(AddHistoriaChorobyPage)}?{nameof(AddHistoriaChorobyViewModel.IdPacjenta)}={ItemId}"));
        }

        #region Pola
        private int id;
        private string imie;
        private string nazwisko;
        private DateTime dataUrodzenia;
        private string plec;
        private string imieNazwisko;
        private DateTime dataUtworzenia;
        private DateTime dataModyfikacji;
        #endregion
        #region Właściwości
        public int Id { get => id; set => SetProperty(ref id, value); }
        public string Imie { get => imie; set => SetProperty(ref imie, value); }
        public string Nazwisko { get => nazwisko; set => SetProperty(ref nazwisko, value); }
        public DateTime DataUrodzenia { get => dataUrodzenia; set => SetProperty(ref dataUrodzenia, value); }
        public string Plec { get => plec; set => SetProperty(ref plec, value); }
        public string ImieNazwisko { get => imieNazwisko; set => SetProperty(ref imieNazwisko, value); }
        public DateTime DataUtworzenia { get => dataUtworzenia; set => SetProperty(ref dataUtworzenia, value); }
        public DateTime DataModyfikacji { get => dataModyfikacji; set => SetProperty(ref dataModyfikacji, value); }
        public ObservableCollection<HistoriaChorobyForView> HistorieChoroby { get; }
        public Command AddHistoriaChorobyCommand { get; }
        #endregion


        public override async void LoadProperties(PacjentForView item)
        {
            Plec = (item.Plec == true) ? "Mężczyzna" : "Kobieta";
            DataModyfikacji = item.DataModyfikacji?.DateTime ?? DateTime.Now;
            DataUtworzenia = item.DataUtworzenia?.DateTime ?? DateTime.Now;
            DataUrodzenia = item.DataUrodzenia?.DateTime ?? DateTime.Now;
            Imie = item.Imie;
            Nazwisko = item.Nazwisko;
            ImieNazwisko = item.ImieNazwisko;
            await ExecuteLoadItemsCommand();
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;
            try
            {
                HistorieChoroby.Clear();
                var dataStore = DependencyService.Get<HistoriaChorobyDataStore>();
                var items = (await dataStore.GetItemsAsync(true)).Where(historia => historia.IdPacjenta == ItemId);
                foreach (var item in items)
                {
                    HistorieChoroby.Add(item);
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

        public async override void OnItemSelected(HistoriaChorobyForView item)
        {
            if (item == null)
            {
                return;
            }
            await Shell.Current.GoToAsync($"{nameof(HistoriaChorobyDetailsPage)}?{nameof(HistoriaChorobyDetailsViewModel.ItemId)}={item.Id}");
        }

        public override void GoToAddPage()
        {
        }
    }
}