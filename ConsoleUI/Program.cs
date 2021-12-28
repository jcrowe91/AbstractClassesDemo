using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             *dCreate an abstract class called Vehicle
             * dThe vehicle class shall have three string properties Year, Make, and Model
             * dSet the defaults to something generic in the Vehicle class
             * dVehicle shall have an abstract method called DriveAbstract with no implementation
             * dVehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * dNow create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * dAdd a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * dProvide the implementations for the abstract methods
             * dOnly in the Motorcycle class will you override the virtual drive method
            */

            // dCreate a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * dCreate 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * d- new it up as one of each derived class
             * dSet the properties with object initializer syntax
             */
            var ranger = new Car { HasTrunk = false, Make = "Ford", Model = "Ranger", Year = 1996 };
            var shadow = new Motorcycle { HasSideCar = false, Make = "Honda", Model = "Shadow", Year = 2000 };
            Vehicle pt = new Car { HasTrunk = true, Make = "Chrysler", Model = "PT", Year = 2003 };
            Vehicle equinox = new Car { HasTrunk = true, Make = "Chevy", Model = "Equinox", Year = 2016 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(ranger);
            vehicles.Add(shadow);
            vehicles.Add(pt);
            vehicles.Add(equinox);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"{veh.Make} {veh.Model} {veh.Year}");
                veh.DriveAbstract();
                veh.DriveVirtual();
                Console.WriteLine("--------------------------------");
            }


            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
