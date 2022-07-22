using Dogs.Application.Abstractions;
using Dogs.Application.Contracts;
using Dogs.Application.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs.Application.Commands
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
