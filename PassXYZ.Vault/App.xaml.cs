using System.Diagnostics;

namespace PassXYZ.Vault;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
	}
    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);
		window.Created += (s, e) => { Debug.WriteLine("\nPassXYZ.Vault.App: 1.Created event\n"); };
		window.Activated += (s, e) => { Debug.WriteLine("\nPassXYZ.Vault.App: 2.Activated event\n"); };
		window.Deactivated += (s, e) => { Debug.WriteLine("\nPassXYZ.Vault.App: 3.Deactivated event\n"); };
		window.Stopped += (s, e) => { Debug.WriteLine("\nPassXYZ.Vault.App: 4.Stopped event\n"); };
		window.Resumed += (s, e) => { Debug.WriteLine("\nPassXYZ.Vault.App: 5.Resumed event\n"); };
		window.Destroying += (s, e) => { Debug.WriteLine("\nPassXYZ.Vault.App: 6.Destroying event\n"); };
		return window;
    }

    protected override void OnStart()
    {
        Debug.WriteLine("\nPassXYZ.Vault.App: OnStart\n");
    }

    protected override void OnSleep()
    {
        Debug.WriteLine("\nPassXYZ.Vault.App: OnSleep\n");
    }

    protected override void OnResume()
    {
        Debug.WriteLine("\nPassXYZ.Vault.App: OnResume\n");
    }
}
