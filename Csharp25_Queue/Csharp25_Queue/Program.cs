/*A Queue stores the elements in FIFO style. It is basically the opposite of a stack collection.
It's non-generic collection.So we can add element of any datatype.It allows multiple now and duplicate values.
Enqueue()   add elements.
Dequeue()   returns and removes top most element.
Peek()      returns, but does not remove top most element.
Dequeue() & Peeek() on an empty queue throws an exception.*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace Csharp25_Queue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //25.1 Let's create the first queue
            Queue myQueue = new Queue();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(31);
            myQueue.Enqueue("This is my string");
            myQueue.Enqueue(null);
            myQueue.Enqueue("This is the last value");
            //Show result
            foreach (var item in myQueue) 
            { 
                Console.WriteLine(item); 
            }
            //25.3
            Queue secondQueue = new Queue(myQueue); //SecondQueue = myQueue

            /*25.2
            Dequeue retrieves the top most item|element in a Queue collection & also removes the item from the top of the queue.
            It's also important to mention that calling the Dequeue() on an empty queue will throw an InvalidOperationException.
            So you need to always make sure that the totalCount is greater than 0 before you call the Dequeue. */
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine($"Number of Elements = {myQueue.Count}");
            while (myQueue.Count > 0) 
            {
                Console.WriteLine(myQueue.Dequeue());//delete items one by one 
            }
            Console.WriteLine($"Number of Elements = {myQueue.Count}");


            /*25.3
            If you want to get the firstItem from a Queue collection without removing it from the Queue, then use the Peek()
            And calling the Peek() & Dequue() methods on an empty Queue collection will always throw a runtime exception.*/
            //Example:
            Console.WriteLine("\n==========================================");
            Console.WriteLine($"Number of Elements = {secondQueue.Count}");
            Console.WriteLine($"The peak of secondQueue is: {secondQueue.Peek()}"); //we get the secondQueue[0], so no elements were removed from secondQueue
            Console.WriteLine($"Number of Elements = {secondQueue.Count}");

            //25.4 The same way if you want to check if a value exists, then you can use the Contains() method.
            Console.WriteLine($"Value 30 exists in secondQueue => {secondQueue.Contains(30)}");

            //25.5
            //If you want to remove all the elements without using the Dequeue(), because it removes them one by one starting from the first item.
            //You can use the Clear() method.
            secondQueue.Clear();
            Console.WriteLine($"Number of Elements = {secondQueue.Count}");

        }
    }
}