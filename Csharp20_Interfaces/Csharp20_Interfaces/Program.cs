using System;
namespace Csharp20_Interfaces
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
    }
}
/*
On the last part we talked about inheritance and polymorphism in C-sharp.
Then we learned how to create a Base|Parent class, then how to create a child class to inherit from this Base class.
But in C# we cannot inherit from multiple classes.

So for example
If we go to the Student.cs file, and we try to inherit from the Professor Base class.
//public class Student: Person, Profesor
We'll get an error->'Student' class cannot have multiple base classes.
And that's right because object oriented programming tries to resemble how objects are defined in real life.

And this is when interfaces come into play
Because interfaces are a very logical way of grouping objects in terms of behavior
Interfaces define:
1.properties 
2.methods 
3.events 
which are members of that interface.

Now interface is contain 
only the declaration of the members 
Because it is the responsibility of the deriving class to define the members.

//20
So let us go to the Person.cs class and you will see that this class has 2 properties and 2 methods.
//
Now let us create an interface which has all the members of the Person class and then we are going to
use that interface to inherit from the Professor and the Student class 
//20.1
To create an interface go to the solution explorer - right click on the project - add - new item option
- Your search for interface - choose the interface option - define a name - IPerson.cs
Now by convention when you create an interface you need to start with a capital.
*/
