using _19_Listen_Filtern_Suchfunktion.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace _19_Listen_Filtern_Suchfunktion.ViewModels;

[ObservableObject]
public partial class MainWindowViewModel
{
    public MainWindowViewModel()
    {
        listData.CollectionChanged += (s, e) => { DoFiltering(); };
        listData.Add(new Person("Susi", "Sonnenschein", "Sales"));
        listData.Add(new Person("Hans", "Müller", "Support"));
        listData.Add(new Person("Dev", "Dave", "Development"));
    }

    public ObservableCollection<Person> listData { get; } = new ObservableCollection<Person>();
    public ObservableCollection<Person> FilteredList { get; } = new ObservableCollection<Person>();
    
    [ObservableProperty]
    private string? filter ="";

    //partial void OnFilterChanged(string? value) => DoFiltering(); // wird durch [ObservableProperty] generiert

    private void DoFiltering()
    {
        FilteredList.Clear();
        string? filterString = filter?.ToLower() ?? "";
        foreach (Person item in listData)
        {
            if (String.IsNullOrEmpty(filter) ||
                item.Fullname.ToLower().Contains(filterString) ||
                item.Job.ToLower().Contains(filterString))
                FilteredList.Add(item);
        }
    }

    [RelayCommand]
    private void AddNewPerson() => listData.Add(new Person("Herbert", "Bossinger", "Management"));
}