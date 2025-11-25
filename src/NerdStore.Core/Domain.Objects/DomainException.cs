using System.Drawing;

namespace NerdStore.Core.Domain.Objects
{
    public class DomainException : Exception
    {
        public DomainException()
        {
            
        }

        public DomainException(string message) : base(message)
        {
            
        }

        public DomainException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}
