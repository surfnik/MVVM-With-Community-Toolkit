using _10_ViewLogik_vs_ViewModel.ViewModels;
using System.Windows;

namespace _10_ViewLogik_vs_ViewModel.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ((MainWindowViewModel)DataContext).MissingData += (sender, EventArgs) => ShowError();
        }

        public void ShowError()
        {
            MessageBox.Show("Bitte Vor- und Nachnamen eingeben.");
        }
    }
}
