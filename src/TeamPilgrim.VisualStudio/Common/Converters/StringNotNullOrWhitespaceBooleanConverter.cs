using System;
using System.Globalization;
using System.Windows.Data;

namespace JustAProgrammer.TeamPilgrim.VisualStudio.Common.Converters
{
    public class StringNotNullOrWhitespaceBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !string.IsNullOrWhiteSpace((string) value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}