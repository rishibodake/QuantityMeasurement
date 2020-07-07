//-----------------------------------------------------------------------
// <copyright file="PositiveTestScenarios.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------
namespace QuantityMeasurementsTests
{
    using NUnit.Framework;
    using QuantityMeasurements;
    using static QuantityMeasurements.AdditionOfUnits;   
    using static QuantityMeasurements.Convertor;
    using static QuantityMeasurements.Units;
    using static QuantityMeasurements.Units.Length;
    using static QuantityMeasurements.Units.Temperature;  
    using static QuantityMeasurements.Units.Volume;
    using static QuantityMeasurements.Units.Weight;
    
    /// <summary>
    /// Class for all the positive test cases
    /// </summary>
    public class PositiveTestScenarios
    {
        /// <summary>
        /// default boolean value
        /// </summary>
        public bool Result; 

        /// <summary>
        /// Setup attribute
        /// </summary>
        [SetUp]
        public void Initialisation()
        {
           this.Result = false;
        }

        /// <summary>
        /// Test Case For Comparing
        /// </summary>       
        [Test]
        public void Provided_TwelveInche_And_OneFeet_Should_Return_True()
        {           
            this.Result = UnitConvertor<Length>(12, INCHES) == UnitConvertor<Length>(1, FEET);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>       
        [Test]
        public void Provided_ZeroFeet_And_ZeroFeet_Should_Return_True()
        {
            Feet first_value = new Feet(0.0);
            Feet second_value = new Feet(0.0);            
            Assert.IsTrue(first_value.ValueInFeet.Equals(second_value.ValueInFeet));
        }

        /// <summary>
        /// Test Case 
        /// </summary>
        [Test]
        public void Provided_ZeroFeet_And_NullValue_Shuold_Return_False()
        {
            Feet feet = new Feet();            
            Assert.IsFalse(feet.Equals(null));
        }

        /// <summary>
        /// Test Case 
        /// </summary>
        [Test]
        public void Provided_ZeroFeet_And_ZeroFeet_Shuold_Return_True()
        {                    
            this.Result = UnitConvertor<Length>(0, FEET) == UnitConvertor<Length>(0, FEET);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Reference_Check_Test_For_Feet()
        {
            Feet first_value = new Feet();
            Feet second_value = new Feet();
            Assert.IsFalse(first_value.Equals(second_value));
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_Improper_Type_Object_Should_Return_False()
        {
            Feet first_value = new Feet();
            object second_value = new object();
            Assert.IsFalse(first_value.Equals(second_value));
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_Equal_Value_Shuold_Return_True()
        {
            Feet first_value = new Feet();
            first_value.ValueInFeet = 4.6;
            Assert.IsTrue(first_value.Equals(first_value));            
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_0Inche_And_0Inche_Should_Return_True()
        {
            Inches first_value = new Inches(0.0);
            Inches second_value = new Inches(0.0);
            Assert.IsTrue(first_value.Inch.Equals(second_value.Inch));
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_0Inch_And_NullValue_Shuold_Return_False()
        {
            Inches inch = new Inches();
            Assert.IsFalse(inch.Equals(null));
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Reference_Check_Test_For_Inch()
        {
            Inches first_value = new Inches();
            Inches second_value = new Inches();
            Assert.IsFalse(first_value.Equals(second_value));
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_Equal_Inch_Value_Shuold_Return_True()
        {
            Inches value = new Inches();
            value.Inch = 4.6;
            Assert.IsTrue(value.Equals(value));
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_Improper_Inches_Type_Object_Should_Return_False()
        {
            Inches first_value = new Inches();
            object second_value = new object();
            Assert.IsFalse(first_value.Equals(second_value));
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_ThreeFeet_And_OneYard_After_Compare_Should_Return_True()
        {
            this.Result = UnitConvertor<Length>(3, FEET) == UnitConvertor<Length>(1, YARDS);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_OneFeet_And_OneYard_After_Compare_Should_Return_False()
        {
            this.Result = UnitConvertor<Length>(1, FEET) == UnitConvertor<Length>(1, YARDS);
            Assert.IsFalse(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_OneInche_And_OneYard_When_Compare_Should_Return_False()
        {
            this.Result = UnitConvertor<Length>(1, INCHES) == UnitConvertor<Length>(1, YARDS);
            Assert.IsFalse(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_OneYard_And_ThirtySixInches_When_Compare_Should_Return_True()
        {
            this.Result = UnitConvertor<Length>(1, YARDS) == UnitConvertor<Length>(36, INCHES);
            Assert.IsTrue(this.Result);                   
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_ThirtySixInches_And_OneYard_When_Compare_Should_Return_True()
        {
            this.Result = UnitConvertor<Length>(36, INCHES) == UnitConvertor<Length>(1, YARDS);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_OneYard_And_ThreeFeet_When_Compare_Should_Return_True()
        {
            this.Result = UnitConvertor<Length>(1, YARDS) == UnitConvertor<Length>(3, FEET);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_TwoInch_And_FiveCM_When_Compare_Should_Return_True()
        {
            this.Result = UnitConvertor<Length>(2, INCHES) == UnitConvertor<Length>(5, CM);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_TwoInch_And_TwoInch_After_Additon_Should_Return_FoueInch()
        {
            this.Result = Addition(UnitConvertor<Length>(2, INCHES), UnitConvertor<Length>(2, INCHES), UnitConvertor<Length>(4, INCHES));
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_OneFeet_And_TwoInch_After_Additon_Should_Return_ForteenInch()
        {
            this.Result = Addition(UnitConvertor<Length>(1, FEET), UnitConvertor<Length>(2, INCHES), UnitConvertor<Length>(14, INCHES));
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_OneFeet_And_OneFeet_After_Additon_Should_Return_TwntyFourInch()
        {
            this.Result = Addition(UnitConvertor<Length>(1, FEET), UnitConvertor<Length>(1, FEET), UnitConvertor<Length>(24, INCHES));
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_TwoInch_And_TwoAndHalfCM_After_Additon_Should_Return_ThreeInch()
        {
            this.Result = Addition(UnitConvertor<Length>(2, INCHES), UnitConvertor<Length>(2.5, CM), UnitConvertor<Length>(3, INCHES));
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_OneGallon_And_ThreePonitSevenEight_Liter_After_Compare_Shuould_Return_True()
        {
            this.Result = UnitConvertor<Volume>(1, GALLON) == UnitConvertor<Volume>(3.78, LITRE);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_Onelitre_And_ThoughsandMiliLiter_After_Compare_Shuould_Return_True()
        {
            this.Result = UnitConvertor<Volume>(1, LITRE) == UnitConvertor<Volume>(1000, ML);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_OneGallon_And_ThreePointSeventyEight_litre_After_Additon_Should_Return_SevenPointFiftySix_litre()
        {
            this.Result = Addition(UnitConvertor<Volume>(1, GALLON), UnitConvertor<Volume>(3.78, LITRE), UnitConvertor<Volume>(7.56, LITRE));
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_OneLire_And_Thousandmllitre_After_Additon_Should_Return_Twolitre()
        {
            this.Result = Addition(UnitConvertor<Volume>(1, LITRE), UnitConvertor<Volume>(1000, ML), UnitConvertor<Volume>(2, LITRE));
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_OneKg_And_ThaousandGrams_After_Compare_Shuould_Return_True()
        {
            this.Result = UnitConvertor<Weight>(1, KILO) == UnitConvertor<Weight>(1000, GRAM);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_OneTones_And_ThousandKilos_After_Compare_Shuould_Return_True()
        {
            this.Result = UnitConvertor<Weight>(1, TONNE) == UnitConvertor<Weight>(1000, KILO);
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_OneTones_And_ThousandGrams_After_Additon_Should_Return_ThousandAndOne_Kilo()
        {
            this.Result = Addition(UnitConvertor<Weight>(1, TONNE), UnitConvertor<Weight>(1000, GRAM), UnitConvertor<Weight>(1001, KILO));
            Assert.IsTrue(this.Result);
        }

        /// <summary>
        /// Test Case
        /// </summary>
        [Test]
        public void Provided_TwoHundreadTwelveF_And_HundredC_After_Compare_Shuould_Return_True()
        {           
            this.Result = UnitConvertor<Temperature>(212, FAHRENHEIT) == UnitConvertor<Temperature>(100, CELSIUS);
            Assert.IsTrue(this.Result);
        }      
    }
}
