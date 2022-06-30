using Dogs.Core.Entities;

namespace Dogs.Core.Repositories
{
    public interface IDogRepository
    {
        Task<Dog> CreateDogAsync(Dog dog);
        Task<List<Dog>> GetDogsAsync();
    }
}
