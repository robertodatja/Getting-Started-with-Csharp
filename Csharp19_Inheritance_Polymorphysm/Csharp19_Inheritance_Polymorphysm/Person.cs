using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp19_Inheritance_Polymorphysm
{
    public class Person
    {
        /*19.1
        So in Visual Studio I have already created a class named Person.cs
        I have defined two properties which are the FullName & Age and a method named GetDetails().
        Now we're going to use these base classes to generate other types.
        It's important that when you choose the base|parent class this as much inclusive as possible.
        //For example:
        With person we can define: a student, a teacher. Because eventhough a teacher and a student are different types,
        they all have a common abstraction which means that they're all persons
        and they all have Age, FullName and we are going to define a good detailed method as well.
        */
        public string FullName { get; set; }    
        public int Age { get; set; }
        //public string GetDetails() => $"{FullName} of age {Age}";

        /*19.9 
        Method Overriding is having in a child and parent class methods with the same name and signature.
        Let us see how we can override a method which means that we can use exactly the same method in the child class.But by modifying the outcome
        To be able to override a method in the Base class. First of all the method needs to be defined as virtual.*/
        public virtual string GetDetails() => $"{FullName} of age {Age}";

        /*19.8
        Suppose you want to use the same method (GetDetails() ) in the child classes but you just want to change it a little bit.         And this is when polymorphism in C-sharp comes into play:
        The word Polymorphism     means    having many forms
        And C-Sharp is a concept where a method can be defined more than one time.
        //
        Types of polymorphism:
        1. Method Overloading -means creating multiple methods in the class. It's having in the same class methods with the same name, but different signatures so different parameters.  
        2. Method Overriding 
        */
        //Let us create an overload method for the GetDetails() 
        //So we have the same name but it takes a partner double.
        public string GetDetails(double height) => $"{FullName} of age {Age}";//The response can be the same it doesn't matter
                                                  //but what's important is that they have the same name but different signatures.
                                                  //
    }
}