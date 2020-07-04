

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

        public static double ConvertToMili(double value,string unit)
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
                        return value * 3.785;
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
