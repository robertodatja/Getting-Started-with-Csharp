//SortiedList collection  stores  key-value pairs in the ascending order of the key.
using System;
using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel;
using System.Reflection;
using System.Collections;

namespace Csharp23_SortedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //23.1
            //Let's create our first SortedList
            SortedList sl1 = new SortedList();
            /*
            Click right on SortedList and then go to the definition we will see that
            SortedList class  inherits from (implements) the IDictionary & ICollection interfaces,
            which means that the elements can be accessed both by key and by index. 
            Keys can be all int|doubl|string 
            But you cannot add keys of different types in the same SortedList.
            */

            //23.2
            //Now let us add some items to our Sortedlist ls1
            sl1.Add(3.1, "Number three");
            sl1.Add(4.1, "Number four");
            sl1.Add(1.1, "Number one");
            sl1.Add(5.1, "Number five");
            sl1.Add(2.1, "Number two");
            //sl1.Add("2.1", "Number two");  -> error
            //sl1.Add(2, "Number two");      -> error
            //sl1.Add(null, "Number two");   -> error
            //
            //Show the result FirstWay
            for (int i = 0; i < sl1.Count; i++)
            {
                Console .WriteLine(  $"Key: {sl1.GetKey(i)}, Value: {sl1.GetByIndex(i)}"  );
            }
            /*When we add elements to a SortedList the elements are sorted by default using the index in ascending order.
            It's important to know that internally,
            SortedList maintains 2 object arrays,  one for keys and another for values.
            So when you add a key-value pair, it runs a binary search using the key to find an appropriate index
            to store a key-value in respective arrays. It also rearranges the elements when you remove the elements from array*/

            //23.3
            //What if you want to get a specific value out of SortedList?
            string value =  (string) sl1[4.1] ;
            Console.WriteLine($"\n Value = {value}");

            //23.4
            //Show result TheShortestWay
            foreach (DictionaryEntry item in sl1)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            //23.5.1
            sl1.Remove(1.1); //delete the item which has key = 1.1
            Console.WriteLine("\n");
            foreach (DictionaryEntry item in sl1) { Console.WriteLine($"Key: {item.Key}, Value: {item.Value}"); }
            //23.5.2
            sl1.RemoveAt(0);//delete the item which has position|index = 0
            Console.WriteLine("\n");
            foreach (DictionaryEntry item in sl1) { Console.WriteLine($"Key: {item.Key}, Value: {item.Value}"); }

            //23.6
            //If you want to check if a certain value or a certain exits.
            Console.WriteLine("\n");
            Console.WriteLine( $"Contains() - {sl1.Contains(3.1)}" );
            Console.WriteLine( $"ContainsKey() - {sl1.ContainsKey(1.1)}" );
            Console.WriteLine( $"ContainsValue() - {sl1.ContainsValue("Number five")}" );
        }
    }
}





//Extra Lesson
/* https://learn.microsoft.com/en-us/visualstudio/ide/finding-and-replacing-text?view=vs-2022
To use multi-caret, 
press Alt+Shift+mouse click or Alt+Shift+. and then use Ctrl+Shift+arrow key to expand selections. 
Next, press Ctrl+C to copy the text in multiple selections. 
Use Alt+Shift+mouse click to create multiple carets for each line to paste in where you want them. 
Finally, press Ctrl+V to paste each line at its own caret.
*/