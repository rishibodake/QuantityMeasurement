

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
            catch (CustomException)
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
