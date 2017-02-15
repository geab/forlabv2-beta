using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.Core.Util
{
    public class LQTUserMessage
    {
        private readonly string _message;
        private readonly bool _isthereError;

        public LQTUserMessage(string message)
            : this(message, false)
        {
        }

        public LQTUserMessage(string message, bool isthereError)
        {
            _message = message;
            _isthereError = isthereError;
        }
        public string Message
        {
            get { return _message; }
        }

        public bool IsThereError
        {
            get { return _isthereError; }
        }
    }
}
