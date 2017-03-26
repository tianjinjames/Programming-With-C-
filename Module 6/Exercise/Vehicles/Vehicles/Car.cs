using System;

namespace Vehicles
{
    public class Car:Vehicles
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerating");
        }

        public void Brake()
        {
            Console.WriteLine("Braking");
        }

        public override void Drive()
        {
            Console.WriteLine("Motoring");
        }
    }
}