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
           
            if (AllUnits.ConvertToInches(12, "inches") == AllUnits.ConvertToInches(1, "feet"))
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
            if (AllUnits.ConvertToInches(0, "feet") == AllUnits.ConvertToInches(0, "feet"))
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
            if(AllUnits.ConvertToInches(3,"feet") == AllUnits.ConvertToInches(1, "yards"))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Feet_And_1Yard_After_Compare_Should_Return_False()
        {          
            if(AllUnits.ConvertToInches(1,"FEET") == AllUnits.ConvertToInches(1, "YARDS"))
            {
                result = true;
            }
            Assert.IsFalse(result);
        }

        [Test]
        public void Provided_1Inche_And_1Yard_When_Compare_Should_Return_False()
        {            
            if (AllUnits.ConvertToInches(1,"inches") == AllUnits.ConvertToInches(1,"YARDS"))
            {
                result = true;
            }
            Assert.IsFalse(result);
        }

        [Test]
        public void Provided_1Yard_And_36Inches_When_Compare_Should_Return_True()
        {        
            if (AllUnits.ConvertToInches(1, "yards") == AllUnits.ConvertToInches(36, "inches")) {
                result = true;
            }           
            Assert.IsTrue(result);                   
        }

        [Test]
        public void Provided_36Inches_And_1Yard_When_Compare_Should_Return_True()
        {           
            if (AllUnits.ConvertToInches(36, "inches") == AllUnits.ConvertToInches(1, "yards"))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Yard_And_3Feet_When_Compare_Should_Return_True()
        {            
            if (AllUnits.ConvertToInches(1, "yards") == AllUnits.ConvertToInches(3, "feet"))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_2Inch_And_5CM_When_Compare_Should_Return_True()
        {
            if (AllUnits.ConvertToInches(2, "inches") == AllUnits.ConvertToInches(5, "cm"))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_2Inch_And_2Inch_After_Additon_Should_Return_4Inch()
        {
            result = AllUnits.Addition(AllUnits.ConvertToInches(2, "inches"), AllUnits.ConvertToInches(2, "inches"), AllUnits.ConvertToInches(4, "inches"));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Feet_And_2Inch_After_Additon_Should_Return_14Inch()
        {
            result = AllUnits.Addition(AllUnits.ConvertToInches(1, "feet"), AllUnits.ConvertToInches(2, "inches"), AllUnits.ConvertToInches(14, "inches"));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Feet_And_1Feet_After_Additon_Should_Return_24Inch()
        {
            result = AllUnits.Addition(AllUnits.ConvertToInches(1, "feet"), AllUnits.ConvertToInches(1, "feet"), AllUnits.ConvertToInches(24, "inches"));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_2Inch_And_2n5CM_After_Additon_Should_Return_3Inch()
        {
            result = AllUnits.Addition(AllUnits.ConvertToInches(2, "inches"), AllUnits.ConvertToInches(2.5, "cm"), AllUnits.ConvertToInches(3, "inches"));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Gallon_And_3point78_Liter_After_Compare_Shuould_Return_True()
        {
            if (AllUnits.ConvertToLiters(1, "gallon") == AllUnits.ConvertToLiters(3.78, "litre"))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1litre_And_100MiliLiter_After_Compare_Shuould_Return_True()
        {
            if (AllUnits.ConvertToLiters(1, "litre") == AllUnits.ConvertToLiters(1000, "ml"))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Gallon_And_3o78_litre_After_Additon_Should_Return_7o57litre()
        {
            result = AllUnits.Addition(AllUnits.ConvertToLiters(1, "gallon"), AllUnits.ConvertToLiters(3.78, "litre"), AllUnits.ConvertToLiters(7.56, "litre"));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Lire_And_1000mllitre_After_Additon_Should_Return_2litre()
        {
            result = AllUnits.Addition(AllUnits.ConvertToLiters(1, "litre"), AllUnits.ConvertToLiters(1000, "ml"), AllUnits.ConvertToLiters(2, "litre"));
            Assert.IsTrue(result);
        }

        [Test]
        public void Provided_1Kg_And_1000Grams_After_Compare_Shuould_Return_True()
        {
            if (AllUnits.ConvertToKilos(1, "kg") == AllUnits.ConvertToKilos(1000, "grams"))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}
