using Demo.Interface_Example01;
using Demo.Interface_Example02;

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
