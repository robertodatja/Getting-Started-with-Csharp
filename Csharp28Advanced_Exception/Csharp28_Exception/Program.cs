/*An application may encounter an error during the execution.
-When an error occurs, either CLR or program code throws an exception which contains necessary information about the ERROR.
-SystemException class - is a base class for all the exceptions that can occur during the execution of the program.
But how can we handle exceptions?
-C# provides a built in support to handle the exception using: try, catch & finally block. */

using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace Csharp28_Exception
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //28 Write try & double tab

            try  //is the block that gets executed
            {
                //28.1.1
                int x = 12;
                Console.WriteLine($"12/0 = {x / 0}");
                //The exception throw within the try block, can be handled using the catch block.
            }

            /* 28.4.1  In the screen, We see that we get an exception and the exception type is - divided by zero exception.
            Then finally we get-the finally block message. We have different types of exceptions and divide by zero exception is just one of them.
            And if you want to build specific blocks for each exception you can do that.
            So let us go back to our code and then let us create a special catch block only for dividing by zero the exception.*/
            //28.4.2
            catch (DivideByZeroException ex) // is executed when an exception is throw|occur
            {
                Console.WriteLine(ex.Message);
            }


            catch (Exception e)
            {
                //Console.WriteLine(e)  //28.1.2 
                Console.WriteLine("This is an Exception"); //28.4.3
                //throw();  //28.1.2  
            }

            //28.3 No matter what happened in the try&catch block.
            //The code that's within the finally block will always be executed.
            finally
            {
                Console.WriteLine("Finally block message\n");
            }
            /* The finally block - is really useful when you have a piece of code which you want to always executed.
            Example:
            If you work with databases, you want to always close the connection string. 
            The finally block  would be a great use for that case.*/

            /*28.5 In C#, you can also manually throw one exception by using  - the throw keyword 
            And any type of exception which is derived from the exception class can be raised using - the throw keyword.
            Example:*/
            //So normally you would get this result from the user input but I'll just assume that the value is -10
            int positiveNumber = -10;
            /* After the keyword new, you can choose one of the exception classes. I'll use the ArgumentException() 
            Because I normally expect the number to be positive number but I have a negative number. */
            if (positiveNumber <= 0) throw new ArgumentException("The number is not a positive!");

        }//EndMain()

    }//EndProgram

}//EndOfnamespace
