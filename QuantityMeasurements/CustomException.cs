using System;

namespace QuantityMeasurements
{
    public class CustomException : Exception
    {
        public enum TypeOfException
        {
            NULL_POINTER_EXCEPTION,CHECK_TYPE_OF_VALUE
        }
        public TypeOfException typeOfException;

        public CustomException(TypeOfException typeOfException)
        {
            this.typeOfException = typeOfException;
        }
    }


}
