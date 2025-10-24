# Extra Lesson: Tuples and Types

\*Tuples are an ordered sequence of values with a fixed length. Each element of a tuple has a type and an optional name. The following code declares a tuple that represents a 2D point.

```
var pt = (X: 1, Y: 2);

var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");
```

\*You can reassign any member of a tuple.

```
pt.X = pt.X + 5;
Console.WriteLine($"The point is now at {pt}.");
```

\*You can also create a new tuple that's a modified copy of the original using a `with` expression.

```
var pt2 = pt with { Y = 10 };
Console.WriteLine($"The point 'pt2' is at {pt2}.");
```

\*You can assign a tuple to a tuple with the same arity and types even if the members have different names.

```
var subscript = (A: 0, B: 0);
subscript = pt;
Console.WriteLine(subscript);
```

# LESSON 9: Ifs and Conditional Logic

\* In C#, the if structure is a fundamental control flow statement used to execute a block of code conditionally based on the evaluation of a Boolean expression.

\*You have to use brackets similar to Java for the Operator precedence

\*Basic if Statement:
The simplest form of the if statement executes a block of code only if a specified condition is true.

```
if (condition)
{
    // Code to execute if the condition is true
}
```

\*condition: This is a Boolean expression that evaluates to either true or false.

\*Code Block: The code enclosed within the curly braces {} is executed if condition is true. If condition is false, this block is skipped.

\*if-else Statement:
The if-else statement provides an alternative block of code to execute if the if condition is false.

```
if (condition)
{
    // Code to execute if the condition is true
}
else
{
    // Code to execute if the condition is false
}
```

\*If condition is true, the code in the if block is executed.

\*If condition is false, the code in the else block is executed.

if-else if-else Statement:
This structure allows for checking multiple conditions sequentially.

```
if (condition1)
{
    // Code to execute if condition1 is true
}
else if (condition2)
{
    // Code to execute if condition1 is false AND condition2 is true
}
else
{
    // Code to execute if all preceding conditions are false
}
```

\*Conditions are evaluated in order. The first if or else if block whose condition evaluates to true is executed, and subsequent else if and else blocks are skipped.

\*The else block at the end is optional and acts as a fallback if none of the preceding if or else if conditions are met.

Nested if Statements:
if statements can be nested within other if, else if, or else blocks to handle more complex decision-making scenarios.

```
if (outerCondition)
{
    if (innerCondition)
    {
        // Code to execute if both outerCondition and innerCondition are true
    }
    else
    {
        // Code to execute if outerCondition is true and innerCondition is false
    }
}
else
{
    // Code to execute if outerCondition is false
}
```

Key Points:

\*The condition within an if statement must always be a Boolean expression.

\*Curly braces {} are required for code blocks containing multiple statements. For a single statement, they are optional but recommended for clarity and consistency.

\*Conditional operators like && (logical AND) and || (logical OR) can be used to combine multiple conditions within a single if statement.

# LESSON 10-11: Loops

\*While Loop: The while loop repeatedly executes a block of code as long as a specified condition remains true. The condition is checked before each execution of the loop body.

```
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
```

\*Do-While Loop: The do-while loop also repeats a block of code based on a condition. However, the key difference is that the condition is checked after the loop body has executed at least once. This ensures the loop body always runs at least one time.

```
int counter = 0;
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
```

\*For Loop: Ideal when the number of iterations is known beforehand. It consists of three parts: initialization, condition, and iterator

```
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
```

\*C# Does support the postfix and prefix operators.

## Operator Precedence

Operator precedence in C# defines the order in which operators in an expression are evaluated. Operators with higher precedence are evaluated before operators with lower precedence.

### General Precedence Rules:

\*Parentheses: Expressions enclosed in parentheses () are evaluated first, regardless of the operators within them. This allows overriding default precedence.

\*Unary Operators: Unary operators (like ++, --, +, -, !, ~) have higher precedence than most binary operators.

\*Multiplicative Operators: Multiplication \_, division /, and modulo % have higher precedence than additive operators.

\*Additive Operators: Addition + and subtraction - have lower precedence than multiplicative operators.

\*Shift Operators: Left shift &lt;&lt; and right shift &gt;&gt; have lower precedence than additive operators.

\*Relational and Type Operators: Less than &lt;, less than or equal to &lt;=, greater than &gt;, greater than or equal to &gt;=, is, as, and typeof have lower precedence than shift operators.

\*Equality Operators: Equal to == and not equal to != have lower precedence than relational operators.

\*Bitwise Operators: Bitwise AND &, XOR ^, and OR | follow equality operators.

\*Logical Operators: Logical AND && and logical OR || follow bitwise operators.

\*Conditional (Ternary) Operator: The conditional operator ? : has lower precedence than logical operators.

\*Assignment Operators: Assignment operators (=, +=, -=, \_=, /=, etc.) have the lowest precedence.

### Associativity:

When multiple operators of the same precedence appear in an expression, their associativity determines the order of evaluation. Most C# operators are left-associative, meaning they are evaluated from left to right. Assignment operators are right-associative.
Example:
int result = 4 + 3 _ 5; // Multiplication (3 _ 5) is performed first, then addition. result will be 19.
int anotherResult = (4 + 3) \* 5; // Parentheses force addition (4 + 3) first, then multiplication. anotherResult will be 35.
