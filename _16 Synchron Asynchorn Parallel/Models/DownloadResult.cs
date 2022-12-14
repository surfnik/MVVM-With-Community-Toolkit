using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Synchron_Asynchorn_Parallel.Models;
[ObservableObject]
public partial class DownloadResult
{
    [ObservableProperty]
    private string url;
    [ObservableProperty]
    private string html;

    public int ContentLength => Html?.Length ?? 0;
}
