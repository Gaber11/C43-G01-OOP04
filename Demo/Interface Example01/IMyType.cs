using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example01
{
    internal interface IMyType
    {
        //Defualt Access Modifier inside interface is "Public"
        //Private Access Modifier is not allowed inside the interface for Signature
        //What you can write inside the Interface?

        //1. Signature of Property.
        int MyProperty { get; set; }

        //2.  Signature of Method 
         void MyFunction();

        //3. Defualt Implemented Method allow [private] .
         void Print()
        {
            Console.WriteLine("Hello Defualt Implemnted Method :) ");
        }
    }
}
