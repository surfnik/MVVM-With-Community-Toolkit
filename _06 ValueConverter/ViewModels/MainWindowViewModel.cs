using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace _06_ValueConverter.ViewModels
{
    [ObservableObject]
    public partial class MainWindowViewModel
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(HasNonZeroValue))]
        private decimal currencyValue;
        public bool HasNonZeroValue => CurrencyValue != 0.0m;

        public MainWindowViewModel()
        {
            
        }

    }
}