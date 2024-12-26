﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Built_in_Interfaces
{
     class Employee 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Department? Department { get; set; }

        public Employee()
        {
            
        }

        //Copy Constructor : To make Deep Copy for the reference without using Iclonable
        public Employee(Employee employeecoppy)
        {
            Id=employeecoppy.Id;
            Name=employeecoppy.Name;
            Salary=employeecoppy.Salary;
            Department=(Department?)employeecoppy.Department?.Clone();

        }


        public object Clone()
        {
            return new Employee()
            {
                Id = Id,
                Name = Name,
                Salary = Salary,
                Department =(Department?) Department?.Clone()
            };
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name} ,Salary: {Salary:c}";
        }


    }
}