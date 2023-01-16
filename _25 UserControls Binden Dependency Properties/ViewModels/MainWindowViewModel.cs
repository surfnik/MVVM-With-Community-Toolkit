using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_UserControls_Binden_Dependency_Properties.ViewModels
{
    [ObservableObject]
    public partial class MainWindowViewModel
    {
        [ObservableProperty]
        public string dummyText;

        public MainWindowViewModel()
        {
            DummyText = "Ein Platzhalter";
        }

    }
}