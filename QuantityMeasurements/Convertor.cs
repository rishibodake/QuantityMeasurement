

using System;
using System.Reflection.Metadata.Ecma335;
using static QuantityMeasurements.Units;

namespace QuantityMeasurements
{
    public static class Convertor
    {
       public static double UnitConvertor<E>(double value, Enum unit)
        {
            Type type = typeof(E);
            string name = type.Name;
            return (name.ToLower()) switch
            {
                "length" => unit switch
                {
                    Length.FEET => value * 12,
                    Length.YARDS => value * 36,
                    Length.CM => value / 2.5,
                    Length.INCHES => value,
                    _ => throw new CustomException(CustomException.TypeOfException.CHECK_TYPE_OF_VALUE),
                },
                "volume" => unit switch
                {
                    Units.Volume.LITRE => value,
                    Units.Volume.GALLON => value * 3.78,
                    Units.Volume.ML => value / 1000,
                    _ => throw new CustomException(CustomException.TypeOfException.CHECK_TYPE_OF_VALUE),
                },
                "weight" => unit switch
                {
                    Units.Weight.KILO => value,
                    Units.Weight.GRAM => value / 1000,
                    Units.Weight.TONNE => value * 1000,
                    _ => throw new CustomException(CustomException.TypeOfException.CHECK_TYPE_OF_VALUE),
                },
                "temprature" => unit switch
                {
                    Units.Temprature.FAHRENHEIT => (value - 32) * 5 / 9,
                    Units.Temprature.CELSIUS => value,
                    _ => throw new CustomException(CustomException.TypeOfException.CHECK_TYPE_OF_VALUE),
                },
                _ => throw new CustomException(CustomException.TypeOfException.INVALID_TYPE_OF_MEASURE_SYSTEM),
            };
        }            
    }
}
