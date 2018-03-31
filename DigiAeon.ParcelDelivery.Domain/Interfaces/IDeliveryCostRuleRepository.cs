using DigiAeon.ParcelDelivery.Domain.Services;
using System.Collections.Generic;

namespace DigiAeon.ParcelDelivery.Domain.Interfaces
{
    public interface IDeliveryCostRuleRepository
    {
        List<DeliveryCostRule> GetAll();
    }
}
