using System;

namespace Promat.Translations.Models
{
    public class QuotaExceededException : Exception
    {
        public QuotaExceededException() : base()
        {
        }
        public QuotaExceededException(string message) : base(message)
        {
        }
        public QuotaExceededException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}