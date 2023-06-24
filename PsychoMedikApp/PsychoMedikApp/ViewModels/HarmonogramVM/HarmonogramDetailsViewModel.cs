using PsychoMedik.Service.Reference;
using PsychoMedikApp.Helpers;
using PsychoMedikApp.ViewModels.Abstract;
using System;

namespace PsychoMedikApp.ViewModels.HarmonogramVM
{
    public class HarmonogramDetailsViewModel : AItemDetailsViewModel<HarmonogramForView>
    {
        public HarmonogramDetailsViewModel()
            : base()
        {
        }

        #region Pola 
        private string imieNazwiskoPracownika;
        private DateTime dataUtworzenia;
        private DateTime? dataPracy;
        private DateTime dataModyfikacji;
        private int? godzinaRozpoczecia;
        private int? godzinaZakonczenia;
        #endregion
        #region Właściwości
        public string ImieNazwiskoPracownika { get => imieNazwiskoPracownika; set => SetProperty(ref imieNazwiskoPracownika, value); }
        public DateTime DataUtworzenia { get => dataUtworzenia; set => SetProperty(ref dataUtworzenia, value); }
        public DateTime DataModyfikacji { get => dataModyfikacji; set => SetProperty(ref dataModyfikacji, value); }
        public DateTime? DataPracy { get => dataPracy; set => SetProperty(ref dataPracy, value); }
        public int? GodzinaRozpoczecia { get => godzinaRozpoczecia; set => SetProperty(ref godzinaRozpoczecia, value); }
        public int? GodzinaZakonczenia { get => godzinaZakonczenia; set => SetProperty(ref godzinaZakonczenia, value); }
        #endregion


        public override void LoadProperties(HarmonogramForView item)
        {
            DataModyfikacji = item.DataModyfikacji?.DateTime ?? DateTime.Now;
            DataUtworzenia = item.DataUtworzenia?.DateTime ?? DateTime.Now;
            DataPracy = item.DataPracy?.DateTime ?? DateTime.Now;
            GodzinaRozpoczecia = item.GodzinaRozpoczecia;
            GodzinaZakonczenia = item.GodzinaZakonczenia;
            ImieNazwiskoPracownika = item.ImieNazwiskoPracownika ?? "";
            this.CopyProperties(item);
        }
    }
}