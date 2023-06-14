using PsychoMedik.Service.Reference;
using PsychoMedikApp.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PsychoMedikApp.ViewModels.WizytaVM
{
    public class WizytaDetailsViewModel : AItemDetailsViewModel<WizytaForView>
    {
        public WizytaDetailsViewModel()
            : base()
        {
        }

        #region Pola
        private string imieNazwiskoPracownika;
        private string imieNazwiskoPacjenta;
        private int? idPacjenta;
        private int? idPracownika;
        private int? idPokoju;
        private DateTime dataWizyty;
        private DateTime dataUtworzenia;
        private DateTime dataModyfikacji;
        #endregion
        #region Właściwości
        public string ImieNazwiskoPracownika { get => imieNazwiskoPracownika; set => SetProperty(ref imieNazwiskoPracownika, value); }
        public string ImieNazwiskoPacjenta { get => imieNazwiskoPacjenta; set => SetProperty(ref imieNazwiskoPacjenta, value); }
        public int? IdPacjenta { get => idPacjenta; set => SetProperty(ref idPacjenta, value); }
        public int? IdPracownika { get => idPracownika; set => SetProperty(ref idPracownika, value); }
        public int? IdPokoju { get => idPokoju; set => SetProperty(ref idPokoju, value); }
        public DateTime DataWizyty { get => dataWizyty; set => SetProperty(ref dataWizyty, value); }
        public DateTime DataUtworzenia { get => dataUtworzenia; set => SetProperty(ref dataUtworzenia, value); }
        public DateTime DataModyfikacji { get => dataModyfikacji; set => SetProperty(ref dataModyfikacji, value); }
        #endregion


        public override void LoadProperties(WizytaForView item)
        {
            ImieNazwiskoPacjenta = item.ImieNazwiskoPacjenta;
            ImieNazwiskoPracownika = item.ImieNazwiskoPracownika;
            IdPacjenta = item.IdPacjenta;
            IdPracownika = item.IdPracownika;
            IdPokoju = item.IdPokoju;
            DataWizyty = item.DataWizyty?.DateTime ?? DateTime.Now;
            DataModyfikacji = item.DataModyfikacji?.DateTime ?? DateTime.Now;
            DataUtworzenia = item.DataUtworzenia?.DateTime ?? DateTime.Now;
        }
    }
}