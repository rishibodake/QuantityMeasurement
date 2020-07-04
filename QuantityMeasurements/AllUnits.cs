

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
    }
}
