using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example03
{
    class AirPlane : Vechale, IMoveable, IFlyable
    {
        void IMoveable.Backword()
        {
            Console.WriteLine("AirPlane Is Backword ");
        }

        void IMoveable.Forword()
        {
            Console.WriteLine("AirPlane Is Forword ");

        }
        void IMoveable.Left()
        {
            Console.WriteLine("AirPlane Is Moved Left ");

        }
        void IMoveable.Right()
        {
            Console.WriteLine("AirPlane Is Moved Right ");

        }
        void IFlyable.Backword()
        {
            Console.WriteLine("AirPlane Is Fly Backward ");
        }
        void IFlyable.Forword()
        {
            Console.WriteLine("AirPlane Is Fly Forward ");
        }
        void IFlyable.Left()
        {
            Console.WriteLine("AirPlane Is Fly Left ");
        }
        void IFlyable.Right()
        {
            Console.WriteLine("AirPlane Is Fly Right ");
        }
    }
}
