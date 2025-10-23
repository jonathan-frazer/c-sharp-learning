//Tuples
var pt = (X: 1, Y: 2);

var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");

//Inplace modification
pt.X = pt.X + 5;
Console.WriteLine($"The point is now at {pt}.");

//modified copy of the original using a with expression.
var pt2 = pt with { Y = 10 };
Console.WriteLine($"The point 'pt2' is at {pt2}.");

var subscript = (A: 0, B: 0);
subscript = pt;
Console.WriteLine(subscript);

/*
A line from the origin to the point (1, 2) has a slope of 2.
The point is now at (6, 2).
The point 'pt2' is at (6, 10).
(6, 2)
*/

Console.WriteLine("\n");
//---------------------------------------------------------------//
//If-Else
int a = 5;
int b = 3;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10");
else
    Console.WriteLine("The answer is not greater than 10");

/*
The answer is not greater than 10
*/

a = 5;
b = 3;
int c = 4;
if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}
/*
The answer is not greater than 10
Or the first number is not equal to the second
*/

Console.WriteLine("\n");
//---------------------------------------------------------------//
//While Loop
int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
}
/*
Hello World! The counter is 0
Hello World! The counter is 1
Hello World! The counter is 2
Hello World! The counter is 3
Hello World! The counter is 4
Hello World! The counter is 5
Hello World! The counter is 6
Hello World! The counter is 7
Hello World! The counter is 8
Hello World! The counter is 9
*/

Console.WriteLine("\n");
//---------------------------------------------------------------//
//Do While Loop
counter = 0;
do
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
} while (counter < 10);
/*
Hello World! The counter is 0
Hello World! The counter is 1
Hello World! The counter is 2
Hello World! The counter is 3
Hello World! The counter is 4
Hello World! The counter is 5
Hello World! The counter is 6
Hello World! The counter is 7
Hello World! The counter is 8
Hello World! The counter is 9
*/

Console.WriteLine("\n");
//---------------------------------------------------------------//
//For Loop
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello World! The counter is {i}");
}
/*
Hello World! The counter is 0
Hello World! The counter is 1
Hello World! The counter is 2
Hello World! The counter is 3
Hello World! The counter is 4
Hello World! The counter is 5
Hello World! The counter is 6
Hello World! The counter is 7
Hello World! The counter is 8
Hello World! The counter is 9
*/