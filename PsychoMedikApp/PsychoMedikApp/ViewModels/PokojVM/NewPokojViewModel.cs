using PsychoMedik.Service.Reference;
using PsychoMedikApp.ViewModels.Abstract;
using System;

namespace PsychoMedikApp.ViewModels.PokojVM
{
    public class NewPokojViewModel : ANewViewModel<Pokoj>
    {
        #region Pola
        private string nazwa;
        private string opis;
        #endregion
        #region Właściwości
        public string Nazwa { get => nazwa; set => SetProperty(ref nazwa, value); }
        public string Opis { get => opis; set => SetProperty(ref opis, value); }
        #endregion
        public override Pokoj SetItem()
        {
            return new Pokoj
            {
                Id = 0,
                CzyAktywny = true,
                DataModyfikacji = DateTime.Now,
                DataUtworzenia = DateTime.Now,
                Opis = this.Opis,
                Nazwa = this.Nazwa,
            };
        }

        public override bool ValidateSave()
        {
            return !String.IsNullOrEmpty(nazwa);
        }
    }
}