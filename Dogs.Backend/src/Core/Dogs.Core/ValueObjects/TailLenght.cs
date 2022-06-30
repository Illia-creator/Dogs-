using Dogs.Core.Exceptions;


namespace Dogs.Core.ValueObjects
{
    public class TailLenght
    {
        public int Value { get; }
        public TailLenght(int value)
        {
            if (value is < 0 or > 150)
                throw new InvalidTailLenghtException(value);

            Value = value;
        }
        public static implicit operator TailLenght(int value) => new(value);

        public static implicit operator int(TailLenght value) => value.Value;

    }
}
