using PsychoMedik.Service.Reference;
using PsychoMedikApp.ViewModels.Abstract;
using System;
using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels.HistoriaChorobyVM
{
    public class HistoriaChorobyDetailsViewModel : AItemDetailsViewModel<HistoriaChorobyForView>
    {
        public HistoriaChorobyDetailsViewModel()
            : base()
        {
            MenuCommand = new Command(GoToAboutPage);
        }
        #region Pola       
        private int? idPacjenta;
        private int? idPracownika;
        private int? idChoroby;
        private string imieNazwiskoPracownika;
        private string imieNazwiskoPacjenta;
        private string nazwaChoroby;
        private DateTime? dataZdiagnozowania;
        private DateTime? dataWyleczenia;
        private PracownikForView wybranyPracownikData;
        private Choroba wybranaChoroba;
        private string opis;
        private DateTime dataUtworzenia;
        private DateTime dataModyfikacji;
        #endregion
        #region Właściwości 
        public DateTime? DataZdiagnozowania { get => dataZdiagnozowania; set => SetProperty(ref dataZdiagnozowania, value); }
        public DateTime? DataWyleczenia { get => dataWyleczenia; set => SetProperty(ref dataWyleczenia, value); }
        public string ImieNazwiskoPracownika { get => imieNazwiskoPracownika; set => SetProperty(ref imieNazwiskoPracownika, value); }
        public string ImieNazwiskoPacjenta { get => imieNazwiskoPacjenta; set => SetProperty(ref imieNazwiskoPacjenta, value); }
        public string NazwaChoroby { get => nazwaChoroby; set => SetProperty(ref nazwaChoroby, value); }
        public int? IdPacjenta { get => idPacjenta; set => SetProperty(ref idPacjenta, value); }
        public int? IdPracownika { get => idPracownika; set => SetProperty(ref idPracownika, value); }
        public int? IdChoroby { get => idChoroby; set => SetProperty(ref idChoroby, value); }
        public string Opis { get => opis; set => SetProperty(ref opis, value); }
        public DateTime DataUtworzenia { get => dataUtworzenia; set => SetProperty(ref dataUtworzenia, value); }
        public DateTime DataModyfikacji { get => dataModyfikacji; set => SetProperty(ref dataModyfikacji, value); }
        #endregion
        public Command MenuCommand { get; }

        public async void GoToAboutPage()
        {
            await Shell.Current.GoToAsync($"//AboutPage");
        }

        public override void LoadProperties(HistoriaChorobyForView item)
        {
            ImieNazwiskoPacjenta = item.ImieNazwiskoPacjenta;
            ImieNazwiskoPracownika = item.ImieNazwiskoPracownika;
            IdPacjenta = item.IdPacjenta;
            IdPracownika = item.IdPracownika;
            IdChoroby = item.IdChoroby;
            DataZdiagnozowania = item.DataZdiagnozowania?.DateTime ?? DateTime.Now;
            DataModyfikacji = item.DataModyfikacji?.DateTime ?? DateTime.Now;
            DataWyleczenia = item.DataWyleczenia?.DateTime ?? DateTime.Now;
            DataUtworzenia = item.DataUtworzenia?.DateTime ?? DateTime.Now;
            Opis = item.Opis;
        }
    }
}