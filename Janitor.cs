using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Janitor : Employee
    {
        public string Type { get; set;}
        
      
        public Janitor(string Type, string Name, int Enumber, string Salary, string Specialty): base()
        {
            Type = "Janitor";
            Name = "Bob";
            Enumber = 44444;
            Salary = "$40,000";
            Specialty = "Mopping Floors";

        }
        


    }

    


        
    

    








}     
