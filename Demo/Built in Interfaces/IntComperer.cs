using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Built_in_Interfaces
{
    class IntComperer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            int? NumbersX=(int?)x;  
            int? NumbersY=(int?)y;

          //  return NumbersX.Value.CompareTo(NumbersY.Value);
            return NumbersX is null ? (NumbersY is null ? 0 : -1): (NumbersY is null ? 1 : NumbersX.Value.CompareTo(NumbersY.Value));

           
        }
    }
}
