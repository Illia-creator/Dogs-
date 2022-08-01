using Dogs.Application.Contracts;
using Dogs.Application.Dto;
using Dogs.Infrastructure.Dal.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dogs.Core.Constants.ResponseMessages;

namespace Dogs.Infrastructure.Dal.Services.View
{
    public class DogView : IDogView
    {
        private readonly DogContext _dogContext;
        public DogView( DogContext dogContext)
        {
            _dogContext = dogContext;
        }

        public async Task<DataServiceMessage> GetAllDogs()
        {
            var result = await _dogContext.Dogs.ToListAsync();
            var data = new DataServiceMessage(true, GoodResponse.GetSuccessfully, result);
            return data;
        }
    }
}
