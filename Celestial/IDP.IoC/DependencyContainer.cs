using IDP.Application.Handler.Command.User;
using IDP.DataLayer.Repository.Command;
using IDP.Domain.IRepository.Command;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace IDP.IoC
{
    public class DependencyContainer
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            // Register MediatR
            services.AddMediatR(typeof(UserHandler).Assembly);

            #region  Register Services 

            #endregion

            #region Register Repositor
            services.AddScoped<IUserCommandRepository, UserCommandRepository>();
            #endregion
        }
    }
}
