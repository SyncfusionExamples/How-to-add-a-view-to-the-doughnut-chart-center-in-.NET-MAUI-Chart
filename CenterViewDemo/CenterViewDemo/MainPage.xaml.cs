using System.Collections.ObjectModel;

namespace CenterViewDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new ChartViewModel();
	}
}
public class Sales
{
    public string Product { get; set; }
    public double Revenue { get; set; }
}
public class ChartViewModel
{
    public ObservableCollection<Sales> Data { get; set; }

    public ChartViewModel()
    {
        Data = new ObservableCollection<Sales>()
        {
            new Sales(){Product = "Food", Revenue = 45},
            new Sales(){Product = "Household", Revenue = 15},
            new Sales(){Product = "Electronics", Revenue = 5},
            new Sales(){Product = "Apparels", Revenue = 24},
            new Sales(){Product = "Others", Revenue = 11},
        };
    }
}

