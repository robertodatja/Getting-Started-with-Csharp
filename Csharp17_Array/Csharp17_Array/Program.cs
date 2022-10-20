/*We learned in part 7 that a variable can hold only one single value

Suppose you want to store a hundred different values.
Now this means that you would have to create a hundred different variables. 
But in some applications you might need even more than that. 
To overcome this problem, C-Sharp has introduced arrays.

An array is a group of variables of the same type. 
And each variable or dataTtem in an array is called an element of that array.
The data types of the elements may be any value  data type like char|int|string|double

An array can be declare using a type name followed by square brackets []
*/

using System;
using System.Diagnostics.Metrics;

namespace Csharp17_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*17.1 Example
            int[] numbers;
            string[] studenNames;
            double[] studentResults;
            */

            //17.2 Declared and Initialized at the same time
            string[] studenNames = new string[10]; //10 is the length of numbers array

            double[] studentResults = new double[4]
            //17.3  Add the values at the same time.
            {
                5, 6.5, 10, 11 //values|elements of studentResults array
            };

            /*17.4
            But of course you don't have to always provide the data when you initialize the object 
            Because arrays can be initialized after you declare them */
            int[] numbers = new int[5];
            numbers[0] = 2;
            numbers[1] = 14;
            numbers[2] = 40;
            numbers[3] = 8;
            numbers[4] = 10;

            //17.6 To do basic operations on arrays we can use different helper classes.
            //Array.Sort(numbers);  //sort by increasing
            Array.Reverse(numbers); //reverse from the end into the begin

            //17.5 Show to users
            //17.5.1 for loop
            //17.5.2
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

/* Remember that an array:
1. Stores values starting with 0-based index 
2. The size of an array must be specified while initialization
3. Values can be accessed using an indexer
4. Can be single dimensional,  multi-dimensional or jagged array

Array Helper Class 
     includes utility methods 
                       for arrays

So in our case we just thought about the sort and reverse methods.
But if you want to find out more about this class:
You can simply write click |hoover to Array keyword
Then go to definition.
Then you'll  see the other properties and methods that you can use with the array.
*/