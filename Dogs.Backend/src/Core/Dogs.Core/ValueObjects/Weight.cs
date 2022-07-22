using Dogs.Core.Exceptions;

namespace Dogs.Core.ValueObjects
{
    public class Weight
    {
        public double Value { get; }

        public Weight(double velue)
        {
            if (Value is < 0 or > 100)
                throw new InvalidWeightException(velue);

            Value = Value;

        }
        public static implicit operator Weight(double value) => new(value);

        public static implicit operator double(Weight value) => value.Value;
    }
}
