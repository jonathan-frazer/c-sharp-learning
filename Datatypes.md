# DataTypes in C#

C# data types are categorized into three main types: Value Types, Reference Types, and Pointer Types.

1. ## Value Types:
   These types store the actual data directly within their memory location.

### Integral Types:-

\*sbyte: 8-bit signed integer (-128 to 127)

\*byte: 8-bit unsigned integer (0 to 255)

\*short: 16-bit signed integer (-32,768 to 32,767)

\*ushort: 16-bit unsigned integer (0 to 65,535)

\*int: 32-bit signed integer (-2,147,483,648 to 2,147,483,647)

\*uint: 32-bit unsigned integer (0 to 4,294,967,295)

\*long: 64-bit signed integer (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)

\*ulong: 64-bit unsigned integer (0 to 18,446,744,073,709,551,615)

### Floating-Point Types:

\*float: 32-bit single-precision floating-point number

\*double: 64-bit double-precision floating-point number

\*decimal: 128-bit decimal type (high precision for financial calculations)

### Character Type:

\*char: 16-bit Unicode character

### Boolean Type:

\*bool: Represents a logical value (true or false)

### User-Defined Value Types:

\*struct: Custom value types defined by the user

\*enum: Enumerated types, a set of named integral constants

2. ## Reference Types:
   These types store a reference (memory address) to the actual data, which is stored elsewhere in memory (on the heap). [1]

### Built-in Reference Types:

\*object: The ultimate base class for all other types in C#

\*string: Represents a sequence of Unicode characters

\*dynamic: Allows for operations that bypass compile-time type checking

### User-Defined Reference Types:

\*class: Custom reference types defined by the user

\*interface: Defines a contract that classes or structs can implement

\*delegate: Represents a reference to a method

\*array: Stores a fixed-size sequential collection of elements of the same type

3. ## Pointer Types:
   These types are used in unsafe code blocks and store memory addresses. They are less commonly used in typical C# applications due to safety concerns and the availability of safer alternatives.

\*Type*: A pointer to a variable of a specific Type (e.g., int*, char\*).

This comprehensive list covers the various data types available in C#.
