using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace _06_ValueConverter.Converter;

class BoolToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if ((bool)value)
            return Visibility.Visible;
        else
            return Visibility.Hidden;
    }
    //oder: 
    //return (bool)value ? Visibility.Visible : (object)Visibility.Hidden;


    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if ((Visibility)value == Visibility.Visible)
            return true;
        else
            return false;
    }
    //oder:
    //return (Visibility)value == Visibility.Visible ? true : (object)false;
}
