using Microsoft.Maui.Layouts;

namespace Cloudly.Views;

public partial class SpecificCityPage : ContentPage
{
	string[] dummyTimes = {"15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00"};
	string[] dummyDays = {"Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
	
	public SpecificCityPage()
	{
		InitializeComponent();
		timeCollection.ItemsSource = dummyTimes;

		FlexLayout daysFlex = new() {
			Direction = FlexDirection.Column,
			JustifyContent = FlexJustify.SpaceAround
		};

		foreach(var day in dummyDays) {
			StackLayout contentStackLayout = [];

			Grid grid = new() {
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength(0.5, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength(0.5, GridUnitType.Star) }
				}
			};

            Label dayName = new() {
				Text = day,
				FontSize = 24,
				FontFamily = "RobotoMedium"
			};

			Grid.SetColumn(dayName, 0);
			grid.Children.Add(dayName);

			FlexLayout contentFlex = new() {
				JustifyContent = FlexJustify.SpaceBetween,
				AlignItems = FlexAlignItems.Center
			};

			Image weatherImage = new() {
				HorizontalOptions =  LayoutOptions.Center,
				MaximumHeightRequest = 30,
				MaximumWidthRequest = 30,
				Source="cloudy"
			};

			HorizontalStackLayout horizontalContent = new HorizontalStackLayout();
			Label degrees = new() {
				Text = "14",
				FontSize = 36,
				FontFamily="RobotoRegular"
			};
			Label unit = new() {
				Text = "°C",
				FontSize = 19,
				FontFamily="RobotoRegular"
			};
			horizontalContent.Children.Add(degrees);
			horizontalContent.Children.Add(unit);

			contentFlex.Children.Add(weatherImage);
			contentFlex.Children.Add(horizontalContent);

			Grid.SetColumn(contentFlex, 1);
			grid.Children.Add(contentFlex);

			contentStackLayout.Children.Add(grid);
			daysFlex.Children.Add(contentStackLayout);
		}
		upcomingDaysFrame.Content = daysFlex;
	}
}