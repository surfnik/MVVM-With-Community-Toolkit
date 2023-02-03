using _26_WPF_Value_Converter_Deep_Dive.Converter;

namespace _26_WPF_Value_Converter_Deep_Dive.ViewModels
{
    [ObservableObject]
    public partial class MainWindowViewModel
    {
        [ObservableProperty]
        private string dummyText;

        public MainWindowViewModel()
        {
            StartDate = DateTime.Today;
            EndDate = DateTime.Today.AddDays(1);
        }

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(StartEndSpan))]
        private DateTime startDate;
        
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(StartEndSpan))]
        private DateTime endDate;

        [ObservableProperty]
        private SpanFormat format = SpanFormat.Hours;

        public TimeSpan StartEndSpan => EndDate - StartDate;

    }
}