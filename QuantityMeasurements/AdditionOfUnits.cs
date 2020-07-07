namespace QuantityMeasurements
{
    public static class AdditionOfUnits
    {
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
