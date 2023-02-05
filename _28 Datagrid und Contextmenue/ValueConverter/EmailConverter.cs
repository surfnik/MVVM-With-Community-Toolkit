using System.Globalization;
using System.Windows.Data;

namespace _28_Datagrid_und_Contextmenue.ValueConverter;
public class EmailConverter : IValueConverter
{
    const string PREFIX = "mailto:";
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        string? email = value as string;
        if (!String.IsNullOrEmpty(email))
            return $"{PREFIX}{email}";
        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        string? mailLink = value as string;
        if (!String.IsNullOrEmpty(mailLink) && mailLink.ToLower().StartsWith(PREFIX))
            return mailLink[PREFIX.Length..];
        return mailLink ?? string.Empty;
    }
}
