using MyMauiApp.ViewModels;

namespace MyMauiApp.Views;

public partial class OtherPage : ContentPage
{
	public OtherPage(OtherPageViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}

