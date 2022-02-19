﻿namespace BetterOODemo
{
    public class Truck : LandVehicle, IRental
    {
        public TruckType Style { get; set; }
        public int RentalId { get; set; }
        public string CurrentRental { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
