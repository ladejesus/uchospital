using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Nurse
    {
        public int Salary { get; set; }
        public int Patients { get; set; }
        public string Task { get; set; }

        public Nurse(int salary, int patients, string task)
        {
            Salary = salary;
            Patients = patients;
            Task = task;
        }



    }












}






