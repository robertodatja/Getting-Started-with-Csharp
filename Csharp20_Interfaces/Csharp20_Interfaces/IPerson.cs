using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Csharp20_Interfaces
{
    public interface IPerson //make this interface accessible (public) from anywhere within this project.
    {
        /*20.2
        Now next we need to define all the members so properties methods and events.
        Let's go to Person class and copy all properties and paste here:
        //properies
        public string FullName { get; set; }
        public int Age { get; set; }
        //methods
        public virtual string GetDetails() => $"{FullName} of age {Age}";
        public string GetDetails(double height) => $"{FullName} of age {Age}";
        */

        /*20.3
        Now we said that an interface cannot have any implementation. It just has the declaration of the members.
        So let us start with the method and remove the implementation:
        public string FullName { get; set; }
        public int Age { get; set; }
        public virtual string GetDetails();//20.3
        public string GetDetails(double height);//20.3 */

        /*20.4
        It's 'also important to mention that an interface cannot include private members, because all the members are public by default.
        So let us remove all the public access modifiers from all the interface members and let us remove the virtual as well.*/
        string FullName { get; set; }
        int Age { get; set; }
        string GetDetails();
        string GetDetails(double height);
    }

    //20.9
    //But in differences from the clases you can have more than one interface to inherit from
    //So let us just go to the IPerson interface and create another one for that writing here public interface
    public interface ITest
    {
        // then just define your method with no return type and name it test.
        void Test();
    }
    //20.10 Then add ITest in Profesor.cs -> public class Profesor : IPerson, ITest
    //20.11 Then import from ITest interface
}