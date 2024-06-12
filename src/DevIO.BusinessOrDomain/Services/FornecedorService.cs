using DevIO.BusinessOrDomain.EntitiesOrModels;
using DevIO.BusinessOrDomain.Interfaces;
using DevIO.BusinessOrDomain.Validations;

namespace DevIO.BusinessOrDomain.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        private readonly IFornecedorRepository _repository;

        public FornecedorService(IFornecedorRepository repository, 
            INotificador notificador) : base(notificador) 
        {
            _repository = repository;
        }

        public async Task Adicionar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)
                || !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco))
                    return;

            if (_repository.Buscar(f => f.Documento == fornecedor.Documento).Result.Any())
            {
                Notificar("Já existe um fornecedor com este doucmento");
                return;
            }
                

            await _repository.Adicionar(fornecedor);
        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor))
                return;

            if (_repository.Buscar(f => f.Documento == fornecedor.Documento &&
                f.Id != fornecedor.Id).Result.Any())
            {
                Notificar("Já existe um fornecedor com este doucmento");
                return;
            }

            await _repository.Atualizar(fornecedor);
        }

        public async Task Remover(Guid id)
        {
            var fornecedor = await _repository.ObterFornecedorProdutosEndereco(id);

            if (fornecedor == null)
            {
                Notificar("Fornecedor não existe");
                return;
            }

            if (fornecedor.Produtos.Any())
            {
                Notificar("Fornecedor possui produtos cadastrados");
                return;
            }

            var endereco = _repository.ObterEnderecoPorFornecedor(id);

            if (endereco != null)
            {
                await _repository.RemoverEnderecoFornecedor(await endereco);
            }

            await _repository.Remover(id);
        }

        public void Dispose()
        {
            _repository?.Dispose();
        }

        
    }
}
