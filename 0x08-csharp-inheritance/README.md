0x08. C# - Inheritance

Requirements
General
Allowed editors: Visual Studio Code
All files will be compiled on Ubuntu 14.04 LTS using dotnet
A README.md file, at the root of the folder of the project, is mandatory
All default C# files named Program.cs should be renamed to the name given in each task
Namespaces should be omitted in this project
Each C# task requires its own folder and .csproj file. Push all task folders to your Github and ensure the task names on the folders are correct
You do not need to push your obj/ or bin/ folders
In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples
All your public classes and their members should have XML documentation tags
All your private classes and members should be documented but without XML documentation tags


General
What is inheritance
How is polymorphism achieved with inheritance
What is a base class
What is a derived class
How to create a derived class
How to override a method or property inherited from the base class
What is the difference between the override and new modifiers
What are is, .GetType(), TypeOf(), .IsInstanceOfType(), and .IsSubclassOf() and when to use them

Tasks

0. This is one of these mandatory
Write a method that returns True if the object is an int, otherwise return False.

Class: Obj
Prototype: public static bool IsOfTypeInt(object obj)

1. For instance mandatory
Write a method that returns True if the object is an instance of, or if the object is an instance of a class that inherited from, Array, otherwise return False.

Class: Obj
Prototype: public static bool IsInstanceOfArray(object obj)

2. Only subclass mandatory
Write a method that returns True if the object is an instance of a class that inherits from the specified class, otherwise return False. The object must be a subclass; your method cannot return True if the object is an instance of the base class.

Class: Obj
Prototype: public static bool IsOnlyASubclass(Type derivedType, Type baseType)

3. Type mandatory
Write a method that prints the names of the available properties and methods of an object. See example for output format.

Class: Obj
Prototype: public static void Print(object myObj)

4. It's not a lesson in classes and inheritance without a Dog mandatory
Write a empty class Dog that inherits from empty class Animal.

Base Class: Animal
Derived Class: Dog

5. Basic shapes mandatory
Write a class Shape.

Class: Shape
public method: public virtual int Area()
Throws an NotImplementedException with the message Area() is not implemented

6. Rectangle mandatory
Based on 5-shape, write a class Rectangle that inherits from Shape.

Class: Rectangle
private field: private int width
private field: private int height
public property: public int Width
get: retrieve width
set: if value is negative, throw an ArgumentException with the message Width must be greater than or equal to 0. Otherwise, set width to the value.
public property: public int Height
get: retrieve height
set: if value is negative, throw an ArgumentException with the message Height must be greater than or equal to 0. Otherwise, set Height to the value.

7. Full rectangle mandatory
Based on 6-shape, write a class Rectangle that inherits from Shape.

Class: Rectangle
private field: private int width
private field: private int height
public property: public int Width
get: retrieve width
set: if value is negative, throw an ArgumentException with the message Width must be greater than or equal to 0. Otherwise, set width to the value.
public property: public int Height
get: retrieve height
set: if value is negative, throw an ArgumentException with the message Height must be greater than or equal to 0. Otherwise, set Height to the value.
public method: public new int Area()
This will override the Area() method defined in the Shape base class. (Try changing new to override and run the program. What happens?) returns the area of the rectangle
public method: public override ToString()
returns [Rectangle] <width> / <height>

8. Square #1 mandatory
Based on 7-shape, write a class Square that inherits from Rectangle

Class: Square
private field: private int size
public property: public int Size
get: retrieve size
set: if value is negative, throw an ArgumentException with the message Size must be greater than or equal to 0. Otherwise, set size, height, and width to the value.

9. Square #2 mandatory
Based on 8-shape, write a class Square that inherits from Rectangle

Class: Square
private field: private int size
public property: public int Size
get: retrieve size
set: if value is negative, throw an ArgumentException with the message Size must be greater than or equal to 0. Otherwise, set size, Height, and Width to the value.
Area() should work without writing a new Area() method within your Square class
.ToString() should return [Square] <size> / <size>
