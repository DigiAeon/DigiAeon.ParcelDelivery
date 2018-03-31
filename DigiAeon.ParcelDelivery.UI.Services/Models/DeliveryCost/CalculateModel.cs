using DigiAeon.ParcelDelivery.Domain;
using DigiAeon.ParcelDelivery.Domain.Services;
using DigiAeon.ParcelDelivery.UI.Services.Interfaces;
using DigiAeon.ParcelDelivery.UI.Services.Interfaces.ViewModels;
using DigiAeon.ParcelDelivery.UI.Services.Interfaces.ViewModels.DeliveryCost;

namespace DigiAeon.ParcelDelivery.UI.Services.Models.DeliveryCost
{
    public class CalculateModel : ModelBase<CalculateViewModel>
    {
        private readonly DeliveryCostCalculator _deliveryCostCalculator;
        public CalculateModel(CalculateViewModel viewModel, DeliveryCostCalculator deliveryCostCalculator, IConfig config) : base(viewModel, config)
        {
            _deliveryCostCalculator = deliveryCostCalculator;

            ViewModel.Cost = 0;
            ViewModel.Category = string.Empty;
        }

        public void CalculateDeliveryCost()
        {
            if (IsAllValid())
            {
                var deliveryCost = _deliveryCostCalculator.GetDeliveryCost(new Parcel(ViewModel.Weight.Value, ViewModel.Height.Value, ViewModel.Width.Value, ViewModel.Depth.Value));
                ViewModel.Cost = (int?)deliveryCost.Cost;
                ViewModel.Category = deliveryCost.Category;
            }
        }

        private bool IsAllValid()
        {
            ViewModel.Errors.Clear();

            if (!ViewModel.Weight.HasValue || ViewModel.Weight.Value <= 0)
            {
                ViewModel.Errors.Add(new Error { Identifier = "Weight", Code = "LESS_OR_EQUAL_ZERO" });
            }

            if (!ViewModel.Height.HasValue || ViewModel.Height.Value <= 0)
            {
                ViewModel.Errors.Add(new Error { Identifier = "Height", Code = "LESS_OR_EQUAL_ZERO" });
            }

            if (!ViewModel.Width.HasValue || ViewModel.Width.Value <= 0)
            {
                ViewModel.Errors.Add(new Error { Identifier = "Width", Code = "LESS_OR_EQUAL_ZERO" });
            }

            if (!ViewModel.Depth.HasValue || ViewModel.Depth.Value <= 0)
            {
                ViewModel.Errors.Add(new Error { Identifier = "Depth", Code = "LESS_OR_EQUAL_ZERO" });
            }

            return ViewModel.Errors.Count <= 0;
        }
    }
}
