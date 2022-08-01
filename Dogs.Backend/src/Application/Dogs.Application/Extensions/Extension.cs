using Dogs.Application.Abstractions;
using Dogs.Application.Commands.CommandHandler;
using Dogs.Application.Commands.UsualCommands;
using Dogs.Application.Dto;
using Dogs.Application.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Dogs.Application.Extensions
{
    public static class Extension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IQuery<DataServiceMessage>, GetDogs>();

            services.AddScoped<IQueryHandler<GetDogs, DataServiceMessage>, GetDogsHandler>();

            services.AddScoped<ICommand, CreateDogCommand>();

            services.AddScoped<ICommandHandler<CreateDogCommand>, CreateDogCommandHendler>();

            return services;
        }
    }
}
