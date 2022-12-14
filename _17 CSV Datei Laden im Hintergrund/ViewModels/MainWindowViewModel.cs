using _17_CSV_Datei_Laden_im_Hintergrund.Models;
using _17_CSV_Datei_Laden_im_Hintergrund.Servises;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_CSV_Datei_Laden_im_Hintergrund.ViewModels;

[ObservableObject]
public partial class MainWindowViewModel
{
    [ObservableProperty]
    private bool isLoading;

    public MainWindowViewModel()
    {
        Communities = new ObservableCollection<CommunityModel>();
    }

    [ObservableProperty]
    private ObservableCollection<CommunityModel> communities;
    //public ObservableCollection<CommunityModel> Communities { get; set; }

    [RelayCommand]
    private async void LoadCsv()
    {
        IsLoading = true;

        using (CsvService service = new CsvService("Gemeindeliste_AT.csv"))
        {
            var result = service.ReadCSV();
            await foreach (var item in result)
                Communities.Add(item);
        }

        IsLoading = false;
    }

}