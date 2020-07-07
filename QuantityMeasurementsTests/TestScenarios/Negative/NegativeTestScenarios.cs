//-----------------------------------------------------------------------
// <copyright file="NegativeTestScenarios.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------
namespace QuantityMeasurementsTests
{
    using System;
    using NUnit.Framework;
    using QuantityMeasurements;
    using static QuantityMeasurements.Convertor;
    using static QuantityMeasurements.Units;
    using static QuantityMeasurements.Units.Length;
    using static QuantityMeasurements.Units.Volume;

    /// <summary>
    /// Public Class For Negative Test Cases
    /// </summary>
    public class NegativeTestScenarios
    {        
        /// <summary>
        /// Test Method to 
        /// </summary>
        [Test]
        public void Provided_Improper_Type_Measurment_Should_Throw_Exception()
        {
            try
            {
                bool result = UnitConvertor<Length>(12, INCHES) == UnitConvertor<Length>(1, GALLON);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.TypeOfException.INVALID_UNIT_FOR_GIVEN_MESUREMENT, e.typeOfException);
            }           
        }

        /// <summary>
        /// Test Method
        /// </summary>
        [Test]
        public void Improper_Type_Measurment_Should_Throw_Exception()
        {
            try
            {
                bool result = UnitConvertor<Volume>(12, INCHES) == UnitConvertor<Volume>(1, GALLON);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(CustomException.TypeOfException.INVALID_MEASUREMENT_UNIT_MISMATCH, e.typeOfException);
            }
        }
    }
}
