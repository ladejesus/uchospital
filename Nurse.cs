using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Nurse
    {
        public int Salary { get; set; }
        public int Patients { get; set; }
        public int Enumber { get; set; }
        public string Task { get; set; }

        public Nurse(string task)
        {
            Salary = 50000;
            Enumber = 222;
            Patients = 2;
            Task = task;
        }



    }












}






