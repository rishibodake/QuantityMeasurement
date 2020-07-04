using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurements
{
    public class Feet
    {
        private double feet;

        public Feet()
        {
        }

        public Feet(double feet)
        {
            this.feet = feet;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj == this)) return false;
            if (!(obj.GetType() == this.GetType())) return false;
            return (((Feet)obj).feet == this.feet);
        }
    }
}
