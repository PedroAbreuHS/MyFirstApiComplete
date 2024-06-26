﻿

using DevIO.BusinessOrDomain.EntitiesOrModels;
using FluentValidation;

namespace DevIO.BusinessOrDomain.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(p => p.Nome).NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa estar entre {MinLength} e {MaxLength} caracteres.");

            RuleFor(p => p.Descricao).NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 1000).WithMessage("O campo {PropertyName} precisa estar entre {MinLength} e {MaxLength} caracteres.");

            RuleFor(p => p.Valor).GreaterThan(0)
                .WithMessage("O campo {PropertyName} precisa ser maior do que {ComparisonValue}.");
        }
    }
}
