using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    class Patient 
    {
        public int Blood_Level { get; set;}
        public int Health_Level { get; set; }

        public Patient(int Blood_Level, int Health_Level)
        {
            Blood_Level = 20;
            Health_Level = 10;
        }
        


    }
}
