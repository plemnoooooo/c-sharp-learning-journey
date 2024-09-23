// Specify the data source.
List<int> scores = [3, 45, 82, 97, 92, 100, 81, 60];

// Define the query expression.
IEnumerable<string> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending
    select $" The score is {score}";

Console.WriteLine(scoreQuery.Count());

// Execute the query.
foreach (string s in scoreQuery)
{
    Console.WriteLine(s);
}

// Output: 97 92 81 