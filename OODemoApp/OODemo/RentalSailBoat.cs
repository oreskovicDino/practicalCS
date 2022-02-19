namespace OODemo
{
    using System;

    public class RentalSailBoat: RentalVehicle
    {
        public override void StartEngine()
        {
            throw new Exception("I don not have an engine to start");
        }
        public override void StoptEngine()
        {
            throw new Exception("I don not have an engine to stop");
        }
    }
}
