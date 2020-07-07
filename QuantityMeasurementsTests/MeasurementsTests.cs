using NUnit.Framework;
using QuantityMeasurements;
using static QuantityMeasurements.Units;
using static QuantityMeasurements.Convertor;
using static QuantityMeasurements.AdditionOfUnits;
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
        public void Provided_TwelveInche_And_OneFeet_Should_Return_True()
        {           
            result = UnitConvertor<Length>(12, INCHES) == UnitConvertor<Length>(1, FEET);
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_ZeroFeet_And_ZeroFeet_Should_Return_True()
        {
            Feet first_value = new  Feet(0.0);
            Feet second_value = new Feet(0.0);            
            Assert.IsTrue(first_value.feet.Equals(second_value.feet));
        }

        [Test]
        public void Provided_ZeroFeet_And_NullValue_Shuold_Return_False()
        {
            Feet feet = new Feet();            
            Assert.IsFalse(feet.Equals(null));
        }

        [Test]
        public void Provided_ZeroFeet_And_ZeroFeet_Shuold_Return_True()
        {           
          //  if (UnitConvertor<Length>(0,FEET) == UnitConvertor<Length>(0,FEET))
            //{
              //  result = true;
            //}
            result = UnitConvertor<Length>(0, FEET) == UnitConvertor<Length>(0, FEET);
            Assert.IsTrue(result);
        }

        [Test]
        public void Reference_Check_Test_For_Feet()
        {
            Feet first_value = new Feet();
            Feet second_value = new Feet();
            Assert.IsFalse(first_value.Equals(second_value));
        }

        [Test]
        public void Provided_Improper_Type_Object_Should_Return_False()
        {
            Feet first_value = new Feet();
            object second_value = new object();
            Assert.IsFalse(first_value.Equals(second_value));
        }

        [Test]
        public void Provided_Equal_Value_Shuold_Return_True()
        {
            Feet first_value = new Feet();
            first_value.feet = 4.6;
            Assert.IsTrue(first_value.Equals(first_value));            
        }

        [Test]
        public void Provided_0Inche_And_0Inche_Should_Return_True()
        {
            Inches first_value = new Inches(0.0);
            Inches second_value = new Inches(0.0);
            Assert.IsTrue(first_value.inches.Equals(second_value.inches));
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
            Inches first_value = new Inches();
            Inches second_value = new Inches();
            Assert.IsFalse(first_value.Equals(second_value));
        }
       
        [Test]
        public void Provided_Equal_Inch_Value_Shuold_Return_True()
        {
            Inches value = new Inches();
            value.inches = 4.6;
            Assert.IsTrue(value.Equals(value));
       }
        [Test]
        public void Provided_Improper_Inches_Type_Object_Should_Return_False()
        {
            Inches first_value = new Inches();
            object second_value = new object();
            Assert.IsFalse(first_value.Equals(second_value));
        }      
        
        [Test]
        public void Provided_ThreeFeet_And_OneYard_After_Compare_Should_Return_True()
        {                     
            result = UnitConvertor<Length>(3, FEET) == UnitConvertor<Length>(1, YARDS);
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_OneFeet_And_OneYard_After_Compare_Should_Return_False()
        {                  
            result = UnitConvertor<Length>(1, FEET) == UnitConvertor<Length>(1, YARDS);
            Assert.IsFalse(result);
        }

        [Test]
        public void Provided_OneInche_And_OneYard_When_Compare_Should_Return_False()
        {                      
            result = UnitConvertor<Length>(1, INCHES) == UnitConvertor<Length>(1, YARDS);
            Assert.IsFalse(result);
        }

        [Test]
        public void Provided_OneYard_And_ThirtySixInches_When_Compare_Should_Return_True()
        {                  
            result = UnitConvertor<Length>(1, YARDS) == UnitConvertor<Length>(36, INCHES);
            Assert.IsTrue(result);                   
        }

        [Test]
        public void Provided_ThirtySixInches_And_OneYard_When_Compare_Should_Return_True()
        {                       
            result = UnitConvertor<Length>(36, INCHES) == UnitConvertor<Length>(1, YARDS);
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_OneYard_And_ThreeFeet_When_Compare_Should_Return_True()
        {                     
            result = UnitConvertor<Length>(1, YARDS) == UnitConvertor<Length>(3, FEET);
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_TwoInch_And_FiveCM_When_Compare_Should_Return_True()
        {         
            result = UnitConvertor<Length>(2, INCHES) == UnitConvertor<Length>(5, CM);
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_TwoInch_And_TwoInch_After_Additon_Should_Return_FoueInch()
        {
            result = Addition(UnitConvertor<Length>(2,INCHES), UnitConvertor<Length>(2,INCHES), UnitConvertor<Length>(4,INCHES));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_OneFeet_And_TwoInch_After_Additon_Should_Return_ForteenInch()
        {
            result = Addition(UnitConvertor<Length>(1,FEET), UnitConvertor<Length>(2,INCHES), UnitConvertor<Length>(14,INCHES));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_OneFeet_And_OneFeet_After_Additon_Should_Return_TwntyFourInch()
        {
            result = Addition(UnitConvertor<Length>(1, FEET), UnitConvertor<Length>(1,FEET), UnitConvertor<Length>(24,INCHES));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_TwoInch_And_TwoAndHalfCM_After_Additon_Should_Return_ThreeInch()
        {
            result = Addition(UnitConvertor<Length>(2,INCHES), UnitConvertor<Length>(2.5,CM), UnitConvertor<Length>(3,INCHES));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_OneGallon_And_ThreePonitSevenEight_Liter_After_Compare_Shuould_Return_True()
        {            
            result = UnitConvertor<Volume>(1, GALLON) == UnitConvertor<Volume>(3.78, LITRE);
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_Onelitre_And_ThoughsandMiliLiter_After_Compare_Shuould_Return_True()
        {           
            result = (UnitConvertor<Volume>(1, LITRE) == UnitConvertor<Volume>(1000, ML));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_OneGallon_And_ThreePointSeventyEight_litre_After_Additon_Should_Return_SevenPointFiftySix_litre()
        {
            result = Addition(UnitConvertor<Volume>(1,GALLON), UnitConvertor<Volume>(3.78,LITRE), UnitConvertor<Volume>(7.56,LITRE));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_OneLire_And_Thousandmllitre_After_Additon_Should_Return_Twolitre()
        {
            result = Addition(UnitConvertor<Volume>(1, LITRE), UnitConvertor<Volume>(1000,ML),UnitConvertor<Volume>(2,LITRE));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_OneKg_And_ThaousandGrams_After_Compare_Shuould_Return_True()
        {           
            result = UnitConvertor<Weight>(1, KILO) == UnitConvertor<Weight>(1000, GRAM);
            Assert.IsTrue(result);
        }


        [Test]
        public void Provided_OneTones_And_ThousandKilos_After_Compare_Shuould_Return_True()
        {            
            result = UnitConvertor<Weight>(1, TONNE) == UnitConvertor<Weight>(1000, KILO);
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_OneTones_And_ThousandGrams_After_Additon_Should_Return_ThousandAndOne_Kilo()
        {
            result = Addition(UnitConvertor<Weight>(1,TONNE), UnitConvertor<Weight>(1000,GRAM), UnitConvertor<Weight>(1001,KILO));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_TwoHundreadTwelveF_And_HundredC_After_Compare_Shuould_Return_True()
        {           
            result = UnitConvertor<Temprature>(212, FAHRENHEIT) == UnitConvertor<Temprature>(100, CELSIUS);
            Assert.IsTrue(result);
        }
      
      
    }
}
