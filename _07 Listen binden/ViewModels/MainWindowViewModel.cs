using _07_Listen_binden.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Listen_binden.ViewModels;

[ObservableObject]
public partial class MainWindowViewModel
{
    [ObservableProperty]
    private Person newPerson = new Person();
    [ObservableProperty]
    private ObservableCollection<Person> persons = new ObservableCollection<Person>();

    public MainWindowViewModel()
    {

    }
    [RelayCommand]
    private void AddPerson()
    {
        Persons.Add(NewPerson);
        NewPerson= new Person();
    }
}