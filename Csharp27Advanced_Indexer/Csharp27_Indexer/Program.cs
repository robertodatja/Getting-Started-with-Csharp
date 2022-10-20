/*An Indexer is a special type of property
 -that allows instances of a class or structure to be accessed(indexed) the same way as an array for its internal collection.
-And we can get or set the indexed value without explicitly specifying a type or instance member
-To define an Indexer, we need to 
                      1.Declare an array to store the data elements
                      2.Define the indexer to allow client code to use the [ ] notation.

-An indexer is just a class.
-But in this class we get to define the capacity and the getter and setter's.

-Indexers are used to treat the objects as an array.
-Indexers are usually known as smart objects|arrays.
*/

using System;
using System.Runtime.Intrinsics.X86;

namespace Csharp27_Indexer
{
    //--------------------------------------------------------------
    //27 Create our Indexer  named FirstIndexer or SampleCollection
    public class FirstIndexer
    {
        //27.1 Create an array with length 60
        private int[] array = new int[60];
        
        //27.2 We need to find the indexer which is used to allow client code to use the [ ] notation.
        public int this[int i]  
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }
    //------------------------------------------------------------

    //27.6 Let's say you want the indexer not to store integer values but string values.
    public class SecondIndexer
    {
        private string[] array = new string[60];
        public string this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }
    //------------------------------------------------------------

    public class Program
    {
        public static void Main(string[] args)
        {
            //27.3 If you want to use the firstIndexer.
            FirstIndexer firstIndexer = new FirstIndexer();
            //27.4 To set the values
            firstIndexer[0] = 25;
            //27.5 Show result to the screen
            Console.WriteLine($"The value = {firstIndexer[0]}");

            //27.7
            SecondIndexer secondIndexer = new SecondIndexer();
            secondIndexer[0] = "25";
            Console.WriteLine($"\nThe value = {secondIndexer[0]}");
        }
    }
}