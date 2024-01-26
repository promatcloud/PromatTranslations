using System;
using System.Net.Http;

namespace Promat.Translations.Models
{
    public class TooManyRequestException : HttpRequestException
    {
        public TooManyRequestException() : base()
        {
        }
        public TooManyRequestException(string message) : base(message)
        {
        }
        public TooManyRequestException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}