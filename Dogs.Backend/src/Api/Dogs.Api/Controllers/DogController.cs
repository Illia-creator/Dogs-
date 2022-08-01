using Dogs.Application.Abstractions;
using Dogs.Application.Commands.UsualCommands;
using Dogs.Application.Dto;
using Dogs.Application.Queries;
using Dogs.Core.Constants;
using Microsoft.AspNetCore.Mvc;

namespace Dogs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        private readonly IQueryHandler<GetDogs, DataServiceMessage> _queryDogsHandler;
        private readonly ICommandHandler<CreateDogCommand> _commandCreateDogHandler;

        public DogController(IQueryHandler<GetDogs, DataServiceMessage> queryDogsHandler,
            ICommandHandler<CreateDogCommand> commandCreateDogHandler)
        {
            _queryDogsHandler = queryDogsHandler;
            _commandCreateDogHandler = commandCreateDogHandler;
        }

        [HttpGet(Routes.GetAllDogs)]
        public async Task<ActionResult> GetAllDogs([FromQuery] GetDogs query)
        {
            var result = await _queryDogsHandler.HandleAsync(query);
            return Ok(result);
        }

        [HttpPost(Routes.CreateDog)]
        public async Task<ActionResult> CreateDog(CreateDogCommand createDogCommand)
        {
            await _commandCreateDogHandler.HandleAsync(createDogCommand);
            return Ok();
        }
    }
}
