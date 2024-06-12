using DevIO.BusinessOrDomain.EntitiesOrModels;

namespace DevIO.BusinessOrDomain.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}

