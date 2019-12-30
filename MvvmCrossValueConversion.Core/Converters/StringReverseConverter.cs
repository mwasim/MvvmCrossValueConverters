using System;
using System.Globalization;
using MvvmCross.Converters;

namespace MvvmCrossValueConversion.Core.Converters
{
    public class StringReverseConverter : MvxValueConverter<string, string>
    {
        protected override string Convert(string value, Type targetType, object parameter, CultureInfo culture)
        {
            value = value ?? string.Empty;

            char[] charArray = value.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
