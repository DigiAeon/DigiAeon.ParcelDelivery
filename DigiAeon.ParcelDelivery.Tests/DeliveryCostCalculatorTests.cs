using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigiAeon.ParcelDelivery.Domain.Services;
using DigiAeon.ParcelDelivery.Infrastructure.Repositories;
using DigiAeon.ParcelDelivery.Domain;

namespace DigiAeon.ParcelDelivery.Tests
{
    [TestClass]
    public class DeliveryCostCalculatorTests
    {
        private DeliveryCostCalculator _deliveryCostCalculator;

        [TestInitialize]
        public void Init()
        {
            _deliveryCostCalculator = new DeliveryCostCalculator(new DeliveryCostRuleRepository());
        }

        [TestMethod]
        public void HeavyParcelTest()
        {
            var parcel = new Parcel(22, 5, 5, 5);
            var deliveryCost = _deliveryCostCalculator.GetDeliveryCost(parcel);

            Assert.AreEqual(deliveryCost.Cost, 330);
            Assert.AreEqual(deliveryCost.Category, "Heavy Parcel");
        }

        [TestMethod]
        public void SmallParcelTest()
        {
            var parcel = new Parcel(2, 3, 10, 12);
            var deliveryCost = _deliveryCostCalculator.GetDeliveryCost(parcel);

            Assert.AreEqual(deliveryCost.Cost, 18);
            Assert.AreEqual(deliveryCost.Category, "Small Parcel");
        }

        [TestMethod]
        public void MediumParcelTest()
        {
            var parcel = new Parcel(10, 20, 5, 20);
            var deliveryCost = _deliveryCostCalculator.GetDeliveryCost(parcel);

            Assert.AreEqual(deliveryCost.Cost, 80);
            Assert.AreEqual(deliveryCost.Category, "Medium Parcel");
        }

        [TestMethod]
        public void LargeParcelTest()
        {
            var parcel = new Parcel(10, 50, 50, 5);
            var deliveryCost = _deliveryCostCalculator.GetDeliveryCost(parcel);

            Assert.AreEqual(deliveryCost.Cost, 375);
            Assert.AreEqual(deliveryCost.Category, "Large Parcel");
        }

        [TestMethod]
        public void RejectedParcelTest()
        {
            var parcel = new Parcel(110, 20, 55, 110);
            var deliveryCost = _deliveryCostCalculator.GetDeliveryCost(parcel);

            Assert.AreEqual(deliveryCost.Cost, -1);
            Assert.AreEqual(deliveryCost.Category, "Rejected");
        }
    }
}
