## Recording
[2020Q3](https://videoportal.epam.com/video/3KpWY4LzNe2L800mYjo2)

[2021Q1](https://videoportal.epam.com/video/dBNrJdbejleBLdkzaQXW)

## Material Content 
- *Exception Sources. Exceptions from APIs, your code.*
- *Handling exceptions and catch blocks.*
- *Nested try blocks.*
- *Finally blocks.*
- *Throwing exceptions,  rethrowing exceptions.*
- *Exception types, custom exceptions and unhandled exceptions.*
- *Logging and NLog .Net Framework.*

## Books & Useful References 
- [Programming C# 5.0. Ian Griffiths. O'Reilly Media. 2012.](http://shop.oreilly.com/product/0636920024064.do)
   - *Chapter 8.* Exceptions. [Download Example Code](https://resources.oreilly.com/examples/0636920024064/blob/master/Ch08.zip)
- [C# 5.0 Unleashed. Bart De Smet. Sams Publishing. 2013](https://www.goodreads.com/book/show/16284093-c-5-0-unleashed)
   - *Chapter 23.* Exceptions.
- [CLR via C#. Jeffrey Richter. Microsoft Press. 2010](https://www.goodreads.com/book/show/7121415-clr-via-c)
   - *Chapter 20.* Exceptions and State Management.
- [Effective C# (Covers C# 6.0): 50 Specific Ways to Improve Your C# (Effective Software Development). Bill Wagner. Addison-Wesley. 2016](https://www.goodreads.com/book/show/30009056-effective-c-covers-c-6-0)
   - *Chapter 5.* Exception Practices.
- [NLog - Flexible & free open-source logging for .NET](http://nlog-project.org/)
- [NLog - Tutorial](https://github.com/NLog/NLog/wiki/Tutorial)
   
## Tasks
- Create a console application (UI).
- Create a class library that allows to convert a string to an integer number. Do not use Parse, TryParse, Convert etc. 
- Console application should reference the library (for demo puproses). 
- Configure logger into the console application (use NLog). Set up two levels of logging - one for errors only, second one for all other levels. 
- Class library should take an ILogger (Microsoft.Extensions.Logging.ILogger) interface as a dependency (from console application) and use it to log every action. 
- All of the exceptions should be logged properly and rethrown to the console application.
- Console application should handle the exceptions and provide the user with the exception details.
