# C# Functional Programming

## Tuples
C# features built-in support for deconstructing tuples, which lets you unpackage all the items in a tuple in a single operation. The general syntax for deconstructing a tuple is similar to the syntax for defining one: you enclose the variables to which each element is to be assigned in parentheses in the left side of an assignment statement.

## User-defined types
C# offers built-in support for deconstructing tuple types, record and DictionaryEntry types. However, as the author of a class, a struct or an interface, you can allow instances of the type to be deconstructed by implementing one or more `Deconstruct` methods. The method returns void. An `out` parameter in the method signature represents each value to be deconstructed.
