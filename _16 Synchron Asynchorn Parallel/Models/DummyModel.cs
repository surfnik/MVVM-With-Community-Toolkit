using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Synchron_Asynchorn_Parallel.Models
{
    [ObservableObject]
    public partial class DummyModel
    {
        [ObservableProperty]
        private string? prop1;
    }
}