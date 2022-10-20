/* We have seen so far that we can create a class. But we cannot create a second class with the same name.
So within one project the class name needs to be unique.

However at one point Microsoft decided to change this with the introduction of something called partialclasses.
So this means that by using the partialclasses we can create two classes with a same name within the same namespace.
And this way two persons can work in the same class.

But why would we use the partialclasses instead of the standardclasses.
Because: Multiple developers can work simultaneously(at the same time) with a single class in separate files.
Example: When you work with a designer like the one in Visual Studio for instance the WindowsForms or WPF 
where all the automatically generated designer code  can be kept in one file, while your code is kept in another one.
*/

using System;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Csharp31_Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //32.3
            //Create an object out of the HelloClass.
            HellloClass hello = new HellloClass();
            //If we type in hello, We've reference to both methods:  HelloWorld & HelloUniverse.
            hello.HelloWorld();
            hello.HelloUniverse();
        }
    }


    /*32.1
    public class HellloClass { }
    public class HellloClass { } 
    //If we hover over the second one, we see that the namespace 'Csharp31_Generic' already has 'HellloClass'.
    //So we see that we cannot have two classes with the same name.*/

    //32.2
    //Change32.1 by adding partial. So now we've 2 classes with the same name within the same namespace.
    public partial class HellloClass 
    {
        //32.2.1 Have a method
        public void HelloWorld() => Console.WriteLine("Hello World");
    }
    public partial class HellloClass
    {
        //32.2.2
        public void HelloUniverse() => Console.WriteLine("Hello Universe");
    }

}