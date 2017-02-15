using System;
using System.Runtime.Serialization;
using System.Text;

namespace LQT.Core.UserExceptions
{
    [Serializable]
    public class LQTUserException : ApplicationException
    {
        private readonly string _message;

        protected LQTUserException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            _message = info.GetString("Code");
        }

        public LQTUserException()
        {
            _message = String.Empty;
        }

        public LQTUserException(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }
    }
}
