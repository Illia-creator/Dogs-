using Dogs.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs.Application.Contracts
{
    public interface IDogProcessing
    {
        Task<DataServiceMessage> CreateDogAsync(CreateDogDto createDogDto);
    }
}
