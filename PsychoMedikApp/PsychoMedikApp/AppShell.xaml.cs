using PsychoMedikApp.ViewModels;
using PsychoMedikApp.Views;
using PsychoMedikApp.Views.ChorobaView;
using PsychoMedikApp.Views.HarmonogramView;
using PsychoMedikApp.Views.HistoriaChorobyView;
using PsychoMedikApp.Views.ObjawView;
using PsychoMedikApp.Views.PacjentView;
using PsychoMedikApp.Views.PokojView;
using PsychoMedikApp.Views.PracownikView;
using PsychoMedikApp.Views.StanowiskoView;
using PsychoMedikApp.Views.WizytaView;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PsychoMedikApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ChorobaDetailsPage), typeof(ChorobaDetailsPage));
            Routing.RegisterRoute(nameof(NewChorobaPage), typeof(NewChorobaPage));
            Routing.RegisterRoute(nameof(ObjawDetailsPage), typeof(ObjawDetailsPage));
            Routing.RegisterRoute(nameof(NewObjawPage), typeof(NewObjawPage));
            Routing.RegisterRoute(nameof(PracownikDetailsPage), typeof(PracownikDetailsPage));
            Routing.RegisterRoute(nameof(NewPracownikPage), typeof(NewPracownikPage));
            Routing.RegisterRoute(nameof(PacjentDetailsPage), typeof(PacjentDetailsPage));
            Routing.RegisterRoute(nameof(NewPacjentPage), typeof(NewPacjentPage));
            Routing.RegisterRoute(nameof(StanowiskoDetailsPage), typeof(StanowiskoDetailsPage));
            Routing.RegisterRoute(nameof(NewStanowiskoPage), typeof(NewStanowiskoPage));
            Routing.RegisterRoute(nameof(PokojDetailsPage), typeof(PokojDetailsPage));
            Routing.RegisterRoute(nameof(NewPokojPage), typeof(NewPokojPage));
            Routing.RegisterRoute(nameof(AddWizytaPage), typeof(AddWizytaPage));
            Routing.RegisterRoute(nameof(WizytaDetailsPage), typeof(WizytaDetailsPage));
            Routing.RegisterRoute(nameof(AddHistoriaChorobyPage), typeof(AddHistoriaChorobyPage));
            Routing.RegisterRoute(nameof(HistoriaChorobyDetailsPage), typeof(HistoriaChorobyDetailsPage));
            Routing.RegisterRoute(nameof(HarmonogramDetailsPage), typeof(HarmonogramDetailsPage));
            Routing.RegisterRoute(nameof(NewHarmonogramPage), typeof(NewHarmonogramPage));
            Routing.RegisterRoute("AboutPage", typeof(AboutPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
