using _17_CSV_Datei_Laden_im_Hintergrund.Models;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_CSV_Datei_Laden_im_Hintergrund.Servises;

public class CsvService : IDisposable
{
    TextReader textreader;
    CsvHelper.CsvReader csvreader;

    public CsvService(string filename)
    {
        textreader = new StreamReader(filename);
        CsvConfiguration config = new CsvConfiguration(CultureInfo.CurrentCulture);
        config.Delimiter = ",";
        config.HasHeaderRecord= false;
        csvreader = new CsvHelper.CsvReader(textreader, config);
    }

    public void Dispose()
    {
        textreader.Dispose();
        csvreader.Dispose();
    }

    public IAsyncEnumerable<CommunityModel> ReadCSV()
    {
        var communities = csvreader.GetRecordsAsync<CommunityModel>();
        Thread.Sleep(1000);return communities;
    }
}
