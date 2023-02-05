using System.Globalization;
using System.Windows;
using System.Windows.Navigation;

namespace _28_Datagrid_und_Contextmenue.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : NavigationWindow
{
    public MainWindow()
    {
        InitializeComponent();

        CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
        ci.DateTimeFormat.ShortDatePattern = "dd.MM.yyyy";
        Thread.CurrentThread.CurrentCulture = ci;

    }
}