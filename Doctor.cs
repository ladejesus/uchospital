using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Doctor:Employer
    {
        public string Specialty { get; set; }
        public string Task { get; set; }
        public int Salary { get; set; }

        public Doctor(string specialty, string task, int salary)
        {
            Specialty = specialty;
            Task = task;
            Salary = salary;

        }




    }

}



