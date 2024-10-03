using System;
using CleanArchitecture.Application.Common.Exceptions.Base;
using CleanArchitecture.Domain.Enums;

namespace CleanArchitecture.Application.Common.Exceptions
{
    public class NotFoundException : CustomApplicationException
    {
        public NotFoundException()
            : base(StatusCode.NotFound)
        {
        }

        public NotFoundException(string message)
            : base(StatusCode.NotFound, message)
        {
        }

        public NotFoundException(object additionalData)
            : base(StatusCode.NotFound, additionalData)
        {
        }

        public NotFoundException(string message, object additionalData)
            : base(StatusCode.NotFound, message, additionalData)
        {
        }

        public NotFoundException(string message, Exception exception)
            : base(StatusCode.NotFound, message, exception)
        {
        }

        public NotFoundException(string message, Exception exception, object additionalData)
            : base(StatusCode.NotFound, message, exception, additionalData)
        {
        }
    }
}