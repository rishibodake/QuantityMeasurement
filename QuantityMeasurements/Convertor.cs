

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
                case "temprature":
                    switch (unit)
                    {
                        case Units.Temprature.FAHRENHEIT:
                            return (value - 32) * 5 / 9;
                        case Units.Temprature.CELSIUS:
                            return value;
                        default:
                            throw new CustomException(CustomException.TypeOfException.CHECK_TYPE_OF_VALUE);
                    }
                default:
                    throw new CustomException(CustomException.TypeOfException.INVALID_TYPE_OF_MEASURE_SYSTEM);
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
