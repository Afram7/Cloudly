using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Cloudly.ViewModels;

public partial class WelcomeViewModel : ObservableObject
{
    private readonly string[] temperatureUnits = ["Celsius", "Fahrenheit"];
    [ObservableProperty]
    private string chosenUnit = "";
    [ObservableProperty]
    private bool isButtonEnabled = false;

    public string[] TemperatureUnits {
        get { return temperatureUnits; }
    }
    
    partial void OnChosenUnitChanged(string value)
    {
        if (ChosenUnit == "Celsius" || ChosenUnit == "Fahrenheit"){
            IsButtonEnabled = true;
        } else {
            IsButtonEnabled = false;
        }
    }

    [RelayCommand]
    private async Task SaveClicked(){
        await RequestLocationPermission();

        Preferences.Set("temperatureUnit", ChosenUnit);

        if (Application.Current != null){
            Application.Current.MainPage = new AppShell();
        }
    }

    [RelayCommand]
    private async Task SkipClicked(){
        await RequestLocationPermission();

        // Set default temperature unit to Celsius
        string defaultTemperatureUnit = temperatureUnits[0];
        Preferences.Set("temperatureUnit", defaultTemperatureUnit);

        if (Application.Current != null){
            Application.Current.MainPage = new AppShell();
        }
    }

    private static async Task RequestLocationPermission(){
        PermissionStatus status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
    }
}