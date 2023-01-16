using System.Windows;
using System.Windows.Controls;

namespace _24_UserControls.Components
{
    /// <summary>
    /// Interaktionslogik für MaxLengthTextBoxUserControl.xaml
    /// </summary>
    public partial class MaxLengthTextBoxUserControl : UserControl
    {
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(MaxLengthTextBoxUserControl.Text), typeof(string),
                typeof(MaxLengthTextBoxUserControl), 
                new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault ));
        public MaxLengthTextBoxUserControl()
        {
            InitializeComponent();
            this.DataContext= this;
        }

        public string Caption { get; set; }
        public int MaxLength { get; set; }
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        

    }
}
