using PsychoMedik.Service.Reference;
using PsychoMedikApp.Helpers;
using PsychoMedikApp.Services;
using PsychoMedikApp.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels.PracownikVM
{
    public class NewPracownikViewModel : ANewViewModel<PracownikForView>
    {

        #region Pola
        private string imie;
        private string nazwisko;
        private DateTime dataUrodzenia;
        private DateTime dataZatrudnienia;
        private DateTime? dataRezygnacji;
        private bool plec;
        private string stanCywilny;
        private string opis;
        private Stanowisko wybraneStanowisko;
        private List<Stanowisko> stanowiska;
        #endregion
        #region Właściwości
        public string Opis { get => opis; set => SetProperty(ref opis, value); }
        public string Imie { get => imie; set => SetProperty(ref imie, value); }
        public string Nazwisko { get => nazwisko; set => SetProperty(ref nazwisko, value); }
        public string StanCywilny { get => stanCywilny; set => SetProperty(ref stanCywilny, value); }
        public DateTime DataUrodzenia { get => dataUrodzenia; set => SetProperty(ref dataUrodzenia, value); }
        public DateTime DataZatrudnienia { get => dataZatrudnienia; set => SetProperty(ref dataZatrudnienia, value); }
        public DateTime? DataRezygnacji { get => dataRezygnacji; set => SetProperty(ref dataRezygnacji, value); }
        public bool Plec { get => plec; set => SetProperty(ref plec, value); }
        public Stanowisko WybraneStanowisko { get => wybraneStanowisko; set => SetProperty(ref wybraneStanowisko, value); }
        public List<Stanowisko> Stanowiska { get => stanowiska; }
        #endregion

        public NewPracownikViewModel()
            : base()
        {
            wybraneStanowisko = new Stanowisko();
            var stanowiskoDataStore = new StanowiskoDataStore();
            stanowiskoDataStore.RefreshListFromService();
            stanowiska = stanowiskoDataStore.items;
        }
        public override PracownikForView SetItem()
        {
            return new PracownikForView
            {                
                Id = 0,
                CzyAktywny = true,
                DataModyfikacji = DateTime.Now,
                DataUtworzenia = DateTime.Now,
                Opis = this.Opis,
                NazwaStanowisko = wybraneStanowisko.Nazwa,
                DataUrodzenia = this.DataUrodzenia,
                DataRezygnacji = this.DataRezygnacji,
                DataZatrudnienia = this.DataZatrudnienia
            }.CopyProperties(this);
        }

        public override bool ValidateSave()
        {
            return !String.IsNullOrEmpty(imie);
        }
    }
}