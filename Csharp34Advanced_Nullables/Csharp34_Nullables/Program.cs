using System;
using System.Reflection;

namespace Csharp34_Nullables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* 34.1
            In C# to evaluate type. We can not assign a null value. For example an integer.
            // int i = null; // we get an error: Cannot convert null to 'int' because it is a non-nullable value type 

            But C# 2.0 introduced nullable types, that allow you to assign null to value type variables.
            Declare nullable types using: nullable<T>  where T is a type.
            To nullable types, you can assign normal range of values as well as null values.
            For example:
            Nullable<int>  can be assigned any value from the minimum value  -2147483648 to maximum value 2147483647 or a null value.
            */

            //34.2.1  Let's create our first nullable integer
            Nullable<int> firstInt = null; 
            /*So we can assign a null to a valuetype datatype. Normally, a valuetype datatype expects us to set a value.
            But when we define it as a nullable then we can assign nULL as well.*/
            
            /* 34.2.2 Another short way of creating a nullable integer is by using ?
            Nullable<int>    is the same like    int?  */
            int? secondInt = null;
            //34.2.3
            int thirdInt = 32;


            /*We can use the null-coalescing operator ?? - to assign a nullable type - to a non nullable type.*/
            // 34.2.4
            //int fourthInt = secondInt; //we get a error:  Cannot implicitly convert type 'int?' to 'int'
            int fourthInt = secondInt ?? 0; // ?? means is secondInt null?  If yes then assign the value 0.
            //34.2.5
            int? fifthInt = -2;
            int sixthInt = fifthInt ?? 0; // ?? means is fifthInt null?  If yes then assign the value 0. Else assign the value of it.


            //34.3 Let's do the same with another datatype, for example the double
            Nullable<double> firstDouble = null;
            double? secondDouble = null;
            double thirdDouble = 12.24;


            //Show the results
            Console.Write($"Integer => first: {firstInt}, second: {secondInt}, third: {thirdInt}, fourth: {fourthInt}, fifth: {fifthInt}, sixth: {sixthInt}");
            Console.Write($"\nDouble  => first: {firstDouble}, second: {secondDouble}, third: {thirdDouble}");
        }
    }
}