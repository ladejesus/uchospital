using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Nurse : Employee
    {
        public string Type { get; set; }
        public int NumberOfPatients { get; set; }

        public Nurse(string Type, int NumberOfPatients, string name, int Enumber, string Salary) : base()
        {
            Type = "Nurse";
            NumberOfPatients = 2;
            Name = "Betty";
            Enumber = 222;
            Salary = "$50,000";
        }



    }












}






