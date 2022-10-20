
/* A class is like a blueprint of a specific object in the real world.
Every object has a color. It has a shape and it has functions.

For example a person.
Each person has specifics like:  age, behaves, birthday, profession, etc..

The same way in object oriented programming a class defines certain properties fields events methods etc..
So by using classes,
we create our own types by grouping together variables of other types methods and events in C-sharp.

A class can be defined by using the class keyword.
A class has different components:
1. Access Modifiers - which are used to define the accessibility of the class and its members.
2. The field - is a class level variable that can hold a value.
3. Constructors - which are called when you create an instance of a class.
4. Methods - which are used to execute certain instructions
5. Properties to encapsulate a private field.
*/

//18.1 Let's create our first class: solution explorer - right click on the project - add - Class -Circle name -Add.

using System;
namespace Csharp18_Class
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //18.8 use First Constructor  Circle()
            Circle c1 = new Circle(); //object c1
            c1.Radius = 5;
            double a1 = c1.GetArea();
            Console.WriteLine(a1);

            //18.9  use Second Constructor  Circle(double radius)
            Circle c2 = new Circle(5); //object c2
            double a2 = c2.GetArea();
            Console.WriteLine(a2);

            //Terminal we see that:
            //We have the same value 78.5,  Eventhough we use the different constructors.
        }
    }
}