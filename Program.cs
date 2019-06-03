using System;

namespace uchospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee mainMenu = new Employee();
            Console.WriteLine("Welcome to UCHospital.");
            mainMenu.GetMainMenu();
        }
    }
}
