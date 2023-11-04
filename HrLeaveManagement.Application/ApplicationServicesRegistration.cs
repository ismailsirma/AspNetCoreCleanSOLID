using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HrLeaveManagement.Application
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            // add profiles one by one, per domain
            // services.AddAutoMapper(typeof(MappingProfile));
            // add every mapping profile
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
