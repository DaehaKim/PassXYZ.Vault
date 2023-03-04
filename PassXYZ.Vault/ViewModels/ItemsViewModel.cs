using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PassXYZ.Vault.Models;
using PassXYZ.Vault.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PassXYZ.Vault.ViewModels;

public partial class ItemsViewModel : BaseViewModel
{
    public ItemsViewModel()
    {
        title = "Browse";
        items = new List<Item>();
    }

    [ObservableProperty]
    private  List<Item> items;

    [ObservableProperty]
    private Item selectedItem;

    [RelayCommand]
    private async void AddItems()
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }

    [RelayCommand]
    private async void LoadItems()
    {

        IsBusy = true;

        try
        {
            Items.Clear();
            var items = await DataStore.GetItemsAsync(true);
            foreach (var item in items)
            {
                Items.Add(item);
                Debug.WriteLine($"ItemsViewModel: {item.Text}, {item.Description}");
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

    [RelayCommand]
    private void OnItemSelected()
    {
        if (SelectedItem == null)
        {
            Debug.WriteLine("OnItemSelected : item is null.");
            return;
        }
    }

}
