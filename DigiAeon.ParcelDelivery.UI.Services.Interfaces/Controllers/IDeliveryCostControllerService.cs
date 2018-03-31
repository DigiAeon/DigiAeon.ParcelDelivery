using DigiAeon.ParcelDelivery.UI.Services.Interfaces.ViewModels.DeliveryCost;

namespace DigiAeon.ParcelDelivery.UI.Services.Interfaces.Controllers
{
    public interface IDeliveryCostControllerService
    {
        CalculateViewModel DisplayPage(CalculateViewModel viewModel);

        CalculateViewModel GetDeliveryCostPage(CalculateViewModel viewModel);
    }
}
