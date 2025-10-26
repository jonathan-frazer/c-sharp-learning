var p1 = new Person(
    "Arjun", "R.", new DateOnly(2001, 10, 10)
);
var p2 = new Person(
    "Jeshurun", "Christopher", new DateOnly(2004, 8, 7)
);
var p3 = new Person(
    "Shavez", "Umar", new DateOnly(2004, 9, 30)
);

p2.pets.Add(new Dog("Jello"));
p2.pets.Add(new Dog("Bella"));
p3.pets.Add(new Cat("Sprinkles"));

Person[] people = [p1, p2, p3];
foreach (var p in people)
{
    Console.WriteLine(p);
}

public class Person(string first, string last, DateOnly bd)
{
    public string lastName { get; } = last;
    public string firstName { get; } = first;
    public DateOnly birthday { get; } = bd;
    public List<Pet> pets { get; } = new List<Pet>();

    public override string ToString()
    {
        return $"{firstName} {lastName} was born on {birthday}\n\t{string.Join("\n\t", pets.Select(pet => $"{pet.First} says {pet.MakeNoise()}"))}";
    }
}

public abstract class Pet(string firstName)
{
    public string First { get; } = firstName;
    public abstract string MakeNoise();
}

public class Cat(string firstName) : Pet(firstName)
{
    public override string MakeNoise() => "Meow";
}
public class Dog(string firstName) : Pet(firstName)
{
    public override string MakeNoise() => "Woof";
}