using Dogs.Application.Commands.UsualCommands;
using Dogs.Application.Dto;
using Dogs.Core.Entities;

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

        public static Dog CreateDogDtoToDog(this CreateDogDto createDogDto)
        {
            return new Dog
            {
                Name = createDogDto.Name,
                Color = createDogDto.Color,
                TailLenght = createDogDto.TailLenght,
                Weight = createDogDto.Weight
            };
        
        }
    }
}
