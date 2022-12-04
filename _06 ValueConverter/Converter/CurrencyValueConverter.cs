using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace _06_ValueConverter.Converter;
public class CurrencyValueConverter : IValueConverter
{
    //vom ViewModel zur View
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        decimal val = (decimal)value;
        return val.ToString("0.00") + (string)parameter;
    }
    
    //von der View zum ViewModel
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        string val = (string)value;
        val = val.Replace("€", "").Trim();
        decimal result = decimal.Parse(val);
        return result;
    }
}
