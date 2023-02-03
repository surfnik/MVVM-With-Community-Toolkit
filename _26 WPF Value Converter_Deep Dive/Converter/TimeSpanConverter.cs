using System.Globalization;
using System.Windows.Data;
//using TimeSpanConverterParameter;

namespace _26_WPF_Value_Converter_Deep_Dive.Converter;

public enum SpanFormat
{
    Days = 1,
    Hours = 2,
    Minutes = 3,
    Seconds = 4,
}

class TimeSpanConverter : IMultiValueConverter, IValueConverter
{
    public TimeSpanConverter()
    {
    }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        TimeSpan ts = (TimeSpan)value;
        if (ts == TimeSpan.MinValue) return string.Empty;

        TimeSpanConverterParameters parameters = parameter as TimeSpanConverterParameters ?? 
            new TimeSpanConverterParameters() { SpanFormat = SpanFormat.Minutes, SpanFormatString = "0.0" };

        switch (parameters.SpanFormat)
        {
            case SpanFormat.Days: return ts.TotalDays.ToString(parameters.SpanFormatString);
            case SpanFormat.Hours: return ts.TotalHours.ToString(parameters.SpanFormatString);
            case SpanFormat.Minutes: return ts.TotalMinutes.ToString(parameters.SpanFormatString);
            case SpanFormat.Seconds: return ts.TotalSeconds.ToString(parameters.SpanFormatString);
        }
        return string.Empty;
    }

    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        SpanFormat format = SpanFormat.Days;
        TimeSpan ts = TimeSpan.Zero;
        if (values[0] is SpanFormat)
            format = (SpanFormat)values[0];

        if (values[1] is TimeSpan)
            ts = (TimeSpan)values[1];

        string formatString = (string)parameter;
        switch (format)
        {
            case SpanFormat.Days: return ts.TotalDays.ToString(formatString);
            case SpanFormat.Hours: return ts.TotalHours.ToString(formatString);
            case SpanFormat.Minutes: return ts.TotalMinutes.ToString(formatString);
            case SpanFormat.Seconds: return ts.TotalSeconds.ToString(formatString);
        }
        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string)
        {
            int val;
            if (int.TryParse((string)value, out val))
            {
                TimeSpanConverterParameters parameters = parameter as TimeSpanConverterParameters ?? new TimeSpanConverterParameters() { SpanFormat = SpanFormat.Minutes, SpanFormatString = "0.0" };
                switch (parameters.SpanFormat)
                {
                    case SpanFormat.Days: return new TimeSpan(val, 0, 0); ;
                    case SpanFormat.Hours: return new TimeSpan(val, 0, 0);
                    case SpanFormat.Minutes: return new TimeSpan(0, val, 0);
                    case SpanFormat.Seconds: return new TimeSpan(0, 0, val);
                }
            }
        }
        return value; //???
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
