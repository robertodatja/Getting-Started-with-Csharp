//The Hashtable collection is used to store key-value pairs.
//Key and a value into the hash table and value can be of any data.
//Also Key cannot be null, but values can be.

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Csharp26_Hashtable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //26.1 Create  Hashtable named ht1
            Hashtable ht1 = new Hashtable();
            //Initialize1: by using Add(key,value) method
            ht1.Add(1, "One"); 
            ht1.Add(2, "Two");

            //26.2
            Hashtable ht2 = new Hashtable() 
            //Initialize2:  by using the object initializer syntax.
            {
                {3, "Three" },
                {"another", 78.5 }
            };

            //26.3
            Dictionary<int,string> myD = new Dictionary<int,string>();        
            myD.Add(1, "One");
            myD.Add(6, "Number 6");
            //Initialize3: by using a dictionary.
            Hashtable ht3 = new Hashtable(myD);
            //26.4
            //If you want to retrieve the Value of an existing Key of the hash table you can use the indexer.
            string valueOfOne = (string) ht3[1]; //convert from type of object to string
            Console.WriteLine($"Value of One is: {valueOfOne}\n");

            /*26.5.1 
            Hashtable elements our key-value pairs stored in DictionaryEntry.
            So this means, we can cast each element in Hashtable to a DictionaryEntry.*/
            Console.WriteLine("\nElements:");
            foreach (DictionaryEntry element in ht3)
            {
                Console.WriteLine($"Key: {element.Key}, Value: {element.Value}");
            }
            //
            //26.5.2  You can also get only the Keys of a Hashtable.
            Console.WriteLine("\nKeys:");
            foreach (var Key in ht3.Keys) { Console.WriteLine(Key); }
            //
            //26.5.3 You can also get only the Values of a Hashtable.
            Console.WriteLine("\nValues:");
            foreach (var Value in ht3.Values) {   Console.WriteLine(Value); }

            //26.6 If you want to remove a certain element from the Hashtable you can use the Remove(Key) method.
            ht3.Remove(1); //delete the element which has Key=1
            Console.WriteLine("\nElements:");
            foreach (DictionaryEntry element in ht3) { Console.WriteLine($"Key: {element.Key}, Value: {element.Value}"); }

            //26.7
            //If you want to check for certain value exist, then you can use the Contains() methods
            Console.WriteLine($"\n\nElement with Key=1 exists: {ht3.Contains(1)}");
            Console.WriteLine($"Key 1 exists: {ht3.ContainsKey(1)}");
            Console.WriteLine($"Value'Number 6' exists: {ht3.ContainsValue("Number 6")}");

            //26.8
            // If you want to remove everything from the Hashtable you can the Clear() method
            ht3.Clear();
            Console.WriteLine("\n\nThe Hashtable is empty!");
            foreach (DictionaryEntry element in ht3) { Console.WriteLine($"Key: {element.Key}, Value: {element.Value}"); }
        }
    }
}