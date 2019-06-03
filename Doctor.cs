using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Doctor : Employee
    {
        public string Type { get; set; }
        public string Specialty { get; set; }

        public Doctor(string Type, string Name, int Enumber, string Salary, string Specialty) : base()
        {
            Type = "Doctor";
            Name = "John";
            Enumber = 111;
            Salary = "$90,000";
            Specialty = "Heart";
        }

        public Doctor()
        {
        }

        public void DoctorMenu()
        {
            bool interacting = true;
            string interact = "";
            DrawBlood blood = new DrawBlood();
            do
            {
                Console.WriteLine("You are in the Doctors menu.\n Press enter to continue. ");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Doctors Menu");
                Console.WriteLine(" 1: Draw Blood\n 2: Perform Heart Surgery\n 3: Back To Employee Menu");
                interact = Console.ReadLine();
                switch(interact)
                {
                    case "1":
                        blood.DrawingBlood();
                        break;
                    case "2":
                        blood.PerformSurgery();
                        break;
                    case "3":
                        interacting = false;
                        break;
                        
                }

            }
            while (interacting);


            

        }



    }

}



