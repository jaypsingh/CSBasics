# Introduction to CS Basis Concepts.

### 1. Array:
Array concept is demostrated in the file **ArrayDemo.cs** 
This files demos the below concept:
- Declaring Arrays
- Adding item to arrays
- getting the item count from Arrays
 
Here only few of the Array mmethods are shown but you can play around with that since intelisence will give all the details.
Note that to use any of tha static method of Array class use *Array.* and intelisense will poulate all the static methods.
And to use any of the instance methods use *ArrayInstanceVariable.*, here ArrayInstanceVariable is tha array variable you define.
 
### 2. List:
Lists concept is demostrated in the file **List.cs**
This files demos the below concept:
- Declating List
- Adding to list
- getting item count from list
 
### 3. Dictionary:
Dictionary concept is demostrated in the file **DictionaryDemo.cs**
This file demonstrates the use of Dictionary. 
Dictionaries are datatype in C# that can be used to keep key-value pair.

This file demonstrates the below concepts:
- Initializing a dictionary.
- Additng item to dictionary
- Get Item from dictionary
- Check if an item exists in a dictionary
- Return item from dictionay only if it exists.
- Loop a dictionary on Key
- Loop a dictionary on Value
- Loop dictionary on elements

### 4. Enums:
Emums concept is demostrated in the file **Emums.cs**.
Enums are data types that is used to represent a numebric value.
The vaue starts from 0 by default. But it can be configured.

### 5. Break and Continue:
Break and Continue concept is demostrated in the file **BreakContinue.cs**
This file demonstrates below concepts
- Break
- Continue

### 6. Constructors:
Constructors concept is demostrated in the file **Constructor.cs**.
This files demos the below concept:
- Constructore
- Parameterized constructor
- "this" keyword

### 7. Exceptions:
Exception concept is demostrated in the file **ExceptionDemo.cs**.
This file demos the below concepts
- exception
- handling exception
- throwing exception
- finally block

### 8. Control Flow And Loop:
Control Flow & Loop concept is demostrated in the file **FlowAndLoop.cs**.
This files demos the below concept:
- If control flow
- For loop
- For each loop
- While loop
- Do while loop


### 9. ForEach Loop:
ForEach loop concept is demostrated in the file **ForEach.cs**.
This files demos the below concept:
- foreach loop
 
This is also explained with other loops in **FlowAndLoop.cs** file. 
Please do refer to that as well.

### 10. Formatting Specifier:
Formatting Specifier concept is demostrated in the file **FormattingSpecifier.cs**.
This files demos the below concept:
- format specifiers

### 11. Lambda Methods:
Lambda Method concept is demostrated in the file **LambdaMethod.cs**.
This class demons the Lamda Methods
(also called as expression bodied methods) 
If your method code is just a line and is used to return a value you can use lamda methods.
The syntax is simple and the operator is =>

### 12. Min Max Static:
Min, Max and Static concept is demostrated in the file **MinMaxStatic.cs**.
This files demos the below concept:
 - Double.MinValue 
 - Double.MaxValue
 - Math.Min
 - Math.Max
 - Static : This is just discussed and not demoed.
 
 *Static Methods and methods that are not associated with object instance. If a method is static you cannot call it with class object*. 
 *Also all the members of a static methids must be static*.
 for example see the main method.

 Also you can see below example
 ```
 Class DemoStatic
 {
    public DemoStatic()
    {
        number = new List<Double> {1.1, 1.2., 3.3, 4.4};
    }

     static public DemoStatic(double newNumber)
     {

       number.Add(newNumber); **// number must be static since this is a static method**
 
     }

     static private List<double> number; **// note that this is static member**
 }
 ```
 
### 13. Nullable Type:
Nullable Type concept is demostrated in the file **NullableTypeDemo.cs**.
Nullable type is a value type that allows defination of a value or null.
This class helps us to demo the below concepts
- Nullable Types
The syntax is simple and the operator is =>

### 14. Null Checking:
Null Checking concept is demostrated in the file **NullCheckingDemo.cs**.
C# supports ?. operator to check null values. 
This class demos the use of *?. operator* for null checking
*"?. is evaluated as "if null then null, if not then dot"*
That means if left side or the operator is null then the expression is null and the expression will not be evaluated further.
If not then . will be used and the expression will be evaluated further. * 

**NullableTypeDemo.cs** is referenced for this demo.


### 15. Object Initializer:
Object Initializer concept is demostrated in the file **ObjectInitializerDemo.cs**.
This class is used to demo object initializers for C#.
**NOTE** that this file will hav 3 classes for the demo purpose.
There are three ways how object can be initialized. 
Default Constructor, Parameterized Constructor and Object Initializers. 
CSBasic.cs and Unit Test will demonstate the object initilization


### 16. Method Over Loading:
Method Over Loading concept is demostrated in the file **OverLoading.cs**.
This file demonstrates the concept of 
- method overloading 

### 17. String Interpolation:
String Interpolation Loading concept is demostrated in the file **StringInterpolation.cs**.
This files demos the below concept:
- string interpolation

### 18. Properties:
Properties concept is demostrated in the file **Properties.cs**.
This files demos the below concept:
- Class Properties (getters and setters)
- Autoimplemented Properties
- Calculated value properties
- Expression Value properties

### 19. Reading From Console:
Reading From Console concept is demostrated in the file **ReadFromConsole.cs**.
This short method demonstrates how we can read data from console.
This file demonstrates the below concept:
- reading data from console.


### 20.ReadOnly And Constant:
ReadOnly And Constant concept is demostrated in the file **ReadOnlyAndConstant.cs**.
This files demos the below concept:
 - ReadOnly Fields
 - Constant Fields

### 21.Reading and Writing to File:
Reading and Writing to File concept is demostrated in the file **ReadWriteFile.cs**.
This file demonstrates the use of iDisposable.
The concept simply tells how C# handles if the file or stream is not closed before the program exits.
This file demonstrates the use of below statement
- using