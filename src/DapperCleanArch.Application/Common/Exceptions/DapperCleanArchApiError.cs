namespace DapperCleanArch.Application.Common.Exceptions
{
    internal class DapperCleanArchApiError
    {
        public DapperCleanArchApiError(string errorMessage, string propertyName)
        {
            ErrorMessage = errorMessage;
            PropertyName = propertyName;
        }

        public string ErrorMessage { get; set; }
        public string PropertyName { get; set; }
    }
}
