using System;

namespace Csharp14_Structures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Step3  Declare struct and Define some values
            So that's all the structure can be initialized with or without the new keyboard.
            The same as a primitive variable ordinal.*/

            Student s1 = new Student(); //define a Student with the new keyword
            s1.FirstName = "Roberto";
            s1.LastName = "DATJA";
            s1.Grade = 5;

            Student s2; //define a Student without  the new keyword
            s2 = new Student();
            s2.FirstName = "Gersi";
            s2.LastName = "HOXHA";
            s2.Grade = 2;

            //Show for users
            Console.WriteLine($"{s1.FirstName} - {s1.LastName} - {s1.Grade}");
            Console.WriteLine($"{s2.FirstName} - {s2.LastName} - {s2.Grade}");

            //Step4
            /* But why should we use structures over other objects?
            We use structures because they are faster than classes for example. And you can use structures whenever you want to just store the data.
            Generally structures are great for game programming. 
            But since they are the new type objects   it's not the best option  to use them when transferring data.For example: when you are passing data to other classes
            Also structures can have:  Methods, Fields, Indexers, Properties, Operator methods, Events. 
            Also structures can have:  Defined constructors.  But not destructors.
            However you can not define a default constructor for structure because a default constructor is automatically defined and cannot be changed. 
            */
            //Step4.1
            //So let us create our first constructor: Go to Student's  file

            //Step4.4
            Student s3 = new Student("John", "Smith", 3); //Let us use the constructor to create the third student.
            s3.ShowStudent(); //Display the result

            /* STRUCTURES
             Can implement one or more interfaces. 
             Can't inherit from other structures or classes.
             Can't be used as a base for other structures or classes.
             Its members can't be specified as abstract virtual or protected.
            */
        }
    }
}