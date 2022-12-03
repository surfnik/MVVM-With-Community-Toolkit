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
        this.NumberCommand = new RelayCommand<string>((value) =>
        {
            long val = long.Parse(value);
            this.CurrentValue = this.CurrentValue * 10.0 + val;
        });
        this.OperatorCommand = new RelayCommand<string>(ExecuteOperation);
    }

    void ExecuteOperation(string op)
    {
        {
            string oper = (string)op;
            if (oper == "=")
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
                    case "#":
                        CurrentValue = 0.0;
                        break;
                    default: break;
                }
            }
            else
            {
                this.operatorToExecute = oper;
                lastValue = CurrentValue;
                CurrentValue = 0.0;
            }
        }
    }
    public RelayCommand<string> NumberCommand { get; }
    public RelayCommand<string> OperatorCommand { get; set; }

}
