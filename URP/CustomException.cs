using System;
using System.Collections.Generic;
using System.Text;

namespace URP
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_ENTRY
        }

        private readonly ExceptionType type;

        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
