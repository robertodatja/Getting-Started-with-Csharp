//Stack stores elements|items in LIFO
//C-Sharp includes a generic and non-generic Steg. And here we're going to learn about the non-generic stack.
using System;
using System.Collections;
using System.Collections.Generic;

namespace Csharp24_Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //24.1  Let's create the first stack
            Stack mystack = new Stack();
            //24.2 Add lelements
            mystack.Push("Hello there");
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            mystack.Push(4.5);
            mystack.Push(null);
            mystack.Push("Top of Stack");
            //Show results
            foreach (var stackItem in mystack)
            {
                Console.WriteLine(stackItem);
            }

            /*24.3
            Peek() method returns  the last | the top most  value from the stack.
            Calling Peek method on empty stack, it will throw InvalidOperationException.*/
            Console.WriteLine( $"\nThe peak of the stack is -  {mystack.Peek()}" );

            /*24.4
            Pop() method removes the top element and return it in the same time.
            If you call Pop() on an empty stack the same way like the Peek() it'll raise an InvalidOperationException. */
            Console.WriteLine($"\n\nStack length =  {mystack.Count}"); //number of elements of mystack
            //
            Console.WriteLine($"The peak of the stack is -  {mystack.Pop()}"); //deletes the top element in our case it deletes: "Top of Stack" 
            mystack.Pop(); //deletes the top element in our case it deletetes: null
            Console.WriteLine($"The peak of the stack  after uses Pop() 2 times  is -  {mystack.Peek()}");
            //
            Console.WriteLine($"Stack length =  {mystack.Count}");

            //24.5
            //if you want to check for certain elements exist within a stack you can use the Contains() method.
            Console.WriteLine($"\n\nmystack has a 3 => {mystack.Contains(3)}");

            /*24.6
            So we learned that to remove the elements one by one we can use the pop method starting from the element at the top
            But if you want to remove all the elements from a stack, you can use the Clear() method. */
            mystack.Clear(); //makes stack empty
            Console.WriteLine($"\n\nmystack has a 3 => {mystack.Contains(3)}");
        }
    }
}

/* Important notes:
1.Stack stores the values in LIFO style.
2.Push() method to add elements into a stack.
3.Pop() method returns & removes elements from the top of the stack 
4.Peak() method always returns the top most element in the stack.
If you use the Pop()|Peak() method in an empty stack then an exception is going to be throw. */