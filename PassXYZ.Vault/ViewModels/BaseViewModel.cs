using CommunityToolkit.Mvvm.ComponentModel;
using PassXYZ.Vault.Models;
using PassXYZ.Vault.Services;

namespace PassXYZ.Vault.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        protected string title = string.Empty;
        
        [ObservableProperty]
        protected bool isBusy;

        [ObservableProperty]
        protected IDataStore<Item> dataStore;
    }
}
