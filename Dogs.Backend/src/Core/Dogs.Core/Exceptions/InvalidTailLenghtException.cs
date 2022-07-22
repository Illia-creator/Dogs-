namespace Dogs.Core.Exceptions
{
    internal class InvalidTailLenghtException : CustomException
    {
        public double Value { get; }

        public InvalidTailLenghtException(double value) : base($"Tail Lenght {value} is invalid")
        {
            Value = value;
        }
    }
}
