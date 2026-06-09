namespace SecureCatalog.Exceptions
{
    public class ApiValidationException : Exception
    {
        public List<string> Errors { get; }

        public ApiValidationException(List<string> errors)
            : base("Validation failed.")
        {
            Errors = errors;
        }
    }
}
