namespace BetterOODemo
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRental> rentals = new List<IRental>();

            rentals.Add(new Truck() { CurrentRental = "Truck Renter" });
            rentals.Add(new SailBoat() { CurrentRental = "Sailboat Renter" });
            rentals.Add(new Car() { CurrentRental = "Car Renter" });

            foreach (var r in rentals)
            {
                if (r is Truck t)
                {
                    t.Style = TruckType.LongBed;
                }
            }
        }
    }
}
