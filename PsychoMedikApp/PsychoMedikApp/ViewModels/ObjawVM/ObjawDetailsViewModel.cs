using PsychoMedik.Service.Reference;
using PsychoMedikApp.ViewModels.Abstract;
using System;

namespace PsychoMedikApp.ViewModels.ObjawVM
{
    public class ObjawDetailsViewModel : AItemDetailsViewModel<Objaw>
    {
        public ObjawDetailsViewModel()
            : base()
        {
        }

        #region Pola
        private string nazwa;
        private string opis;
        private DateTime dataUtworzenia;
        private DateTime dataModyfikacji;
        #endregion
        #region Właściwości
        public string Nazwa { get => nazwa; set => SetProperty(ref nazwa, value); }
        public string Opis { get => opis; set => SetProperty(ref opis, value); }
        public DateTime DataUtworzenia { get => dataUtworzenia; set => SetProperty(ref dataUtworzenia, value); }
        public DateTime DataModyfikacji { get => dataModyfikacji; set => SetProperty(ref dataModyfikacji, value); }
        #endregion


        public override void LoadProperties(Objaw item)
        {
            Nazwa = item.Nazwa;
            Opis = item.Opis;
            DataModyfikacji = item.DataModyfikacji?.DateTime ?? DateTime.Now;
            DataUtworzenia = item.DataUtworzenia?.DateTime ?? DateTime.Now;
        }
    }
}