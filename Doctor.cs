using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }
        public string Task { get; set; }
        public int Salary { get; set; }
        public int Enumber { get; set; }

        public Doctor(string specialty, string task) : base (name)
        {
            Specialty = specialty;
            Task = task;
            Salary = 90000;
            Enumber = 111;
        }




    }

}



