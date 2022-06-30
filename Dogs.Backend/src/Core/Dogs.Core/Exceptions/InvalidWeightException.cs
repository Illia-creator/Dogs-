namespace Dogs.Core.Exceptions
{
    internal class InvalidWeightException : CustomException
    {
        public int Value { get; }
        public InvalidWeightException(int value):base($"Weight {value} is invalid.")
        {
            Value = value;
        }
    }
}
