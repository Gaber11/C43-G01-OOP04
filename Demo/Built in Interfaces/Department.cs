﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Built_in_Interfaces
{
    class Department 
    {
        public int Code { get; set; }
        public string? Title { get; set; }

        public object Clone()
        {
            return new Department()
            {
                Code = Code,
                Title = Title
            };

        }
    }
}
