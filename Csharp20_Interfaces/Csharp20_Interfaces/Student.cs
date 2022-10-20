using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Csharp20_Interfaces
{
    //20.7 Let's do the same(like 20.6) for Student.cs class
    public class Student : IPerson
    {
        //20.8 you can still have your own members with your professor classes
        //For example (press prop..)
        public string Subject { get; set; }

        //20.7
        public string FullName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetDetails()
        {
            throw new NotImplementedException();
        }

        public string GetDetails(double height)
        {
            throw new NotImplementedException();
        }
    }
}
