using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{ /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "####";
        public string Make { get; set; } = "NeedMake";
        public string Model { get; set; } = "NeedModel";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("This car can drive");
        }
    }
}
