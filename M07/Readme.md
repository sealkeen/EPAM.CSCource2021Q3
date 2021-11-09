## Material Content 
- *Delegate types.*
- *Creating a delegate.*
- *Multicast delegates.*
- *Invoking a delegate.*
- *Common delegate types.*
- *Inline methods (anonymous function and  lambda expression).*
- *Delegates versus interfaces.*
- *Captured variables.*
- *Events. Standard event delegate pattern. Custom add and remove methods.*
- *Events versus delegates.*
- *Lambdas and expression trees.*

## Books & Useful References 
- [Programming C# 5.0. Ian Griffiths. O'Reilly Media. 2012.](http://shop.oreilly.com/product/0636920024064.do) 
    - *Chapter 9.* Delegates, Lambdas and Events. [Download Example Code](https://resources.oreilly.com/examples/0636920024064/blob/master/Ch09.zip)
- [C# in Depth. Jon Skeet. Manning Publications Co. 2013](https://www.manning.com/books/c-sharp-in-depth-third-edition)
   - *Chapter 5.* [Fast-tracked delegates.](https://livebook.manning.com/#!/book/c-sharp-in-depth-third-edition/chapter-5/)
   - *Chapter 9.* [Lambda expressions and expression trees.](https://livebook.manning.com/#!/book/c-sharp-in-depth-third-edition/chapter-9/)
- [C# 5.0 Unleashed. Bart De Smet. Sams Publishing. 2013](https://www.goodreads.com/book/show/16284093-c-5-0-unleashed)
   - *Chapter 17.* Delegates.
- [CLR via C#. Jeffrey Richter. Microsoft Press. 2010](https://www.goodreads.com/book/show/7121415-clr-via-c)
   - *Chapter 17.* Delegates.

## Tasks  
**Objective:** 
- *understand delegate usage scenarios;*
- *understand the relationship delegates versus interfaces;*
- *understand callback functions;*
- *study design pattern Strategy;*
- *study design pattern Observer;*
- *understand difference between events and delegates;*
- *understand DRY (Don’t Repeat Yourself), SoC (Separation of Concerns principles), Low Coupling principles;*
- *understand standard event delegate pattern.*

**Tasks**
1. Create a console application.
2. Create a class, which allows to bubble-sort a matrix of integers (do not use System.Array methods) in order to arrange matrix rows:
- *in ascending (descending) order by sums of matrix row elements*
- *in ascending (descending) order by maximum element in a matrix row;*
- *in ascending (descending) order by minimum element in a matrix row;*
- *USE DELEGATES with STRATEGY PATTERN (comparison type and order type should be passed by user. You can hardcode demo-matrix)*
3. Develop a Countdown class, which implements the capability to transmit a message to any subscriber 
who subscribes to the event after the appointed time (waiting time is provided by the user).
You can use the Thread.Sleep() method to create a wait effect. 
Provide the possibility of subscribing to an event in several classes.
