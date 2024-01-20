using System.Globalization;

namespace AdventureWorks.MAUI.Converters;

public class InvertedBoolConverter : IValueConverter
{
  public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
  {
    return !(bool)(value ?? true);
  }

  public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
  {
    return null;
  }
}
