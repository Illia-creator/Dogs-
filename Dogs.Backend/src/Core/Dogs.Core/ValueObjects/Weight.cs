using Dogs.Core.Exceptions;

namespace Dogs.Core.ValueObjects
{
    public class Weight
    {
        public int Value { get; }

        public Weight(int velue)
        {
            if (Value is < 0 or > 100)
                throw new InvalidWeightException(velue);

            Value = Value;

        }
        public static implicit operator Weight(int value) => new(value);

        public static implicit operator int(Weight value) => value.Value;
    }
}
