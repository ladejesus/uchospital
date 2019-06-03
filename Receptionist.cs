using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Receptionist : Employee
    {
        public string Type { get; set; }


        public Receptionist(string Type, string Name, int Enumber, string Salary) : base()
        {
            Type = "Receptionist";
            Name = "Joan";
            Enumber = 333;           
            Salary = "$45,000";
            
        }
            


    }
}
