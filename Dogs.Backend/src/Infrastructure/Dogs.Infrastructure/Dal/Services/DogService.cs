using Dogs.Core.Entities;
using Dogs.Core.Repositories;
using Dogs.Infrastructure.Dal.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs.Infrastructure.Dal.Services
{
    public class DogService : IDogRepository
    {
        private readonly DogContext _context;

        public DogService(DogContext context)
        {
            _context = context;
        }
        public Task<Dog> CreateDogAsync(Dog dog)
        {
           _context.Dogs.AddAsync(dog);
            _context.SaveChanges();
            return Task.FromResult(dog);
        }

        public async Task<List<Dog>> GetDogsAsync()
        {
            var result = await _context.Dogs.ToListAsync();
            return result;
        }
    }
}
