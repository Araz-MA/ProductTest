using System;
using CleanArchitecture.Application.Common.Exceptions.Base;
using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.Common.Exceptions
{
    public class LogicException : CustomApplicationException
    {
        public LogicException()
            : base(StatusCode.LogicError)
        {
        }

        public LogicException(string message)
            : base(StatusCode.LogicError, message)
        {
        }

        public LogicException(object additionalData)
            : base(StatusCode.LogicError, additionalData)
        {
        }

        public LogicException(string message, object additionalData)
            : base(StatusCode.LogicError, message, additionalData)
        {
        }

        public LogicException(string message, Exception exception)
            : base(StatusCode.LogicError, message, exception)
        {
        }

        public LogicException(string message, Exception exception, object additionalData)
            : base(StatusCode.LogicError, message, exception, additionalData)
        {
        }
    }
}