namespace DigiAeon.ParcelDelivery.Domain.Services
{
    public class DeliveryCost
    {
        public DeliveryCost(string category, decimal cost)
        {
            Category = category;
            Cost = cost;
        }

        public string Category { get; private set; }

        public decimal Cost { get; private set; }
    }
}
