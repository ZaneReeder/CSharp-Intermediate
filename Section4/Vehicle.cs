using System;

namespace Section4
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle being initialized");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialized. {0}", registrationNumber);

        }
    }
}
