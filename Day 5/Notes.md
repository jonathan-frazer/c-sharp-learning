# Lesson 15: LINQ - Language Integrated Query

\* LINQ lets you get your data in the form of a QUERY instead of a for-loop

```
//LINQ -
int[] scores = [97, 92, 81, 60];

//Instead of a for loop We use a query
IEnumerable<int> scoreQuery = from score in scores where score > 80 select score;

//This returns an IEnumerable which can be For-Eached
foreach (int score in scoreQuery)
    Console.Write($"{score} ,");
/*97 ,92 ,81 ,*/
```

\*The IEnumerable type is returned from the Language Integrated Query. And is naturally supported by the C# Compiler.

\*The Query itself is said to have the `Question` not the `Answer`. This type of execution is called `Deferred Execution`. And it saves a good amount of memory.

\*IEnumerable's can be made into lists pretty easily like so, Kinda like Python's generators.

```
List<int> scoreList = scoreQuery.ToList();
```

\*One thing to note is that this is CASE-Sensitive. So you have to keep all the Keywords in lowercase. For Basic Queries

```
from <var name> in <iterable> where <condition> select <value>
```

\*It kinda reminds me of List Comprehensions

# Lesson 16: LINQ Query Expressions

\* Orderby is allowed in LINQ. So you can do sorts just like in SQL

```
int[] scores2 = [6, 8, 11, 33, 34];
IEnumerable<int> scoreOrderQuery = from score in scores2 where score > 10 orderby score descending select score;
foreach (int score in scoreOrderQuery)
    Console.Write($"{score},");
/*34,33,11,*/
```

```
Console.WriteLine("\n" + scoreOrderQuery.Count());
/* 3 */
```

\* It's important to note all the methods in the IEnumerable Methods

\*The IEnumerable interface in C# defines a single method:
IEnumerator GetEnumerator();

\*This method returns an IEnumerator object, which is responsible for iterating through the elements of the collection. The IEnumerator interface, in turn, defines the following members:

• Current property: Gets the current element in the iteration. <br>
• MoveNext() method: Advances the enumerator to the next element of the collection. It returns true if the enumerator was successfully advanced to the next element, false if the enumerator has passed the end of the collection. <br>
• Reset() method: Sets the enumerator to its initial position, which is before the first element in the collection. <br>

While IEnumerable itself only exposes GetEnumerator(), the System.Linq.Enumerable class provides a rich set of extension methods that operate on IEnumerable objects. These methods enable powerful query operations and are commonly used with LINQ. Some examples include:

• Filtering: Where() <br>
• Projection: Select() <br>
• Ordering: OrderBy(), OrderByDescending() <br>
• Grouping: GroupBy() <br>
• Aggregation: Sum(), Average(), Count(), Min(), Max() <br>
• Element operations: FirstOrDefault(), LastOrDefault(), ElementAt() <br>
• Set operations: Distinct(), Union(), Intersect() <br>

These Enumerable extension methods are not part of the IEnumerable interface itself but are widely used with any type that implements IEnumerable.

# Lesson 17: LINQ Method Syntax

\*Method syntax is another way to use LINQ

```
int[] scores3 = [50, 35, 40, 21, 32, 92, 111];
var scoreMethodQuery = scores3.Where(s => s > 35).OrderBy(s => s).Select(s => s * 2);
foreach (int score in scoreMethodQuery)
    Console.WriteLine(score);
```

\*It's important to keep in Mind LINQ doesn't affect the underlying datastructure.

\*For More info on LINQ's you can look here:-<br>
`https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/working-with-linq`
