using PsychoMedik.Service.Reference;
using PsychoMedikApp.Helpers;
using PsychoMedikApp.Services;
using PsychoMedikApp.ViewModels.Abstract;
using System;
using System.Collections.Generic;

namespace PsychoMedikApp.ViewModels.PacjentVM
{
    public class NewPacjentViewModel : ANewViewModel<PacjentForView>
    {
        #region Pola
        private string imie;
        private string nazwisko;
        private string opis;
        private DateTime dataUrodzenia;
        private bool plec;
        private PracownikForView wybranyPracownik;
        private List<PracownikForView> pracownicy;
        private DateTime dataUtworzenia;
        private DateTime dataModyfikacji;
        #endregion
        #region Właściwości
        public string Imie { get => imie; set => SetProperty(ref imie, value); }
        public string Nazwisko { get => nazwisko; set => SetProperty(ref nazwisko, value); }
        public string Opis { get => opis; set => SetProperty(ref opis, value); }
        public DateTime DataUrodzenia { get => dataUrodzenia; set => SetProperty(ref dataUrodzenia, value); }
        public bool Plec { get => plec; set => SetProperty(ref plec, value); }
        public DateTime DataUtworzenia { get => dataUtworzenia; set => SetProperty(ref dataUtworzenia, value); }
        public DateTime DataModyfikacji { get => dataModyfikacji; set => SetProperty(ref dataModyfikacji, value); }
        public PracownikForView WybranyPracownik { get => wybranyPracownik; set => SetProperty(ref wybranyPracownik, value); }
        public List<PracownikForView> Pracownicy { get => pracownicy; }
        #endregion

        public override PacjentForView SetItem()
        {
            return new PacjentForView
            {
                Id = 0,
                CzyAktywny = true,
                DataModyfikacji = DateTime.Now,
                DataUtworzenia = DateTime.Now,
                DataUrodzenia = this.DataUrodzenia,
                ImieNazwisko = this.wybranyPracownik.Imie + " " + this.wybranyPracownik.Nazwisko,
                IdPracownika = wybranyPracownik.Id
            }.CopyProperties(this);
        }
        public NewPacjentViewModel()
            : base()
        {
            var pracownikForViewDataStora = new PracownikDataStore();
            pracownikForViewDataStora.RefreshListFromService();
            pracownicy = pracownikForViewDataStora.items;
        }

        public override bool ValidateSave()
        {
            return !String.IsNullOrEmpty(imie);
        }
    }
}