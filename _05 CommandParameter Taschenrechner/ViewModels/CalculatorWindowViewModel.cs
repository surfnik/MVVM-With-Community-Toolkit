namespace _05_CommandParameter_Taschenrechner.ViewModels;
[ObservableObject]
public partial class CalculatorWindowViewModel
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(ClearAllCommand))] //ClearAll nur wenn CurrentValue != 0
    private double currentValue;
    double lastValue;
    string operatorToExecute;
    public CalculatorWindowViewModel()
    {
        //alle Commands werden durch den Quellcodegenerator [RelayCommand] erzeugt. 
        //es müssen nur noch die privaten Methoden erstellt werden. Bindung in der View erfolgt auf die generierten Methoden,
        //Die Namen der generierten Methoden lauten wie die privaten Methoden + Command.
        //Hier sind das: NumberCommand, OperatorCommand und ClearAllCommand
    }

    [RelayCommand] // erzeugt automatisch "public global IRelayCommand<string> NumberCommand, auf das in der View gebunden wird
    private void Number(string value)
    {
        long val = long.Parse(value);
        CurrentValue = CurrentValue * 10.0 + val;
    }
    [RelayCommand]
    public void Operator(string op)
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

    [RelayCommand(CanExecute = nameof(CanClear))] //prüfen ob ausführbar
    private void ClearAll() => CurrentValue = 0.0;
    public bool CanClear() => CurrentValue != 0;
}
