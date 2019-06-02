using System;
using System.Collections.Generic;
using System.Text;

namespace uchospital
{
    class Patient
    {
        public int BloodLevel { get; set; }
        public int Health { get; set; }

        public Patient()
        {
            BloodLevel = 20;
            Health = 10;
        }

    }
}
