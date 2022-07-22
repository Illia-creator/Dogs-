using Dogs.Application.Abstractions;

namespace Dogs.Application.Commands
{
    public class CreateDogCommand : ICommand
    {
        public int DogId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double TailLenght { get; set; }
        public double Weight { get; set; }
    }
}
