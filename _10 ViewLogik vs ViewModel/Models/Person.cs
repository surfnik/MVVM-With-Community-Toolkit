namespace _10_ViewLogik_vs_ViewModel;

[ObservableObject]
public partial class Person
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Fullname))]
    private string firstname;
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Fullname))]
    private string lastname;
    [ObservableProperty]
    private string department;
    
    public string Fullname => $"{Firstname} {Lastname}";
}
