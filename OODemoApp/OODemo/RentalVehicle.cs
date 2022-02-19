namespace OODemo
{
    using System;

    public class RentalVehicle
    {
        public int RentalId { get; set; }
        public string CurrentRental { get; set; }
        public decimal PricePerDay { get; set; }
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
