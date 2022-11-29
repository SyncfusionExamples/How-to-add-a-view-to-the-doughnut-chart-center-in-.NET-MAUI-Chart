# How-to-add-a-view-to-the-doughnut-chart-center-in-.NET-MAUI-Chart
The center view of the doughnut chart is used to share additional information about it. Any view can be added to the doughnut chart center using the CenterView property of the DoughnutSeries, as per the following code example.

```
xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"

<chart:SfCircularChart>
.  .  . 
    <chart:SfCircularChart.Series>

        <chart:DoughnutSeries ItemsSource="{Binding Data}" InnerRadius="0.6" XBindingPath="Product"
                                                  YBindingPath="Revenue" ShowDataLabels="True">

            <chart:DoughnutSeries.CenterView>
                <StackLayout>
                    <Label Text="Total:" HorizontalOptions="Center"/>
                    <Label Text="$35.07K" HorizontalOptions="Center"/>
                </StackLayout>
            </chart:DoughnutSeries.CenterView>
        .  .  .
        </chart:DoughnutSeries>

    </chart:SfCircularChart.Series>

</chart:SfCircularChart>
```

```
using Syncfusion.Maui.Charts;

SfCircularChart chart = new SfCircularChart();
. . .
DoughnutSeries series = new DoughnutSeries();
chart.Series.Add(series);
series.XBindingPath = "Product";
series.YBindingPath = "Revenue";
series.ItemsSource = new ChartViewModel().Data;
series.InnerRadius = 0.6;
series.ShowDataLabels = true;

Label labelOne = new Label();
labelOne.Text = "Total:";
labelOne.HorizontalOptions = LayoutOptions.Center;
Label labelTwo = new Label();
labelTwo.Text = "$35.07K";
labelTwo.HorizontalOptions = LayoutOptions.Center;
StackLayout layout = new StackLayout();
layout.Children.Add(labelOne);
layout.Children.Add(labelTwo);

series.CenterView = layout;
. . .
Content = chart;
```


**Doughnut chart with center view**


<img width="427" alt="maui_doughnut_chart_centerview" src="https://user-images.githubusercontent.com/105496256/204472918-4daf3e4b-75c2-4150-a7a9-54368eb0b464.PNG">
