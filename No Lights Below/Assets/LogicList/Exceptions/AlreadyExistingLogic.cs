using System;

namespace LogicList.Exceptions
{
    public class AlreadyExistingLogic : Exception
    {
        // Constructor with a message only
        public AlreadyExistingLogic(string message) : base(message)
        {
        }

        // Constructor with a message and an inner exception
        public AlreadyExistingLogic(string message, Exception innerException) 
            : base(message, innerException)
        {
        }

        // Constructor with a message, an error code, and an inner exception
        public AlreadyExistingLogic(string message, int errorCode, Exception innerException) 
            : base(message + $" (Error Code: {errorCode})", innerException)
        {
        }

        // Default constructor
        public AlreadyExistingLogic() 
            : base("An instance of AlreadyExistingLogic has occurred.")
        {
        }
    }
}