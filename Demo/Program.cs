using Demo.Interface_Example01;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 02 Interface - Example 01
           // IMyType myType;
            //Declare for reference from type "ImyType" , containing Garbag Value
            //CLR will allocate 4 bytes in the stack .
            //CLR will allocate 0 bytes in the Heap .

            //myType = new IMyType(); //invalid ==> U Can't Create an object from interface

           // MyType myType = new MyType();
           // myType.MyProperty = 10;
           // myType.MyFunction();
           //// myType.Print();
           //IMyType refFromInterface = new MyType();
           // refFromInterface.MyFunction();
           // refFromInterface.Print();

            #endregion

        }
    }
}
