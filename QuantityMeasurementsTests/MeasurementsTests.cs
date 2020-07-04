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

        [Test]
        public void Provided_0Inch_And_NullValue_Shuold_Return_False()
        {
            Feet feet = new Feet();            
            Assert.IsFalse(feet.Equals(null));
        }

        [Test]
        public void Provided_0Inch_And_0Feet_Shuold_Return_True()
        {
            bool check = compare.Check(0, 0);
            Assert.IsTrue(check);
        }

        [Test]
        public void Reference_Check_Test_For_Feet()
        {
            Feet value_1 = new Feet();
            Feet value_2 = new Feet();
            Assert.IsFalse(value_1.Equals(value_2));
        }

        [Test]
        public void Provided_Improper_Type_Object_Should_Return_False()
        {
            Feet value_1 = new Feet();
            object value_2 = new object();
            Assert.IsFalse(value_1.Equals(value_2));
        }

        [Test]
        public void Provided_Equal_Value_Shuold_Return_True()
        {
            Feet value_1 = new Feet();
            value_1.feet = 4.6;
            Assert.IsTrue(value_1.Equals(value_1));
            
        }


    }
}