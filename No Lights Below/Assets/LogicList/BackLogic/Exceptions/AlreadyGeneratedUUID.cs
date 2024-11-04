using System;

namespace LogicList.BackLogic.Exceptions
{
    public class AlreadyGeneratedUuid : Exception
    {
        // Constructor with a message only
        public AlreadyGeneratedUuid(string message) : base(message)
        {
        }

        // Constructor with a message and an inner exception
        public AlreadyGeneratedUuid(string message, Exception innerException) 
            : base(message, innerException)
        {
        }

        // Constructor with a message, an error code, and an inner exception
        public AlreadyGeneratedUuid(string message, int errorCode, Exception innerException) 
            : base(message + $" (Error Code: {errorCode})", innerException)
        {
        }

        // Default constructor
        public AlreadyGeneratedUuid() 
            : base("An instance of AlreadyExistingLogic has occurred.")
        {
        }
    }
}