using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Receptionist
    {
        public int Salary { get; set; }
        public string Task { get; set; }

        public Receptionist(int salary, string task)
        {
            Salary = salary;
            Task = task;
        }
            


    }
}
