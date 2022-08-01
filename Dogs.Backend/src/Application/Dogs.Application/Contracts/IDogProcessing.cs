using Dogs.Application.Dto;

namespace Dogs.Application.Contracts
{
    public interface IDogProcessing
    {
        Task<DataServiceMessage> CreateDogAsync(CreateDogDto createDogDto);
    }
}
