**[View document in Syncfusion .NET MAUI Knowledge Base](https://www.syncfusion.com/kb/13165/how-to-apply-alternate-row-style-in-net-maui-listview-sflistview)**

## Sample

```xaml
<ContentPage.Resources>
        <ResourceDictionary>
            <local:IndexToColorConverter x:Key="IndexToColorConverter"/>
        </ResourceDictionary>
</ContentPage.Resources>

<listView:SfListView x:Name="listView" ItemSize="50" ItemsSource="{Binding ContactsInfo}" >
    <listView:SfListView.ItemTemplate>
        <DataTemplate>
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </listView:SfListView.ItemTemplate>
</listView:SfListView>


C#:

public class IndexToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var listview = parameter as SfListView;
        var index = listview.DataSource.DisplayItems.IndexOf(value);

        return index % 2 == 0 ? Colors.LightGray : Colors.Aquamarine;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
```
