namespace Dogs.Core.Exceptions
{
    internal sealed class InvalidNameException : CustomException
    {
        public string Value { get; }
        public InvalidNameException(string? value) : base($"Name {value} is invalid.")
        {
            Value = value;
        }
    }
}
