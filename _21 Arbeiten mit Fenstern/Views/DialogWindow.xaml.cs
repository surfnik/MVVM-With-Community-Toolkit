using _21_Arbeiten_mit_Fenstern.ViewModels;
using System.Windows;

namespace _21_Arbeiten_mit_Fenstern.Views
{
    /// <summary>
    /// Interaktionslogik für DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window
    {
        public DialogWindow()
        {
            InitializeComponent();
            var vm = this.DataContext as DialogWindowViewModel;
            vm.Ok += (o, e) => DialogResult = true;
            vm.Cancel += (o, e) => DialogResult = false;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult= true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
