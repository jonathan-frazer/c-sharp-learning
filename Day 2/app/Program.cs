int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

a = 2100000000;
b = 2100000000;
c = a + b;
Console.WriteLine(c);

Console.WriteLine($"Max value of int: {int.MaxValue}");
Console.WriteLine($"Max value of long: {long.MaxValue}");
Console.WriteLine($"Max value of float: {float.MaxValue}");
Console.WriteLine($"Max value of double: {double.MaxValue}");
Console.WriteLine($"Max value of decimal: {decimal.MaxValue}");


a = 2100000000;
b = 2100000000;
long longC = checked(a + b);
Console.WriteLine(longC);
/*
Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
   at Program.<Main>$(String[] args) in C:\Users\My PC\OneDrive\Desktop\Programming\C#\Day 2\app\Program.cs:line 20  
*/