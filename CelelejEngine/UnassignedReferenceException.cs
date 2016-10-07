using System;
using System.Runtime.Serialization;

namespace CelelejEngine
{
    [Serializable]
    public class UnassignedReferenceException : SystemException
    {
        public UnassignedReferenceException()
            : base("Unassigned reference exception.")
        {
        }

        public UnassignedReferenceException(string message)
            : base(message)
        {
        }

        public UnassignedReferenceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected UnassignedReferenceException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
