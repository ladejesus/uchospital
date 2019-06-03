using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Receptionist : Employee
    {
        public string Type { get; set; }
        public bool TalkingOnPhone { get; set; }

        public Receptionist(string Type, string Name, int Enumber, string Salary) : base()
        {
            Type = "Receptionist";
            Name = "Joan";
            Enumber = 333;           
            Salary = "$45,000";
            TalkingOnPhone = true;
        }

        public void AnsweringPhone()
        {
            this.TalkingOnPhone = true;
        }

        public void HangUpPhone()
        {
            this.TalkingOnPhone = false;
        }

        public Receptionist()
        {
        }
    }
}
