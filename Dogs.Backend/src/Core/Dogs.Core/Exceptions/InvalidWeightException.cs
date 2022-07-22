namespace Dogs.Core.Exceptions
{
    internal class InvalidWeightException : CustomException
    {
        public double Value { get; }
        public InvalidWeightException(double value):base($"Weight {value} is invalid.")
        {
            Value = value;
        }
    }
}
