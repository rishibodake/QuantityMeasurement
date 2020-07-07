//-----------------------------------------------------------------------
// <copyright file="Inches.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------

namespace QuantityMeasurements
{
    /// <summary>
    /// Public class for Inch
    /// </summary>
    public class Inches
    {
        /// <summary>
        /// global value for inch
        /// </summary>
        public double Inch;

        /// <summary>
        /// Initializes a new instance of the <see cref="Inches"/> class
        /// </summary>
        public Inches()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Inches"/> class
        /// </summary>
        /// <param name="inches">Input parameter</param>
        public Inches(double inches)
        {
            this.Inch = inches;
        }

        /// <summary>
        /// Override Method
        /// </summary>
        /// <param name="obj">Input object</param>
        /// <returns>Returns boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) 
            {
                return false;
            }

            if (!(obj == this)) 
            { 
                return false; 
            }

            if (!(obj.GetType() == this.GetType())) 
            {
                return false;
            }

            return ((Inches)obj).Inch == this.Inch;
        }

        /// <summary>
        /// Override Method
        /// </summary>
        /// <returns>Integer Value</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Override ToString method
        /// </summary>
        /// <returns>return String</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
