using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Nurse : Employee
    {
        public string Type { get; set; }
        public int NumberOfPatients { get; set; }

        public Nurse(string Type, int NumberOfPatients, string name, int Enumber, string Salary) : base()
        {
            Type = "Nurse";
            NumberOfPatients = 2;
            Name = "Betty";
            Enumber = 222;
            Salary = "$50,000";
        }

        public void NurseMenu()
        {
            bool interacting = true;
            string interact = "";
            DrawBlood blood = new DrawBlood();
            do
            {
                Console.WriteLine("You are in the Nurses menu.\n Press enter to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Nurses Menu");
                Console.WriteLine(" 1: Draw Blood\n 2: Patients List\n 3: Exit To Employee Menu");
                interact = Console.ReadLine();
                switch (interact)
                {
                    case "1":
                        blood.DrawingBlood();
                        break;
                    case "2":
                        nurse.NumberOfPatients();
                        break;
                    case "3":
                        interacting = false;
                        break;
                }
            } while (interacting);
        }
            


            



    }












}






