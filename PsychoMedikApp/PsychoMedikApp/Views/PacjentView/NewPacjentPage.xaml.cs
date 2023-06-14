using PsychoMedikApp.ViewModels.PacjentVM;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychoMedikApp.Views.PacjentView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPacjentPage : ContentPage
    {
        //public ObservableCollection<string> Items { get; set; }
        public PsychoMedik.Service.Reference.Pacjent Item { get; set; }

        public NewPacjentPage()
        {
            InitializeComponent();
            BindingContext = new NewPacjentViewModel();
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