using PsychoMedikApp.Services.Abstract;
using PsychoMedikApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels.Abstract
{
    public abstract class AItemDetailsListViewModel<T, W> : AItemDetailsViewModel<T>
    {
        public IDataStore<W> DataStoreW => DependencyService.Get<IDataStore<W>>();
        private W _selectedItem;
        public ObservableCollection<W> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<W> ItemTapped { get; }



        public AItemDetailsListViewModel(string title)
            :base()
        {
            Title = title;
            Items = new ObservableCollection<W>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            ItemTapped = new Command<W>(OnItemSelected);
            AddItemCommand = new Command(OnAddItem);
        }



        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;
            try
            {
                Items.Clear();
                var items = await DataStoreW.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = default(W);
        }
        public W SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }
        public abstract void GoToAddPage();
        public async void OnAddItem(object obj)
        {
            GoToAddPage();
        }



        public async virtual void OnItemSelected(W item)
        {
            if (item == null)
                return;
        }
    }
}
