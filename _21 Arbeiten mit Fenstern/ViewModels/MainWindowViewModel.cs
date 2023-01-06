using System.Windows;

namespace _21_Arbeiten_mit_Fenstern.ViewModels;

[ObservableObject]
public partial class MainWindowViewModel
{
    // Variante mit Events:
    //public event EventHandler OpenDialogEvent;

    //Variante mit Delegates
    public delegate (string name, string email) OpenDialogHandler(string name, string email);
    public OpenDialogHandler OpenDialogH { get; set; }

    // für die MessageBox:
    public delegate MessageBoxResult OpenMessageBoxHandler(string title, string text);
    public OpenMessageBoxHandler OpenMessageBox { get; set; }

    public MainWindowViewModel()
    {
        
    }

    [RelayCommand]
    private void OpenDialog()
    {
        // Variante mit Events:
        //this.OpenDialogEvent?.Invoke(this, EventArgs.Empty);

        //Variante mit Delegates
        (Name, Email) = OpenDialogH(this.Name, this.Email);
    }

    [RelayCommand]
    private void OpenMsg()
    {
        if (this.OpenMessageBox("Frage", "Willst du das?") == MessageBoxResult.Yes)
        {
            Name = "42 Entwickler";
        }
        else
        {
            Name = "Nö";
        }
    }
    [ObservableProperty]
    private string name;
    [ObservableProperty]
    private string email;

}