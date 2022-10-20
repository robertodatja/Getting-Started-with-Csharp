/*A structure is a value type data type. Structures are used to represent a record.
//Example:
Suppose you want to keep track of the students in a school.
You might want to track: the first name, the last name and the grade etc for each student.
//Step0
So let us create our first structure: 
1. Go to the solution explorer -- right click on the project Csharp14Structures
2. Add -- New Item -- Class --Change name Student -- Add button
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Csharp14_Structures
{
    //Step1  Change to public struct
    public struct Student
    {
        //Step2:  Create members
        /*Write prop, Press double tab */
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        //Step4.2
        /*Write ctor, Press double tab*/
        //which is going to create the default constructor. Because a default constructor is automatically defined by the structure.
        //So let us change the default constructor to take some parameters.
        public Student(string fName, string lName, int grade)
        {
            //Let us assign these values to our variables.
            this.FirstName = fName;
            this.LastName = lName;
            this.Grade = grade;
        }

        //Step4.3
        public void ShowStudent()
        {
            Console.WriteLine($"{FirstName} - {LastName} - {Grade}");
        }
    }
}
