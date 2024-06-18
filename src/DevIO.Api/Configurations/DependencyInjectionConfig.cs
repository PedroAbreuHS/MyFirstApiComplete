
using DevIO.BusinessOrDomain.Interfaces;
using DevIO.BusinessOrDomain.Services;
using DevIO.DataOrInfrastructure.Contexto;

namespace DevIO.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MyDbContext>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IFornecedorRepository, IFornecedorRepository>();
            
            return services;
        }
    }
}
