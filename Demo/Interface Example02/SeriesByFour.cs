﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example02
{
    internal class SeriesByFour : Iseries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 4;
        }
    }
}