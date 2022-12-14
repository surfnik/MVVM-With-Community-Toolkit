using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_CSV_Datei_Laden_im_Hintergrund.Models;
[ObservableObject]
public partial class CommunityModel
{
    [ObservableProperty]
    private int id;
    [ObservableProperty]
    private string name;

    public override string? ToString()
    {
        return $"{Id} - {Name}";
    }
}
