using System;
using System.Globalization;
using MvvmCross.Converters;

namespace MvvmCrossValueConversion.Core.Converters
{
    public class TwoWayConverter : MvxValueConverter<double, string>
    {
        protected override string Convert(double value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value * value).ToString(CultureInfo.InvariantCulture);
        }

        protected override double ConvertBack(string value, Type targetType, object parameter, CultureInfo culture)
        {
            double.TryParse(value, out var doubleValue);

            return Math.Sqrt(doubleValue);
        }
    }
}
