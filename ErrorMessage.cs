namespace Data
{
    internal static class ErrorMessage
    {
        public static string ParameterIsNullOrEmptyOrWhiteSpace(string ParamName, string ClassName)
        {
            return $"The parameter \"{ParamName}\", of class \"{ClassName}\", cannot be null, empty, or white space.";
        }
    }
}