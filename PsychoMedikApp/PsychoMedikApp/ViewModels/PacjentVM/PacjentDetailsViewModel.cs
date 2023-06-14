using PsychoMedik.Service.Reference;
using PsychoMedikApp.Helpers;
using PsychoMedikApp.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PsychoMedikApp.ViewModels.PacjentVM
{
    public class PacjentDetailsViewModel : AItemDetailsViewModel<PacjentForView>
    {
        public PacjentDetailsViewModel()
            : base()
        {
        }

        #region Pola
        private string imie;
        private string nazwisko;
        private DateTime dataUrodzenia;
        private string plec;
        private string imieNazwiskoPracownikaProwadzacego;
        private DateTime dataUtworzenia;
        private DateTime dataModyfikacji;
        #endregion
        #region Właściwości
        public string Imie { get => imie; set => SetProperty(ref imie, value); }
        public string Nazwisko { get => nazwisko; set => SetProperty(ref nazwisko, value); }
        public DateTime DataUrodzenia { get => dataUrodzenia; set => SetProperty(ref dataUrodzenia, value); }
        public string Plec { get => plec; set => SetProperty(ref plec, value); }
        public string ImieNazwiskoPracownikaProwadzacego { get => imieNazwiskoPracownikaProwadzacego; set => SetProperty(ref imieNazwiskoPracownikaProwadzacego, value); }
        public DateTime DataUtworzenia { get => dataUtworzenia; set => SetProperty(ref dataUtworzenia, value); }
        public DateTime DataModyfikacji { get => dataModyfikacji; set => SetProperty(ref dataModyfikacji, value); }
        #endregion


        public override void LoadProperties(PacjentForView item)
        {
            Plec = (item.Plec == true) ? "Mężczyzna" : "Kobieta";
            DataModyfikacji = item.DataModyfikacji?.DateTime ?? DateTime.Now;
            DataUtworzenia = item.DataUtworzenia?.DateTime ?? DateTime.Now;
            DataUrodzenia = item.DataUrodzenia?.DateTime ?? DateTime.Now;
            Imie = item.Imie;
            Nazwisko = item.Nazwisko;
            ImieNazwiskoPracownikaProwadzacego = item.ImieNazwiskoPracownikaProwadzacego;
        }
    }
}