using DigiAeon.ParcelDelivery.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DigiAeon.ParcelDelivery.Domain.Services
{
    public class DeliveryCostCalculator
    {
        private List<DeliveryCostRule> _deliveryCostRules;

        public DeliveryCostCalculator(IDeliveryCostRuleRepository deliveryCostRepository)
        {
            _deliveryCostRules = deliveryCostRepository.GetAll();
        }
        public DeliveryCost GetDeliveryCost(Parcel parcel)
        {
            var rule = _deliveryCostRules.FirstOrDefault(x => x.Condition(parcel) == true);

            if (rule != null)
            {
                switch (rule.CostMultiplyTo)
                {
                    case CostMultiplyToOptions.Weight:
                        return new DeliveryCost(rule.RuleName, rule.CostMultiply * parcel.Weight);

                    case CostMultiplyToOptions.Volume:
                        return new DeliveryCost(rule.RuleName, rule.CostMultiply * parcel.Volume);

                    default:
                        return new DeliveryCost(rule.RuleName, -1);
                }
            }

            throw new DataNotFoundException("Delivery cost rules not found!");
        }
    }
}
