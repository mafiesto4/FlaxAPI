// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.

using System;
using System.Runtime.Serialization;

namespace FlaxEngine
{
    [Serializable]
    public class MissingReferenceException : SystemException
    {
        public MissingReferenceException()
            : base("Missing reference exception.")
        {
        }

        public MissingReferenceException(string message)
            : base(message)
        {
        }

        public MissingReferenceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected MissingReferenceException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
