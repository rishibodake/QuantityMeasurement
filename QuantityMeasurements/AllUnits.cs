﻿

using System;
using System.Reflection.Metadata.Ecma335;

namespace QuantityMeasurements
{
    public static class AllUnits
    {
       public static double ConvertToInches(double value,string unit)
        {
            try
            {
                switch (unit.ToLower())
                {
                    case null:
                        throw new CustomException(CustomException.TypeOfException.NULL_POINTER_EXCEPTION);
                    case "feet":
                        return value * 12;
                    case "yards":
                        return value * 36;
                    case "cm":
                        return value/2.5;
                    case "inches":
                        return value;
                    default:
                        throw new CustomException(CustomException.TypeOfException.CHECK_TYPE_OF_VALUE);
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public static double ConvertToLiters(double value, string unit)
        {
            try
            {
                switch (unit.ToLower())
                {
                    case null:
                        throw new CustomException(CustomException.TypeOfException.NULL_POINTER_EXCEPTION);
                    case "litre":
                        return value;
                    case "gallon":
                        return value * 3.78;
                    case "ml":
                        return value / 1000;
                    default:
                        throw new CustomException(CustomException.TypeOfException.CHECK_TYPE_OF_VALUE);
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public static double ConvertToKilos(double value, string unit)
        {
            try
            {
                switch (unit.ToLower())
                {
                    case null:
                        throw new CustomException(CustomException.TypeOfException.NULL_POINTER_EXCEPTION);
                    case "kg":
                        return value;
                    case "grams":
                        return value /1000;
                    case "tones":
                        return value*1000;
                    default:
                        throw new CustomException(CustomException.TypeOfException.CHECK_TYPE_OF_VALUE);
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public static double ConvertTemprature(double value, string unit)
        {
            try
            {
                switch (unit)
                {
                    case null:
                        throw new CustomException(CustomException.TypeOfException.NULL_POINTER_EXCEPTION);
                    case "F":
                        return (value - 32) * 5 / 9;
                    case "C":
                        return value;
                    default:
                        throw new CustomException(CustomException.TypeOfException.CHECK_TYPE_OF_VALUE);
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public static bool Addition(double value_1, double value_2, double expected_value)
        {
            double result = value_1 + value_2;           
            if (result == expected_value)
            {
                return true;
            }
            return false;
        }
    }
}
