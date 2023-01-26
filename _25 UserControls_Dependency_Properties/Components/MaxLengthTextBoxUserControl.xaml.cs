using System.Windows;
using System.Windows.Controls;

namespace _25_UserControls_Dependency_Properties.Components;

/// <summary>
/// Interaktionslogik für MaxLengthTextBoxUserControl.xaml
/// </summary>
public partial class MaxLengthTextBoxUserControl : UserControl
{
    public static readonly DependencyProperty TextPoperty =
        DependencyProperty.Register(nameof(MaxLengthTextBoxUserControl.Text), typeof(string),
            typeof(MaxLengthTextBoxUserControl), 
            new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
    public MaxLengthTextBoxUserControl()
    {
        InitializeComponent();
        this.DataContext = this;
        //Bindung im XML: DataContext="{Binding RelativeSource={RelativeSource self}}" funkionioert nicht :(
    }

    public string Caption { get; set; }
    public int MaxLength { get; set; }
    public string Text
    {
        get => (string)GetValue(TextPoperty);
        set => SetValue(TextPoperty, value);
    }

}
