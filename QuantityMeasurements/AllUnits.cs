

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
                        return value * 39;
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
