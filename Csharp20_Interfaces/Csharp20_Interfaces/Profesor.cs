using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp20_Interfaces
{
    //20.8 Let's do the same(like 20.6) for Student.cs class
    public class Profesor : IPerson, ITest //20.8 20.10
    {
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

        //20.11
        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}