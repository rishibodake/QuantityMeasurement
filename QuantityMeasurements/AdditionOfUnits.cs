//-----------------------------------------------------------------------
// <copyright file="AdditionOfUnits.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------

namespace QuantityMeasurements
{
    /// <summary>
    /// Static type of class that will help to add units
    /// </summary>
    public static class AdditionOfUnits
    {
        /// <summary> 
        /// Method that add given units
        /// </summary>
        /// <param name="firstValue">First Value As Parameter</param>
        /// <param name="secondValue">Second Value As Parameter</param>
        /// <param name="expected_value">Expected Value</param>
        /// <returns>Condition after addition</returns>
        public static bool Addition(double firstValue, double secondValue, double expected_value)
        {
            double result = firstValue + secondValue;
            if (result == expected_value)
            {
                return true;
            }

            return false;
        }
    }
}
