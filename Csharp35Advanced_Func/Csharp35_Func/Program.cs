/*
We've learned so far how to define a delegate but C# 3.0 includes built in generic delegate types: funC and action 
So we don't need to define custom delegates as we did in part 29.

Func is a generic delegate which is included in the system namespace.
It has zero or more input parameters and one output parameter.
But what is this signature and how can we create a func in C# ?

Important to mention that Func delegates:
1. can have 0-16 input parameters 
2. can also be used with an anonymous method or lambda expression.
*/
using System;
using System.Reflection.Metadata;

namespace Csharp35_Func
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //35.2 I'm going to create a reference to the Square methods.
            //So we said that a Func has zero or more input parameters and it has always an output parometer.
            //Func<input,output> name = method;    //input&output type of method
            Func<double,double> square = SQUARE;
            Console.WriteLine($"square = {square(2)}");
            //35.3
            Func<double, double> cubic = CUBIC;
            Console.WriteLine($"cubic = {cubic(2)}");
            //35.4
            Func<double> two = TWO;
            Console.WriteLine($"two = {two()}\n");
            /*35.5
            Func<void>  
            //We get error           
            Because the return type is void and the Func which is a generic delegates must always have a return value.
            So we can not create a reference of the SHOW() method. */

            //---------------------------------The second way for creating Func-------------------------------------------
            //35.6                        Creating an anonymous method
            Func<double, double> squareII = delegate(double value) { return value * value; }; //I'm not using mathclass: Math.Pow()
            Console.WriteLine($"square = {squareII(2)}");
            //35.3                       Creating a lambda expression
            Func<double, double> cubicII = (double value) => value*value*value;
            Console.WriteLine($"cubic = {cubicII(2)}");
            //35.4
            Func<double> twoII = TWO;
            Console.WriteLine($"twoII = {two()}");
            //We see that the result - is the same like referencing the SQUARE()|CUBIC() methods
        }


        //35.1 Before we start using the Func. Let us create a couple of methods.
        static double SQUARE(double number) => Math.Pow(number, 2);
        static double CUBIC(double number) => Math.Pow(number, 3);
        static double TWO() => 2;
        static void SHOW() => Console.WriteLine("Hello there");

    }
}