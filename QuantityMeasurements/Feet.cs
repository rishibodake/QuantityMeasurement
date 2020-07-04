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
            if (this == obj)
                return true;
            if(obj == null)
                return false;
            return true;                                
        }
    }
}
