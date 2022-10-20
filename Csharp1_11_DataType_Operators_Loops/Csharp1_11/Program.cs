//1&2
//Create first console app. //File->NewProject->C#->Console app

using System; //Include System namespace into app

namespace Csharp1_11
{  //namespace declaration //A namespace is a Collection of Classes
    class Program  //class declaration //The class Program contains all data and method definitions that Program uses.
    {
        static void Main(string[] args) //Methods define the behavior of the class //The Main method the Entry Point for all C# Programs.
        {
            Console.WriteLine("Hello world"); //WriteLine is a method of the console class defined in the System namespace.
            //This System causes the message Hello World to be displayed on the screen. Press ctrl+F5 button or go to debug.


            //3
            Circle circle = new Circle(); //create circle object 


            //4.DataTypes
            //C sharp is a strongly typed language. This means that you need to define the type of data that you want to store.
            string message = "Berti";
            // string catch = "Berti; //Get erroc because catch can't be a variableName, it is in System.
            bool boolVar = false;
            //Each data type except stringin object include a value range. Compiler will always give you an error if the value goes out of the pipes allowed range.
            Console.WriteLine($"Size of int {sizeof(int)}"); //This means that for each integer data type there are  4 bytes = 32 bits of memory allocated 
            Console.ReadKey(); //Press from Keyboard


            //5 DataType Categorized
            /*In C-sharp that data types are categorized based on how they store their values in a memory.
            C-Sharp include two categories value types and reference types of data type is of value type.*/
            int a = 20;
            int b = 15;
            a = b; //a=15
                   //REFERENCE
            string A = "#a123"; //reference= #A123, value="a"
            string B = "#b123"; //reference= #B123, value="b"
            A = B; //a="#b123"
            /*string A and string B the both point to the same value=b by assigning the reference in the final case we see that instead it creates
            a second copy other reference which refers to the same location in memory.
            Reference type variables are stored in a different area of memory called HEAP.
            This means that when a reference type variable is no longer used like a, in this case, it can be marked or garbage collection.
            Examples of reference types are classes objects arrays strings interfaces etc..*/


            //6.1 Conversion
            //.1 Implicit  1)smaller to LARGER datatypes       2) derived to BASE clases
            //.2 Explicit  LARGER to smaller datatypes  POSSIBLE data loss
            int num = 12345789;
            //long > int 
            long newNum = num; //First the Compiler implicitly conversions (without being truncated or rounded off)  the num from int to long,  then it assigns to newNum.  
                               //You can do the same for base classes as well.
            Console.WriteLine(newNum);
            //6.2
            /*However if a conversion cannot be made without a risk of losing information the compiler requires that
            you perform an explicit type conversion which is called a CAST. A CAST is a way of explicitly informing
            the compiler that you intend to make the conversion and that you are aware that data loss might happen.
            For example a conversion from tabel to integer requires a CAST. */
            double x = 1234.5;
            /*
            int va = x;
            We get an  Error. If hoover the mouseover here (va=x).It cannot implicitly convert a double to int.
            And this happens because double datatype is larger than integer at the time.*/
            //So we need to add a CAST in front of x.
            int va = (int)x;
            /*But in this case since you are converting a double to everything that's after the floating point we're lost.
            So we will have a truncated value.*/
            Console.WriteLine(va);


            //7 Variables
            //A variable is nothing but just a name given to a storage area that our program can manipulate.
            string emri = "Berti"; //7.1
            string mbiemri; mbiemri = "Datja"; //7.2
            string emer, mbiemer; //7.3
                                  //Variable's value must be assigned to a variable before using it. Otherwise we'll get the Error.


            //8 Constants
            /*Constant refers to a fixed value that the application cannot change during its execution 
            They are treated just like regular variables except that their values cannot be modified after their definition.*/
            //Example: Area of CIrcle
            const double pi = 3.14;
            double r = 5;
            double area = pi * r * r;
            Console.WriteLine("Area - {0}", area);


            //9.Operators are just symbols that are used to perform operations. C-Sharp comes with different types of operators:
            //Basic assignment, arithmetic, relational, logical, unary, tannery, bitwise and bit shift, Compound Assign.
            //9.1 The basic assignment operator: is used to assign values to variables and for this operator we use the equal sign. =
            //Example:
            int firstNr, secondNr;
            firstNr = 10; //Assigning a constant to a variable
            Console.WriteLine("First Number = {0}", firstNr);
            secondNr = firstNr; //Assigning a variable to a variable
            Console.WriteLine("Second Number = {0}", secondNr);
            //
            //9.2 Arithmetic operators are used to perform arthmetic operations such as addition subtraction multiplication division etc..
            //Example:
            double firstN = 5.4, secondNrr = 3.25, resut;
            int num1 = 26, num2 = 4, reminder;
            resut = firstN + secondNrr; //Addition operator
            Console.WriteLine("{0}+{1}={2}", firstNr, secondNrr, resut);
            resut = firstN - secondNrr; //Substraction operator
            Console.WriteLine("{0}-{1}={2}", firstNr, secondNrr, resut);
            resut = firstN * secondNrr; //Multiplication operator
            Console.WriteLine("{0}*{1}={2}", firstNr, secondNrr, resut);
            resut = firstN / secondNrr; //Division operator
            Console.WriteLine("{0}/{1}={2}", firstN, secondNrr, resut);
            reminder = num1 % num2; //Reminder operator
            Console.WriteLine("{0}%{1}={2}", num1, num2, reminder);
            //
            /*9.3 Relational operators are used to check the relationship between two operands.  ==, >=, ..
            So the relationship is true then the result will be true otherwise it will result in false.
            So relational operators return a bool value either false or true.*/
            //Example:
            bool result;
            int firstNrr = 10, secondnNr = 20;
            result = (firstNrr == secondNr);
            Console.WriteLine("{0}=={1} returns{2}", firstNrr, secondNr, result);
            result = (firstNrr > secondNr);
            Console.WriteLine("{0}>{1} returns{2}", firstNrr, secondNr, result);
            result = (firstNrr < secondNr);
            Console.WriteLine("{0}<{1} returns{2}", firstNrr, secondNr, result);
            result = (firstNrr >= secondNr);
            Console.WriteLine("{0}>={1} returns{2}", firstNrr, secondNr, result);
            result = (firstNrr <= secondNr);
            Console.WriteLine("{0}<={1} returns{2}", firstNrr, secondNr, result);
            result = (firstNrr != secondNr);
            Console.WriteLine("{0}!={1} returns{2}", firstNrr, secondNr, result);
            //
            //9.4 .Logical operators performs logical operations. || &&
            //Example:
            bool resultt;
            int firstNR = 10, secondNR = 20;
            resultt = (firstNR == secondNR) || (firstNR > 5); //OR operator
            Console.WriteLine(resultt);
            resultt = (firstNR == secondNR) && (firstNR > 5); //AND operator
            Console.WriteLine(resultt);
            //
            //9.5 Unity operators operates on a single operands which means that we can either increase or value decrease the value or change the logic of that value.
            //Example:
            int number = 10, resulT;
            bool flag = true;
            resulT = +number; Console.WriteLine("+number = " + resulT); //10 remains the same
            resulT = -number; Console.WriteLine("-number = " + resulT); //-10 change the sign
            resulT = ++number; Console.WriteLine("++number = " + resulT); //11 increment by 1
            resulT = --number; Console.WriteLine("--number = " + resulT); //10 decrement by 1
            Console.WriteLine("flag = " + (!flag)); //false
                                                    //
                                                    //9.6 Tannery operator operates on three. Or perhaps it is a shorthand for the if-then-else statement.
                                                    //Example:
            int numm = 10;
            string res;
            res = (numm < 0) ? "Greater" : "Not Greater";
            Console.WriteLine("{0} is {1}", numm, res);
            //
            //9.7 The bitwise and be achieved operators are used to perform bit manipulation operations. <<, >>, ...
            //
            //9.8 Compound assignment operators are used to assign different values to the defined variables. +=, *=, &=, ...
            //https://www.tutorialspoint.com/csharp/csharp_operators.html
            //Example:
            int numberR = 10;
            numberR += 5; //number= number+5; 
            Console.WriteLine(numberR);//15
            numberR -= 3; //number= number-3; 
            Console.WriteLine(numberR);//12
            numberR *= 2; //number= number*2; 
            Console.WriteLine(numberR);//24
            numberR /= 3; //number= number/3; 
            Console.WriteLine(numberR);//8
            numberR %= 3; //number= number%3; 
            Console.WriteLine(numberR);//2
                                       //
            numberR &= 10; //number= number&10;  2&10;  (0010)&(1010) = 0010   = 2
            Console.WriteLine(numberR);//2
            numberR |= 14; //number= number|14;  2|14;  (0010)|(1110) = 1110   = 14
            Console.WriteLine(numberR);//14
            numberR ^= 12; //number= number^12;  14^12; (1110)^(1100) = 0010   = 2
            Console.WriteLine(numberR);//2=0010 in Binary
                                       //
            numberR <<= 2; //number= number<<2; //grab 2 firstBits and place in the End, so we get 1000
            Console.WriteLine(numberR);//8=1000 in Binary
            numberR >>= 3; //number= number>>3; //grab 3 lastBits and place in the Begin, so we get 0001
            Console.WriteLine(numberR);//1=0001 in Binary


            /*10 Decisions statements are used to control the flow of execution of the code* 
            and these statements are used to execute a part of code based on conditions.
            If a condition is true then the code will be executed otherwise it won't in C-sharp.
            We have 4 major types of decision statements: 1.if 2.if/else 3.else/if 4.switch */
            //10.1 
            //if statements are used when you want to execute or exclude a piece of code if a certain condition is met or not 
            //Example
            int numberr = 10;
            if (numberr > 0)
            {
                Console.WriteLine("Tt's a positive number");
            }
            Console.ReadKey(); //stop if we run in debug mode
                               //
                               //10.2 Example
            int numberRr = 10;
            if (numberRr > 0)
            {
                Console.WriteLine("Tt's a positive number");
            }
            else
            {
                Console.WriteLine("Tt's NOT a positive number");
            }
            //
            //10.3 Example
            int numberi = 10;
            if (numberi > 0)
            {
                Console.WriteLine("Tt's a positive number");
            }
            //we can add as many conditions as we want.
            else if (numberi < 0)
            {
                Console.WriteLine("Tt's NOT a positive number");
            }
            else
            {
                Console.WriteLine("Tt's 0");
            }
            //
            //10.4
            //If a large number of if and else if statements are required to implement the logic it is more convenient to use switch statements.
            string day = "Tuesday";
            if (day == "Monday") { Console.WriteLine("It's Monday"); }
            else if (day == "Tuesday") { Console.WriteLine("It's Monday"); }
            else if (day == "Wednesday") { Console.WriteLine("It's Tuesday"); }
            else if (day == "Thursday") { Console.WriteLine("It's Wednesday"); }
            else if (day == "Friday") { Console.WriteLine("It's Friday"); }
            else { Console.WriteLine("It's weekend"); }
            //
            //Now this is not the best way to compare strings but that is not the intention of this part.
            //With a switch statement things get much easier.
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday");
                    break; //get out of switch
                case "Tuesday":
                    Console.WriteLine("It's Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday");
                    break;
                default:
                    Console.WriteLine("It's weekend");
                    break;
            }
            //
            //11
            //If you want to execute your code for a certain number of times or until a certain condition is met you can use the C-sharp loops.
            //We have 3 types of loops: for, while, do while.
            //11.1 The for loop is usually used when you already know the number of times that you want to repeat the execution of your code.
            // for(init; loop_condition; update-expression)
            //Example:
            for (int i = 1; i < 11; i += 2)
            {
                Console.WriteLine($"{i}-Hello from C#!");
            }
            //11.2 while loop the same like the for loop. It will keep on executing until a certain condition is met.
            //Example:
            int j = 1;
            while (j < 11)
            {
                Console.WriteLine($"{j}-Hello from C#!");
                j++;
            }
            //11.3
            //do while loop is similar to the While loop but in the do-I loop the test condition is put at the end of the loop
            //which means that the code inside the loop is executed at least one time.
            //Example:
            int k = 1;
            do
            {
                Console.WriteLine($"{k}-Hello from C#!");
                k += 3;
            }
            while (k < 11);
        }
    }

    //3
    /* C-Sharp is an object oriented programming language and by that we understand that the program built on top of C-Sharp 
    consists of different objects that interact with each other by means of actions 
    the actions that an object may take are called methods.*/
    class Circle //A Circle class used to build an circle object
    {
        //member variables
        double radius;
        double pi = 3.14;

        public void AcceptRadius()
        {
            radius = 4.5;
        }
        public double GetArea()
        {
            return pi * radius * radius;
        }
        public void ShowResults()
        {
            Console.WriteLine("Radius: {0}", radius);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}