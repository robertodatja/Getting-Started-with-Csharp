/*
A predicate in C# is also a delegate like Func & Action delegates
But a predicate delegate takes one input parameter and returns a boolean value. 
*/
using System;
using System.Linq.Expressions;

namespace Csharp37_Predicate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //37.2.1 
            Predicate<int> iseven = IsEven; //Write Predicate, takes 1 int parameter, named iseven & references to the IsEven
            Console.WriteLine(iseven(5)); //test the iseven predicate
            Console.WriteLine(iseven(6));
            Console.WriteLine("------");
            //37.2.2
            Predicate<string> islowercase = IsLowerCase; 
            Console.WriteLine(islowercase("this is a lower case string"));
            Console.WriteLine(islowercase("this is NOT a lower case string"));


            //-----------------------------------------------------------------------------------------------------------
            /* The predicates are the same like Func&Action, can be used with anonymous methods and lambda expressions.*/
            //37.3.1                    Creating an anonymous method
            Predicate<int> isevenn = delegate (int number) { return number % 2 == 0; }; 
            Console.WriteLine($"\nThe number 6 is even: {isevenn(6)}");

            //37.3.2                         Creating a lambda expression
            Predicate<string> islowercasee = (string text) => text.Equals(text.ToLower());
            Console.WriteLine($"The text 'Erebare' is lowecase: {islowercasee("this is NOT a lower case string")}");
            
            //The results are the same like when we were using the methods.
        }



        /* 37.1 Before we test the predicates. Let's created 2 bool methods, which take only 1 parameter. 
        Because we said that predicates can be used only with methods that return a bool value and take only 1 parameter.
        //FirstMethod
        static bool IsEven(int number)
        {
            return number%%2 == 0;
        }
        //SecondMethod
        static bool IsLowerCase(string text)
        {
            return text.Equals(text.ToLower());
        }
        */

        //37.1 The shortest way: means instead of {} and return, we use =>
        static bool IsEven(int number) =>  number % 2 == 0;
        //SecondMethod
        static bool IsLowerCase(string text) => text.Equals(text.ToLower());

    }
}