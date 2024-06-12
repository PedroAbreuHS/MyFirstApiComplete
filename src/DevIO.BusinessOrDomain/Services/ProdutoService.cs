using DevIO.BusinessOrDomain.EntitiesOrModels;
using DevIO.BusinessOrDomain.Interfaces;
using DevIO.BusinessOrDomain.Validations;

namespace DevIO.BusinessOrDomain.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository, 
            INotificador notificador) : base (notificador)
        {
            _repository = repository;
        }

        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto))
                return;

            await _repository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto))
                return;

            await _repository.Atualizar(produto);
        }

        public async Task Remover(Guid id)
        {
            await _repository.Remover(id);
        }

        public void Dispose()
        {
            _repository?.Dispose();
        }

        
    }
}
