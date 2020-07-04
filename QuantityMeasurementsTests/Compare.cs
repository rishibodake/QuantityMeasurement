namespace QuantityMeasurementsTests
{
    public class Compare
    {
        public bool Check(int feets, int inches)
        {
            if(inches/12 == feets)
            {
                return true;
            }
            return false;
        }
    }
}
