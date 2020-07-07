//-----------------------------------------------------------------------
// <copyright file="Convertor.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------
namespace QuantityMeasurements
{
    using System;
    using System.Reflection.Metadata.Ecma335;
    using static QuantityMeasurements.Units;

    /// <summary>
    /// Static type of class that contains method to convert the units to base units
    /// </summary>
    public static class Convertor
    {
        /// <summary>
        /// Method returns double and it is static method
        /// </summary>
        /// <typeparam name="E">Generic type of enum</typeparam>
        /// <param name="value">Input parameter value</param>
        /// <param name="unit">Input enum value</param>
        /// <returns>Return double value after processing</returns>
       public static double UnitConvertor<E>(double value, Enum unit)
        {
            Type type = typeof(E);
            string name = type.Name;
            switch (name.ToLower())
            {
                case "length":
                    switch (unit)
                    {
                        case Length.FEET:
                            return value * 12;
                        case Length.YARDS:
                            return value * 36;
                        case Length.CM:
                            return value / 2.5;
                        case Length.INCHES:
                            return value;
                        default:
                            throw new CustomException(CustomException.TypeOfException.CHECK_TYPE_OF_VALUE);
                    }

                case "volume":
                    switch (unit)
                    {
                        case Units.Volume.LITRE:
                            return value;
                        case Units.Volume.GALLON:
                            return value * 3.78;
                        case Units.Volume.ML:
                            return value / 1000;
                        default:
                            throw new CustomException(CustomException.TypeOfException.CHECK_TYPE_OF_VALUE);
                    }

                case "weight":
                    switch (unit)
                    {
                        case Units.Weight.KILO:
                            return value;
                        case Units.Weight.GRAM:
                            return value / 1000;
                        case Units.Weight.TONNE:
                            return value * 1000;
                        default:
                            throw new CustomException(CustomException.TypeOfException.CHECK_TYPE_OF_VALUE);
                    }

                case "temperature":
                    switch (unit)
                    {
                        case Units.Temperature.FAHRENHEIT:
                            return (value - 32) * 5 / 9;
                        case Units.Temperature.CELSIUS:
                            return value;
                        default:
                            throw new CustomException(CustomException.TypeOfException.CHECK_TYPE_OF_VALUE);
                    }

                default:
                    throw new CustomException(CustomException.TypeOfException.INVALID_TYPE_OF_MEASURE_SYSTEM);
            }
        }            
    }
}
