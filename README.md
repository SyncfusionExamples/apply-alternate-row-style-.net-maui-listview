# How to apply alternate row style in .NET MAUI ListView (SfListView)?

The [.NET MAUI ListView (SfListView)](https://www.syncfusion.com/maui-controls/maui-listview) allows the application of alternate row styling for items using [IValueConverter](https://docs.microsoft.com/en-us/dotnet/maui/fundamentals/data-binding/converters).

**Steps:**
1. Bind the IndexToColorConverter to the BackgroundColor property of the element loaded in the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemsSource). Pass the SfListView reference to find the index of the underlying object.
2. Get the item index from the [DataSource.DisplayItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_DisplayItems) property and return the color based on the index.

![Alternate row style in .NET MAUI ListView (SfListView)](https://www.syncfusion.com/uploads/user/kb/maui/maui-2063/maui-2063_img1.png)

Download the complete sample on [GitHub](https://github.com/SyncfusionExamples/apply-alternate-row-style-.net-maui-listview).

**Conclusion**

I hope you enjoyed learning how to apply alternate row style in .NET MAUI ListView

You can refer to our .[NET MAUI ListView](https://www.syncfusion.com/maui-controls/maui-listview) feature tour page to learn about its other groundbreaking feature representations and [documentation](https://help.syncfusion.com/maui/listview/getting-started), and how to quickly get started with configuration specifications. Explore our [.NET MAUI ListView](https://github.com/syncfusion/maui-demos/tree/master/MAUI/ListView)[example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/ListView) to understand how to create and manipulate data.

For current customers, check out our components from the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion®, try our 30-day [free trial](https://www.syncfusion.com/downloads?utm_medium=ads&amp;utm_source=googleads&amp;utm_campaign=winforms-tier3&amp;gclid=CjwKCAjwgqejBhBAEiwAuWHioHGi37_0A3P4JtugQp2qh86mquGYgLZtYLQQRoKU62TzJldf_Bc3RxoCl6oQAvD_BwE)to check out our other controls.

Please let us know in the comments section if you have any queries or require clarification. Contact us through our [support forums](https://www.syncfusion.com/forums/), [Direct-Trac](https://support.syncfusion.com/create), or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sflistview). We are always happy to assist you!
