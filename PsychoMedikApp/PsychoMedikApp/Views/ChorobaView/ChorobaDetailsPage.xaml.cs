﻿using PsychoMedikApp.ViewModels.ChorobaVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoMedikApp.Views.ChorobaView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChorobaDetailsPage : ContentPage
    {
        //public ObservableCollection<string> Items { get; set; }


        public ChorobaDetailsPage()
        {
            InitializeComponent();
            BindingContext = new ChorobaDetailsViewModel();

            //    Items = new ObservableCollection<string>
            //    {
            //        "Item 1",
            //        "Item 2",
            //        "Item 3",
            //        "Item 4",
            //        "Item 5"
            //    };

            //    MyListView.ItemsSource = Items;
            //}

            //async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
            //{
            //    if (e.Item == null)
            //        return;

            //    await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //    //Deselect Item
            //    ((ListView)sender).SelectedItem = null;
            //}
        }
    }
}