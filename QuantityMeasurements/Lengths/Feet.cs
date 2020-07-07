//-----------------------------------------------------------------------
// <copyright file="Feet.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------
namespace QuantityMeasurements
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Public class for foot
    /// </summary>
    public class Feet
    {
        /// <summary>
        /// Global value for feet
        /// </summary>
        public double ValueInFeet;

        /// <summary>
        /// Initializes a new instance of the <see cref="Feet"/> class
        /// </summary>
        public Feet()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Feet"/> class
        /// </summary>
        /// <param name="feet">Input parameter</param>
        public Feet(double feet)
        {
            this.ValueInFeet = feet;
        }

        /// <summary>
        /// Override method 
        /// </summary>
        /// <param name="obj">Input object</param>
        /// <returns>Returns boolean value</returns>
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

            return ((Feet)obj).ValueInFeet == this.ValueInFeet;
        }

        /// <summary>
        /// Override Method
        /// </summary>
        /// <returns>Integer value</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.ValueInFeet);
        }
    }
}
