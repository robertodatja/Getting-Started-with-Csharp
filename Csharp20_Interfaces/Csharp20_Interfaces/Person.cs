using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Csharp20_Interfaces
{
    /*20.5  Remove the existing implementations
    public class Person
    {
         public string FullName { get; set; }
         public int Age { get; set; }
         public virtual string GetDetails() => $"{FullName} of age {Age}";
         public string GetDetails(double height) => $"{FullName} of age {Age}";
    }
    */


    //20.6 and then inherit from the person interface.
    public class Person:IPerson 
    {
        //So when you inherit from an interface you need to implement all the properties methods and events.
        //So let us now import everything for the IPerson interface
        //So click into  Person:IPerson -choose implement interface and we get everything below:

        //20.6.2
        /*We can also change the properties to have only the getters and setters
        public string FullName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } */
        public string FullName { get; set; }
        public int Age { get; set;
        }
        //20.6.1
        /*By default the implementation is going to throw exceptions let us replace these code with the old one.
        public string GetDetails() { throw new NotImplementedException(); }
        public string GetDetails(double height) { throw new NotImplementedException(); } */
        public string GetDetails() => $"{FullName} of age {Age}";
        public string GetDetails(double height) => $"{FullName} of age {Age}";
    }

}