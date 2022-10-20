/*
We have seen that a function or a method can have one or more parameters of different data types.
-But what if you want to pass a function itself as a Parminter.
-How does C-Sharp handle the callback functions or event handlers?
And the answer is delegates,

-Delegate is a typesafe the function pointer.
One good way of understanding delegates is by thinking of a delegate or something that gives a name to a method signature.
A delegate can be seen as a placeholder for a/some method(s).
 */

using System;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Csharp29_Delegates
{
    /*29.1 Let's create a delegate
    -public - delegate -the next we need to define the signature of the methods that this delegate can point to.
    -void. So the return type of the method is going to be void. -Let's name deledate: StringDelegate(string parameter). */
    public delegate void StringDelegate(string text);

    public class Program
    {
        public static void Main(string[] args)
        {
            //29.3 Now let us see how we can reference these 2 methods by using the same delegate.
            StringDelegate strD1 = ToUpperCase; //This means that by using the StringDelegate, I've now created a reference to the ToUpperCase method.
            strD1("this is lowercase"); //Way1: to invoke the StringDelegate
            strD1.Invoke("this is another lowercase string");  //Way2: to invoke the StringDelegate

            //29.4  If you want to change the reference of the StringDelegate ot the ToUpperCase function|method
            //you can do the same or you can just write:
            strD1 = TolowerCase;
            strD1.Invoke("THIS IS UPPER CASE"); //Example to test it
                                                //So this is how you can use a delegate to point 2 different functions.

            //29.7-----------------------------------------
            Console.WriteLine("-------------------------");
            WriteOutput("this is lowercase string", strD1);
            //We've the transform string, because we pass as a parameter which is now pointing to the ToUpperCase function.

        }//Main


        //29.2  Let's create 2 methods which have the same signature as our delegate.
        static void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
        static void TolowerCase(string text) => Console.WriteLine(text.ToLower());


        /*29.5
        And it's important that the signature of the delegate: type and parameters are the same for all the methods.
            In our case:
                            type(type param);
        public delegate void StringDelegate(string text);
        static void ToUpperCase(string text);
        static void TolowerCase(string text); 
        */
        /*Example: 
        If I change the string to be an int then this delegate will not work for the ToUpperCase
              //static void ToUpperCase(int text) => Console.WriteLine(text.ToUpper());
        Then we got to Main(),  click by the right on ToUpperCase, and we get the error: 
        "CSO123: No overload for 'ToUpperCase' matches the delegate 'StringDelegate' ".
        //So,the  void ToUpperCase   would have a parameter as string.
        */
        //So this is how we can create pointers to different methods using a delegate.


        /*29.6---------------------------------------------------------------------------------------------------------
        But most importantly we said that, we can use a delegate to pass a function as a parameter for another function.
        Let us create a function now, that takes as a parameter a delegate.*/
        static void WriteOutput(string text, StringDelegate strD1)
        {
            Console.WriteLine($"\nBefore: {text}");
            strD1(text); //use the delegate to show the re4sult after we point to certain function

        }


    }//Program
}//namespace