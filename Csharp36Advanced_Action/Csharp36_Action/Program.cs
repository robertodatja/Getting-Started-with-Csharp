/* Action is also  a delegate type  defined in the system namespace
Action delegate - is the same as - the Func delegate - except that the Action delegate does not return a value.
In other words an Action delegate  can be used with a method that has a void return type.

Important to mention that Action delegates:
1. can have 0-16 input parameters 
2. can also be used with an anonymous method or lambda expression.
*/

//36 Copy-Paste the code from Csharp35_Func

using System;
using System.ComponentModel;

namespace Csharp36_Action
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*36.2.
            1.Change the Func to action
            2.We need to define the input parameters. No return type & we have only 1 input parameter: the double number. So let us remove the second one
            3.Change the reference to be SQUARE & CUBIC methods
            4.To see the result we just remove|deltete Console.WriteLine as below:
            */
            Action<double> squareII = SQUARE; //reference to SQUARE
            squareII(2); //result

            Action<double> cubicII = CUBIC; //reference to SQUARE
            cubicII(2); //result

            /* TWO() method doesn't have a return type.
            That is why we can use the Action delegate and it doesn't have any parameter.
            So in this case we can simply remove everything and write just Action.*/
            Action twoII = TWO;
            twoII(); //result

            //The same way like TWO() method
            Action show = SHOW;
            show();//result
        }

        //Let's convert all the Func delegates to Action delegates:
        //36.1 Let's change all these signatures.
        //Let's change the double return type to void, then instead of returning the Math.Pow() - write Console.WriteLine( Math.Pow())
        static void SQUARE(double number) => Console.WriteLine(Math.Pow(number, 2));
        static void CUBIC(double number) => Console.WriteLine(Math.Pow(number, 3));
        static void TWO() => Console.WriteLine(2);
        static void SHOW() => Console.WriteLine("Hello there");
    }
}

//Click Alt+Shift & click with mouse  in some rows|lines to make changes