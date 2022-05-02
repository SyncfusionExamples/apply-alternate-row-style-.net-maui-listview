using Syncfusion.Maui.ListView;
using Syncfusion.Maui.ListView.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    #region IndexToColorConverter
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
    #endregion
}
