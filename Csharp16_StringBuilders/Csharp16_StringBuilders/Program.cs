/* 16
A String instance is immutable 
means that once we create a string object we cannot modify the value of the string object in the memory!
So any operation that appears to modify the string 
it will discard the old value and it will create new instance in memory to hold the new value.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Csharp16_StringBuilders
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            //16.1
            string hello = "Hello World";
            var hi = hello;
            hello = "hello there";
            /*
            When I compared the references they are going to be different.
            Which means that eventhough we have changed the value of the string,  the old value is still there but without a reference.
            */
            Console.WriteLine(ReferenceEquals(hello, hi)); //It'll give False

            /*16.2 Solution:
            C# introduced string builder. A string builder is a dynamic object that allows you to expand the number of characters in a string.
            It doesn't create a new object in the memory but dynamically will expand the memory to accommodate the modified strings.*/
            //So let us initialize a StringBuilder
            StringBuilder sb = new StringBuilder("this is a sring builder");
            var sbNew = sb;
            sb.Append(" this is additional");
            //Check references
            Console.WriteLine(ReferenceEquals(sb, sbNew)); //True
                                                           //So this means that C-Sharp did not create a new instance for the new value of our string builder.

            //16.3
            /*Important Methods of a StrtingBuilder
            Append() -will simply append values to the end of a string.
            AppendFormat() -will append formatted values to the end.
            Insert() -insert a string at a specified index.
            Remove() -remove the specified range and the last one is the replace
            Replace() -replace chars with new ones
            */
            Console.WriteLine("\n");
            //AnotherExample:
            StringBuilder sb2 = new StringBuilder();
            sb2.Append("I have ");
            Console.WriteLine(sb2); //I have
            sb2.AppendFormat("{0:C}", 25); /*way of formatting currencies */
            Console.WriteLine(sb2); //I have $25.00
            sb2.Insert(0, "John:");
            Console.WriteLine(sb2); //John:I have $25.00 
            sb2.Remove(1, 2);
            Console.WriteLine(sb2); //Jn:I have $25.00
            //Because we started from the index one but the string builder is based on the index 0.
            sb2.Replace("have", "had");
            Console.WriteLine(sb2); //Jn:I had $25.00
        }
    }
}


/* Remember that:
1. StringBuilder is mutable
2. StringBuilder performs faster than strings when appending multiple string values.
3. Initialize StringBuilder as class with a parameter or without a parameter.
   StringBuilder sb = new StringBuilder();
4. Use StringBuilder when you need to append for more than 3 or 4 strings.
5. Use the Append() method to add or append strings with StringBuilder.
6. Use ToString() method to get the string from StringBuilder. */