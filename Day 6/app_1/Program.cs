var p = new Person()
{
    firstName = "Kaio",
    lastName = "Kincade",
    birthday = new DateOnly(2105, 6, 14)
};

Console.WriteLine($"{p.firstName} {p.lastName} was born on {p.birthday}");

public class Person
{

    public string lastName;
    public string firstName;
    public DateOnly birthday;
}

