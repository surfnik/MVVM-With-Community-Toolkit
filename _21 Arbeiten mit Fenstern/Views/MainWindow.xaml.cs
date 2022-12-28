using _21_Arbeiten_mit_Fenstern.ViewModels;
using System.Windows;

namespace _21_Arbeiten_mit_Fenstern.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var vm = (MainWindowViewModel)DataContext;
            // Variante mit Events:
            //vm.OpenDialogEvent += (s, ev) =>
            //{
            //    DialogWindow dialog = new DialogWindow();
            //    if (dialog.ShowDialog() == true)
            //    {
            //        var dialogViewModel = ((DialogWindowViewModel)dialog.DataContext);
            //        vm.Email = dialogViewModel.Email;
            //        vm.Name = dialogViewModel.Name;
            //    }
            //};

            //Variante mit Delegates
            vm.OpenDialogH = (name, email) =>
            {
                DialogWindow dialog = new DialogWindow();
                if (dialog.ShowDialog() == true)
                {
                    var dialogViewModel = ((DialogWindowViewModel)dialog.DataContext);
                    return (dialogViewModel.Name, dialogViewModel.Email);
                }
                else
                    return (string.Empty, string.Empty);
            };
        }
    }
}
