using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Animationen_und_Styles_Trigger.ViewModels;
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

    public Person(string firstname, string lastname, string department)
    {
        Firstname = firstname;
        Lastname = lastname;
        Department = department;
    }

    public Person()
    {
    }

    public string Fullname => $"{Firstname} {Lastname}";

}
