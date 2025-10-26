var p1 = new Person(
    "Kaio",
    "Kincade",
    new DateOnly(2105, 6, 14)
);

var p2 = new Person(
    "Tsuyu",
    "Kincade",
    new DateOnly(2105, 2, 10)
);

foreach (var p in new Person[] { p1, p2 })
    Console.WriteLine($"{p.firstName} {p.lastName} was born on {p.birthday}");

public class Person(string first, string last, DateOnly bd)
{
    public string lastName { get; } = last;
    public string firstName { get; } = first;
    public DateOnly birthday { get; } = bd;
}

