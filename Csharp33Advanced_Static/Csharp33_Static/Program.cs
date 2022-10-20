/*
C# includes the static keyword. 
static keyword can be applied on:
1.Classes, 2.Variables, 3.Methods, 4.Properties, 5.Operators, 6.Events, 7.Constructors.
static keyword can not be applied on:
1.Indexers, 2.Destructors, 3.Types other than classes.

When using the static keyword, it means that the class cannot be initialized using the new keyword.
So, the properties, variables, methods etc. can be accessed directly by using the classname instead of creating a new object.
*/

using System;
using System.Xml.Linq;

namespace Csharp33_Static
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //33.1.2  Let's see how we can use the static classes in here. 
            //I have already created a Student class. Let's see how we can access the FullName property from the Student class.
            Student student = new Student(); //by using the Student class we are initializing a new object, named student.
            student.FullName = "John Doe";
            student.StudentInfo();

            //33.2.2 And we said that when we have a static class, we can not initialize an object by using the new keyword
            //we can use directly the class name
            Console.WriteLine("\nWe've used a static class");
            STUDENT.FullName = "John Doe";
            STUDENT.StudentInfo();

            /* 33.3 
            But why should we use static classes in C# ? The main benefit of using a static-class is that:
            You can use the members of a static class without creating an instance of that class.
            Example: 33.2.2  
            So to use the FullName we didn't have to create an object. 
            The same way to use the StudentInfo() we didn't have to create an object as well.

            Also, static classes are well known to be used to create extension methods, 
            which are methods that enable you to add methods to existing types without creating a new derived type.
            */
        }
    }

    //33.1.1 
    public class Student
    {
        public string title = "Student: ";
        public void StudentInfo() => Console.WriteLine($"{title} {FullName}");
        public string FullName { get; set; }
    }

    //33.2.1  Let's add the static keyword in the class and in the its members.
    public static class STUDENT
    {
        public static string title = "Student: ";
        public static void StudentInfo() => Console.WriteLine($"{title} {FullName}");
        public static string FullName { get; set; }
    }
}