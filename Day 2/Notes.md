# LESSON 7-8: Numbers Integers and Math

A signed 32-bit integer, ranging from -2,147,483,648 to 2,147,483,647. This is the most commonly used integer type in C#

```
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c); //-> 24
```

Here are the main integer data types in C#:
\*sbyte: A signed 8-bit integer, ranging from -128 to 127.
\*byte: An unsigned 8-bit integer, ranging from 0 to 255.
\*short: A signed 16-bit integer, ranging from -32,768 to 32,767.
\*ushort: An unsigned 16-bit integer, ranging from 0 to 65,535.
\*int: A signed 32-bit integer, ranging from -2,147,483,648 to 2,147,483,647. This is the most commonly used integer type in C#.
\*uint: An unsigned 32-bit integer, ranging from 0 to 4,294,967,295.
\*long: A signed 64-bit integer, ranging from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807. Used for very large integer values.
\*decimal: In C#, decimal is a 128-bit floating-point data type designed for financial and monetary calculations where high precision and accuracy are paramount
\*ulong: An unsigned 64-bit integer, ranging from 0 to 18,446,744,073,709,551,615. Used for even larger non-negative integer values.
\*nint and nuint: These are platform-dependent integer types introduced in C# 9.0. Their size (32-bit or 64-bit) depends on the architecture of the machine running the code. nint is signed, and nuint is unsigned.

\*Numbers overflow into the negative values

```
int a = 2100000000;
int b = 2100000000;
int c = a + b;
Console.WriteLine(c); //-> -94967296
```

\*You can get the max value from it like so

```
Console.WriteLine($"Max value of int: {int.MaxValue}"); //2147483647
Console.WriteLine($"Max value of long: {long.MaxValue}"); //9223372036854775807
Console.WriteLine($"Max value of float: {float.MaxValue}"); //3.4028235E+38
Console.WriteLine($"Max value of double: {double.MaxValue}"); //1.7976931348623157E+308
Console.WriteLine($"Max value of decimal: {decimal.MaxValue}"); //79228162514264337593543950335
```

### Typcasting

```
int a = 2100000000;
int b = 2100000000;
long c = (long)a + (long)b;
Console.WriteLine(c);
```

While Java and C# both support typecasting to convert a value from one data type to another, there are some key differences in their implementation and features:

1. Unified Type System:
   \*C#: C# has a unified type system where all types, including primitive types (like int, float), ultimately derive from System.Object. This means that primitive types can be treated as objects, allowing for consistent behavior and the use of methods defined on Object.
   \*Java: Java distinguishes between primitive types and reference types (objects). Primitive types are not objects and do not inherit from a common root type. This can lead to situations where boxing and unboxing are required to convert between primitive types and their corresponding wrapper classes (e.g., int to Integer).

2. Safe Casting Operators:
   \*C#: C# provides the `as` operator and the `is` operator for safe casting.
   The `as` operator attempts a cast and returns null if the conversion fails, rather than throwing an InvalidCastException.
   The `is` operator checks if an object is compatible with a given type and returns a boolean, allowing for conditional casting.
   \*Java: Java's casting mechanism directly throws an InvalidCastException if a cast is unsuccessful. Developers typically use instanceof to check type compatibility before performing a cast to avoid runtime errors.
3. Explicit vs. Implicit Conversions:
   Both languages support implicit (automatic) and explicit (manual) type conversions.
   \*Implicit conversions: occur when there is no loss of data or precision (e.g., int to long).
   \*Explicit conversions: (casting) are required when there is a potential for data loss or when converting between incompatible types.
4. Boxing and Unboxing (Java Specific):
   \*Java: Due to the distinction between primitive types and objects, Java uses boxing to convert a primitive type to its corresponding wrapper class object, and unboxing to convert a wrapper class object back to a primitive type. This process adds overhead and is a feature unique to Java's type system in this context. C# handles this more seamlessly due to its unified type system.

\*In C#, checked is a keyword used to explicitly enable overflow checking for integral-type arithmetic operations and conversions within a specific code block or expression.

```
a = 2100000000;
b = 2100000000;
long longC = checked(a + b);
Console.WriteLine(longC);
/*
Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
   at Program.<Main>$(String[] args) in C:\Users\My PC\OneDrive\Desktop\Programming\C#\Day 2\app\Program.cs:line 20
*/
```

Will throw an error instead of printing .

\*M in C# means decimal, just like F meant float in Java

```
decimal age = 13M;
float weight = 24.4F;
```
