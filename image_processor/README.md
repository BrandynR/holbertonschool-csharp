Image Processing
 Specializations - AR/VR ― More!

 by Carrie Ybay, software engineer at Holberton School

 Ongoing project - started 08-12-2020, must end by 08-20-2020 (in about 3 hours) - you're done with 0% of tasks.

 Checker was released at 08-18-2020 12:00 AM

 QA review fully automated.

Readme
Parallel Processing, Concurrency, and Async Programming in .NET
Using threads and threading
System.Drawing Namespace
For this project you will be utilizing .NET’s System.Drawing namespace. You will need to install it using NuGet.

Mac users: In addition to adding the System.Drawing NuGet package, you will need to also do the following:

brew install mono-libgdiplus
In the project folder: dotnet add package runtime.osx.10.10-x64.CoreCompat.System.Drawing
All images in this project are sourced from Unsplash.

What you should learn
At the end of this project you are expected to be able to explain to anyone, without the help of Google:

What is parallel programming?
What is concurrency?
What is threading?
When is it appropriate to use multiple threads? When is it not?
How do you create, start, pause, resume, and abort threads?
What are threading best practices?
What is meant by ‘thread-safe’?
What is the difference between processes and threads?
What kind of applications benefit from multithreading? What applications don’t?
Requirements for C# projects
Allowed editors: Visual Studio Code
All files will be compiled on Ubuntu 14.04 LTS using dotnet
A README.md file, at the root of the folder of the project, is mandatory
You do not need to push your obj/ or bin/ folders
In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples
All your public classes and their members should have XML documentation tags
All your private classes and members should be documented but without XML documentation tags
Tasks

0. Inverse #advanced
In this project you will be creating an image processing console application that takes a list of images and creates new images from them based on the method.

For this task, create a method that inverts an image’s color.

1. Grayscale #advanced
Add a new method to the ImageProcessor class that converts each image to grayscale.

Class: ImageProcessor
Method: public static void Grayscale(string[] filenames)
File name format: <original_file_name>_grayscale.<original_file_extension>

2. Black / White #advanced
Add a new method to the ImageProcessor class that reduces each image to only black and white values, based on a given threshold.

Class: ImageProcessor
Method: public static void BlackWhite(string[] filenames, double threshold)
File name format: <original_file_name>_bw.<original_file_extension>
A pixel with a greater or equal luminance than the threshold should be white
A pixel with a lower luminance than the threshold should be black

3. Thumbnail #advanced
Add a new method to the ImageProcessor class that creates a thumbnail image based on a given height (in pixels).

Class: ImageProcessor
Method: public static void Thumbnail(string[] filenames, int height)
File name format: <original_file_name>_th.<original_file_extension>
The new thumbnail image should retain the aspect ratio of the original image
The method should not reduce the resolution of the image