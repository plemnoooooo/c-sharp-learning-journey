var numbers = new List<int> { 45, 56, 99, 48, 67, 78 };
Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}");

numbers.Sort();
Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}");

// foreach (var number in numbers)
// {
//     Console.WriteLine($"{number}");
// }
