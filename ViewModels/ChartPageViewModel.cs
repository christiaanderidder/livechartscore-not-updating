using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace MyMauiApp.ViewModels;

public partial class ChartPageViewModel : ObservableObject
{
    private readonly Random _random = new ();

    [ObservableProperty] private int _refreshCounter = 0;
    
    [ObservableProperty] private IEnumerable<ISeries> _data = Enumerable.Empty<ISeries>();

    [RelayCommand]
    public Task Refresh()
    {
        Data = new ISeries[] { new LineSeries<int> { Values = GetData() } };
        RefreshCounter++;
        
        return Task.CompletedTask;
    }

    private IEnumerable<int> GetData() => Enumerable.Range(0, 30).Select(_ => _random.Next(0, 25));
}