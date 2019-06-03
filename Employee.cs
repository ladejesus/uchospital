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

        public Employee()
        {
        }

        public void Pay()
        {

        }

        public void GetMainMenu()
        {
            string menuChoice = "";
            Console.WriteLine("Press enter to continue. ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine(" 1: Choose Employee\n 2: Employee Info\n 3: Pay Employee\n 4: Patient Levels\n 5: Exit");
            menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "1":
                    string employeeMenu = "";
                    Console.WriteLine(" 1: Doctor\n 2: Nurse\n 3: Receptionist\n 4: Janitor\n 5: Back to Main Menu");
                    employeeMenu = Console.ReadLine();
                    switch (employeeMenu)
                    {
                        case "1":
                            

                    }
            }
        }
    
        

        


    }
}
