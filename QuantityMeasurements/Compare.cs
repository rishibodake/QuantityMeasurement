namespace QuantityMeasurementsTests
{
    public class Compare
    {
        public bool CompareFeetToInches(int feets, int inches)
        {
            if(inches/12 == feets)
            {
                return true;
            }
            return false;
        }
        public bool CompareFeetToYards(double feet, double yards)
        {
            if(feet/3 == yards)
            {
                return true;
            }
            return false;
        }
    }
}
