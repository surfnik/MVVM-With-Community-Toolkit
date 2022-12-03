using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Bitte_Benachichtigen.ViewModels
{
    [ObservableObject]
    public partial class MainWindowViewModel
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Fullname))]
        private string firstname;
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Fullname))]
        private string lastname;

        public string Fullname => $"{Firstname} {Lastname}";

        public MainWindowViewModel()
        {
            Firstname = "Paul";
            Lastname = "Baumann";
        }
    }
}