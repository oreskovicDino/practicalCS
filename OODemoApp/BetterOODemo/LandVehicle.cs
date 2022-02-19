namespace BetterOODemo
{
    using System;

    public class LandVehicle
    {
        public int NumberOfPassangers { get; set; }

        public virtual void StartEngine()
        {
            Console.WriteLine("Turn key to ignition setting");
            Console.WriteLine("Turn key to on");
        }
        public virtual void StoptEngine()
        {
            Console.WriteLine("Turn key to off");
        }
    }
}
