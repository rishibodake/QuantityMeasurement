namespace QuantityMeasurementsTests
{
    public class Compare
    {
        public bool Check(int feets, int inches)
        {
            if(inches/feets == inches)
            {
                return true;
            }
            return false;
        }
    }
}
