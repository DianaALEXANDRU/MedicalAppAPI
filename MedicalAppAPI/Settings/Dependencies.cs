using MedicalAppAPI.Core.Services;
using MedicalAppAPI.Repository;

namespace MedicalAppAPI.Settings
{
    public class Dependencies
    {
        public static void Inject(WebApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Services.AddControllers();
            applicationBuilder.Services.AddSwaggerGen();

            AddRepositories(applicationBuilder.Services);
            AddServices(applicationBuilder.Services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<PatientService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<PatientRepository>();
        }
    }
}
