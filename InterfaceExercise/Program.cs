using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values


            var car = new Car();
            car.HasWindows = true;
            car.speed = "Fast";
            car.HasBrakes = true;
            car.wheels = 4;
            car.name = "Subaru";

            Console.WriteLine($"wow your car is {car.speed} it must be a {car.name} ");

            if (car.wheels == 4)
            {
                Console.WriteLine($"That car has 4 tires");
            }
            else if (car.wheels == 3)
            {
                Console.WriteLine($"that car has 3 tires");
            }
            else if (car.wheels == 2)
            {
                Console.WriteLine($"that car has 2 tires");
            }
            else if (car.wheels == 1)
            {
                Console.WriteLine($"That car has 1 tire");
            }

            var truck = new Truck();
            truck.name = "F-150";
            truck.EngineSize = "3.5L";
            truck.GasType = "Premium";
            truck.wheels = 4;
            truck.HasWindows = true;
            truck.HasBrakes = true;

            Console.WriteLine($"my new Ford {truck.name} has an engine that is {truck.EngineSize} that takes {truck.GasType} gas");

            List<Truck> myTrucks = new List<Truck>();
            var trucks = new Truck();
            truck.name = "F-150";
            truck.EngineSize = "3.5L";
            truck.GasType = "Premium";
            truck.wheels = 4;
            truck.HasWindows = true;
            truck.HasBrakes = true;
            myTrucks.Add(truck);

            foreach (Truck t in myTrucks)
            {
                Console.WriteLine("Name: " + t.name);
                Console.WriteLine("Engine Size: " + t.EngineSize);
                Console.WriteLine("Gas Type: " + t.GasType);
                Console.WriteLine("Number of Wheels: " + t.wheels);
                Console.WriteLine("Has Windows: " + t.HasWindows);
                Console.WriteLine("Has Brakes: " + t.HasBrakes);
            }

            var suv = new SUV();
            suv.logo = "Mercedes";
            suv.IsCompact = true;
            suv.NumberOfsSeats = 6;
            suv.HasWindows = true;
            suv.HasBrakes = true;
            suv.wheels = 4;
            
            Console.WriteLine($"is that SUV a {suv.logo}? does it really fit {suv.NumberOfsSeats} people?");
            
            
            
            
            List<SUV> mySuv = new List<SUV>();
            var Suv = new SUV();
            suv.logo = "Mercedes";
            suv.IsCompact = true;
            suv.NumberOfsSeats = 6;
            suv.HasWindows = true;
            suv.HasBrakes = true;
            suv.wheels = 4;
            mySuv.Add(suv);

            foreach (SUV su in mySuv)
            {
                Console.WriteLine("Logo: " + suv.logo);
                Console.WriteLine("Is Compact: " + suv.IsCompact); 
                Console.WriteLine("Has Windows: " + suv.HasWindows);
                Console.WriteLine("Has Brakes: " + suv.HasBrakes);
                Console.WriteLine("Wheels: " + suv.wheels);
                Console.WriteLine();
            }

        }
    }
}

        
    
