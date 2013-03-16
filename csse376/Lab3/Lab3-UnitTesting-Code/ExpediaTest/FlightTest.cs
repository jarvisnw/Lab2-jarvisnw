using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
		//TODO Task 7 items go here
        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(DateTime.Today, DateTime.Today.AddDays(1), 500);
            Assert.IsNotNull(target);
        }
        [Test()]
        public void TestThatFlightlHasCorrectBasePriceForTwoDayFlight()
        {
            var target = new Flight(DateTime.Today, DateTime.Today.AddDays(2), 500);
            Assert.AreEqual(240, target.getBasePrice());
        }

        [Test()]
        public void TestThatFlightlHasCorrectBasePriceForTenDayFlight()
        {
            var target = new Flight(DateTime.Today, DateTime.Today.AddDays(10), 500);
            Assert.AreEqual(400, target.getBasePrice());
        }
        [Test()]
        public void TestFlightEqualsMethod()
        {
            var target = new Flight(DateTime.Today, DateTime.Today.AddDays(10), 500);
            var target2 = new Flight(DateTime.Today, DateTime.Today.AddDays(10), 500);
            Assert.IsTrue(target.Equals(target2));
        }
	}
}
