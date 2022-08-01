using Dogs.Application.Abstractions;
using Dogs.Application.Commands.UsualCommands;
using Dogs.Application.Contracts;
using Dogs.Application.Mapper;

namespace Dogs.Application.Commands.CommandHandler
{
    public class CreateDogCommandHendler : ICommandHandler<CreateDogCommand>
    {
        private readonly IDogProcessing _dogProcessing;

        public CreateDogCommandHendler(IDogProcessing dogProcessing)
        {
            _dogProcessing = dogProcessing;
        }

        public async Task HandleAsync(CreateDogCommand command)
        {
            var mapper = Mapping.CreateCommandDog(command);
            await _dogProcessing.CreateDogAsync(mapper);
        }
    }
}
