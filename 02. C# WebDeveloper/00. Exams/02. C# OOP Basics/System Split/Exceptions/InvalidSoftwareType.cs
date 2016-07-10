using System;

namespace System_Split.Exceptions
{
    class InvalidSoftwareType : Exception
    {
        private const string InvalidSoftwareTypeMessage = "The given software type is not valid.";

        public InvalidSoftwareType()
            : base(InvalidSoftwareTypeMessage)
        {
            
        }

        public InvalidSoftwareType(string message)
            : base(message)
        {

        }
    }
}
