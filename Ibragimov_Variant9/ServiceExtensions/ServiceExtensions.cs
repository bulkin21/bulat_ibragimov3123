using Ibragimov_Variant9.Interfaces.StudentsInterfaces;

namespace Ibragimov_Variant9.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();

            return services;
        }
    }
}
