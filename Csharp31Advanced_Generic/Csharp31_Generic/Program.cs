/*
Generics are the most powerful feature of C sharp. Generics were introduced in C# 2.0.
Generics allow you to define type-safe-data-structures without committing to actual data types.
This results in a significant performance boost and higher quality code because you get to reuse data
processing algorithms without duplicating type specific code.
A genetic clauss can be defined using the angle brackets <> 

But why should we use generics?  There are a lot of benefits in using generics 
Example: casting is not required for accessing each elements. Client code that uses generics is type safety to the execution.
//But most importantly: Code is not duplicated for multiple types of data.//
And of course in C sharp we have different built in collection classes that are generic.
So for example one of them is - the List class. 
List<T> collection
 */

using System;
namespace Csharp31_Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //31.2  Now let us create an object by using the generic class inside the Main() method.
            //Let's type of T string, name firstTest. So this way the Value (in row 29) has tHe type string.
            Test<string> firstTest = new Test<string>();
            firstTest.Value = "This is a string"; //And if we hover over the Value we see that it's of type String.
            firstTest.Details(); //Show the results

            //31.3  Now we can use the same class but we can change the type of T.
            Test<int> secondTest = new Test<int>(); //And if we hover over the Value we see that it's of type Integer.
            secondTest.Value = 5;
            secondTest.Details();

            /*31.4 
            List<string>  //T stands for the type of the element, here we choose string
            If you right click over the List- peak definition, we see that this class is a generic one.
            Other generic collections in C# are dictionary and SortedList.
            */
        }
    }

    /*31.1
    Create the public class Test. Then we need to use the <> to define a generic class.
    T stands for type because we said that in a generic class,
    We don't need to define the type because you define the type when you initialize an object using the generic classes. */
    public class Test<T>
    {
        //Define properties, press prop&doubleTab, type: T, name: Value
        public T Value { get; set; }

        //Define a method
        //public void Details() { Console.WriteLine($"Parameter type: {typeof(T)}, value: {Value}"); } //Way1
        public void Details() => Console.WriteLine($"Parameter type: {typeof(T)}, value: {Value}"); //Way2 the shortest way

    }
}