using Demo.Interface_Example01;
using Demo.Interface_Example02;
using Demo.Interface_Example03;

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

            #region Part 03 Interface - Example 02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //PrintTenNumberFromSeries(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //Console.WriteLine("===================================================================================");
            //PrintTenNumberFromSeries(seriesByThree);

            //SeriesByFour seriesByFour = new SeriesByFour();
            //Console.WriteLine("===================================================================================");
            //PrintTenNumberFromSeries(seriesByFour);
            #endregion

            #region Part 04 Interface - Example 03
            // AirPlane plane = new AirPlane();

            //IMoveable moveable = new AirPlane();
            //moveable.Backword();
            //moveable.Forword();
            //moveable.Right();
            //moveable.Left();
            //IFlyable flyable = new AirPlane();
            //flyable.Backword();
            //flyable.Forword();
            //flyable.Right();
            //flyable.Left();
            //Console.WriteLine("====================================");
            //IMoveable moveabl = new Car();
            //moveabl.Backword();
            //moveabl.Forword();
            //moveabl.Right();
            //moveabl.Left();

            #endregion

            #region Part 05 Deep Copy Vs Shallow Copy

            //// int[] Arr1 = { 1, 2, 3};
            //// int[] Arr2 = { 4, 5, 6 };
            //// Console.WriteLine($"Arr01 GetHashCode: { Arr1.GetHashCode()}");
            //// Console.WriteLine($"Arr02 GetHashCode: {Arr2.GetHashCode()}");
            //// Arr2 = Arr1;
            //// 
            //// Console.WriteLine("After Shallow Copy =======> Arr2=Arr1");
            //// Console.WriteLine($"Arr01 GetHashCode: {Arr1.GetHashCode()}");
            //// Console.WriteLine($"Arr02 GetHashCode: {Arr2.GetHashCode()}");
            //// Console.WriteLine(Arr1[0]);
            //// Console.WriteLine(Arr2[0]);
            //// Arr1[0] = 100;
            //// Console.WriteLine(Arr1[0]);
            //// Console.WriteLine(Arr2[0]);
            //// Arr2= (int[])Arr1.Clone();
            //// Console.WriteLine("After Clone Copy =======> Arr2=(int[])Arr1.clone()");
            //// Console.WriteLine($"Arr01 GetHashCode: {Arr1.GetHashCode()}");
            //// Console.WriteLine($"Arr02 GetHashCode: {Arr2.GetHashCode()}");
            //// Arr1[0] = 50;
            //// Console.WriteLine(Arr1[0]);
            //// Console.WriteLine(Arr2[0]);
            ////-------------------
            ////This Object [1,2,3] has 2 reference [Arr1,Arr2] (اسمين دلع )
            ////This Object [4,5,6] Become Unreachable object.
            ////Shallow Coppy [سطحي ]
            ////Clone Method: will generate new object with new difference identity
            ////            : will the same state [Data] of the caller object.      
            ////-------------------





            #endregion
        }
        //static void PrintTenNumberFromSeries(Iseries series)
        //{
        //    if (series is null) return;
        //    for (int i = 0; i <= 10; i++)
        //    {
        //        Console.Write($"{series.Current}\t");
        //        series.GetNext();
        //    }
        //    series.Reset();
        //    Console.WriteLine();
        //}

    }
}
