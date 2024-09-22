var names = new List<string> { "Plemno", "Ana", "Felipe" };
names.Add("David");
names.Add("Damian");
names.Add("Maria");

foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}