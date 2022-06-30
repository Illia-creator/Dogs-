namespace Dogs.Core.ValueObjects
{
    public class DogId
    {
        public int Value { get; }
        public DogId(int value)
        {
            Value = value;
        }
        public static implicit operator DogId(int value) => new(value);

        public static implicit operator int(DogId value) => value.Value;
    }
}
