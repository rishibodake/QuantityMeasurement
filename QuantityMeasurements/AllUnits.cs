

using System;
using System.Reflection.Metadata.Ecma335;

namespace QuantityMeasurements
{
    public static class AllUnits
    {
       public static double ConvertToCentimeter(double value,string unit)
        {
            try
            {
                switch (unit.ToLower())
                {
                    case null:
                        throw new CustomException(CustomException.TypeOfException.NULL_POINTER_EXCEPTION);
                    case "feet":
                        return Math.Round(value * 30.38);
                    case "yards":
                        return Math.Round(value * 91.44);
                    case "inches":
                        return Math.Round(value * 2.54);
                    case "cm":
                        return value;
                    default:
                        throw new CustomException(CustomException.TypeOfException.CHECK_TYPE_OF_VALUE);
                }
            }
            catch (CustomException e)
            {
                throw new CustomException(CustomException.TypeOfException.NULL_POINTER_EXCEPTION);
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
