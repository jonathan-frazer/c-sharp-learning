# LESSON 1: Start Project

C# is a Strongly Type Compiled Language, which means it compiles the whole project and then runs

## dotnet new

The 'dotnet new' command creates a .NET project based on a template.

Common templates are:
Template Name Short Name Language Tags

---

Blazor Web App blazor [C#] Web/Blazor/WebAssembly
Class Library classlib [C#],F#,VB Common/Library
Console App console [C#],F#,VB Common/Console
Windows Forms App winforms [C#],VB Common/WinForms
WPF Application wpf [C#],VB Common/WPF

An example would be:
dotnet new console

Display template options with:
dotnet new console -h
Display all installed templates with:
dotnet new list
Display templates available on NuGet.org with:
dotnet new search web

Here we run a simple console application with
`dotnet new console -o app`
To create an "Console Application" within a new folder App

# LESSON 2: Environment Setup

\*They download the C# Dev Kit
\*In the Dev kit there will be a `Solution Explorer` to give a logical view of the place
\*They also showcase how the Debug Mode is run
\*You can also do the following:-

> Ctrl + F5 for run
> F5 for Debug mode

# LESSON 3: Learning Links

\*They provide a link for `dot.net`. Then scroll down to the learning portal,
And you can learn about all the different frameworks and things you can do
That has all the documentation and all that important stuff
\*It has the spec and what words are allowed and not allowed

\*Then they teach about basic strings

```
string friend1 = "Shino";
string friend2 = "Hayato";
Console.WriteLine($"Hi, I'm Kaio. These are my friends {friend1} and {friend2}");
```

# LESSON 4: Strings

\*strings are depicted in Double Quotes.
\*strings in C# are immutable. This means that once a string object is created, its content cannot be changed.
\*strings in C# are objects. They are instances of the System.String class, which is a reference type.
\*strings support concatenation with the + operator meaning you can also do

```
Console.WriteLine("[Concat]Hi, I'm Kaio. These are my friends " + friend2 + " and " + friend1);
```

### Now we explore Strings and Their methods in C#

\*.Length() Method
Returns the no. of characters in a string

```
string message = "Hello World!";
int stringLength = message.Length; // stringLength will be 12
Console.WriteLine($"The string has {stringLength} characters.");
```

\*.StartsWith() Method
Same as in Java and Python

```
string myString = "Hello World";
bool startsWithHello = myString.StartsWith("Hello"); // returns true
bool startsWithHi = myString.StartsWith("Hi");     // returns false
```

\*.EndsWith() Method
Same as in Java and Python

```
string myString = "Hello World";
bool endsWithWorld = myString.EndsWith("World"); // returns true
bool endsWithMars = myString.EndsWith("Mars");   // returns false
```

\*.Trim() Method
Allows you to trim spaces from a string

```
string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");
```

\* .Replace() Method
Replaces a given string with another string

```
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);
```

\* .ToLower()/.ToUpper() Method
Converts the String into all Upper/Lower case

```
string sayHello = "Hello World!";
Console.WriteLine(sayHello.ToLower()); //-> "hello world!"
Console.WriteLine(sayHello.ToUpper()); //-> "HELLO WORLD!"
```

\* .Contains()

In basic mode it searches for a substring

```
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));
```

You can have an additional argument to ignore case(Very important),

```
string mainString = "Hello World!";
Console.WriteLine("\nIgnore Case Search: " + mainString.Contains("hello", StringComparison.OrdinalIgnoreCase)); //true
```

Taking a more complex example we can even use it in a List Object

```
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
Console.WriteLine("numbers: " + string.Join(", ", numbers));
Console.WriteLine("'numbers' Contains 3: " + numbers.Contains(3)); // true
Console.WriteLine("'numbers' Contains 6: " + numbers.Contains(6) + "\n"); // false

string[] fruits = { "apple", "banana", "orange" };
Console.WriteLine("fruits: " + string.Join(", ", fruits));
Console.WriteLine("'fruits' Contains banana: " + fruits.Contains("banana") + "\n"); // true
```

\*For String.Contains(), it typically uses an internal mechanism similar to IndexOf(). If the substring is found, IndexOf() returns a non-negative index, and Contains() returns true. Otherwise, IndexOf() returns -1, and Contains() returns false.
\*For collections, Contains() generally iterates through the elements and compares each element with the target item using equality comparison (e.g)

OUTPUT:-

```
numbers: 1, 2, 3, 4, 5
'numbers' Contains 3: True
'numbers' Contains 6: False

fruits: apple, banana, orange
'fruits' Contains banana: True
```
