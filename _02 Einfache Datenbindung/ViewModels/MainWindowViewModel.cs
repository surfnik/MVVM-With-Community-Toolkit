using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Einfache_Datenbindung.ViewModels
{
    [ObservableObject]
    public partial class MainWindowViewModel
    {
        [ObservableProperty]
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
}