using System;
using System.Globalization;
using MvvmCross.Converters;

namespace MvvmCrossValueConversion.Core.Converters
{
    public class StringLengthConverter : MvxValueConverter<string, int>
    {
        protected override int Convert(string value, Type targetType, object parameter, CultureInfo culture)
        {
            value = value ?? string.Empty;

            return value.Length;
        }
    }
}
