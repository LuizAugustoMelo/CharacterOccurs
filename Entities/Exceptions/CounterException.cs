using System;

namespace Entities.Exceptions
{
    class CounterException : ApplicationException
    {
        public CounterException(string message) : base(message) { }
    }
}
