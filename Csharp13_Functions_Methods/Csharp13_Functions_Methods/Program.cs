public class Program
{
    public static void Main(string[] args)
    {
        //Step3
        /* Calling a function
        <Name>(<parameters>)
        */
        double firstSum = AddNumbers(12.7, 16.35);
        Console.WriteLine($"FirstSum = {firstSum}");

        double secondSum = AddNumbers(9.5, 10);
        Console.WriteLine($"SecondSum = {secondSum}");

        Hello();
    }


    /*13
    A function allows you to encapsulate a piece of code and then call that code from the other parts of your application.
    For example: You are in a situation where you are writing the same code over and over again which does the same thing.
    So in this case you will create a function and then reuse it whenever you need it.
    They are basically declared like this: 
    <visibility> <return type> <Name> (parameters){
    {
     //code goes here
    }
     */

    //Step1
    //public  double AddNumbers(double firstNr, double secondNr)
    //For this to work I need to change the signature from public double to public static double.
    public static  double  AddNumbers(double firstNr, double secondNr)
    {
        return firstNr + secondNr;
    } 
    //The shortest way:
    //public static double AddNumbers(double firstNr, double secondNr) => firstNr + secondNr;

    //Step2
    public static void Hello()
    {
        Console.WriteLine("Hello from a void function!");
    }
}