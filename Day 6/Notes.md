# Lesson 18: Introduction to Object Oriented Programming

\*So far C# can work without any structure. But C# is fundamentally Object Oriented.<br>
\*This is how the original Hello World program is run.

```
using System;
namespace MyNamespace
{
    public class MyApp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

\*Let's create a class of our own.

```
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
```

OUTPUT:-

```
Kaio Kincade was born on 14-06-2105
```

\*That's just for basic public members. Now what if we wanted private members. That's where we would have to deal with making Constructors

```
var p = new Person(
    "Kaio",
    "Kincade",
    new DateOnly(2105, 6, 14)
);

public class Person
{
    public Person(string first, string last, DateOnly bd)
    {
        firstName = first;
        lastName = last;
        birthday = bd;
    }

    private string lastName;
    private string firstName;
    private DateOnly birthday;
}
```

\*The variables are in now, but we can't access them now. So here we'd normally make Getters and setters. And we'll get to that but first it's best if we deal with `Primary Constructors` first

```
var p = new Person(
    "Kaio",
    "Kincade",
    new DateOnly(2105, 6, 14)
);

public class Person(string first, string last, DateOnly bd)
{
    private string lastName = last;
    private string firstName = first;
    private DateOnly birthday = bd;
}
```

\*It let's you pass your Constructor Arguments in the Class definition itself.
This lets you keep a primary constructor. And you can make a secondary constructor later. Another example of C#'s Syntactic sugar.

\*Now we look at properties. So this is where `get` and `set` comes in

```
var p = new Person(
    "Kaio",
    "Kincade",
    new DateOnly(2105, 6, 14)
);

Console.WriteLine($"{p.firstName} {p.lastName} was born on {p.birthday}");

public class Person(string first, string last, DateOnly bd)
{
    public string lastName { get; } = last;
    public string firstName { get; } = first;
    public DateOnly birthday { get; } = bd;
}
```

\*It's important to know that the variables here should be public otherwise it won't be exposed to the outside. What's private generally should stay in the class. Tbh I prefer this style WAYY better

\*OUTPUT:-<br>

```
Kaio Kincade was born on 14-06-2105
```

\*The last thing before we go is that you can make lists/Arrays of classes. And even iterate through them

```
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
```

\*OUTPUT:-<br>

```
Kaio Kincade was born on 14-06-2105
Tsuyu Kincade was born on 10-02-2105
```

\*NOTE: The `this` keyword, does exist here. I was worried about that too lol

# Lesson 19: Object Oriented Programming Advanced

## Abstract Classes

\* Classes can extend one another with the `:` syntax

\* An Abstract class must be defined, just like with another abstact method

\* Overriding methods must be explicit with the `override` keyword in the method.

```
public abstract class Pet(string firstName){
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
```

\*We can attach it to our previous example to get the following output:-

```
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
    Console.WriteLine($"{p.firstName} {p.lastName} was born on {p.birthday}");
    foreach (var pet in p.pets)
    {
        Console.WriteLine($"\t{pet.First} says {pet.MakeNoise()}");
    }
}

public class Person(string first, string last, DateOnly bd)
{
    public string lastName { get; } = last;
    public string firstName { get; } = first;
    public DateOnly birthday { get; } = bd;
    public List<Pet> pets { get; } = new List<Pet>();
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
```

OUTPUT:-

```
Arjun R. was born on 10-10-2001
Jeshurun Christopher was born on 07-08-2004
        Jello says Woof
        Bella says Woof
Shavez Umar was born on 30-09-2004
        Sprinkles says Meow
```

\*And of course, you can also use the .ToString() method

```
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
```

OUTPUT:-

```
Arjun R. was born on 10-10-2001

Jeshurun Christopher was born on 07-08-2004
        Jello says Woof
        Bella says Woof
Shavez Umar was born on 30-09-2004
        Sprinkles says Meow
```

\*As you can see, I made use of LINQ too in the .ToString() method. I think I did a good job of it

\*One thing to notice is that when making classes. You can use the `?` to make members Nullable

```
public class PersonExample
{
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    public DateOnly? birthday { get; set; }
}
```
