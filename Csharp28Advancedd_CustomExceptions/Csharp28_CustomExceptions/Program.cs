/*An application may encounter an error during the execution.
-When an error occurs, either CLR or program code throws an exception which contains necessary information about the ERROR.
-SystemException class - is a base class for all the exceptions that can occur during the execution of the program.
But how can we handle exceptions?
-C# provides a built in support to handle the exception using: try, catch & finally block. */

using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace Csharp28_CustomExceptions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //---------------------------------------------------PART2---------------------------------------------------------------------
            //----------------------------------------------CUSTOM EXCEPTIONS--------------------------------------------------------------
            //28.8.2  Create a Student object named student
            Student student = new Student();
            //28.9  Pres try&doubleTab
            try
            {
                student.Age = -10; //28.9.1 Define the Student Age
                ValidatStudentAge(student.Age); //28.9.2 Create the ValidatStudentAge() method  to validate the Age.
            }
            /*29.10  Go in the catch block,
            Replace the exception class with the InvalidStudentAgeException,Display to the screen the e.message, Remove the throw.*/
            catch (InvalidStudentAgeException e) // catch (Exception e)
            {
                //Console.WriteLine(e);
                Console.WriteLine(e.Message);
                //throw;
            }


        }//EndMain()


        /*28.9.3
        Create the ValidatStudentAge() method by clicking on the left in the row 68, then Generate ValidatStudentAge() */
        private static void ValidatStudentAge(int age)
        {
            if (age < 18) throw new InvalidStudentAgeException(age);
        }


    }//EndProgram






    /*28.6-----------------------------------CUSTOM EXCEPTIONS-------------------------------------------------------------------
    We can also create our own custom exceptions and we can do that by using the Exception base class.
    So let us start creating our own custom exception. Let's create a Student class which we're going to use for our custom exception.*/
    public class Student
    {
        public int StudentID { get; set; }
        public int Age { get; set; }
    }
    /*28.7
    I want to create a customException which is going to be thrown when the users do not provide a valid Age.
    Example: when they provide a negative number.
    Let's name customException as InvalidStudentAgeException, which inherits from the ExceptionBasedclass.
    Because we said: that we need to use the ExceptionBaseclass to create customExceptions. */
    public class InvalidStudentAgeException : Exception
    {
        //28.7.2 Create an constructor by pressing ctor-doubleTab
        public InvalidStudentAgeException()
        {

        }
        //28.7.3 Create another constructor that takes as parameter the StudentAge.
        //And inherits from the Baseclass which is the Exception. And inside the base we define the stringMessage
        public InvalidStudentAgeException(int age) : base($"The number {age} is not a valid age!")
        {

        }
        //28.8.1 Save the changes and then go inside the Main() method to create a Student object.
    }


}//EndOfnamespace


//So we see that we can create Custom Exception classes to differentiate from the system Exceptions.
