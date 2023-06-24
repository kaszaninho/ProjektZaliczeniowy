using PsychoMedik.Service.Reference;
using PsychoMedikApp.Helpers;
using PsychoMedikApp.Services;
using PsychoMedikApp.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels
{
    [QueryProperty(nameof(IdPracownika), nameof(IdPracownika))]
    public class AddWizytaViewModel : ANewViewModel<WizytaForView>
    {
        public AddWizytaViewModel()
            : base()
        {
            wybranyPacjentData = new PacjentForView();
            wybranyPokoj = new Pokoj();

            var pacjentForViewDataStore = new PacjentDataStore();
            pacjentForViewDataStore.RefreshListFromService();
            pacjenci = pacjentForViewDataStore.items;

            var pokojDataStore = new PokojDataStore();
            pokojDataStore.RefreshListFromService();
            pokoje = pokojDataStore.items;
        }
        #region Pola       
        private int idPracownika;
        private DateTime? dataWizyty;
        private PacjentForView wybranyPacjentData;
        private List<PacjentForView> pacjenci;
        private Pokoj wybranyPokoj;
        private string opis;
        private List<Pokoj> pokoje;
        #endregion
        #region Właściwości 
        public int IdPracownika { get => idPracownika; set => SetProperty(ref idPracownika, value); }
        public DateTime? DataWizyty { get => dataWizyty; set => SetProperty(ref dataWizyty, value); }
        public PacjentForView WybranyPacjentData { get => wybranyPacjentData; set => SetProperty(ref wybranyPacjentData, value); }
        public List<PacjentForView> Pacjenci
        {
            get
            {
                return pacjenci;
            }
        }
        public Pokoj WybranyPokoj { get => wybranyPokoj; set => SetProperty(ref wybranyPokoj, value); }
        public string Opis { get => opis; set => SetProperty(ref opis, value); }
        public List<Pokoj> Pokoje { get => pokoje; }
        #endregion

        public override WizytaForView SetItem()
        {
            return new WizytaForView
            {
                Id = 0,
                CzyAktywny = true,
                DataModyfikacji = DateTime.Now,
                DataUtworzenia = DateTime.Now,
                IdPokoju = WybranyPokoj.Id,
                IdPacjenta = WybranyPacjentData.Id,
                IdPracownika = this.IdPracownika,
                DataWizyty = DataWizyty,
                Opis = Opis,
            }.CopyProperties(this);
        }

        public override bool ValidateSave()
        {
            return !String.IsNullOrEmpty(Opis);
        }
    }
}
