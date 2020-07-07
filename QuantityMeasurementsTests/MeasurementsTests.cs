using NUnit.Framework;
using QuantityMeasurements;
using System;
using System.Xml.Serialization;
using static QuantityMeasurements.Units;
using static QuantityMeasurements.Convertor;
using static QuantityMeasurements.Units.Length;
using static QuantityMeasurements.Units.Weight;
using static QuantityMeasurements.Units.Volume;
using static QuantityMeasurements.Units.Temprature;

namespace QuantityMeasurementsTests
{
    public class Tests
    {
        bool result; 
        [SetUp]
        public void Initialisation()
        {
           result = false;
        }

        [Test]
        public void Provided_12Inche_And_1Feet_Should_Return_True()
        {
           
            if (UnitConvertor<Length>(12,INCHES) == UnitConvertor<Length>(1,FEET))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_0Feet_And_0Feet_Should_Return_True()
        {
            Feet first_value = new  Feet(0.0);
            Feet second_value = new Feet(0.0);            
            Assert.IsTrue(first_value.feet.Equals(second_value.feet));
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
            if (UnitConvertor<Length>(0,FEET) == UnitConvertor<Length>(0,FEET))
            {
                result = true;
            }
            Assert.IsTrue(result);
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
            if(UnitConvertor<Length>(3,FEET) == UnitConvertor<Length>(1,YARDS))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Feet_And_1Yard_After_Compare_Should_Return_False()
        {          
            if(UnitConvertor<Length>(1,FEET) == UnitConvertor<Length>(1,YARDS))
            {
                result = true;
            }
            Assert.IsFalse(result);
        }

        [Test]
        public void Provided_1Inche_And_1Yard_When_Compare_Should_Return_False()
        {            
            if (UnitConvertor<Length>(1,INCHES) == UnitConvertor<Length>(1,YARDS))
            {
                result = true;
            }
            Assert.IsFalse(result);
        }

        [Test]
        public void Provided_1Yard_And_36Inches_When_Compare_Should_Return_True()
        {        
            if (UnitConvertor<Length>(1,YARDS) == UnitConvertor<Length>(36,INCHES)) {
                result = true;
            }           
            Assert.IsTrue(result);                   
        }

        [Test]
        public void Provided_36Inches_And_1Yard_When_Compare_Should_Return_True()
        {           
            if (UnitConvertor<Length>(36,INCHES) == UnitConvertor<Length>(1,YARDS))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Yard_And_3Feet_When_Compare_Should_Return_True()
        {            
            if (UnitConvertor<Length>(1,YARDS) == UnitConvertor<Length>(3,FEET))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_2Inch_And_5CM_When_Compare_Should_Return_True()
        {
            if (UnitConvertor<Length>(2,INCHES) == UnitConvertor<Length>(5,CM))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_2Inch_And_2Inch_After_Additon_Should_Return_4Inch()
        {
            result = Addition(UnitConvertor<Length>(2,INCHES), UnitConvertor<Length>(2,INCHES), UnitConvertor<Length>(4,INCHES));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Feet_And_2Inch_After_Additon_Should_Return_14Inch()
        {
            result = Addition(UnitConvertor<Length>(1,FEET), UnitConvertor<Length>(2,INCHES), UnitConvertor<Length>(14,INCHES));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Feet_And_1Feet_After_Additon_Should_Return_24Inch()
        {
            result = Addition(UnitConvertor<Length>(1, FEET), UnitConvertor<Length>(1,FEET), UnitConvertor<Length>(24,INCHES));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_2Inch_And_2n5CM_After_Additon_Should_Return_3Inch()
        {
            result = Addition(UnitConvertor<Length>(2,INCHES), UnitConvertor<Length>(2.5,CM), UnitConvertor<Length>(3,INCHES));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Gallon_And_3point78_Liter_After_Compare_Shuould_Return_True()
        {
            if (UnitConvertor<Volume>(1,GALLON) == UnitConvertor<Volume>(3.78,LITRE))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1litre_And_100MiliLiter_After_Compare_Shuould_Return_True()
        {
            if (UnitConvertor<Volume>(1,LITRE) == UnitConvertor<Volume>(1000,ML))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Gallon_And_3o78_litre_After_Additon_Should_Return_7o57litre()
        {
            result = Convertor.Addition(UnitConvertor<Volume>(1,GALLON), UnitConvertor<Volume>(3.78,LITRE), UnitConvertor<Volume>(7.56,LITRE));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Lire_And_1000mllitre_After_Additon_Should_Return_2litre()
        {
            result = Convertor.Addition(UnitConvertor<Volume>(1, LITRE), UnitConvertor<Volume>(1000,ML),UnitConvertor<Volume>(2,LITRE));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Kg_And_1000Grams_After_Compare_Shuould_Return_True()
        {
            if (UnitConvertor<Weight>(1,KILO) == UnitConvertor<Weight>(1000,GRAM))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }


        [Test]
        public void Provided_1Tones_And_1000Kilos_After_Compare_Shuould_Return_True()
        {
            if (UnitConvertor<Weight>(1,TONNE) == UnitConvertor<Weight>(1000,KILO))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Tones_And_1000Grams_After_Additon_Should_Return_1001Kilo()
        {
            result = Convertor.Addition(UnitConvertor<Weight>(1,TONNE), UnitConvertor<Weight>(1000,GRAM), UnitConvertor<Weight>(1001,KILO));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_212F_And_100C_After_Compare_Shuould_Return_True()
        {
            if (UnitConvertor<Temprature>(212,FAHRENHEIT) == UnitConvertor<Temprature>(100,CELSIUS))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
      
      
    }
}
