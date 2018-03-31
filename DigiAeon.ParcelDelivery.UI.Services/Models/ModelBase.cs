using DigiAeon.ParcelDelivery.UI.Services.Interfaces;
using DigiAeon.ParcelDelivery.UI.Services.Interfaces.ViewModels;

namespace DigiAeon.ParcelDelivery.UI.Services.Models
{
    public abstract class ModelBase<T> where T : ViewModelBase, new()
    {
        protected ModelBase(T viewModel, IConfig config)
        {
            ViewModel = viewModel;
            Config = config;
        }
        public T ViewModel { get; set; }
        public IConfig Config { get; }
    }
}
