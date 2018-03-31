using DigiAeon.ParcelDelivery.Domain.Services;
using DigiAeon.ParcelDelivery.UI.Services.Interfaces;
using DigiAeon.ParcelDelivery.UI.Services.Interfaces.Controllers;
using DigiAeon.ParcelDelivery.UI.Services.Interfaces.ViewModels.DeliveryCost;
using DigiAeon.ParcelDelivery.UI.Services.Models.DeliveryCost;

namespace DigiAeon.ParcelDelivery.UI.Services.Controllers
{
    public class DeliveryCostControllerService : IDeliveryCostControllerService
    {
        private DeliveryCostCalculator _deliveryCostCalculator;
        private IConfig _config;

        public DeliveryCostControllerService(DeliveryCostCalculator deliveryCostCalculator, IConfig config)
        {
            _deliveryCostCalculator = deliveryCostCalculator;
            _config = config;
        }

        public CalculateViewModel DisplayPage(CalculateViewModel viewModel)
        {
            var model = new CalculateModel(viewModel, _deliveryCostCalculator, _config);

            return model.ViewModel;
        }

        public CalculateViewModel GetDeliveryCostPage(CalculateViewModel viewModel)
        {
            var model = new CalculateModel(viewModel, _deliveryCostCalculator, _config);
            model.CalculateDeliveryCost();

            return model.ViewModel;
        }
    }
}
