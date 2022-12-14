using _16_Synchron_Asynchorn_Parallel.Models;
using System.Diagnostics;
using System.Net.Http;
using System.Text;

namespace _16_Synchron_Asynchorn_Parallel.ViewModels;

[ObservableObject]
public partial class MainWindowViewModel
{
    string[] urls = new string[]
    {
        "https://www.suse.de",
        "https://steamcommunity.com/",
        "https://docs.microsoft.com",
        "https://www.youtube.com",
        "https://www.youtobe.com",
        "https://www.asp.net",
        "https://www.google.com",
        "https://www.yahoo.com",
        "https://www.bing.com",
        "https://www.heise.de"

    };

    [ObservableProperty]
    private string infoText;

    [RelayCommand]
    private void Download() 
    {
        Stopwatch watch = Stopwatch.StartNew();
        List<DownloadResult> results = new List<DownloadResult>(urls.Length);
        foreach (string url in urls)
        {
            results.Add(DownloadUrlSync(url));
            ShowResults(results);
        }
        watch.Stop();
        long elapsedMs = watch.ElapsedMilliseconds;
        InfoText += $"Total execution Time: {elapsedMs}ms";
    }


    [RelayCommand]
    async private Task DownloadAsyn()
    {
        Stopwatch watch = Stopwatch.StartNew();
        List<DownloadResult> results = new List<DownloadResult>(urls.Length);
        foreach (string url in urls)
        {
            results.Add(await DownloadUrl(url));
            ShowResults(results);
        }
        watch.Stop();
        long elapsedMs = watch.ElapsedMilliseconds;
        InfoText += $"Total execution Time: {elapsedMs}ms";
    }

    [RelayCommand]
    async private Task DownloadParallel()
    {
        Stopwatch watch = Stopwatch.StartNew();
        List<Task<DownloadResult>> taskList = new List<Task<DownloadResult>>(urls.Length);
        foreach (string url in urls)
        {
            taskList.Add(DownloadUrl(url));
        }
        
        var results = await Task.WhenAll(taskList);
       
        ShowResults(results.ToList());
        watch.Stop();
        long elapsedMs = watch.ElapsedMilliseconds;
        InfoText += $"Total execution Time: {elapsedMs}ms";
    }
    private void ShowResults(List<DownloadResult> results)
    {
        StringBuilder text= new StringBuilder();
        foreach (DownloadResult result in results)
        {
            text.Append(result.Url);
            text.Append('\t');
            text.Append(result.ContentLength);
            text.Append("\n");
        }
        InfoText= text.ToString();
    }

    private DownloadResult DownloadUrlSync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            string html = client.GetStringAsync(url).Result;
            return new DownloadResult() { Url = url, Html = html };
        }
    }

    private async Task<DownloadResult> DownloadUrl(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            string html = await client.GetStringAsync(url);
            return new DownloadResult() { Url=url, Html= html };
        }
    }
}