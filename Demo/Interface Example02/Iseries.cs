using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example02
{
    //Dev 01---->Gaber
    internal interface Iseries
    {
        public int Current { get; set; }

        void GetNext();
        public void Reset()
        {
            Current = 0;
        }


    }
}
