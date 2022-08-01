using Dogs.Core.ValueObjects;

namespace Dogs.Core.Entities
{
    public class Dog
    {
        public DogId DogId { get; set; }
        public Name Name { get; set; }
        public Color Color { get; set; }
        public TailLenght TailLenght { get; set; }
        public Weight Weight { get; set; }
    }
}
