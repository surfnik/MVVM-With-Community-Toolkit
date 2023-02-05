namespace _04_Command.ViewModels;

[ObservableObject]
public partial class MainWindowViewModel
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Fullname))]
    [NotifyCanExecuteChangedFor(nameof(ClearCommand))]
    private string? firstname;
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Fullname))]
    [NotifyCanExecuteChangedFor(nameof(ClearCommand))]
    private string? lastname;

    public string Fullname => $"{Firstname} {Lastname}";

    public MainWindowViewModel()
    {
        Firstname = "Paul";
        Lastname = "Baumann";
    }

    [RelayCommand(CanExecute = nameof(CanClearClick))] //nur ausführbar, wenn CanClearClick == True
    private void Clear()
    {
        Firstname = ""; Lastname = "";
    }
    private bool CanClearClick() => !string.IsNullOrEmpty(firstname) || !string.IsNullOrEmpty(lastname);
}