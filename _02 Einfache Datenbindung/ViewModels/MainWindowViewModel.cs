﻿namespace _02_Einfache_Datenbindung.ViewModels;

[ObservableObject]
public partial class MainWindowViewModel
{
    [ObservableProperty] //erzeugt automatisch "public string Firstname" mit Getter und Setter
    private string firstname;
    [ObservableProperty]
    private string lastname;

    public string Fullname => $"{Firstname} {Lastname}";

    public MainWindowViewModel()
    {
        Firstname = "Paul";
        Lastname = "Baumann";
    }
}