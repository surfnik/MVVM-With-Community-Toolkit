using _27_WPF_DataGrid.Models;
using _27_WPF_DataGrid.Serviceds;
using System.Collections.ObjectModel;

namespace _27_WPF_DataGrid.ViewModels;

[ObservableObject]
public partial class MainWindowViewModel
{
    //[ObservableProperty]
    //private string dummyText;

    public ObservableCollection<Person> Persons { get; set; } = new ObservableCollection<Person>();
    public ObservableCollection<Department> Departments { get; set; } = new ObservableCollection<Department>();

    public MainWindowViewModel()
    {
        var svc = new PersonService();
        foreach (var person in svc.GetPersons())
            this.Persons.Add(person);
        foreach (var dep in svc.GetDepartments())
                    this.Departments.Add(dep);
    }

}