using MyMauiApp.ViewModels;

namespace MyMauiApp.Views;

public partial class ChartPage : ContentPage
{
	public ChartPage(ChartPageViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}

