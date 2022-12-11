using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Synchron_Asynchorn_Parallel.ViewModels
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