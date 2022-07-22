using Dogs.Application.Commands;
using Dogs.Application.Dto;

namespace Dogs.Application.Mapper
{
    public static class Mapping
    {
        public static CreateDogDto CreateCommandDog(this CreateDogCommand createDogCommand)
        {
            return new CreateDogDto
            {
                Name = createDogCommand.Name,
                Color = createDogCommand.Color,
                TailLenght = createDogCommand.TailLenght,
                Weight = createDogCommand.Weight
            };
        }
    }
}
