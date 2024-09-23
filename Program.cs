// Specify the data source.
List<int> scores = [3, 45, 82, 97, 92, 100, 81, 60];

// Define the query expression.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending
    select score;

var scoreQuery2 = scores
    .Where(s => s > 80)
    .OrderByDescending(s => s);

List<int> myScores = scoreQuery.ToList();
foreach (var score in myScores)
{
    Console.WriteLine(score);
}

// 97 92 81