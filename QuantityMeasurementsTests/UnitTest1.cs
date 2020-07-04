using NUnit.Framework;

namespace QuantityMeasurementsTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Compare compare = new Compare();
            bool result = compare.Check(1, 12);
            Assert.IsTrue(result);
        }
    }
}