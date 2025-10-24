//var - Local Variable Type Inferece
var names = new List<string> { "Aeon", "Tsuyu", "Kaio", "Ikari" };
foreach (var name in names)
    Console.WriteLine(name);

/*
Aeon
Tsuyu
Kaio
Ikari
*/

Console.WriteLine("\n");
//------------------------------------------------------------------//

//Mutable
names.Insert(2, "Izayoi");
foreach (var name in names)
    Console.WriteLine(name);
/*
Aeon
Tsuyu
Izayoi
Kaio
Ikari
*/

Console.WriteLine("\n");
//------------------------------------------------------------------//

//Indexing
Console.WriteLine("First: " + names[0]);
Console.WriteLine("Second: " + names[1]);
Console.WriteLine("Last: " + names[^1]);
Console.WriteLine("Third Last: " + names[^3]);
/*
First: Aeon
Second: Tsuyu
Last: Ikari
Third Last: Izayoi
*/

Console.WriteLine("\n");
//------------------------------------------------------------------//

//Ranges
foreach (var name in (names[1..4]))
    Console.WriteLine(name);
/*
Tsuyu
Izayoi
Kaio
*/

Console.WriteLine("\n");
//------------------------------------------------------------------//

//ARRAY
var array = new string[] { "Aeon", "Tsuyu", "Kaio", "Ikari" };
foreach (var name in array)
    Console.WriteLine(name);
/*
Aeon
Tsuyu
Kaio
Ikari
*/
Console.WriteLine("\n");
//------------------------------------------------------------------//

//ARRAY Cloning
array = [.. array, "Izayoi"];
foreach (var name in array)
    Console.WriteLine(name);
/*
Aeon
Tsuyu
Kaio
Ikari
Izayoi
*/
Console.WriteLine("\n");
//------------------------------------------------------------------//

//Sorting Lists-Strings
names.Sort();
foreach (var name in names)
    Console.WriteLine($"Hello {name}");

/*
Hello Aeon
Hello Ikari
Hello Izayoi
Hello Kaio
Hello Tsuyu
*/