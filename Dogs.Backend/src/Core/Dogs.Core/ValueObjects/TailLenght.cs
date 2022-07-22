using Dogs.Core.Exceptions;


namespace Dogs.Core.ValueObjects
{
    public class TailLenght
    {
        public double Value { get; }
        public TailLenght(double value)
        {
            if (value is < 0 or > 150)
                throw new InvalidTailLenghtException(value);

            Value = value;
        }
        public static implicit operator TailLenght(double value) => new(value);

        public static implicit operator double(TailLenght value) => value.Value;
    }
}
