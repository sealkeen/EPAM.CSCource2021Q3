## Material Content
- *Char type*
- *String type*
- *String formatting*
- *String parsing*
- *String comparing*
- *Regular expressions, regex*

## Books & Useful References
- [Programming C# 5.0. Ian Griffiths. O'Reilly Media. 2012.](http://shop.oreilly.com/product/0636920024064.do)
   - *Chapter 2.* Basic Coding in C#
- [C# 6.0 in a Nutshell. Joseph Albahari, Ben Albahari. O'Reilly Media. 2012.](http://shop.oreilly.com/product/0636920040323.do)
   - *Chapter 2.* C# Language Basics
- [Know Thy Complexities!](http://bigocheatsheet.com/)

## Tasks
1. Create a console application
2. Create a class that implements a method which allows to define an average word length in an input string (returns double).
(Punctuation characters should not affect the word length. Don't use regex.)
3. Create a class that implements a method that doubles in the first string parameter all characters belonging the second string parameter.
(example: first parameter - "omg i love shrek", second parameter - "o kek", result - "oomg i loovee shreekk")
4. Create a class that implements a method, that returns the sum of two big numbers (bigger than long). The input numbers are strings and the function must return a string.
(do not use long, big int and etc.)
5. Create a class that implements a method which reverses all of the words within the string passed in.
(example: ReverseWords("The greatest victory is that which requires no battle") => "battle no requires which that is victory greatest The")
6. Create a class that implements a method that takes a string which contains text with phone numbers with format like (+X (XXX) XXX-XX-XX or X XXX XXX-XX-XX or +XXX (XX) XXX-XXXX).
(take the source from Text.txt file you should create yourself). A method should return a list of strings with that numbers and write them to another Numbers.txt file 

Example of Text.txt file:
Bla bla bla my number is +7 (921) 345-67-89 kekeke
Blo Blo blo +375 (34) 444-7843 ololo

Should return : "+7 (921) 345-67-89" and "+375 (34) 444-7843"
