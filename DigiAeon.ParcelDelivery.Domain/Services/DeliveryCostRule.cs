using System;

namespace DigiAeon.ParcelDelivery.Domain.Services
{
    public class DeliveryCostRule
    {
        public string RuleName { get; set; }
        public Func<Parcel, bool> Condition { get; set; }
        public decimal CostMultiply { get; set; }
        public CostMultiplyToOptions CostMultiplyTo { get; set; }
    }
}
