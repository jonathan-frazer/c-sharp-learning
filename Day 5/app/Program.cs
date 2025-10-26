//LINQ - Language Integrated Query
int[] scores = [97, 92, 81, 60];

//Instead of a for loop We use a query
IEnumerable<int> scoreQuery = from score in scores where score > 80 select score;

//This returns an IEnumerable which can be For-Eached
foreach (int score in scoreQuery)
    Console.Write($"{score} ,");
/*97 ,92 ,81 ,*/

Console.WriteLine("\n");
//------------------------------------------------------------------//

//Use of Order By
int[] scores2 = [6, 8, 11, 33, 34];
IEnumerable<int> scoreOrderQuery = from score in scores2 where score > 10 orderby score descending select score;
foreach (int score in scoreOrderQuery)
    Console.Write($"{score},");
/*34,33,11,*/


Console.WriteLine("\n" + scoreOrderQuery.Count()); //3


Console.WriteLine("\n");
//------------------------------------------------------------------//

//Using Method Syntax
int[] scores3 = [50, 35, 40, 21, 32, 92, 111];
var scoreMethodQuery = scores3.Where(s => s > 35).OrderBy(s => s).Select(s => s * 2);
foreach (int score in scoreMethodQuery)
    Console.WriteLine(score);