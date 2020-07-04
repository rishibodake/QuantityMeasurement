using NUnit.Framework;

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

        
    }
}