using PsychoMedikApp.ViewModels.PokojVM;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoMedikApp.Views.PokojView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPokojPage : ContentPage
    {
        //public ObservableCollection<string> Items { get; set; }
        public PsychoMedik.Service.Reference.Pokoj Item { get; set; }

        public NewPokojPage()
        {
            InitializeComponent();
            BindingContext = new NewPokojViewModel();
        }

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