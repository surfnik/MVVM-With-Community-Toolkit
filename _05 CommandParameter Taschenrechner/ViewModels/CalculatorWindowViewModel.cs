using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _05_CommandParameter_Taschenrechner.ViewModels;
[ObservableObject]
public partial class CalculatorWindowViewModel
{
    [ObservableProperty]
    private double currentValue;
    double lastValue;
    string operatorToExecute;
    public CalculatorWindowViewModel()
    {
        NumberCommand = new RelayCommand<string>((value) =>
        {
            long val = long.Parse(value);
            CurrentValue = CurrentValue * 10.0 + val;
        });
        OperatorCommand = new RelayCommand<string>(ExecuteOperation); //mit CommandParameter RelayCommand mit <T>
        ClearAllCommand = new RelayCommand(ExecuteClearAll); //ohne CommandParameter RelayCommand ohne <T>
    }
    void ExecuteOperation(string op)
    {
        {
            if (op == "=") //Brechnung wird ausgeführt mit dem Operator aus 'operatorToExecute'
            {
                switch (operatorToExecute)
                {
                    case "+":
                        CurrentValue += lastValue;
                        break;
                    case "-":
                        CurrentValue = lastValue - currentValue;
                        break;
                    case "*":
                        CurrentValue *= lastValue;
                        break;
                    case "/":
                        CurrentValue = lastValue / currentValue;
                        break;
                    default: break;
                }
            }
            else //Rechenbefehl wird in 'operatorToExecute' abgelegt
            {
                this.operatorToExecute = op;
                lastValue = CurrentValue;
                CurrentValue = 0.0;
            }
        }
    }
    private void ExecuteClearAll()
    {
        CurrentValue= 0;
    }

    // CommandBinding mit CommandParameter:
    public RelayCommand<string> NumberCommand { get; }
    public RelayCommand<string> OperatorCommand { get; }
    
    // CommandBinding ohne CommandParameter:
    public RelayCommand ClearAllCommand { get; }

}
