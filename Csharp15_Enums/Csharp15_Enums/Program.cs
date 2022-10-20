/*Enum 
is a value type data type. It is used to declare a list of names integer constants.
It can be defined using the keyword directly inside: namespace|class|structure.*/

using System;
using System.Runtime.Intrinsics.X86;

namespace Csharp15_Enums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //15.3
            // If you want to see the value of a Enum
            Console.WriteLine(weekDays.Friday);
            Console.WriteLine((int)weekDays.Thursday);

            //15.4
            /*It is mainly used to make code more readable.
            So instead of writng: the first day, the second day, etc. 
            You can just write Monday and then you can defined that Monday stands as the first day of the week.
            So basically, makes the code more readable by giving related Constants a meaningful name.
            //
            You can do the same for the months:
            So instead of writing 1-12 or the month number you can just write January for the first one etc..
            It is also great when you want to test your code.
            //
            But it is important to mention that: The Enum cannot be used with a string type.
            So I cannot write: Monday = "1"
            //
            Enum is  an abstract class that includes static helper methods to work with Enums.
            Some of the main methods are:
            1. Get.Name() - Returns the name of the constant of the specified value of specified Enum.
            2. GetNames() - Returns an array of string name of all the constant of specified Enum.
            3. TryParse() - Converts the string representation of the name or numeric value of one or more Enumerated constants
                            to  an equivalent Enumerated object. The return value indicates whether the conversion succeeded.*/

            Console.WriteLine("GetName()");
            Console.WriteLine(Enum.GetName(typeof(weekDays), 5));

            Console.WriteLine("GetNames()");
            foreach (string str in Enum.GetNames(typeof(weekDays)))
                Console.WriteLine(str);

            Console.WriteLine("TryParse()");
            weekDays wdEnum;
            Enum.TryParse<weekDays>("3", out wdEnum);
            /*Checks for a value 3 in the weekdays in Enums and then if it exists it'll convert it to the real weekday display.
            So in this case since Wednesday has a value 3. It will check if it exists.
            So in this case we have defined it to be 3. Seems we have already 3 value in the weekdays. It's going to return Wednesday.*/
            Console.WriteLine(wdEnum);

        }

        //15.1
        //So let does define our enemy inside our program class.
        enum weekDays
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        /*15.2 
        If you hoover the Monday you'll see that the value is 0 because if you don't defined the number it'll start by default from 0.
        But if you want to change that you can just write in your Monday is equal to 1
        and then you're going to see that the next day's going to have to 2, 3, ..., and Sunday has the value 7. */
    }
}