using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    class DrawBlood : Patient
    {
        public void DrawingBlood()
        {
            BloodLevel -= 6;
            Health -= 3;
            Console.WriteLine("You have drawn blood from the patient. ");
        }

        public void PerformSurgery()
        {
            Health += 3;
            Console.WriteLine("You have just performed open heart surgery.");
        }


    }
}
