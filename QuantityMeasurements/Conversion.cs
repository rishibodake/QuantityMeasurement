﻿namespace QuantityMeasurements
{
    public class Conversion
    {
        public double FeetsToInches(double feet)
        {
            return feet * 12;
        }

        public double InchesToFeets(double inches)
        {
            return inches / 12;
        }

        public double YardsToInches(double yards)
        {
            return yards * 36;
        }
    }
}
