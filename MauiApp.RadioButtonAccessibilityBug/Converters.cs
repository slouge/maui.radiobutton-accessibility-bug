using System.Globalization;

namespace MauiAppRadioButtonAccessibilityBug;

public class EqualityConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null || parameter == null)
            return false;

        return value.ToString() == parameter.ToString();
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return (bool)value ? parameter ?? string.Empty : null!;
    }
}
