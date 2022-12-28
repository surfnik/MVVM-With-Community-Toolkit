namespace _21_Arbeiten_mit_Fenstern.ViewModels;
[ObservableObject]
public partial class DialogWindowViewModel
{
	public event EventHandler Ok;
	public event EventHandler Cancel;
	public DialogWindowViewModel()
	{

	}


	[ObservableProperty]
	private string name;
	[ObservableProperty]
	private string email;

	[RelayCommand]
	private void OkClick()
	{
		Ok?.Invoke(this, EventArgs.Empty);
	}
	[RelayCommand]
	private void CancelClick()
	{
		Cancel?.Invoke(this, EventArgs.Empty);
	}
}
