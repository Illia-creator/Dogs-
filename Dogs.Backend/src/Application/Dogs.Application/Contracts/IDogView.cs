using Dogs.Application.Dto;

namespace Dogs.Application.Contracts
{
    public interface IDogView
    {
        Task<DataServiceMessage> GetAllDogs();
    }
}
