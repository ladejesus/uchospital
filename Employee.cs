using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Employer
    {
        public string Name { get; set; }
        public int Enumber { get; set; }
        public int Salary { get; set; }

        //Pay Method Pay()

        public Employer(string name, int eNumber, int salary)
        {
            Name = name;
            Enumber = eNumber;
            Salary = salary;
        }

        public string ChooseEmployeeType()
        {
            Console.WriteLine("Pick and employee type from the following: Doctor, Nurse, Janitor or Receptionist");
            return Console.ReadLine();
        }
        
        

        


    }
}
