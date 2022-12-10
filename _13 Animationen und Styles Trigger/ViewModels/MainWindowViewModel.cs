using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Animationen_und_Styles_Trigger.ViewModels;
[ObservableObject]
public partial class MainWindowViewModel
{
    [ObservableProperty]
    private Person newPerson = new Person();
    [ObservableProperty]
    private ObservableCollection<Person> persons = new ObservableCollection<Person>();

    public MainWindowViewModel()
    {   // Drei Personen erstellt, damit man sie nicht immer wieder neu eingeben muss
        Persons.Add(new Person("Susi", "Sonnenschein", "Sales"));
        Persons.Add(new Person("Hans", "Müller", "Development"));
        Persons.Add(new Person("Hugo", "Bossinger", "Management"));
    }
    [RelayCommand]
    private void AddPerson()
    {
        Persons.Add(NewPerson);
        NewPerson = new Person();
    }
}