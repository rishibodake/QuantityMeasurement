

namespace QuantityMeasurements
{
    public class Inches
    {
        public double inches;
        public Inches()
        {
        }

        public Inches(double inches)
        {
            this.inches = inches;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj == this)) return false;
            if (!(obj.GetType() == this.GetType())) return false;
            return (((Inches)obj).inches == this.inches);
        }
    }
}
