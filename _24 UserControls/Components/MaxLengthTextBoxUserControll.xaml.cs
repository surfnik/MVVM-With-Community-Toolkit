using System.Windows.Controls;

namespace _24_UserControls.Components
{
    /// <summary>
    /// Interaktionslogik für MaxLengthTextBoxUserControll.xaml
    /// </summary>
    public partial class MaxLengthTextBoxUserControll : UserControl
    {
        public MaxLengthTextBoxUserControll()
        {
            InitializeComponent();
            this.DataContext= this;
        }

        public string Caption { get; set; }
        public int MaxLength { get; set; }

    }
}
