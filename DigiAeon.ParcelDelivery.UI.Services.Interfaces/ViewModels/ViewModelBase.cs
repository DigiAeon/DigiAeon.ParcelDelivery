using System.Collections.Generic;

namespace DigiAeon.ParcelDelivery.UI.Services.Interfaces.ViewModels
{
    public abstract class ViewModelBase
    {
        public ViewModelBase()
        {
            Errors = new List<Error>();
        }
        public List<Error> Errors { get; set; }
    }
}
