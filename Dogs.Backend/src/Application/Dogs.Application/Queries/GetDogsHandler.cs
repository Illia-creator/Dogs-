using Dogs.Application.Abstractions;
using Dogs.Application.Contracts;
using Dogs.Application.Dto;

namespace Dogs.Application.Queries
{
    public class GetDogsHandler : IQueryHandler<GetDogs, DataServiceMessage>
    {
        private readonly IDogView _dogView;
        public GetDogsHandler(IDogView dogView)
        {
            _dogView = dogView;
        }
        public async Task<DataServiceMessage> HandleAsync(GetDogs query)
        {
            return await _dogView.GetAllDogs();
        }
    }
}
