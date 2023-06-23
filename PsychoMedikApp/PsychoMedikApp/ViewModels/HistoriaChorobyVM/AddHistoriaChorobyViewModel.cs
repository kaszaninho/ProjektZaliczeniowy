using PsychoMedik.Service.Reference;
using PsychoMedikApp.Helpers;
using PsychoMedikApp.Models;
using PsychoMedikApp.Services;
using PsychoMedikApp.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels
{
    [QueryProperty(nameof(IdPacjenta), nameof(IdPacjenta))]
    public class AddHistoriaChorobyViewModel : ANewViewModel<HistoriaChorobyForView>
    {
        public AddHistoriaChorobyViewModel()
            : base()
        {
            wybranyPracownik = new PracownikForView();
            wybranaChoroba = new Choroba();

            var pracownikForViewDataStore = new PracownikDataStore();
            pracownikForViewDataStore.RefreshListFromService();
            pracownicy = pracownikForViewDataStore.items;

            var chorobaDataStore = new ChorobaDataStore();
            chorobaDataStore.RefreshListFromService();
            choroby = chorobaDataStore.items;
        }
        #region Pola       
        private int idPacjenta;
        private DateTime? dataZdiagnozowania;
        private DateTime? dataWyleczenia;
        private PracownikForView wybranyPracownik;
        private List<PracownikForView> pracownicy;
        private Choroba wybranaChoroba;
        private string opis;
        private List<Choroba> choroby;
        #endregion
        #region Właściwości 
        public int IdPacjenta { get => idPacjenta; set => SetProperty(ref idPacjenta, value); }
        public DateTime? DataZdiagnozowania { get => dataZdiagnozowania; set => SetProperty(ref dataZdiagnozowania, value); }
        public DateTime? DataWyleczenia { get => dataWyleczenia; set => SetProperty(ref dataWyleczenia, value); }
        public PracownikForView WybranyPracownik { get => wybranyPracownik; set => SetProperty(ref wybranyPracownik, value); }
        public List<PracownikForView> Pracownicy
        {
            get
            {
                return pracownicy;
            }
        }
        public Choroba WybranaChoroba { get => wybranaChoroba; set => SetProperty(ref wybranaChoroba, value); }
        public string Opis { get => opis; set => SetProperty(ref opis, value); }
        public List<Choroba> Choroby { get => choroby; }
        #endregion

        public override HistoriaChorobyForView SetItem()
        {
            return new HistoriaChorobyForView
            {
                Id = 0,
                CzyAktywny = true,
                DataModyfikacji = DateTime.Now,
                DataUtworzenia = DateTime.Now,
                DataWyleczenia = this.DataWyleczenia,
                DataZdiagnozowania = this.DataZdiagnozowania,
                IdChoroby = WybranaChoroba.Id,
                IdPacjenta = this.IdPacjenta,
                IdPracownika = WybranyPracownik.Id,
                Opis = Opis,
                NazwaChoroby = WybranaChoroba.Nazwa,               
            }.CopyProperties(this);
        }

        public override bool ValidateSave()
        {
            return !String.IsNullOrEmpty(Opis);
        }
    }
}
