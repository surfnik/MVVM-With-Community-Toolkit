namespace _25_UserControls_Dependency_Properties.ViewModels;

[ObservableObject]
public partial class MainWindowViewModel
{

    [ObservableProperty]
    private string text1;
    [ObservableProperty]
    private string text2;
    public MainWindowViewModel()
    {
        Text1 = "Dummy1";
        Text2 = "Dummy2";
    }

}