namespace _27_WPF_DataGrid.Models;

[ObservableObject]
public partial class Person
{
    public int Id { get; set; }
    public string Firstname { get; set; } = null!;
    public string Lastname { get; set; } = null!;
    public string Email { get; set; } = null!;
    public DateTime? Birthday { get; set; } = null;
    public Department Department { get; set; } = null!;
}
