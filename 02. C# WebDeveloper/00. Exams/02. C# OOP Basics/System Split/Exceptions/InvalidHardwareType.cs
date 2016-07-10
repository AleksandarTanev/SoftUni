using System;

namespace System_Split.Exceptions
{
    class InvalidHardwareType : Exception
    {
        private const string InvalidHardwareTypeMessage = "The given hardware type is not valid.";

        public InvalidHardwareType()
            : base(InvalidHardwareTypeMessage)
        {

        }

        public InvalidHardwareType(string message)
            : base(message)
        {

        }
    }
}
