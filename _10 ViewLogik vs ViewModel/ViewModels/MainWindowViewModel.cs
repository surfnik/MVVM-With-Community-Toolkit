using System;
using System.Collections.ObjectModel;

namespace _10_ViewLogik_vs_ViewModel.ViewModels;
[ObservableObject]
public partial class MainWindowViewModel
{
    [ObservableProperty]
    private Person newPerson = new Person();
    [ObservableProperty]
    private ObservableCollection<Person> persons = new ObservableCollection<Person>();

    public MainWindowViewModel()
    {
        AddPersonCommand = new RelayCommand<Person>((o) =>
        {
            if (string.IsNullOrWhiteSpace(NewPerson.Firstname) || string.IsNullOrWhiteSpace(NewPerson.Lastname))
                MissingData?.Invoke(this, EventArgs.Empty);
            else
            {
                Persons.Add(NewPerson);
                NewPerson = new Person();
            }
        });
    }
    public RelayCommand<Person> AddPersonCommand { get; }

    public event EventHandler MissingData;
}