using DigiAeon.ParcelDelivery.Domain.Interfaces;
using DigiAeon.ParcelDelivery.Domain.Services;
using System.Collections.Generic;

namespace DigiAeon.ParcelDelivery.Infrastructure.Repositories
{
    public class DeliveryCostRuleRepository : IDeliveryCostRuleRepository
    {
        public List<DeliveryCostRule> GetAll()
        {
            // I am assuming technical team has decided to store delivery costing rules in database or somewhere outside like in XML file.

            var rules = new List<DeliveryCostRule>();
            rules.Add(new DeliveryCostRule { RuleName = "Rejected", Condition = x => x.Weight > 50, CostMultiply = 0, CostMultiplyTo = CostMultiplyToOptions.NA });
            rules.Add(new DeliveryCostRule { RuleName = "Heavy Parcel", Condition = x => x.Weight > 10, CostMultiply = 15, CostMultiplyTo = CostMultiplyToOptions.Weight });
            rules.Add(new DeliveryCostRule { RuleName = "Small Parcel", Condition = x => x.Volume < 1500, CostMultiply = 0.05M, CostMultiplyTo = CostMultiplyToOptions.Volume });
            rules.Add(new DeliveryCostRule { RuleName = "Medium Parcel", Condition = x => x.Volume < 2500, CostMultiply = 0.04M, CostMultiplyTo = CostMultiplyToOptions.Volume });
            rules.Add(new DeliveryCostRule { RuleName = "Large Parcel", Condition = x => true == true, CostMultiply = 0.03M, CostMultiplyTo = CostMultiplyToOptions.Volume });

            return rules;
        }
    }
}
