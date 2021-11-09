## Recording 
[Lectures 0 and 1 2020Q3](https://videoportal.epam.com/video/zXWOJMdqvL1ZA5gDYnDv) 

[Lecture 1 2021Q1](https://videoportal.epam.com/video/9w0kaE206Ro5loQGYeLn)

## Material Content 
- *Framework Overview.*
- *The CLR and Core Framework.*
- *Applied Technologies - review*
- *C#’s Defining Features.*
- *Object Orientation.*
- *Type Safety.*
- *Memory Management.*
- *Platform Support.*
- *C#, CLR and ECMA-Standarts.*
- *Managed Code and the CLR.*
- *Assemblies, multi-file assemblies, strong name assemblies, GAC, ILDASM and JetBrains dotPeek tools.*
- *Visual Studio. Project types in VS. Anatomy of a Simple Program. Adding a Project to an Existing Solution. Referencing One Project from Another. Namespaces. Program Entry Point.*

## Books & Useful References 
- [Programming C# 5.0. Ian Griffiths. O'Reilly Media. 2012.](http://shop.oreilly.com/product/0636920024064.do)
  - *Chapter 12.* Assemblies [Download Example Code](https://resources.oreilly.com/examples/0636920024064/blob/master/Ch12.zip)
- [CLR via C#. Jeffrey Richter. Microsoft Press. 2010](https://www.goodreads.com/book/show/7121415-clr-via-c)
   - *Chapter 1.* The CLR’s Execution Model
   - *Chapter 2.* Building, Packaging, Deploying, and Administering Applications and Types
   - *Chapter 3.* Shared Assemblies and Strongly Named Assemblies
- [C# 5.0 Unleashed. Bart De Smet. Sams Publishing. 2013](https://www.goodreads.com/book/show/16284093-c-5-0-unleashed)
   - *Chapter 25.* Assemblies and Application Domains
- [C# 6.0 in a Nutshell. Joseph Albahari, Ben Albahari. O'Reilly Media. 2015.](http://shop.oreilly.com/product/0636920040323.do)
   - *Chapter 1.* Introducing C# and the .NET Framework [Code Listings](http://www.albahari.com/nutshell/ch01.aspx)
   - *Chapter 18.* Assemblies [Code Listings](http://www.albahari.com/nutshell/cs4ch17.aspx)   

## Tasks  
**Objective:** 

Using .NET CLI:
1. Create a solution in a new folder
2. Create a project - a class library (ArrayHelper)
   - In that library implement a class, which allows to bubble-sort an array (both ASC/DESC). Note: do not use built-in sorting methods (like OrderBy, Sort, etc)
   - In that library implement a class, which allows to calculate the sum of all positive elements in a two dimensional array
   - Add necessary validations
3. Add ArrayHelper library to solution
4. Create a project - a class library (RectangleHelper)
   - In that library implement a class, which allows to calculate perimeter and square of a rectangle
   - Add necessary validations
5. Add RectangleHelper library to solution
6. Create a project - a console application, which demonstrates the functional of these two libraries
7. Add to solution
8. Build the solution
9. Run console application
10. Publish as self-contained assembly for Windows x64 and any other architecture of your choice (for example, ARM x86)
11. Collect all used commands to the script

