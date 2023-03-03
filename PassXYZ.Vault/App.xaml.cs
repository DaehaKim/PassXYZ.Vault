using PassXYZ.Vault.Services;
using PassXYZ.Vault.Views;

namespace PassXYZ.Vault;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        DependencyService.Register<MockDataStore>();
        MainPage = new AppShell();
    }

	private async void OnMenuItemClicked(System.Object sender, System.EventArgs e)
	{
		await Shell.Current.GoToAsync("//LoginPage");
	}
}