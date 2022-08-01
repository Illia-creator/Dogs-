using Dogs.Application.Contracts;
using Dogs.Application.Dto;
using Dogs.Application.Mapper;
using Dogs.Infrastructure.Dal.Context;
using static Dogs.Core.Constants.ResponseMessages;

namespace Dogs.Infrastructure.Dal.Services.Proccesing
{
    public class DogService : IDogProcessing
    {
        private readonly DogContext _context;

        public DogService(DogContext context)
        {
            _context = context;
        }


        public async Task<DataServiceMessage> CreateDogAsync(CreateDogDto createDogDto)
        {
            var mapper = createDogDto.CreateDogDtoToDog();

            await _context.Dogs.AddAsync(mapper);
            await _context.SaveChangesAsync();

            var data = new DataServiceMessage(true, GoodResponse.AddedSuccessfully, mapper);
            return data;
        }
    }
}
