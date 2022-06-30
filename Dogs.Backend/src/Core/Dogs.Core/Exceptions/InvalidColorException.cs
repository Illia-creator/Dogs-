namespace Dogs.Core.Exceptions
{
    internal sealed class InvalidColorException : CustomException
    {
        public string Value { get; }
        public InvalidColorException(string? value) : base($"Color {value} is invalid.")
        {
            Value = value;
        }
    }
}
