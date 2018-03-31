namespace DigiAeon.ParcelDelivery.UI.Services.Interfaces.ViewModels.DeliveryCost
{
    public class CalculateViewModel : ViewModelBase
    {
        public int? Weight { get; set; }

        public int? Height { get; set; }

        public int? Width { get; set; }

        public int? Depth { get; set; }

        public int? Cost { get; set; }

        public string Category { get; set; }
    }
}
