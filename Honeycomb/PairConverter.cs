using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Honeycomb
{
    class PairConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // TODO: Subscribe to the input collection to update the output collection.
            ObservableCollection<int> input = (ObservableCollection<int>)value;
            ObservableCollection<Pair> output = new ObservableCollection<Pair>();

            // TODO: Handle odd-sized collections.
            for (int i = 0; i < input.Count; i += 2)
            {
                output.Add(new Pair { First = input[i], Second = input[i + 1] });
            }

            return output;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
