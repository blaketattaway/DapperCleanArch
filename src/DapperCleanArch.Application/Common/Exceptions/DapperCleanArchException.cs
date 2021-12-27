using System.Net;

namespace DapperCleanArch.Application.Common.Exceptions
{
    internal class DapperCleanArchException : Exception
    {
        public DapperCleanArchException(string message, HttpStatusCode statusCode)
           : base(message)
        {
            StatusCode = statusCode;
            ApiErrors = new List<DapperCleanArchApiError>();
        }

        public HttpStatusCode StatusCode { get; set; }
        public ICollection<DapperCleanArchApiError> ApiErrors { get; set; }
    }
}
