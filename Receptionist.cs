using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Receptionist
    {
        public int Salary { get; set; }
        public int Enumber { get; set; }
        public string Task { get; set; }

        public Receptionist(string task)
        {
            Salary = 45000;
            Enumber = 333;
            Task = task;
        }
            


    }
}
