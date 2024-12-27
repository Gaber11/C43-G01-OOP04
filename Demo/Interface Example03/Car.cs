using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example03
{
    class Car : Vechale, IMoveable
    {
        public void Backword()
        {
            Console.WriteLine("Car Is Moved Backward ");

        }
            public void Forword()
        {
            Console.WriteLine("Car Is Moved Forward ");

        }

        public void Left()
        {
            Console.WriteLine("Car Is Moved Left ");
        }

        public void Right()
        {
            Console.WriteLine("Car Is Moved Right ");
        }
    }
}
