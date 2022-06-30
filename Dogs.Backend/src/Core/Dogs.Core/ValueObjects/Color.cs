using Dogs.Core.Exceptions;

namespace Dogs.Core.ValueObjects
{
    public class Color
    {

        public string Value { get; }

        public Color(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidColorException(value);

            Value = value;
        }

        public static implicit operator Color(string value) => new(value);

        public static implicit operator string(Color value) => value.Value;
        public override string ToString() => Value;
    }
}
