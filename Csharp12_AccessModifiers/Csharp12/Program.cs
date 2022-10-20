
using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using System.Threading;

namespace Csharp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //12.1 //Step2
            //Let us now create an object from Student class
            Student student = new Student("John", "Smith", 20);
            //Show to the users
            //the firstName and lastName variable are accessible from a student object because we have defined them as a public property.
            Console.WriteLine($"First Name - {student.firstName}");
            Console.WriteLine($"Last Name - {student.lastName}");

            //Console.WriteLine($"Age Name - {student.age}");
            //I'll get an error which says student up age is not accessible due to its protection level.
            //Which means that the age variable has been defined as a private variable so it cannot be accessed from outside this class.

            //----------------------------------------------------------
            Console.WriteLine("\n");
            //12.3 //Step2
            STUDENT student2 = new STUDENT("Roberto", "Datja", 29);
            Console.WriteLine($"First Name - {student2.firstName}");
            Console.WriteLine($"Last Name - {student2.lastName}");
            Console.WriteLine($"Last Name - {student2.age}");//The age field is now accessible from another class.
            /*Now the reason why all these three variables are accessible from another class within the same file
            is because: both the class Program and the class STUDENT belong to the same assembly.*/ 
        }
    }


    //12Access modifiers
    //are used to specify the level at which each variable|function|object can be accessed within the application.
    //C-sharp we have 5 types of access modifiers:  public, private, protected, internal and protected internal.

    /*12.1&12.2 Public&Private: accessed from the only within the class
    /* 12.1
    When class or members of that class are specified to be public it means that they can be accessed by
    other functions and objects anywhere within the application.
    12.2 
    But members defined private can only be accessed within that class in which they are defined.
    Example: */

    //12.1 //Step1
    public class Student
    {
        //3 members
        public string firstName;
        public string lastName;
        private int age;

        //Constructor
        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age; //But we have access it down here because we are inside the Student class
        }
    }


    //12.2
    /*protected: accessed from within the defined class and child classes
    protected access modifier protected member variables and classes can only be accessed 
    within the classes in which they are defined and inside the child classes. Now this concept will be explained later.
    That's why I'm going to skip the demo from here because once we learn about the inheritance in an upcoming
    part we are going to get back to the protected access modifier and to see how we works.*/

    //12.3
    /* internal:  accessed from within the same assembly
    internal access modifier is used to make variables and functions accessible 
    within the Assembly of the class in which they are defined.
    Example:*/

    //12.3//Step1
    public class STUDENT
    {
        //3 internal members 
        internal string firstName;
        internal string lastName;
        internal int age;

        //Constructor
        public STUDENT(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age; 
        }
    }
}

//12.4
/*protected internal: accessed from child classes within the same assembly
protected internal access modifier which is a combination of protected and internal modifiers.
This means that it makes a variable accessible to the child classes
are inside the same assembly of a class in which they were actually defined.*/