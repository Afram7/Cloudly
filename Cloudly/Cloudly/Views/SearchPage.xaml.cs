namespace Cloudly.Views;

public partial class SearchPage : ContentPage
{
	string[] dummyCities = { "Tibro", "Skövde", "Jönköping", "Stockholm", "Göteborg", "Värnamo", "Oslo", "Hjo", "Trollhättan", "Linköping"};
	public SearchPage()
	{
		InitializeComponent();
		recentlySearchedCitiesColloection.ItemsSource = dummyCities;
	}
}