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
        [NotifyPropertyChangedFor(nameof(Fullname))] //generiert OnProprertyChanged(nameof(Fullname))
        private string firstname;
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Fullname))]
        private string lastname;

        public string Fullname => $"{Firstname} {Lastname}"; //wird automatisch über Änderungen benachrichtig wegen "[NotifyPropertyChangedFor(nameof(Fullname))]"

        public MainWindowViewModel()
        {
            Firstname = "Paul";
            Lastname = "Baumann";
        }
    }
}