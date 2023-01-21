using System.Windows.Controls;

namespace _24_UserControls.Components
{
    /// <summary>
    /// Interaktionslogik für MaxLengthTextBoxUserControl.xaml
    /// </summary>
    public partial class MaxLengthTextBoxUserControl : UserControl
    {
        public MaxLengthTextBoxUserControl()
        {
            InitializeComponent();
            this.DataContext= this;
        }

        public string Caption { get; set; }
        public int MaxLength { get; set; }

    }
}
