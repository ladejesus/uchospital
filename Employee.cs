﻿using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    public class Employee
    {
        public string Name { get; set; }
        public string Salary { get; set; }
        public int Enumber { get; set; }


        List<Employee> employeeList = new List<Employee>();

        Doctor doctor = new Doctor("Doctor", "John", 111, "$90,000", "Heart Surgeon");
        Nurse nurse = new Nurse("Nurse", "Betty", 222, "$50,000");
        Receptionist receptionist = new Receptionist("Receptionist", "Joan", 333, "$45,000");
        Janitor janitor = new Janitor("Janitor", "Bob", 444, "$40,000");

        public void AddEmployeeList()
        {
            employeeList.Add(doctor);
            employeeList.Add(nurse);
            employeeList.Add(receptionist);
            employeeList.Add(janitor);
        }

        public void EmployeeInfo()
        {
            int employeeNumber = 1;
            foreach (Employee employee in employeeList) ;
            {
                
            }
        }
        

        public void GetMainMenu()
        {
            bool interacting = true;
            string menuChoice = "";
            Doctor doctor = new Doctor();
            Nurse nurse = new Nurse();
            Receptionist receptionist = new Receptionist();
            Janitor janitor = new Janitor();
            do
            {
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
                                doctor.DoctorMenu();
                                break;
                            case "2":
                                nurse.NurseMenu();
                                break;
                            case "3":
                                receptionist.AnsweringPhone();
                                receptionist.HangUpPhone();
                                break;
                            case "4":
                                janitor.IsSweeping();
                                janitor.NotSweeping();
                                break;
                            case "5":
                                interacting = false;
                                break;
                        }
                        break;


                }
            } while (interacting);
        }
    
        

        


    }
}
