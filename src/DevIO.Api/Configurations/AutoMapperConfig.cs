using AutoMapper;
using DevIO.Api.ViewModelsOrDtos;
using DevIO.BusinessOrDomain.EntitiesOrModels;

namespace DevIO.Api.Configurations
{
    public class AutoMapperConfig : Profile
    {
        protected AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
