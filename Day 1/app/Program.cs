//Basic Strings
string friend1 = "Shino";
string friend2 = "Hayato";
Console.WriteLine($"{friend1}: {friend1.Length}");
Console.WriteLine($"{friend2}: {friend2.Length}");
Console.WriteLine($"[DOllar]Hi, I'm Kaio. These are my friends {friend1} and {friend2}");
Console.WriteLine("[Concat]Hi, I'm Kaio. These are my friends " + friend2 + " and " + friend1);

//Contains
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
Console.WriteLine("numbers: " + string.Join(", ", numbers));
Console.WriteLine("'numbers' Contains 3: " + numbers.Contains(3)); // true
Console.WriteLine("'numbers' Contains 6: " + numbers.Contains(6) + "\n"); // false

string[] fruits = { "apple", "banana", "orange" };
Console.WriteLine("fruits: " + string.Join(", ", fruits));
Console.WriteLine("'fruits' Contains banana: " + fruits.Contains("banana") + "\n"); // true

//Case Functions
string sayHello = "Hello World!";
Console.WriteLine("Lowercase:" + sayHello.ToLower()); //-> "hello world!"
Console.WriteLine("Uppercase:" + sayHello.ToUpper()); //-> "HELLO WORLD!"

string mainString = "Hello World!";
Console.WriteLine("\nIgnore Case Search: " + mainString.Contains("hello", StringComparison.OrdinalIgnoreCase)); //true
