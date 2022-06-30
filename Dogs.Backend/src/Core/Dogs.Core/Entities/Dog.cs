using Dogs.Core.ValueObjects;

namespace Dogs.Core.Entities
{
    public class Dog
    {
        public DogId DogId { get; private set; }
        public Name Name { get; private set; }
        public Color Color { get; private set; }
        public TailLenght TailLenght { get; private set; }
        public Weight Weight { get; private set; }

        public Dog(DogId dogId, Name name, Color color, TailLenght tailLenght, Weight weight)
        {
            DogId = dogId;
            Name = name;
            Color = color;
            TailLenght = tailLenght;
            Weight = weight;
        }
    }
}
