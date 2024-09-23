Console.WriteLine("hello oop");

var p1 = new Person("Plemno", "Puwell", new DateOnly(2005, 4, 9));
var p2 = new Person("David", "Fowler", new DateOnly(1986, 1, 1));

p1.Pets.Add(new Dog("Fred"));
p1.Pets.Add(new Dog("Barney"));

p2.Pets.Add(new Cat("Beyonce"));

List<Person> people = [p1, p2];
foreach (var person in people)
{
    Console.WriteLine($"{person}");

    foreach (var pet in person.Pets)
    {
        Console.WriteLine($"      {pet}");
    }
}

public class Person(string firstName, string lastName, DateOnly birthday)
{
    public string First { get; } = firstName;
    public string Last { get; } = lastName;
    public DateOnly Birthday { get; } = birthday;

    public List<Pet> Pets { get; } = new();
    public override string ToString()
    {
        return $"Human {First} {Last}";
    }
}

public abstract class Pet(string firstName)
{
    public string First { get; } = firstName;
    public abstract string MakeNoise();

    public override string ToString()
    {
        return $"{First} and I am a {GetType().Name} and I {MakeNoise()}";
    }
}

public class Cat(string firstName) : Pet(firstName)
{
    public override string MakeNoise() => "meow";
}

public class Dog(string firstName) : Pet(firstName)
{
    public override string MakeNoise() => "bark";
}