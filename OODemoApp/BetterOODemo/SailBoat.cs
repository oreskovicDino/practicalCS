namespace BetterOODemo
{
    public class SailBoat : IRental
    {
        public int RentalId { get; set; }
        public string CurrentRental { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
