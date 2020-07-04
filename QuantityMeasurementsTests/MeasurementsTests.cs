using NUnit.Framework;
using QuantityMeasurements;

namespace QuantityMeasurementsTests
{
    public class Tests
    {
        Compare compare;
        [SetUp]
        public void Setup()
        {
            compare = new Compare();
        }

        [Test]
        public void Provided_1Inche_And_12Feet_Should_Return_True()
        {
            
            bool result = compare.Check(1,12);
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_0Inche_And_0Feet_Should_Return_True()
        {
            Feet value_1 = new  Feet(0.0);
            Feet value_2 = new Feet(0.0);
            Assert.AreEqual(value_1, value_2);
        }


    }
}