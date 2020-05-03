using System;

namespace Circus_Trein.Exception
{
    [Serializable]
    public class WagonException : System.Exception
    {
        public WagonException()
        {
        }
        public WagonException(string message) : base(message)
        {
        }

        public WagonException(string message, System.Exception innerException)
            : base(message, innerException)
        {
            
        }    
    }
}