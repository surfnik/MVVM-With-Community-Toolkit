using _27_WPF_DataGrid.Models;
using _27_WPF_DataGrid.Serviceds;
using System.Collections.ObjectModel;

namespace _27_WPF_DataGrid.ViewModels;

[ObservableObject]
public partial class MainWindowViewModel
{
    public ObservableCollection<Person> Persons { get; set; } = new ObservableCollection<Person>();
    public ObservableCollection<Department> Departments { get; set; } = new ObservableCollection<Department>();

    public MainWindowViewModel()
    {
        var svc = new PersonService();
        foreach (Person person in svc.GetPersons())
            this.Persons.Add(person);
        foreach (Department dep in svc.GetDepartments())
                    this.Departments.Add(dep);
    }
}