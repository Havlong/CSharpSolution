using System;

namespace SixthLab.Classes
{
    public class NotANumberException : InvalidCastException
    {
        public Object Cause
        {
            get;
        }

        public NotANumberException(string message, object cause) : base(message + "\nProvided type: " + cause.GetType())
        {
            Cause = cause;
        }
    }
}