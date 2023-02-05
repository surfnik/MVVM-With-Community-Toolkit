using _28_Datagrid_und_Contextmenue.Models;
using _28_Datagrid_und_Contextmenue.Services;
using System.Collections.ObjectModel;
using System.Windows.Media.Animation;

namespace _28_Datagrid_und_Contextmenue.ViewModels;

public partial class MainWindowViewModel
{
    public ObservableCollection<Person> Persons { get; set; } = new ObservableCollection<Person>();
    public ObservableCollection<Department> Departments { get; set; } = new ObservableCollection<Department>();

    [RelayCommand]
    private void Remove(object o)
    {
        if (o as Person != null)
            this.Persons.Remove((Person)o);
    }
    public MainWindowViewModel()
    {
        var svc = new PersonService();
        foreach (Person person in svc.GetPersons())
            this.Persons.Add(person);
        foreach (Department dep in svc.GetDepartments())
            this.Departments.Add(dep);
    }
}