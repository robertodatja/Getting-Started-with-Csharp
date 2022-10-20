/*Inheritance is used to make applications faster and simpler.
Because with inheritance, we can build several types based on a single abstraction.
Inheritance defines which is the base or the parent class and which is child one.
A child class is a clASS that inherits from Base/Parent class.
In C# The ultimate base class is the object class. 
//Now let us go to Visual Studio and learn about inheritance by defining different classes.*/

using System;
namespace Csharp19_Inheritance_Polymorphysm
{
    public class Program
    {
        public static void Main(string[] args)
        {
        //19.6
        /*Let's create 3 different objects. And let's assign values to all of them.
        Person person = new Person()        { Age = 15, FullName = "John Smith" };
        Profesor profesor = new Profesor()  { Age = 45, FullName = "Jimy Snack" };
        Student student = new Student()     { Age = 18, FullName = "Joe Doe" };

        Now we have defined the properties for all the objects.
        For the Personclass, we know that it has 2 properties: Age & FullName 
        //
        But we see that we can use the same properties for the Professor and Student.
        And the reason why we can do that is 
        Because in the Professorclass we have inherited from the Personclass and in the Student class we have done the same.
        //
        So now we are inheriting from the PersonBaseclass which means that we have access to the properties & the methods.
        But other than the properties of the Personclass we can use the properties that we have defined within these classes as well.
                                                                                 Examples:
        Profesor profesor = new Profesor()  { Age = 45, FullName = "Jimy Snack", Subject = "Math"};
        Student student = new Student()     { Age = 18, FullName = "Joe Doe",    Grade = 12};
        */
        //----------------------------------------------------------------------------------------
        //19.6
        Person person = new Person() { Age = 15, FullName = "John Smith" };
        Profesor profesor = new Profesor() { Age = 45, FullName = "Jimy Snack", Subject = "Math" };
        Student student = new Student() { Age = 18, FullName = "Joe Doe", Grade = 12 };
        //19.7
        //We can use the same method.Examples:
        Console.WriteLine(person.GetDetails());
        Console.WriteLine(profesor.GetDetails());//We can do the same for a Professor because we're inhereting from the Person
        Console.WriteLine(student.GetDetails()); //We can do the same for a Student because we're inhereting from the Person
                                                 //But currently to get the details for each object. You 're using the GetDetails() method in the Person.cs class.
        }
     }
}