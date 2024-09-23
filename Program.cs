Console.WriteLine("hello oop");

var p1 = new Person("Plemno", "Puwell", new DateOnly(2005, 4, 9));
var p2 = new Person("David", "Fowler", new DateOnly(1986, 1, 1));

List<Person> persons = [p1, p2];
Console.WriteLine(persons.Count());

public class Person(string firstName, string lastName, DateOnly birthday)
{
    public string First { get; } = firstName;
    public string Last { get; } = lastName;
    public DateOnly Birthday { get; } = birthday;
}
