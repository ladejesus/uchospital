﻿using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Janitor : Employee
    {
        public string Type { get; set; }

        public Janitor(string Type, string Name, int Enumber, string Salary) : base()
        {
            Type = "Janitor";
            Name = "Bob";
            Enumber = 444;
            Salary = "$40,000";
        }

        bool sweeping = true;
        
        

    }

    


        
    

    








}     
