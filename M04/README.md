## Material Content 
- *Encapsulation. Access modifiers. Properties. Automatic properties. Indexers.*
- *Inheritance.*
- *Sealed Methods and Classes.*
- *Special Base Types - System.ValueType, System.Enum.*
- *Virtual methods.*
- *System. Object (Equals, GetHashCode, ToString and etc).*
- *Abstract methods.*
- *Abstract classes.*
- *Interface Inheritance.*
- *Dynamic.*
- *Single dispatch and multiple dispatch.*

## Books & Useful References 
- [Programming C# 5.0. Ian Griffiths. O'Reilly Media. 2012.](http://shop.oreilly.com/product/0636920024064.do)
  - *Chapter 6.* Inheritance [Download Example Code](https://resources.oreilly.com/examples/0636920024064/blob/master/Ch06.zip)
  - *Chapter 14.* Dynamic Typing [Download Example Code](https://resources.oreilly.com/examples/0636920024064/blob/master/Ch14.zip)
- [C# 4.0 Unleashed. Bart De Smet. Sams Publishing. 2011](https://www.goodreads.com/book/show/16284093-c-5-0-unleashed)
   - *Chapter 11.* Fields, Properties, and Indexers
   - *Chapter 14.* Object-Oriented Programming
   - *Chapter 22.* Dynamic Programming .
- [CLR via C#. Jeffrey Richter. Microsoft Press. 2010](https://www.goodreads.com/book/show/7121415-clr-via-c)
   - *Chapter 10.* Properties
   - *Chapter 13.* Interfaces

## Tasks  
1. Develop a geometric shapes class hierarchy - Circle, Triangle, Square, Rectangle, etc...  Classes should describe the properties of a shape and have methods for calculating the area and perimeter of the shape. (*A task with an emphasis on building an inheritance hierarchy, without unduly detailed implementation*).
2. Create a class hierarchy and implement key methods for a computer game (no functional requirements yet). Game's plot:
- A player can move within a rectangular field with size Width * Height
- There are some bonuses on the fiels (apples, cherries, bananas) which could be picked up by a player and give them score points
- There are some monsters (wolves, bears) hunting the player and move using an algoritm
- There are some obstacles on the field (stones, trees) which player and monster should avoid
- The goal is to collect all bonuses and don't be eaten by monsters

Note: it's possible to use abstract classes and interfaces
