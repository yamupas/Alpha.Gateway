using System;
using System.Collections.Generic;
using System.Text;

namespace Alpha.Common.Exceptions
{
    public abstract class BadRequestException : ApplicationException
    {
        protected BadRequestException(string message)
            : base("Bad Request", message)
        {
        }
    }
}
