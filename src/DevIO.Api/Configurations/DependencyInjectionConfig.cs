
using DevIO.BusinessOrDomain.Interfaces;
using DevIO.DataOrInfrastructure.Contexto;

namespace DevIO.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MyDbContext>();
            services.AddScoped<IFornecedorRepository, IFornecedorRepository>();
            services.AddScoped<IFornecedorRepository, IFornecedorRepository>();
            
            return services;
        }
    }
}
