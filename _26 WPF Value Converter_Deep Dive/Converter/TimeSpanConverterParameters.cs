using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _26_WPF_Value_Converter_Deep_Dive.Converter;

public class TimeSpanConverterParameters : DependencyObject
{
    public static readonly DependencyProperty SpanFormatProberty =
        DependencyProperty.Register(nameof(SpanFormat), typeof(SpanFormat),
            typeof(TimeSpanConverterParameters), new PropertyMetadata(null));

    public static readonly DependencyProperty SpanFormatStringProberty =
        DependencyProperty.Register(nameof(SpanFormatString), typeof(string),
            typeof(TimeSpanConverterParameters), new PropertyMetadata(null));

    public SpanFormat SpanFormat
    {
        get => (SpanFormat)GetValue(SpanFormatProberty);
        set => SetValue(SpanFormatProberty, value);
    }

    public string SpanFormatString
    {
        get => (string)GetValue(SpanFormatStringProberty);
        set => SetValue(SpanFormatStringProberty, value);
    }
}
