

namespace DevIO.BusinessOrDomain.EntitiesOrModels
{
    public class Produto : Entity
    {
        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        /*EF Relation*/
        public Fornecedor? Fornecedor { get; set; }

        /*Para satisfazer o relacionamento*/
        public Guid FornecedorId { get; set; }
    }
}
