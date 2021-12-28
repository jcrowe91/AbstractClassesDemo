using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcycle is in drive");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive!");
        }
    }
}
