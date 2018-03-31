using System;
namespace DigiAeon.ParcelDelivery.Domain
{
    public class DataNotFoundException : Exception
    {
        public DataNotFoundException(string message) : base(message)
        {}
    }
}
