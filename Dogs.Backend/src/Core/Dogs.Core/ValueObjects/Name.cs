using Dogs.Core.Exceptions;

namespace Dogs.Core.ValueObjects
{
    public class Name
    {
        public string Value { get; }

        public Name(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidNameException(value);

            Value = value;
        }

        public static implicit operator Name(string value) => new(value);

        public static implicit operator string(Name value) => value.Value;
        public override string ToString() => Value;
    }
}
