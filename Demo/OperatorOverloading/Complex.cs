using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.OperatorOverloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
        #region Operators Overloading

        //Operators Overloading: Must be non private class member function
        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ??0) + (Right?.Real ??0),
                Imag = (Left?.Imag ??0) + (Right?.Imag ??0)
            };
            //left?.Real
            //Left !=null? Left.Real:null
        }

        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0)
            };
            //left?.Real
            //Left !=null? Left.Real:null
        }

        #endregion

    }
}
