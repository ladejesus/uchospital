using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Employee
    {
        public string Name { get; set; }

        //Pay Method Pay()

        public Employee(string name)
        {
            Name = name;

        }

        public void Pay()
        {

        }

        public void GetMainMenu()
        {
            string menuChoice = "";

            Console.WriteLine("Main Menu");
            Console.WriteLine(" 1: Choose Employee\n 2: Employee Attributes\n 3: Employee Pay\n 4: Patient Levels\n 5: Exit");

            menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "1":
                    string employeeMenu = "";
                    Console.WriteLine(" 1: Doctor\n 2: Nurse\n 3: Receptionist\n 4: Janitor 5: Main Menu");
                    employeeMenu = Console.ReadLine();

            }
        }
    
        

        


    }
}
