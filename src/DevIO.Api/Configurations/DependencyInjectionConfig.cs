
using DevIO.BusinessOrDomain.EntitiesOrModels;
using DevIO.BusinessOrDomain.Interfaces;
using DevIO.BusinessOrDomain.Services;
using DevIO.DataOrInfrastructure.Contexto;
using DevIO.DataOrInfrastructure.Repository;

namespace DevIO.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MyDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            //services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();            
            services.AddScoped<IProdutoService, ProdutoService>();            
            
            return services;
        }
    }
}
