using NUnit.Framework;
using QuantityMeasurements;

namespace QuantityMeasurementsTests
{
    public class Tests
    {
        Compare compare;
        Conversion convert;
        [SetUp]
        public void Setup()
        {
            compare = new Compare();
            convert = new Conversion();
        }

        [Test]
        public void Provided_1Inche_And_12Feet_Should_Return_True()
        {
            
            bool result = compare.CompareFeetToInches(1,12);
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_0Feet_And_0Feet_Should_Return_True()
        {
            Feet value_1 = new  Feet(0.0);
            Feet value_2 = new Feet(0.0);            
            Assert.IsTrue(value_1.feet.Equals(value_2.feet));
        }

        [Test]
        public void Provided_0Feet_And_NullValue_Shuold_Return_False()
        {
            Feet feet = new Feet();            
            Assert.IsFalse(feet.Equals(null));
        }

        [Test]
        public void Provided_0Feet_And_0Feet_Shuold_Return_True()
        {
            bool check = compare.CompareFeetToInches(0, 0);
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

        [Test]
        public void Provided_0Inche_And_0Inche_Should_Return_True()
        {
            Inches value_1 = new Inches(0.0);
            Inches value_2 = new Inches(0.0);
            Assert.IsTrue(value_1.inches.Equals(value_2.inches));
        }

        [Test]
        public void Provided_0Inch_And_NullValue_Shuold_Return_False()
        {
            Inches inch = new Inches();
            Assert.IsFalse(inch.Equals(null));
        }

        [Test]
        public void Reference_Check_Test_For_Inch()
        {
            Inches value_1 = new Inches();
            Inches value_2 = new Inches();
            Assert.IsFalse(value_1.Equals(value_2));
        }
       
        [Test]
        public void Provided_Equal_Inch_Value_Shuold_Return_True()
        {
            Inches value_1 = new Inches();
            value_1.inches = 4.6;
            Assert.IsTrue(value_1.Equals(value_1));

        }
        [Test]
        public void Provided_Improper_Inches_Type_Object_Should_Return_False()
        {
            Inches value_1 = new Inches();
            object value_2 = new object();
            Assert.IsFalse(value_1.Equals(value_2));
        }      
        
        [Test]
        public void Provided_3Feet_And_1Yard_After_Compare_Should_Return_True()
        {
            bool result = compare.CompareFeetToYards(3.0, 1.0);
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Feet_And_1Yard_After_Compare_Should_Return_False()
        {
            bool result = compare.CompareFeetToYards(1.0, 1.0);
            Assert.IsFalse(result);
        }

        [Test]
        public void Provided_1Inche_And_1Yard_When_Compare_Should_Return_False()
        {
            bool result = compare.CompareFeetToYards(convert.InchesToFeets(1.0), 1.0);
            Assert.IsFalse(result);
        }

        [Test]
        public void Provided_1Yard_And_36Inches_When_Compare_Should_Return_True()
        {
            bool result = compare.CompareFeetToYards(convert.InchesToFeets(36.00), 1.0);
            Assert.IsTrue(result);
        }
    }
}
