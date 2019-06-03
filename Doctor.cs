using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Doctor 
    {
        public string Specialty { get; set; }
        public int Salary { get; set; }
        public int Enumber { get; set; }

        public Doctor(string heart) 
        {
            Specialty = heart;
            Salary = 90000;
            Enumber = 111;
        }

        public void DoctorMenu()
        {
            bool interacting = true;
            string interact = "";
            DrawBlood blood = new DrawBlood
            do
            {
                Console.WriteLine("You are in the Doctors menu.\n Press rnter to continue. ");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Doctors Menu");
                Console.WriteLine(" 1: Draw Blood\n 2: View Doctor Info\n 3: Back To Employee Menu");
                interact = Console.ReadLine();
                switch(interact)
                {
                    case "1":
                        blood.DrawingBlood();
                        break;
                    case "2":
                        
                }

            }


            

        }



    }

}



