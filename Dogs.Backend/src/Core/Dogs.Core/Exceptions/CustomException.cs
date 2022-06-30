namespace Dogs.Core.Exceptions
{
    internal class CustomException : Exception
    {
        protected CustomException(string? message) : base(message)
        {

        }
    }
}
