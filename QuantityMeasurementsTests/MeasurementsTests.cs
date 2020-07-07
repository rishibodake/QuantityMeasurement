using NUnit.Framework;
using QuantityMeasurements;
using System;
using System.Xml.Serialization;

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
           
            if (AllUnits.ConvertToInches(12,Units.Length.INCHES) == AllUnits.ConvertToInches(1, Units.Length.FEET))
            {
                result = true;
            }

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
            if (AllUnits.ConvertToInches(0,Units.Length.FEET) == AllUnits.ConvertToInches(0, Units.Length.FEET))
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
            if(AllUnits.ConvertToInches(3,Units.Length.FEET) == AllUnits.ConvertToInches(1, Units.Length.YARDS))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Feet_And_1Yard_After_Compare_Should_Return_False()
        {          
            if(AllUnits.ConvertToInches(1,Units.Length.FEET) == AllUnits.ConvertToInches(1, Units.Length.YARDS))
            {
                result = true;
            }
            Assert.IsFalse(result);
        }

        [Test]
        public void Provided_1Inche_And_1Yard_When_Compare_Should_Return_False()
        {            
            if (AllUnits.ConvertToInches(1,Units.Length.INCHES) == AllUnits.ConvertToInches(1,Units.Length.YARDS))
            {
                result = true;
            }
            Assert.IsFalse(result);
        }

        [Test]
        public void Provided_1Yard_And_36Inches_When_Compare_Should_Return_True()
        {        
            if (AllUnits.ConvertToInches(1, Units.Length.YARDS) == AllUnits.ConvertToInches(36, Units.Length.INCHES)) {
                result = true;
            }           
            Assert.IsTrue(result);                   
        }

        [Test]
        public void Provided_36Inches_And_1Yard_When_Compare_Should_Return_True()
        {           
            if (AllUnits.ConvertToInches(36, Units.Length.INCHES) == AllUnits.ConvertToInches(1, Units.Length.YARDS))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Yard_And_3Feet_When_Compare_Should_Return_True()
        {            
            if (AllUnits.ConvertToInches(1, Units.Length.YARDS) == AllUnits.ConvertToInches(3, Units.Length.FEET))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_2Inch_And_5CM_When_Compare_Should_Return_True()
        {
            if (AllUnits.ConvertToInches(2, Units.Length.INCHES) == AllUnits.ConvertToInches(5, Units.Length.CM))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_2Inch_And_2Inch_After_Additon_Should_Return_4Inch()
        {
            result = AllUnits.Addition(AllUnits.ConvertToInches(2, Units.Length.INCHES), AllUnits.ConvertToInches(2, Units.Length.INCHES), AllUnits.ConvertToInches(4, Units.Length.INCHES));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Feet_And_2Inch_After_Additon_Should_Return_14Inch()
        {
            result = AllUnits.Addition(AllUnits.ConvertToInches(1, Units.Length.FEET), AllUnits.ConvertToInches(2, Units.Length.INCHES), AllUnits.ConvertToInches(14, Units.Length.INCHES));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Feet_And_1Feet_After_Additon_Should_Return_24Inch()
        {
            result = AllUnits.Addition(AllUnits.ConvertToInches(1, Units.Length.FEET), AllUnits.ConvertToInches(1, Units.Length.FEET), AllUnits.ConvertToInches(24, Units.Length.INCHES));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_2Inch_And_2n5CM_After_Additon_Should_Return_3Inch()
        {
            result = AllUnits.Addition(AllUnits.ConvertToInches(2, Units.Length.INCHES), AllUnits.ConvertToInches(2.5, Units.Length.CM), AllUnits.ConvertToInches(3, Units.Length.INCHES));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Gallon_And_3point78_Liter_After_Compare_Shuould_Return_True()
        {
            if (AllUnits.ConvertToLiters(1, Units.Volume.GALLON) == AllUnits.ConvertToLiters(3.78, Units.Volume.LITRE))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1litre_And_100MiliLiter_After_Compare_Shuould_Return_True()
        {
            if (AllUnits.ConvertToLiters(1, Units.Volume.LITRE) == AllUnits.ConvertToLiters(1000, Units.Volume.ML))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Gallon_And_3o78_litre_After_Additon_Should_Return_7o57litre()
        {
            result = AllUnits.Addition(AllUnits.ConvertToLiters(1, Units.Volume.GALLON), AllUnits.ConvertToLiters(3.78, Units.Volume.LITRE), AllUnits.ConvertToLiters(7.56, Units.Volume.LITRE));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Lire_And_1000mllitre_After_Additon_Should_Return_2litre()
        {
            result = AllUnits.Addition(AllUnits.ConvertToLiters(1, Units.Volume.LITRE), AllUnits.ConvertToLiters(1000, Units.Volume.ML), AllUnits.ConvertToLiters(2, Units.Volume.LITRE));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Kg_And_1000Grams_After_Compare_Shuould_Return_True()
        {
            if (AllUnits.ConvertToKilos(1, Units.Weight.KILO) == AllUnits.ConvertToKilos(1000, Units.Weight.GRAM))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }


        [Test]
        public void Provided_1Tones_And_1000Kilos_After_Compare_Shuould_Return_True()
        {
            if (AllUnits.ConvertToKilos(1, Units.Weight.TONNE) == AllUnits.ConvertToKilos(1000, Units.Weight.KILO))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Tones_And_1000Grams_After_Additon_Should_Return_1001Kilo()
        {
            result = AllUnits.Addition(AllUnits.ConvertToKilos(1, Units.Weight.TONNE), AllUnits.ConvertToKilos(1000, Units.Weight.GRAM), AllUnits.ConvertToKilos(1001, Units.Weight.KILO));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_212F_And_100C_After_Compare_Shuould_Return_True()
        {
            if (AllUnits.ConvertTemprature(212, Units.Temprature.FAHRENHEIT) == AllUnits.ConvertTemprature(100, Units.Temprature.CELSIUS))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
      
    }
}
