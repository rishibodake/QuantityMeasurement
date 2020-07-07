//-----------------------------------------------------------------------
// <copyright file="CustomException.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------
namespace QuantityMeasurements
{
    using System;

    /// <summary>
    /// Public class for Custom Exception
    /// </summary>
    public class CustomException : Exception
    {     
        /// <summary>
        /// Exception type
        /// </summary>
        public TypeOfException typeOfException;

        /// <summary>
        ///  /// Initializes a new instance of the <see cref="CustomException"/> class
        /// </summary>
        /// <param name="typeOfException">Input type of exception</param>
        public CustomException(TypeOfException typeOfException)
        {
            this.typeOfException = typeOfException;
        }

        /// <summary>
        /// Enums for custom exceptions
        /// </summary>
        public enum TypeOfException
        {
            /// <summary>
            /// Null Pointer Enum
            /// </summary>
            NULL_POINTER_EXCEPTION,

            /// <summary>
            /// Improper Type Enum
            /// </summary>
            INVALID_UNIT_FOR_GIVEN_MESUREMENT,

            /// <summary>
            /// Invalid Measure Enum
            /// </summary>
            INVALID_MEASUREMENT_UNIT_MISMATCH
        }
    }
}
