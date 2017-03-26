using System;

namespace Vehicles
{
    public class Airplane : Vehicles
    {
        public void TakeOff()
        {
            Console.WriteLine("Taking off");
        }

        public void Land()
        {
            Console.WriteLine("Landing");
        }

        public override void Drive()
        {
            Console.WriteLine("Flying");
        }
    }
}