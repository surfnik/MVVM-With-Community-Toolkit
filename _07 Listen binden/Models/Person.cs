using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Listen_binden.Models;
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
