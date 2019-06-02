using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Nurse : Employee
    {
        public string Type { get; set; }
        
        
        public Nurse(string Type, string Name, int Enumber, string Salary, string Specialty): base()
        {
            Type = "Nurse";
            Name = "Betty";
            Enumber = 22222;
            Salary = "$50,000";
            Specialty = "Draw Blood";

        }


    }












}






