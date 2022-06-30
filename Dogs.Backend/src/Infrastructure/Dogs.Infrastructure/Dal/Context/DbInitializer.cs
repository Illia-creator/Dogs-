namespace Dogs.Infrastructure.Dal.Context
{
    public class DbInitializer
    {
        public static void Initialize(DogContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
