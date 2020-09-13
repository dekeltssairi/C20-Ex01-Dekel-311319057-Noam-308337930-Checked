using System;
using System.Runtime.Serialization;

namespace FacadeLayer
{
    [Serializable]
    public class SingletonException
       : Exception
    {
        public SingletonException()
        {
        }

        public SingletonException(string message)
           : base(message)
        {
        }

        public SingletonException(Exception innerException)
           : base(null, innerException)
        {
        }

        public SingletonException(string message, Exception innerException)
           : base(message, innerException)
        {
        }

#if !WindowsCE
        protected SingletonException(SerializationInfo info, StreamingContext context)
           : base(info, context)
        {
        }
#endif
    }
}
