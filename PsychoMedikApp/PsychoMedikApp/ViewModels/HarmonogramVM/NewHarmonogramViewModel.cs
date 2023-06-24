using PsychoMedik.Service.Reference;
using PsychoMedikApp.Services;
using PsychoMedikApp.ViewModels.Abstract;
using System;
using System.Collections.Generic;

namespace PsychoMedikApp.ViewModels.HarmonogramVM
{
    public class NewHarmonogramViewModel : ANewViewModel<HarmonogramForView>
    {
        public NewHarmonogramViewModel()
        {
            var pracownikDataStore = new PracownikDataStore();
            pracownikDataStore.RefreshListFromService();
            pracownicy = pracownikDataStore.items;
        }

        #region Pola 
        private DateTime? dataPracy;
        private int? godzinaRozpoczecia;
        private int? godzinaZakonczenia;
        private PracownikForView wybranyPracownik;
        private List<PracownikForView> pracownicy;
        #endregion
        #region Właściwości
        public PracownikForView WybranyPracownik { get => wybranyPracownik; set => SetProperty(ref wybranyPracownik, value); }
        public List<PracownikForView> Pracownicy { get => pracownicy; }
        public DateTime? DataPracy { get => dataPracy; set => SetProperty(ref dataPracy, value); }
        public int? GodzinaRozpoczecia { get => godzinaRozpoczecia; set => SetProperty(ref godzinaRozpoczecia, value); }
        public int? GodzinaZakonczenia { get => godzinaZakonczenia; set => SetProperty(ref godzinaZakonczenia, value); }
        #endregion
        public override HarmonogramForView SetItem()
        {
            return new HarmonogramForView
            {
                Id = 0,
                CzyAktywny = true,
                DataModyfikacji = DateTime.Now,
                DataUtworzenia = DateTime.Now,
                DataPracy = this.DataPracy,
                GodzinaZakonczenia = this.GodzinaZakonczenia,
                GodzinaRozpoczecia = this.GodzinaRozpoczecia,
                IdPracownika = wybranyPracownik.Id,
            };
        }

        public override bool ValidateSave()
        {
            return !DataPracy.Equals(null);
        }
    }
}