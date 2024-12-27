using Demo.Built_in_Interfaces;
using Demo.Interface_Example01;
using Demo.Interface_Example02;
using Demo.Interface_Example03;
using System.Globalization;
using System.Numerics;

namespace Demo.OperatorOverloading
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

            #region Part06 Why Clone Method Says it Makes a Shallow Copy
            //string[] Names01 = ["Gaber", "Ahmed", "Hager"];
            //string[] Names02 = ["Saber", "Mohmed", "Tag"];
            //Console.WriteLine($"Names01.GetHashCode(): {Names01.GetHashCode()}");
            //Console.WriteLine($"Names02.GetHashCode(): {Names02.GetHashCode()}");
            //Names02 = (string[]) Names01.Clone();
            ////Clone Method : will Generate New Object with new and Different Identity.
            ////              : This Object will have Same State [Data] of original object.[Shallow coppy of items]
            //Console.WriteLine("===============AFTER Deep Coppy: ----->  Names02 = (string[]) Names01.Clone() ");
            //Console.WriteLine($"Names01.GetHashCode(): {Names01.GetHashCode()}");
            //Console.WriteLine($"Names02.GetHashCode(): {Names02.GetHashCode()}");



            #endregion

            #region Part 07 Built-in Interfaces - ICloneable
            //Employee employee01 = new Employee() { Id = 10, Name = "Gaber", Salary = 8000, Department = new Department() { Code = 1001, Title = "Sales" } };
            //Employee employee02 = new Employee() { Id = 20, Name = "Omnia", Salary = 4000, Department = new Department() { Code = 2002, Title = "HR" } };

            //Console.WriteLine($"employee01.GetHashCode() {employee01.GetHashCode()}");
            //Console.WriteLine($"employee02.GetHashCode() {employee02.GetHashCode()}");
            //employee01 = employee02;
            //Console.WriteLine($"After Shallow Copy");

            //Console.WriteLine($"employee01.GetHashCode() {employee01.GetHashCode()}");
            //Console.WriteLine($"employee02.GetHashCode() {employee02.GetHashCode()}");

            //employee02 = (Employee)employee01.Clone(); //Deep clone with clone 2.1
            //// Clone Method : This Method Generate New Object with New and Different Identity
            ////              : This Object will Have the same state [data] of caller object
            //Console.WriteLine($"After Deep Copy");
            //Console.WriteLine($"employee01.GetHashCode() {employee01.GetHashCode()}");
            //Console.WriteLine($"employee02.GetHashCode() {employee02.GetHashCode()}");

            //Console.WriteLine($"employee01----> {employee01}");
            //Console.WriteLine($"employee02----> {employee02}");


            //employee02 = new Employee(employee01);  //Deep Copy 2.2

            //if (employee01.Department is not null)
            //    employee01.Department.Title = "Technical";

            //Console.WriteLine(" After This code: employee01.Name =Hitham; ");

            //Console.WriteLine($"employee01----> {employee01}");
            //Console.WriteLine($"employee02----> {employee02}");
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("-------------------------------");

            //Console.WriteLine(" After This code: Copy Constructor --> employee02 = new Employee(employee01);");
            //Console.WriteLine($"employee01.GetHashCode() {employee01.GetHashCode()}");
            //Console.WriteLine($"employee02.GetHashCode() {employee02.GetHashCode()}");

            //Console.WriteLine($"employee01----> {employee01}");
            //Console.WriteLine($"employee02----> {employee02}");


            #endregion

            #region Part 08 Built-In Interface ICompareable

            //int[] Numbers = [9, 5, 6, 7, 1, 2, 3, 4, 8];
            //Array.Sort(Numbers);

            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Employee[] employees =
            //    {
            //    new Employee(){Id=10 , Name = "Ahmed" , Salary = 9000},
            //    new Employee(){Id=11 , Name = "Mahmoud" , Salary = 8000},
            //    new Employee(){Id=12 , Name = "Mohamed" , Salary = 7000},
            //    new Employee(){Id=13 , Name = "Anas" , Salary = 6000}

            //};
            //Array.Sort(employees);
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}





            #endregion

            #region Part 09 Built-In Interface IComparer

            // Employee[] employees =
            //     {
            //     new Employee(){Id=10 , Name = "Ahmed" , Salary = 9000},
            //     new Employee(){Id=11 , Name = "Mahmoud" , Salary = 8000},
            //     new Employee(){Id=12 , Name = "Mohamed" , Salary = 7000},
            //     new Employee(){Id=13 , Name = "Anas" , Salary = 6000}
            // };
            //
            // Array.Sort(employees,new EmployeeComperer());
            //int[] Numbers = [1, 2, 3, 4, 7, 6, 9, 8];
            //Array.Sort(Numbers,new IntComperer());
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Part 10 Operators Overloading - Binary Operators

            //Complex c1 = new Complex(){ Real = 2,Imag= 4};
            //Complex c2 = new Complex() { Real = 3, Imag = 5 };
            //Complex c3 = default;  //Null
            //c3 = c1 + c2;
            //c1 = default;

            //Console.WriteLine($"C1 = {c1}");
            //Console.WriteLine($"C2 = {c2}");

            //Console.WriteLine($"{c1} + {c2} = {c3}");




            #endregion

            #region Part 11 Operators Overloading - Unary Operators
            //Complex C1 = new Complex() { Real = 2, Imag = 4 };
            //Complex C2 = new Complex() { Real = 3, Imag = 5 };
            ////  Complex C3 = default;  //Null

            //Console.WriteLine($"C1 = {C1}");
            //Complex C3 = ++C1;
            //Console.WriteLine($"After ++C1 = {C1}");

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
