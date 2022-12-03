using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Command.ViewModels
{
    [ObservableObject]
    public partial class MainWindowViewModel
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Fullname))]
        [NotifyCanExecuteChangedFor(nameof(ClearCommand))]
        private string? firstname;
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Fullname))]
        [NotifyCanExecuteChangedFor(nameof(ClearCommand))]
        private string? lastname;

        public string Fullname => $"{Firstname} {Lastname}";
        public RelayCommand<MainWindowViewModel> ClearCommand { get; }

        public MainWindowViewModel()
        {
            ClearCommand = new RelayCommand<MainWindowViewModel>(
                (o) => { Firstname = ""; Lastname = ""; },
                (o) => !string.IsNullOrEmpty(firstname) || !string.IsNullOrEmpty(lastname));

            //ClearCommand = new RelayCommand<MainWindowViewModel>(OnClearClick, CanClearClick);
            Firstname = "Paul";
            Lastname = "Baumann";
        }

        //private void OnClearClick()
        //{
        //    Firstname = ""; Lastname = "";
        //}

        //private bool CanClearClick() => !string.IsNullOrEmpty(firstname) || !string.IsNullOrEmpty(lastname);
    }
}