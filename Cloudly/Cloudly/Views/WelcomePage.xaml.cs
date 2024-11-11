using Cloudly.ViewModels;

namespace Cloudly.Views;

public partial class WelcomePage : ContentPage
{
	public WelcomePage(WelcomeViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}