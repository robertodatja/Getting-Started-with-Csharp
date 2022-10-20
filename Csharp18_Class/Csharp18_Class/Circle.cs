using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp18_Class
{
    /*18.2 So let us start with the access modifiers that has defined this class to be a public one 
    which means that now this class is accessible from any other class within our solution.*/
    public class Circle
    {
        //18.3 Let us define a field since this is a circle related class
        private const double PI = 3.14; //To get a more precise value use Math.PI;


        //18.5 Now that we created the constructor let us create a property 
        //Press prop - Press double Tab
        public double Radius { get; set; }

        //-----------------------------------------------------------------------------------------------------------
        //18.4 Define First Constructor
        //Press ctor - Press double Tab
        public Circle()
        {
            Console.WriteLine("Circle() created");  
        }

        /*18.7 Second Constructor
        Let's create another constructor as well because in a class we can have different constructor 
        So we can have the default constructor without any parameters | a phrase | constructors that have parameters
        And we assign these parameters when we initialize the object.
        */
        public Circle(double radius)
        {
            Radius = radius; //we assign   this radius value    to     our  Radius property.
        }

        /*18.6 Now let us create a method 
        which you are going to use to calculate the area.
        It's to be the access modifier it's going to be of type double because we want to return a double value.*/
        public double GetArea() => PI * Math.Pow(Radius, 2);
        public double GetPerimeter() => PI * PI * Radius;
    }
}
