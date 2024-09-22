var names = new string[] { "Plemno", "Ana", "Felipe" };
// names.Add("Damian") // LIST<T>
names = [..names, "Damian"];

foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

