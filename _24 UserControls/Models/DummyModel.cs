using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_UserControls.Models
{
    [ObservableObject]
    public partial class DummyModel
    {
        [ObservableProperty]
        private string? prop1;
    }
}