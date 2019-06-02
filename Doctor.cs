using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Doctor : Employee
    {
        public string Type { get; set;}
        
         public Doctor(string Type, string Name, int Enumber, string Salary, string Specialty) : base()

         {
            Type = "Doctor";
            Name = "John";
            Enumber = 11111;
            Salary = "$90,000";
            Specialty = "Heart";

         }













    }

}



