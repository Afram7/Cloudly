using Cloudly.Views;

namespace Cloudly;

public partial class App : Application
{
	public App(IServiceProvider serviceProvider)
	{
		InitializeComponent();
		Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;

		bool isFirstLaunch = !Preferences.ContainsKey("isFirstLaunch");
		if (isFirstLaunch){
			MainPage = serviceProvider.GetRequiredService<WelcomePage>();
			Preferences.Set("isFirstLaunch", false);
		} else {
			MainPage = new AppShell();
		}
	}

    private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e){
        if (e.NetworkAccess != NetworkAccess.Internet)
        {
            MainPage?.DisplayAlert("No Internet Connection", "Make sure your device is connected to the internet.", "OK");
        }
    }
}