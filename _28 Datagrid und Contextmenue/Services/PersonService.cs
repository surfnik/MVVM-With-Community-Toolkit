using _28_Datagrid_und_Contextmenue.Models;

namespace _28_Datagrid_und_Contextmenue.Services;

internal class PersonService
{
    public IEnumerable<Person> GetPersons()
    {
        var deps = GetDepartments();
        var engDep = deps[0];
        var salesDep = deps[1];
        var mgmDep = deps[2];
        return new Person[]
        {
            new Person() {Firstname = "Max", Lastname = "Muster", Email = "max@muster.at", Id = 1, Department= engDep},
            new Person() {Firstname = "Susi", Lastname = "Müller", Email = "susi@muster.at", Id = 1, Department= salesDep, Birthday = new DateTime(1988,3,27)},
            new Person() {Firstname = "Dave", Lastname = "Dev", Email = "dave@muster.at", Id = 1, Department= engDep, Birthday = new DateTime(1990,7,12)},
            new Person() {Firstname = "Chief", Lastname = "Bossinger", Email = "chief@muster.at", Id = 1, Department= mgmDep, Birthday = new DateTime(1986,9,10)}
        };
    }
    public Department[] GetDepartments()
    {
        return new Department[]
        {
            new Department() {Id = 1, Name = "Engeneering" },
            new Department() {Id = 2, Name = "Sales" },
            new Department() {Id = 3, Name = "Management" }
        };
    }
}
