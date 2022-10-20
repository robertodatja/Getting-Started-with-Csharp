
/*
Arrays are used to group a set of related objects.
We could create a set of any data type and we can access the elements using indexes.

Collections are similar to Arrays 
But collections provide a more flexible way of working with a group of objects.

For example:
In Arrays you need to define the number of elements in an array when the array was declared.
But in collections you don't need to define the size of the collection beforehand.
You can add elements or even remove them from the collection at any point of time. 
Every collection class implements the IEnumerable interface.
So values from the collection can be accessed using a ForEach loop.
We have 2 types of collections.
1.Generic - Lists _is a collection which has items of similar type. (Ex: BookStore, which has only books)
2.Non Generic - ArrayLists (Ex: Supermarket, which has items of different types)

The System.Collections namespace includes following non-generic collections:
-ArrayList -stores objects of any type like an array.
-SortedList -stores key & value pairs.
-Stacks -stores the values in LIFO style (Last In First Out).
-Queue -stores values in FIFO style (First In First Out).
-Hashtable -stores key & value pairs.
 */

using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Csharp20_21__Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*22
            An ArrayList is a non-generic type of collection in C#.
            It can contain elements of any datatypes and it's similar to an array, Except that it grows automatically as you add items to it.
            Like an array you don't need to specify the size of ArrayList
            */
            //22.1Example:
            ArrayList myValues = new ArrayList();
            myValues.Add(10);
            myValues.Add("This is a string");
            myValues.Add(12.25);
            //So we see that in an ArrayList we can add any type of data.

            //22.2
            //In an ArrayList except single that we can add a range of values.
            myValues.AddRange( new ArrayList(){"John", 24, 78.78} ); //add a new ArrayList

            //22.3
            //Add and AddRange add in the end, what if we want to add in the certain position? -use Insert(position, vlue)
            myValues.Insert(1, "This is the First Index");
            myValues.Insert(3, "This is the Third Index");
            myValues.InsertRange(5,new ArrayList() { "Berti", 29, 1993.2022 });

            //22.4
            myValues.RemoveRange(5, 3); //delete 3 items(values) in position 5,6,7
            myValues.Remove("This is the First Index");
            myValues.RemoveAt(0); //delete the item in postion 0

            /*22.5
            Now if we right click on ArrayList - then go to definition.
            We see that ArrayList inherits from IEnumerable - which means that we can use the ForEach loop to iterate through all the values.
            public class ArrayList : ICollection, IEnumerable, IList, ICloneable */
            //Example, Display all the items to the screen
            foreach (var value in myValues)
            {
                Console.WriteLine(value);
            }


            //22.6 ----------------------------------------------------------------------------
            //Let's create a new ArrayList called AList2
            Console.WriteLine("\n AList2 UnSorted");
            ArrayList Alist2 = new ArrayList();
            Alist2.Add(12);
            Alist2.Add(13); 
            Alist2.AddRange(new ArrayList() { 5, 7, 4, 8, 9, 23});
            foreach (var item in Alist2) { Console.WriteLine(item); }
            //22.6
            Console.WriteLine("\n AList2 Sorted in ascending way ");
            Alist2.Sort();
            foreach (var item in Alist2) { Console.WriteLine(item); }
            /*We get an exception. And that's right because when you want to use the Sort or Reverse method in an ArrayList 
            You need to make sure that you have only elements which have the same datatype. Now go back to AList2 
            From Alist2.Add(13.4); Update to  Alist2.Add(13); Now all elements are int */
            //22.7
            Console.WriteLine("\n AList2Sorted then Reversed ");
            Alist2.Reverse();
            foreach (var item in Alist2) { Console.WriteLine(item); }
            /*22.8
            Contains() method
            checks whether a specified element exists in the ArrayList or not. It returns true if it exists, otherwise false */
            Console.WriteLine($" 12 exists in the AList2 - {Alist2.Contains(12)}");
            Console.WriteLine($" 29 exists in the AList2 - {Alist2.Contains(29)}");
            /*22.9
            If you want to delete all the elements, you can use the Clear() method */
            Alist2.Clear();
            foreach (var item in Alist2) { Console.WriteLine(item); }
            Console.WriteLine("\n AList2 is empty!! ");

            /*22.10
            It is important to mention that an ArrayList allocates memory for 8 items whenever an object is created 
            And when a 9th item is added, then memory for another 8 items are added.
            And to verify this we then use the Count and Capacity methods. */
            Alist2.Add(22);
            Alist2.Add(23);
            Console.WriteLine($"Count - {Alist2.Count}"); //2, because we added 2 items
            Console.WriteLine($"Capacity - {Alist2.Capacity}"); //8 by default
            //22.10.2 
            Alist2.Clear();
            Alist2.Add(2);
            Alist2.Add(23);
            Alist2.Add(10);
            Alist2.Add(43);
            Alist2.Add(202);
            Alist2.Add(67);
            Alist2.Add(54);
            Alist2.Add(89);
            Alist2.Add(14);
            Console.WriteLine($"Count - {Alist2.Count}"); //9, because we added 9 items
            Console.WriteLine($"Capacity - {Alist2.Capacity}"); //16=8*2, because 9>8
        }  
    }
}

