# Lesson 12: List<T> and Collections of Data

\*Similar to Java, C# has a method for lists too.

\*We use `var` for Local variable type inference. Where we can use it whenever the type is implicit. Try avoiding using it too much. It's fine for lists though

\*Lists are iterated using the `foreach` loop in C#. In Here it's Syntax is a mix of Java and Python. The following is an example of the list

```
var names = new List<string> { "Aeon", "Tsuyu", "Kaio", "Ikari" };
foreach (var name in names)
    Console.WriteLine(name);

/*
Aeon
Tsuyu
Kaio
Ikari
*/
```

\*Lists are Mutable, and can be changed. This can be done via it's methods.

```
var names = new List<string> { "Aeon", "Tsuyu", "Kaio", "Ikari" };
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
```

## List Methods

The List<T> class in C# provides numerous methods for manipulating collections of data. These methods can be broadly categorized by their function:

### Adding and Inserting Elements:

\* `Add(T item)`: Adds an object to the end of the List<T>.

\* `AddRange(IEnumerable<T> collection)`: Adds the elements of a specified collection to the end of the List<T>.

\* `Insert(Int32 index, T item)`: Inserts an element into the List<T> at the specified index.

\* `InsertRange(Int32 index, IEnumerable<T> collection)`: Inserts the elements of a collection into the List<T> at the specified index. [1]

### Removing Elements:

\* `Clear()`: Removes all elements from the List<T>.

\* `Remove(T item)`: Removes the first occurrence of a specific object from the List<T>.

\* `RemoveAt(Int32 index)`: Removes the element at the specified index of the List<T>.

\* `RemoveAll(Predicate<T> match)`: Removes all elements that match the conditions defined by the specified predicate.

### Searching and Finding Elements:

\* `BinarySearch(T item)`: Searches for an element in a sorted List<T> using the default comparer. Overloads exist for custom comparers and ranges.

\* `Contains(T item)`: Determines whether an element is in the List<T>.

\* `Exists(Predicate<T> match)`: Determines whether an element matching the conditions defined by the specified predicate exists in the List<T>.

\* `Find(Predicate<T> match)`: Searches for an element that matches the conditions defined by the specified predicate and returns the first occurrence.

\* `FindAll`(Predicate<T> match)`: Retrieves all the elements that match the conditions defined by the specified predicate.

\* `FindIndex(Predicate<T> match)`: Searches for an element that matches the conditions defined by the specified predicate and returns the zero-based index of the first occurrence. Overloads exist for starting index and count.

\* `IndexOf(T item)`: Searches for the specified object and returns the zero-based index of the first occurrence within the entire List<T>. Overloads exist for starting index and count.

\* `LastIndexOf(T item)`: Searches for the specified object and returns the zero-based index of the last occurrence within the entire List<T>. Overloads exist for starting index and count.

### Sorting and Reordering:

\* `Reverse()`: Reverses the order of the elements in the entire List<T>. Overloads exist for reversing a range.

\* `Sort()`: Sorts the elements in the entire List<T> using the default comparer. Overloads exist for custom comparers and ranges.

### Other Operations:

\* `AsReadOnly()`: Returns a read-only ReadOnlyCollection<T> wrapper for the current List<T>.

\* `ConvertAll<TOutput>(Converter<T, TOutput> converter)`: Converts the elements of the current List<T> to another type, and returns a list containing the converted elements.

\* `CopyTo(T[] array, Int32 arrayIndex)`: Copies the entire List<T> to a compatible one-dimensional array, starting at the specified index of the target array. Overloads exist for copying a range.

\* `EnsureCapacity(Int32 capacity)`: Ensures that the capacity of the list is at least the specified capacity.

\* `ForEach(Action<T> action)`: Performs the specified action on each element of the List<T>. [1]

\* `GetRange(Int32 index, Int32 count)`: Returns a shallow copy of a range of elements in the source List<T>.

\* `ToArray`():`Copies the elements of the List<T> to a new array.

\*`TrimExcess()`: Sets the capacity to the actual number of elements in the List<T>, if that number is less than a threshold percentage of current capacity.

\* `TrueForAll(Predicate<T> match)`: Determines whether every element in the List<T> matches the conditions defined by the specified predicate.

# Lesson 13: Arrays, Lists, Indexing, and Foreach

## Indexing:

\*Lists in C# can be Indexed with the `[]`, They don't need to use the .get() method like they do in Java.

\*They even support negative indexing by means of the `^` operator.

```
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
```

\*Lists can even be made into ranges like they do in Python

```
foreach (var name in (names[1..4]))
    Console.WriteLine(name);

/*
Tsuyu
Izayoi
Kaio
*/
```

## Arrays

\*Now, we move onto Arrays. Arrays are similar to lists but if you've come this far you probably should be knowing the difference. But since this is a refresher let's go through it again

\*In C#, both arrays and List<T> are used to store collections of data, but they differ significantly in their characteristics and use cases.

\*Fixed Size: An array's size is determined at the time of its creation and cannot be changed afterward.

\*Contiguous Memory: Array elements are stored in contiguous memory locations, allowing for efficient access by index. [1]

\*Strongly Typed: Arrays are strongly typed, meaning all elements must be of the same data type.

\*Belongs to System.Array: Arrays are a fundamental data structure in the .NET framework and belong to the System.Array namespace.

List<T> (Generic List):

\*Dynamic Size: A List<T> can grow or shrink dynamically as elements are added or removed.

\*Built on Arrays: Internally, List<T> uses an array to store its elements. When the underlying array becomes full, a new, larger array is allocated, and the elements are copied over.

\*Type-Safe (Generics): List<T> uses generics to provide type safety, ensuring that only elements of the specified type T can be stored.

\*More Functionality: List<T> offers a rich set of methods for manipulating the collection, such as Add, Remove, Insert, Sort, Contains, etc. [2]

Key Differences Summarized:

| Feature           | Array                                     | List<T>                                                  |
| ----------------- | ----------------------------------------- | -------------------------------------------------------- |
| Size              | Fixed                                     | Dynamic                                                  |
| Memory Allocation | Contiguous                                | Can be reallocated and copied internally                 |
| Type Safety       | Strongly typed                            | Type-safe (using generics)                               |
| Flexibility       | Less flexible (fixed size)                | More flexible (dynamic size, more methods)               |
| Performance       | Faster for direct element access by index | Can have performance overhead during resizing operations |

When to Use Which:

\*Use Arrays

when you know the exact number of elements you need to store and that number will not change. Arrays are ideal for performance-critical scenarios where direct, indexed access is frequent.

\*Use List<T>

when the number of elements is unknown or likely to change frequently. List<T> provides greater flexibility and a more convenient API for managing collections, albeit with potential performance implications during resizing.

### Array Example:-

\* Array is fixed in Length, but it is still MUTABLE.

```
var array = new string[] { "Aeon", "Tsuyu", "Kaio", "Ikari" };
foreach (var name in array)
    Console.WriteLine(name);
/*
Aeon
Tsuyu
Kaio
Ikari
*/
```

\*You can copy arrays with this notation that is super clean and looks like Javascript

```
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
```

# Lesson 14: Sorting and Searching

\*Sorting is done using the `.Sort()` method.

```
var nums = new List<int> { 22, 67, 12, 123, 169};
names.Sort();
foreach (var num in nums)
    Console.WriteLine(num);

/*
12
22
67
123
169
*/
```

\*Strings are sorted lexicographically

```
var names = new List<string> { "Aeon", "Tsuyu", "Izayoi", "Kaio", "Ikari" };
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
```
