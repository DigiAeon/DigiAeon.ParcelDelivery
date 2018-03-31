using System.Web.Mvc;
using DigiAeon.ParcelDelivery.UI.Services.Interfaces.Controllers;
using DigiAeon.ParcelDelivery.UI.Services.Interfaces.ViewModels.DeliveryCost;

namespace DigiAeon.ParcelDelivery.UI.Controllers
{
    public class DeliveryCostController : Controller
    {
        private IDeliveryCostControllerService _service;
        public DeliveryCostController(IDeliveryCostControllerService service)
        {
            _service = service;
        }

        [HttpGet]
        [ActionName(DeliveryCostControllerConstants.CalculateAction)]
        public ActionResult Calculate(CalculateViewModel viewModel)
        {
            return View(_service.DisplayPage(viewModel));
        }

        [HttpPost]
        [ActionName(DeliveryCostControllerConstants.GetDeliveryCostAction)]
        public JsonResult GetDeliveryCost(CalculateViewModel viewModel)
        {
            return Json(_service.GetDeliveryCostPage(viewModel), JsonRequestBehavior.AllowGet);
        }
    }

    public class DeliveryCostControllerConstants
    {
        public const string ControllerName = "DeliveryCost";
        public const string CalculateAction = "Calculate";
        public const string GetDeliveryCostAction = "GetDeliveryCost";
    }
}