namespace _19_Listen_Filtern_Suchfunktion.Models;
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
    private string job;

    public string Fullname => $"{Firstname} {Lastname}";
    public Person()
    {

    }

    public Person(string firstname, string lastname, string job)
    {
        Firstname = firstname;
        Lastname = lastname;
        Job = job;
    }
}
