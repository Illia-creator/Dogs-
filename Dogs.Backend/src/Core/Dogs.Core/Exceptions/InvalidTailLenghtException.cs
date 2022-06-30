namespace Dogs.Core.Exceptions
{
    internal class InvalidTailLenghtException : CustomException
    {
        public int Value { get; }

        public InvalidTailLenghtException(int value) : base($"Tail Lenght {value} is invalid")
        {
            Value = value;
        }
    }
}
